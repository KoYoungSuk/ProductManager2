using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager2
{
    class Global
    {
        //ID AND PASSWORD ARE CENSORED DUE TO SECURITY ISSUE. (GITHUB)
        public String dburl = "koyoungsuk2.iptime.org";
        public String dbport = "1521";
        public String dbsid = "XE";
        public String dbid =  "dbid";
        public String dbpw = "dbpw";
        //ID AND PASSWORD ARE CENSORED DUE TO SECURITY ISSUE. (GITHUB) 
        public Global()
        {
            
        }

        public String connectionString(String dburl, String dbport, String dbsid, String dbid, String dbpw)
        {
            String connstr = String.Format("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={2})));User Id={3};Password={4}", dburl, dbport, dbsid, dbid, dbpw);

            return connstr;
        }

        public void message(String msg, Boolean error)
        {
            if (error)
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(msg, "ProductManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public String checkOS()
        {
            string HKLMWinNTCurrent = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            string osName = Registry.GetValue(HKLMWinNTCurrent, "productName", "").ToString();
            string osBuild = Registry.GetValue(HKLMWinNTCurrent, "CurrentBuildNumber", "").ToString();
            String label;
            String[] osName_arr = osName.Split(' ');
            if (osName_arr[1].Equals("10"))
            {
                if (Int32.Parse(osBuild) > 21000)
                {
                    label = "Your OS: Windows 11 " + osName_arr[2] + " Build: " + osBuild;
                }
                else
                {
                    label = "Your OS: " + osName + " Build: " + osBuild;
                }
            }
            else
            {
                label = "Your OS: " + osName + " Build: " + osBuild;
            }
            return label;
        }
    }
}
