namespace UltronPOSCR
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTxtOpt = new System.Windows.Forms.TextBox();
            this.QtyNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.DiscTxt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalUnits = new System.Windows.Forms.TextBox();
            this.SizeX = new System.Windows.Forms.TextBox();
            this.RateTxt = new System.Windows.Forms.NumericUpDown();
            this.UnitTxt = new System.Windows.Forms.ComboBox();
            this.SizeY = new System.Windows.Forms.NumericUpDown();
            this.RatePerLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.BtnNewBill = new System.Windows.Forms.Button();
            this.DeteleRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QtyNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 15.75F);
            this.AddBtn.Location = new System.Drawing.Point(563, 105);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(177, 52);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "اندراج";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 11.25F);
            this.ClearBtn.Location = new System.Drawing.Point(6, 105);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(49, 37);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "مٹائیں";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label1.Location = new System.Drawing.Point(697, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "تعداد";
            // 
            // DescriptionTxtOpt
            // 
            this.DescriptionTxtOpt.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.DescriptionTxtOpt.Location = new System.Drawing.Point(482, 58);
            this.DescriptionTxtOpt.Name = "DescriptionTxtOpt";
            this.DescriptionTxtOpt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DescriptionTxtOpt.Size = new System.Drawing.Size(126, 40);
            this.DescriptionTxtOpt.TabIndex = 1;
            // 
            // QtyNum
            // 
            this.QtyNum.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.QtyNum.Location = new System.Drawing.Point(680, 58);
            this.QtyNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QtyNum.Name = "QtyNum";
            this.QtyNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QtyNum.Size = new System.Drawing.Size(59, 38);
            this.QtyNum.TabIndex = 0;
            this.QtyNum.ValueChanged += new System.EventHandler(this.QtyNum_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label6.Location = new System.Drawing.Point(530, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "تفصیل";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TotalTxt);
            this.groupBox1.Controls.Add(this.DiscTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TotalUnits);
            this.groupBox1.Controls.Add(this.SizeX);
            this.groupBox1.Controls.Add(this.RateTxt);
            this.groupBox1.Controls.Add(this.UnitTxt);
            this.groupBox1.Controls.Add(this.DescriptionTxtOpt);
            this.groupBox1.Controls.Add(this.SizeY);
            this.groupBox1.Controls.Add(this.QtyNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RatePerLbl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(10, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(745, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label2.Location = new System.Drawing.Point(403, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label4.Location = new System.Drawing.Point(41, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "ٹوٹل";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Enabled = false;
            this.TotalTxt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalTxt.Location = new System.Drawing.Point(5, 58);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalTxt.Size = new System.Drawing.Size(109, 39);
            this.TotalTxt.TabIndex = 7;
            // 
            // DiscTxt
            // 
            this.DiscTxt.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.DiscTxt.Location = new System.Drawing.Point(119, 58);
            this.DiscTxt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DiscTxt.Name = "DiscTxt";
            this.DiscTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DiscTxt.Size = new System.Drawing.Size(59, 38);
            this.DiscTxt.TabIndex = 6;
            this.DiscTxt.ValueChanged += new System.EventHandler(this.DiscTxt_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label3.Location = new System.Drawing.Point(127, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "ڈسکاؤنٹ";
            // 
            // TotalUnits
            // 
            this.TotalUnits.Enabled = false;
            this.TotalUnits.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalUnits.Location = new System.Drawing.Point(269, 58);
            this.TotalUnits.Name = "TotalUnits";
            this.TotalUnits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalUnits.Size = new System.Drawing.Size(77, 39);
            this.TotalUnits.TabIndex = 7;
            // 
            // SizeX
            // 
            this.SizeX.Enabled = false;
            this.SizeX.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.SizeX.Location = new System.Drawing.Point(351, 58);
            this.SizeX.Name = "SizeX";
            this.SizeX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeX.Size = new System.Drawing.Size(49, 39);
            this.SizeX.TabIndex = 7;
            // 
            // RateTxt
            // 
            this.RateTxt.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.RateTxt.Location = new System.Drawing.Point(183, 58);
            this.RateTxt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.RateTxt.Name = "RateTxt";
            this.RateTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RateTxt.Size = new System.Drawing.Size(81, 38);
            this.RateTxt.TabIndex = 5;
            this.RateTxt.ValueChanged += new System.EventHandler(this.RateTxt_ValueChanged);
            // 
            // UnitTxt
            // 
            this.UnitTxt.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.UnitTxt.FormattingEnabled = true;
            this.UnitTxt.Items.AddRange(new object[] {
            "میٹر",
            "گز"});
            this.UnitTxt.Location = new System.Drawing.Point(615, 58);
            this.UnitTxt.Name = "UnitTxt";
            this.UnitTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UnitTxt.Size = new System.Drawing.Size(60, 40);
            this.UnitTxt.TabIndex = 3;
            this.UnitTxt.SelectedIndexChanged += new System.EventHandler(this.UnitTxt_SelectedIndexChanged);
            // 
            // SizeY
            // 
            this.SizeY.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.SizeY.Location = new System.Drawing.Point(417, 59);
            this.SizeY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SizeY.Name = "SizeY";
            this.SizeY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeY.Size = new System.Drawing.Size(59, 38);
            this.SizeY.TabIndex = 2;
            this.SizeY.ValueChanged += new System.EventHandler(this.SizeY_ValueChanged);
            // 
            // RatePerLbl
            // 
            this.RatePerLbl.AutoSize = true;
            this.RatePerLbl.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.RatePerLbl.Location = new System.Drawing.Point(202, 19);
            this.RatePerLbl.Name = "RatePerLbl";
            this.RatePerLbl.Size = new System.Drawing.Size(67, 32);
            this.RatePerLbl.TabIndex = 1;
            this.RatePerLbl.Text = "ریٹ فی میٹر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label7.Location = new System.Drawing.Point(629, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "یونٹ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label5.Location = new System.Drawing.Point(291, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "صافی";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.Location = new System.Drawing.Point(10, 222);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewMain.RowTemplate.Height = 25;
            this.dataGridViewMain.Size = new System.Drawing.Size(745, 254);
            this.dataGridViewMain.TabIndex = 5;
            // 
            // BtnNewBill
            // 
            this.BtnNewBill.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 15.75F);
            this.BtnNewBill.Location = new System.Drawing.Point(10, 12);
            this.BtnNewBill.Name = "BtnNewBill";
            this.BtnNewBill.Size = new System.Drawing.Size(177, 57);
            this.BtnNewBill.TabIndex = 7;
            this.BtnNewBill.Text = "نیا بل";
            this.BtnNewBill.UseVisualStyleBackColor = true;
            this.BtnNewBill.Click += new System.EventHandler(this.BtnNewBill_Click);
            // 
            // DeteleRowBtn
            // 
            this.DeteleRowBtn.BackColor = System.Drawing.Color.White;
            this.DeteleRowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeteleRowBtn.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Bold);
            this.DeteleRowBtn.ForeColor = System.Drawing.Color.Black;
            this.DeteleRowBtn.Location = new System.Drawing.Point(10, 482);
            this.DeteleRowBtn.Name = "DeteleRowBtn";
            this.DeteleRowBtn.Size = new System.Drawing.Size(26, 26);
            this.DeteleRowBtn.TabIndex = 8;
            this.DeteleRowBtn.UseVisualStyleBackColor = false;
            this.DeteleRowBtn.Click += new System.EventHandler(this.DeteleRowBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 520);
            this.Controls.Add(this.DeteleRowBtn);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.BtnNewBill);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QtyNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTxtOpt;
        private System.Windows.Forms.NumericUpDown QtyNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RatePerLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UnitTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RateTxt;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SizeY;
        private System.Windows.Forms.NumericUpDown DiscTxt;
        private System.Windows.Forms.TextBox SizeX;
        private System.Windows.Forms.TextBox TotalUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button BtnNewBill;
        private System.Windows.Forms.Button DeteleRowBtn;
    }
}

