using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeasyApp 
{
    public partial class DataPage : Form
    {
        private int status;
        private string username;
        private string password;
        private string email;
        private string contact;
        private string desc;
        private int acctype;
        private int callfrom;
        private string date;
        private string platform;
        private string uid;
        public DataPage(int status = 0, int callfrom = 0)
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            this.date = dt.ToString("yyyy/MM/dd");
            this.status = status;
            this.callfrom = callfrom;
            this.AccTypeInsertCBox.Items.Add("");
            this.AccTypeInsertCBox.SelectedIndex = 0;
            for (int i = 1; i <= 5; i++)
            {
                Query qry = new Query("kelas", "nama_kelas", $"WHERE id_kelas = {i}");
                Database acctypes = new SQLDBHelper(qry.select());
                AccTypeInsertCBox.Items.Add(acctypes.GetValue());
            }
            AccUIDNonInsert.ReadOnly = true;
            SaveUpdateButton.Enabled = false;
            SaveUpdateButton.Visible = false;
            CrossFunc();
        }

        private void UserIcon_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.status = 1;
            CrossFunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.status = 2;
            CrossFunc();
        }
        private void CrossFunc()
        {
            if (status == 1) // Inputan
            {
                AccUIDNonInsert.ReadOnly = true;
                SaveButton.Enabled = true;
                SaveButton.Visible = true;
                SaveUpdateButton.Enabled = false;
                SaveUpdateButton.Visible = false;
                EditButton.Enabled = false;
                EditButton.Visible = false;
                DeleteButton.Enabled = false;
                DeleteButton.Visible = false;
                LabelData.Text = "Penginputan Data";
                this.AccUIDNonInsert.Text = "";
                this.AccUNameInsert.Text = "";
                this.AccUPassInsert.Text = "";
                this.AccEmailInsert.Text = "";
                this.AccPhoneInsert.Text = "";
                this.AccPlatfInsert.Text = "";
                this.AccDescInsert.Text = "";
            }
            else if (status == 2) // Suntingan
            {
                SaveButton.Enabled = false;
                SaveButton.Visible = false;
                SaveUpdateButton.Enabled = true;
                SaveUpdateButton.Visible = true;
                EditButton.Enabled = false;
                EditButton.Visible = false;
                DeleteButton.Enabled = false;
                DeleteButton.Visible = false;
                LabelData.Text = "Penyuntingan Data";
            }
            else if (status == 3) // Lihat Saja
            {
                SaveButton.Enabled = false;
                SaveButton.Visible = false;
                EditButton.Enabled = true;
                EditButton.Visible = true;
                DeleteButton.Enabled = true;
                DeleteButton.Visible = true;
                SaveUpdateButton.Enabled = false;
                SaveUpdateButton.Visible = false;
                LabelData.Text = "Lihat Data";
                AccUNameInsert.ReadOnly = true;
                AccUPassInsert.ReadOnly = true;
                AccEmailInsert.ReadOnly = true;
                AccDescInsert.ReadOnly = true;
                AccPlatfInsert.ReadOnly = true;
                AccPhoneInsert.ReadOnly = true;
                AccTypeInsertCBox.Enabled = false;
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButtton_Click(object sender, EventArgs e)
        {
            if (callfrom == 1)
            {
                CallShowPage();
            }
            if (callfrom == 2)
            {
                CallShowPage();
            }
            if (callfrom == 3)
            {
                CallShowPage();
            }
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveUpdateButton.Enabled = true;
            SaveUpdateButton.Visible = true;
            DeleteButton.Visible = false;
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            EditButton.Visible = false;
            AccUNameInsert.ReadOnly = false;
            AccUPassInsert.ReadOnly = false;
            AccEmailInsert.ReadOnly = false;
            AccDescInsert.ReadOnly = false;
            AccPlatfInsert.ReadOnly = false;
            AccPhoneInsert.ReadOnly = false;
            AccTypeInsertCBox.Enabled = true;
            LabelData.Text = "Penyuntingan Data";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(AccPhoneInsert.Text) || AccPhoneInsert.Text == "")
                {
                    this.contact = "";
                }
                else
                {
                    this.contact = AccPhoneInsert.Text;
                }
                if (string.IsNullOrEmpty(AccDescInsert.Text) || AccDescInsert.Text == "")
                {
                    this.desc = "";
                }
                else
                {
                    this.desc = AccDescInsert.Text;
                }
                Query qry = new Query("depo_bus", "(no_plat, tujuan, staff, no_telp_staff, supir, no_telp_supir, asal, depo_id_user, depo_id_kelas, tanggal_masuk)", "", $"('{AccUIDNonInsert.Text}', '{AccPlatfInsert.Text}', '{AccUNameInsert.Text}', '{AccUPassInsert.Text}', '{AccEmailInsert.Text}', '{contact}', '{desc}', 1, {acctype}, '{date}')");
                Database insert = new SQLDBHelper(qry.insert());
                insert.ExecQuery();
                MessageBox.Show("Data Sudah Diinput, Silahkan Cek di Menu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void DataPage_Load(object sender, EventArgs e)
        {
            this.AccUIDNonInsert.Text = ShowPage.accuidpasstodatapage;
            this.AccUNameInsert.Text = ShowPage.accunamepasstodatapage;
            this.AccUPassInsert.Text = ShowPage.accupasspasstodatapage;
            this.AccEmailInsert.Text = ShowPage.accemailpasstodatapage;
            this.AccPhoneInsert.Text = ShowPage.accphonepasstodatapage;
            this.AccPlatfInsert.Text = ShowPage.accplatfpasstodatapage;
            this.AccDescInsert.Text = ShowPage.accdescpasstodatapage;
            this.AccTypeInsertCBox.SelectedIndex = ShowPage.acctypepasstodatapage;
            this.uid = AccUIDNonInsert.Text;
        }
        private void CallShowPage() 
        {
            ShowPage sp = new ShowPage(1);
            this.Hide();
            sp.Show();
        }

        private void AccTypeInsertCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.acctype = AccTypeInsertCBox.SelectedIndex;
        }

        private void SaveUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(AccPlatfInsert.Text) || AccPlatfInsert.Text == "")
                {
                    this.platform = "";
                }
                else
                {
                    this.platform = AccPlatfInsert.Text;
                }

                if (string.IsNullOrEmpty(AccUNameInsert.Text) || AccUNameInsert.Text == "")
                {
                    this.username = "";
                }
                else
                {
                    this.username = AccUNameInsert.Text;
                }

                if (string.IsNullOrEmpty(AccUPassInsert.Text) || AccUPassInsert.Text == "")
                {
                    this.password = "";
                }
                else
                {
                    this.password = AccUPassInsert.Text;
                }

                if (string.IsNullOrEmpty(AccEmailInsert.Text) || AccEmailInsert.Text == "")
                {
                    this.email = "";
                }
                else
                {
                    this.email = AccEmailInsert.Text;
                }

                if (string.IsNullOrEmpty(AccPhoneInsert.Text) || AccPhoneInsert.Text == "")
                {
                    this.contact = "";
                }
                else
                {
                    this.contact = AccPhoneInsert.Text;
                }

                if (string.IsNullOrEmpty(AccDescInsert.Text) || AccDescInsert.Text == "")
                {
                    this.desc = "";
                }
                else
                {
                    this.desc = AccDescInsert.Text;
                }

                Query qry = new Query("depo_bus", $"tujuan = '{platform}', staff = '{username}', no_telp_staff = '{password}', supir = '{email}', no_telp_supir = '{contact}', asal = '{desc}'", $"WHERE no_plat = '{AccUIDNonInsert.Text}'");
                Database update = new SQLDBHelper(qry.update());
                update.ExecQuery();
                MessageBox.Show("Data Sudah Diubah, Silahkan Cek di Menu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Query qry = new Query("depo_bus", "", $"WHERE no_plat= '{AccUIDNonInsert.Text}'");
                Database del = new SQLDBHelper(qry.delete());
                del.ExecQuery();
                MessageBox.Show("Data Sudah Dihapus, Silahkan Cek Di Menu");
                this.AccUIDNonInsert.Text = "";
                this.AccUNameInsert.Text = "";
                this.AccUPassInsert.Text = "";
                this.AccEmailInsert.Text = "";
                this.AccPhoneInsert.Text = "";
                this.AccPlatfInsert.Text = "";
                this.AccDescInsert.Text = "";
                this.AccTypeInsertCBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void AccDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void AccUpdDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void LabelData_Click(object sender, EventArgs e)
        {

        }

        private void UIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void UNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AccUNameInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccUPassInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void UPassLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void AccEmailInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccPhoneInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactLabel_Click(object sender, EventArgs e)
        {

        }

        private void DescLabel_Click(object sender, EventArgs e)
        {

        }

        private void AccDescInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccPlatfInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccPlatfLabel_Click(object sender, EventArgs e)
        {

        }

        private void AccUIDNonInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
