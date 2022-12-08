using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace BeasyApp
{
    public interface Select { public string select(); }
    public interface Insert { public string insert(); }
    public interface Delete { public string delete(); }
    public interface Update { public string update(); }
    public class Query : Select, Insert, Delete, Update
    {
        public string table;
        public string col;
        public string condition;
        public string value;
        public Query(string table="", string col="", string condition="", string value = "") { this.table = table; this.col = col; this.condition = condition; this.value = value; }
        public string select() { return $"SELECT {col} FROM {table} {condition}"; }
        public string insert() { return $"INSERT INTO {table} {col} VALUES {value}"; }
        public string delete() { return $"DELETE FROM {table} {condition}"; }
        public string update() { return $"UPDATE {table} SET {col} {condition}"; }
    }
    public abstract class Database
    {
        public SQLiteConnection conn;
        public string query;
        string dbname = "beasy.sqlite3";
        public Database(string query)
        {
            conn = new SQLiteConnection($"Data Source={dbname}");
            if (!File.Exists($"./{dbname}"))
            {
                SQLiteConnection.CreateFile($"{dbname}");
                MakeDb();
            }
            this.query = query;
        }
        public abstract void ExecQuery();
        public abstract void ExecReader(DataGridView dgv, DataTable dt);
        public abstract string GetValue(int col = 0);
        private void MakeDb()
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = ("CREATE TABLE IF NOT EXISTS \"akun\" (\"id_user\" INTEGER,\"username\" TEXT,\"password\" INTEGER, PRIMARY KEY (\"id_user\")); CREATE TABLE IF NOT EXISTS \"kelas\" (\"id_kelas\" INTEGER NOT NULL,\"nama_kelas\"	TEXT NOT NULL, PRIMARY KEY(\"id_kelas\")); CREATE TABLE IF NOT EXISTS \"depo_bus\" (\"no_plat\" VARCHAR NOT NULL, \"staff\"	TEXT, \"no_telp_staff\" VARCHAR , \"supir\" TEXT NOT NULL, \"no_telp_supir\" VARCHAR NOT NULL, \"asal\"	TEXT, \"tujuan\" TEXT, \"depo_id_kelas\" INTEGER, \"depo_id_user\" INTEGER, \"tanggal_masuk\"	TEXT NOT NULL, FOREIGN KEY(\"depo_id_kelas\") REFERENCES \"kelas\"(\"id_kelas\"), FOREIGN KEY(\"depo_id_user\") REFERENCES \"akun\"(\"id_user\"),PRIMARY KEY(\"no_plat\")); INSERT INTO \"kelas\" (\"id_kelas\",\"nama_kelas\") VALUES (1,'Eksekutif'), (2,'Bisnis'), (3,'Ekonomi');");
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
    }
    class SQLDBHelper : Database
    {
        public SQLDBHelper(string query) : base(query) { this.query = query; }
        public override void ExecQuery()
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
        public override void ExecReader(DataGridView dgv, DataTable dt)
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv.DataSource = dt;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            conn.Close();
            cmd.Dispose();
        }
        public override string GetValue(int col)
        {
            string value = "";
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    value = reader.GetString(col);
                }
                catch (FormatException)
                {
                    value = Convert.ToString(reader.GetInt32(col));
                }
                catch (InvalidCastException)
                {
                    try
                    {
                        value = Convert.ToString(reader.GetInt32(col));
                    }
                    catch
                    {
                        value = "";
                    }

                }

            }
            conn.Close();
            cmd.Dispose();
            if (value == "")
            {
                return "-";
            }
            else
            {
                return value;
            }

        }
    }
}
