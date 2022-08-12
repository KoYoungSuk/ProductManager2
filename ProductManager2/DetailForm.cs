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
    public partial class DetailForm : Form
    {
        Global g = new Global();
        String number;
        OracleConnection conn = null;
        public DetailForm(String number, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.number = number;
            runQuery(number);
        }

        public void runQuery(String number)
        {
            try
            {
                ProductDAO productdao = new ProductDAO(conn);
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
                ProductDAO productdao = new ProductDAO(conn);
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
            ModifyForm mf = new ModifyForm(number, conn);
            mf.Show();
            this.Hide();
        }
    }
}
