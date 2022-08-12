using Oracle.ManagedDataAccess.Client;
using Excel = Microsoft.Office.Interop.Excel;
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
    public partial class Form1 : Form
    {
        OracleConnection conn;

        Global g = new Global();
        public Form1(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn; 
            runQuery(false, "product_no");
            label1.Text = "STATUS: Successfully Connected at [ " + DateTime.Now.ToString() + " ] ";
            label9.Text = g.checkOS();
        }

        public void selectProduct(String number)
        {
            try
            {
                DetailForm df = new DetailForm(number, conn);
                df.Show();
            }
            catch (Exception ex)
            {
                g.message(ex.Message, true);
            }
        }
      
        public void runQuery(Boolean desc, String columnname)
        {
            textBox1.Text = "";
            try
            {
                ProductDAO productdao = new ProductDAO(conn);
                DataTable dt = productdao.getProductList(desc, columnname);
                int productnumber = productdao.getProductNumber();
                if(dt != null)
                {
                    dataGridView1.DataSource = dt;
                    label8.Text = "Product Number: " + productnumber;
                }
                else
                {
                    g.message("Null", true);
                }
            }catch(Exception ex)
            {
                g.message(ex.Message, true);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e){ }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectProduct(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifyForm mf = new ModifyForm(textBox1.Text, conn);
            mf.Show();
        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Close(); 
            Application.Exit();
        }

        private void clearDataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            runQuery(false, "product_no");
        }

        private void reloadDescendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void byProductNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runQuery(true, "product_no");
        }

        private void byBuyDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runQuery(true, "buy_date");
        }

        private void byBuyDateUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runQuery(true, "buy_date_used");
        }

        private void byProductNoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            runQuery(false, "product_no");
        }

        private void byBuyDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            runQuery(false, "buy_date");
        }

        private void byBuyDateUsedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            runQuery(false, "buy_date_used");
        }

        private void KeyDown_Load(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                selectProduct(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDAO productdao = new ProductDAO(conn);
                int RowsDeleted = productdao.deleteProduct(textBox1.Text);
                if(RowsDeleted == 1)
                {
                    g.message("Success Deleted!", false);
                    runQuery(false, "product_no");
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

        private void aboutProductManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WriteForm wf = new WriteForm(conn);
            wf.Show(); 
        }

        private void saveAsExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Microsoft Excel 97~2003 File(*.xls)|*.xls|All Files(*.*)|*.*";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.OverwritePrompt = true;
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel._Worksheet workSheet = null;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    excelApp = new Excel.Application();
                    if (excelApp == null)
                    {
                        g.message("Not Excel Installed!", true);
                        return;
                    }

                    wb = excelApp.Workbooks.Add(true);

                    workSheet = wb.Worksheets.get_Item(1) as Excel._Worksheet;
                    workSheet.Name = "Excel WorkSheet";

                    if (dataGridView1.Rows.Count == 0)
                    {
                        g.message("Empty Data.", true);
                    }

                    // Header(Schema)
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        workSheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }

                    // Instance
                    for (int r = 0; r < dataGridView1.Rows.Count; r++)
                    {
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            workSheet.Cells[r + 2, i + 1] = dataGridView1.Rows[r].Cells[i].Value;
                        }
                    }

                    wb.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    wb.Close(Type.Missing, Type.Missing, Type.Missing);
                    excelApp.Quit();
                    releaseObject(excelApp);
                    releaseObject(workSheet);
                    releaseObject(wb);

                    g.message("Success!", false);
                }
            }
            catch (Exception ex)
            {
                g.message(ex.Message, true);
            }
        
       }
       private void releaseObject(object obj)
       {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }

            catch (Exception e)
            {
                obj = null;
                g.message(e.Message, true);
            }

            finally
            {
                GC.Collect();
            }
       }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            Application.Exit(); 
        }
    }
}
