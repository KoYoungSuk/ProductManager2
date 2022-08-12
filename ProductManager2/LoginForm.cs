using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager2
{
    public partial class LoginForm : Form
    {
        Global g = new Global();
        OracleConnection conn = null; 
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fulldbaddress = textBox3.Text;
            String address = fulldbaddress.Split(':')[0];
            String sidandport = fulldbaddress.Split(':')[1];
            String sid = sidandport.Split('/')[1];
            String port = sidandport.Split('/')[0];
            String id = textBox1.Text;
            String password = textBox2.Text;
            Boolean check = false;
            try
            {
                String connstr = g.connectionString(address, port, sid, id, password);
                conn = new OracleConnection(connstr);
                conn.Open();
                check = true;

                if (check)
                {
                    ProductDAO productdao = new ProductDAO(conn);
                    Boolean existstatus = productdao.checkTableExist();
                    if (!existstatus)
                    {
                        DialogResult dr = MessageBox.Show("You need to create Table. Continue?", "ProductManager", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if(dr == DialogResult.OK)
                        {
                            int result = productdao.createTable();
                            if(result == 1)
                            {
                                g.message("Success", false);
                            }
                            else
                            {
                                g.message("Unknown Error", true); 
                            }
                        }
                        else
                        {
                            g.message("Sorry but You need to create Table. Program will be terminated. ", true); 
                        }

                    }
                    Form1 frm = new Form1(conn);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    g.message("Login Error: DataBase Login Error.", true); 
                }
                /*
                ProductDAO productdao = new ProductDAO(g.dburl, g.dbport, g.dbsid, g.dbid, g.dbpw);
                List<MemberDTO> memberlist = productdao.getMemberList();
                foreach(MemberDTO memberdto in memberlist)
                {
                    if (id.Equals("admin"))
                    {
                        if(BCrypt.Net.BCrypt.Verify(password, memberdto.Password))
                        {
                            check = true;
                            break;
                        }
                    }
                }
                if (check)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    g.message("Login Error: ID and Password are not corrected.", true);
                }
                */

            }
            catch(Exception ex)
            {
                g.message(ex.Message, true);
            }
        }

        private void KeyDown_Load(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
