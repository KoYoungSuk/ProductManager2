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
    public partial class WriteForm : Form
    {
        Global g = new Global();
        public WriteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String product_no = textBox1.Text;
            String product_name = textBox2.Text;
            String buy_date = textBox3.Text;
            String buy_date_used = textBox4.Text;
            String purpose = textBox5.Text; 
            try
            {
                ProductDTO productdto = new ProductDTO(product_no, product_name, buy_date, buy_date_used, purpose);
                ProductDAO productdao = new ProductDAO(g.dburl, g.dbport, g.dbsid, g.dbid, g.dbpw);
                int Rowsinserted = productdao.insertProduct(productdto);
                if(Rowsinserted == 1)
                {
                    g.message("Successfully Inserted!", false);
                    this.Hide();
                }
                else
                {
                    g.message("Unknown Error Message", true);
                }
            }
            catch(Exception ex)
            {
                g.message(ex.Message, true);
            }
        }
    }
}
