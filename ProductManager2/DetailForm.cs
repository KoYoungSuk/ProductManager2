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
    public partial class DetailForm : Form
    {
        Global g = new Global();
        String number;
        public DetailForm(String number)
        {
            InitializeComponent();
            this.number = number;
            runQuery(number);
        }

        public void runQuery(String number)
        {
            try
            {
                ProductDAO productdao = new ProductDAO(g.dburl, g.dbport, g.dbsid, g.dbid, g.dbpw);
                SortedList<String, String> productlist = productdao.GetProductListByNumber(number);
                if(productlist != null)
                {
                    textBox1.Text = productlist["product_no"];
                    textBox2.Text = productlist["product_name"];
                    textBox3.Text = productlist["buy_date"];
                    textBox4.Text = productlist["buy_date_used"];
                    textBox5.Text = productlist["purpose"];
                }
                else
                {
                    g.message("Null Error", true);
                }
            }catch(Exception ex)
            {
                g.message(ex.Message, true);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDAO productdao = new ProductDAO(g.dburl, g.dbport, g.dbsid, g.dbid, g.dbpw);
                int RowsDeleted = productdao.deleteProduct(number);
                if(RowsDeleted == 1)
                {
                    g.message("Success Deleted!", false);
                    this.Hide();
                }
                else
                {
                    g.message("Unknown Error Message", true);
                }
            }catch(Exception ex)
            {
                g.message(ex.Message, true); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifyForm mf = new ModifyForm(number);
            mf.Show();
            this.Hide();
        }
    }
}
