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
            String id = textBox1.Text;
            String password = textBox2.Text;
            Boolean check = false;
            try
            {
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
