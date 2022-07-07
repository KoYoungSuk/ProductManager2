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
    public partial class AboutForm : Form
    {
        Global g = new Global();
        public AboutForm()
        {
            InitializeComponent();
        }

        private void KeyDown_Load(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                label5.Text = g.checkOS();
            }
            else if(e.KeyCode == Keys.K)
            {
                label1.Text = "reganaMtcudorP";
            }
            else if(e.KeyCode == Keys.CapsLock)
            {
                label5.Text = "Caps Lock Pressed!";
            }
            else if(e.KeyCode == Keys.E)
            {
                label5.Text = "Easter Egg Found!";
            }
            else if(e.KeyCode == Keys.F)
            {
                label5.Text = "친구들한테 잘하자!";
            }
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
