namespace ProductManager2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDescendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byProductNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byBuyDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byBuyDateUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadAscendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byProductNoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byBuyDateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byBuyDateUsedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataGridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProductManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(617, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(646, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "MODIFY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(646, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "STATUS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "ProductManager ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "VER 20220813";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "POWERED BY ORACLE DATABASE";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "THIS PROGRAM REQUIRES WINDOWS 7 OR HIGHER..";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(108, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Load);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "물품 번호 입력:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(646, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 62);
            this.button3.TabIndex = 11;
            this.button3.Text = "WRITE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(646, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 63);
            this.button4.TabIndex = 12;
            this.button4.Text = "RELOAD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(646, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 58);
            this.button5.TabIndex = 13;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.dataBaseDToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitXToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveAsExcelFileToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileFToolStripMenuItem.Text = "File(F)";
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitXToolStripMenuItem.Text = "Exit(X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // saveAsExcelFileToolStripMenuItem
            // 
            this.saveAsExcelFileToolStripMenuItem.Name = "saveAsExcelFileToolStripMenuItem";
            this.saveAsExcelFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveAsExcelFileToolStripMenuItem.Text = "Save as Excel File";
            this.saveAsExcelFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsExcelFileToolStripMenuItem_Click);
            // 
            // dataBaseDToolStripMenuItem
            // 
            this.dataBaseDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadDescendToolStripMenuItem,
            this.reloadAscendToolStripMenuItem,
            this.clearDataGridViewToolStripMenuItem});
            this.dataBaseDToolStripMenuItem.Name = "dataBaseDToolStripMenuItem";
            this.dataBaseDToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.dataBaseDToolStripMenuItem.Text = "DataBase(D)";
            // 
            // reloadDescendToolStripMenuItem
            // 
            this.reloadDescendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byProductNoToolStripMenuItem,
            this.byBuyDateToolStripMenuItem,
            this.byBuyDateUsedToolStripMenuItem});
            this.reloadDescendToolStripMenuItem.Name = "reloadDescendToolStripMenuItem";
            this.reloadDescendToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reloadDescendToolStripMenuItem.Text = "Reload(Descend)";
            this.reloadDescendToolStripMenuItem.Click += new System.EventHandler(this.reloadDescendToolStripMenuItem_Click);
            // 
            // byProductNoToolStripMenuItem
            // 
            this.byProductNoToolStripMenuItem.Name = "byProductNoToolStripMenuItem";
            this.byProductNoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.byProductNoToolStripMenuItem.Text = "By Product_No";
            this.byProductNoToolStripMenuItem.Click += new System.EventHandler(this.byProductNoToolStripMenuItem_Click);
            // 
            // byBuyDateToolStripMenuItem
            // 
            this.byBuyDateToolStripMenuItem.Name = "byBuyDateToolStripMenuItem";
            this.byBuyDateToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.byBuyDateToolStripMenuItem.Text = "By Buy_Date";
            this.byBuyDateToolStripMenuItem.Click += new System.EventHandler(this.byBuyDateToolStripMenuItem_Click);
            // 
            // byBuyDateUsedToolStripMenuItem
            // 
            this.byBuyDateUsedToolStripMenuItem.Name = "byBuyDateUsedToolStripMenuItem";
            this.byBuyDateUsedToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.byBuyDateUsedToolStripMenuItem.Text = "By Buy_Date_Used";
            this.byBuyDateUsedToolStripMenuItem.Click += new System.EventHandler(this.byBuyDateUsedToolStripMenuItem_Click);
            // 
            // reloadAscendToolStripMenuItem
            // 
            this.reloadAscendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byProductNoToolStripMenuItem1,
            this.byBuyDateToolStripMenuItem1,
            this.byBuyDateUsedToolStripMenuItem1});
            this.reloadAscendToolStripMenuItem.Name = "reloadAscendToolStripMenuItem";
            this.reloadAscendToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reloadAscendToolStripMenuItem.Text = "Reload(Ascend)";
            // 
            // byProductNoToolStripMenuItem1
            // 
            this.byProductNoToolStripMenuItem1.Name = "byProductNoToolStripMenuItem1";
            this.byProductNoToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.byProductNoToolStripMenuItem1.Text = "By Product_No";
            this.byProductNoToolStripMenuItem1.Click += new System.EventHandler(this.byProductNoToolStripMenuItem1_Click);
            // 
            // byBuyDateToolStripMenuItem1
            // 
            this.byBuyDateToolStripMenuItem1.Name = "byBuyDateToolStripMenuItem1";
            this.byBuyDateToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.byBuyDateToolStripMenuItem1.Text = "By Buy_Date";
            this.byBuyDateToolStripMenuItem1.Click += new System.EventHandler(this.byBuyDateToolStripMenuItem1_Click);
            // 
            // byBuyDateUsedToolStripMenuItem1
            // 
            this.byBuyDateUsedToolStripMenuItem1.Name = "byBuyDateUsedToolStripMenuItem1";
            this.byBuyDateUsedToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.byBuyDateUsedToolStripMenuItem1.Text = "By Buy_Date_Used";
            this.byBuyDateUsedToolStripMenuItem1.Click += new System.EventHandler(this.byBuyDateUsedToolStripMenuItem1_Click);
            // 
            // clearDataGridViewToolStripMenuItem
            // 
            this.clearDataGridViewToolStripMenuItem.Name = "clearDataGridViewToolStripMenuItem";
            this.clearDataGridViewToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.clearDataGridViewToolStripMenuItem.Text = "Clear DataGridView";
            this.clearDataGridViewToolStripMenuItem.Click += new System.EventHandler(this.clearDataGridViewToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProductManagerToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpHToolStripMenuItem.Text = "Help(H)";
            // 
            // aboutProductManagerToolStripMenuItem
            // 
            this.aboutProductManagerToolStripMenuItem.Name = "aboutProductManagerToolStripMenuItem";
            this.aboutProductManagerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aboutProductManagerToolStripMenuItem.Text = "About ProductManager";
            this.aboutProductManagerToolStripMenuItem.Click += new System.EventHandler(this.aboutProductManagerToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "This is not Copyrighted.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Product Number:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Your Operating System:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(638, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 355);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 64);
            this.panel2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ProductManager 2022-08-13";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadDescendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadAscendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataGridViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProductManagerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem byProductNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byBuyDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byBuyDateUsedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byProductNoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byBuyDateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byBuyDateUsedToolStripMenuItem1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsExcelFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

