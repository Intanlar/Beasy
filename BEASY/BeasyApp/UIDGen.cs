using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeasyApp 
{
    internal class UIDGen
    {
        private string uid;
        public string getUid() { return uid; }
        public void UID(string timestamp)
        {
            long tt = Convert.ToInt64(timestamp);
            string newtt = tt.ToString("X");
            char[] uid_array = newtt.ToCharArray();
            Array.Reverse(uid_array);
            string uid = new string(uid_array);
            this.uid = uid;
        }
    }
}
