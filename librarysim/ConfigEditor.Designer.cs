namespace librarysim
{
    partial class ConfigEditor
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
          this.nud_AdultCheckOutPeriod = new System.Windows.Forms.NumericUpDown();
          this.lbl_AdultCheckOutPeriod = new System.Windows.Forms.Label();
          this.lbl_ChildrenCheckOutPeriod = new System.Windows.Forms.Label();
          this.nud_ChildrenCheckOutPeriod = new System.Windows.Forms.NumericUpDown();
          this.gb_CheckOutPeriods = new System.Windows.Forms.GroupBox();
          this.nub_VideoCheckOutPeriod = new System.Windows.Forms.NumericUpDown();
          this.lbl_VideoCheckOutPeriod = new System.Windows.Forms.Label();
          this.nud_DVDPeriod = new System.Windows.Forms.NumericUpDown();
          this.lbl_DVDPeriod = new System.Windows.Forms.Label();
          this.gb_CheckOutLimits = new System.Windows.Forms.GroupBox();
          this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
          this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
          this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
          this.label3 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.label1 = new System.Windows.Forms.Label();
          this.nud_AdultBookLimit = new System.Windows.Forms.NumericUpDown();
          this.lbl_AdultBooks = new System.Windows.Forms.Label();
          this.gb_AgeDelimiter = new System.Windows.Forms.GroupBox();
          this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
          this.pnl_groupboxes = new System.Windows.Forms.Panel();
          this.btn_Save = new System.Windows.Forms.Button();
          this.btn_reset = new System.Windows.Forms.Button();
          this.groupBox1 = new System.Windows.Forms.GroupBox();
          this.textBox1 = new System.Windows.Forms.TextBox();
          this.btn_close = new System.Windows.Forms.Button();
          ((System.ComponentModel.ISupportInitialize)(this.nud_AdultCheckOutPeriod)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.nud_ChildrenCheckOutPeriod)).BeginInit();
          this.gb_CheckOutPeriods.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.nub_VideoCheckOutPeriod)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.nud_DVDPeriod)).BeginInit();
          this.gb_CheckOutLimits.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.nud_AdultBookLimit)).BeginInit();
          this.gb_AgeDelimiter.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
          this.pnl_groupboxes.SuspendLayout();
          this.groupBox1.SuspendLayout();
          this.SuspendLayout();
          // 
          // nud_AdultCheckOutPeriod
          // 
          this.nud_AdultCheckOutPeriod.Location = new System.Drawing.Point(9, 32);
          this.nud_AdultCheckOutPeriod.Name = "nud_AdultCheckOutPeriod";
          this.nud_AdultCheckOutPeriod.Size = new System.Drawing.Size(89, 20);
          this.nud_AdultCheckOutPeriod.TabIndex = 0;
          // 
          // lbl_AdultCheckOutPeriod
          // 
          this.lbl_AdultCheckOutPeriod.AutoSize = true;
          this.lbl_AdultCheckOutPeriod.Location = new System.Drawing.Point(6, 16);
          this.lbl_AdultCheckOutPeriod.Name = "lbl_AdultCheckOutPeriod";
          this.lbl_AdultCheckOutPeriod.Size = new System.Drawing.Size(63, 13);
          this.lbl_AdultCheckOutPeriod.TabIndex = 1;
          this.lbl_AdultCheckOutPeriod.Text = "Adult books";
          // 
          // lbl_ChildrenCheckOutPeriod
          // 
          this.lbl_ChildrenCheckOutPeriod.AutoSize = true;
          this.lbl_ChildrenCheckOutPeriod.Location = new System.Drawing.Point(6, 64);
          this.lbl_ChildrenCheckOutPeriod.Name = "lbl_ChildrenCheckOutPeriod";
          this.lbl_ChildrenCheckOutPeriod.Size = new System.Drawing.Size(77, 13);
          this.lbl_ChildrenCheckOutPeriod.TabIndex = 2;
          this.lbl_ChildrenCheckOutPeriod.Text = "Children books";
          // 
          // nud_ChildrenCheckOutPeriod
          // 
          this.nud_ChildrenCheckOutPeriod.Location = new System.Drawing.Point(9, 80);
          this.nud_ChildrenCheckOutPeriod.Name = "nud_ChildrenCheckOutPeriod";
          this.nud_ChildrenCheckOutPeriod.Size = new System.Drawing.Size(89, 20);
          this.nud_ChildrenCheckOutPeriod.TabIndex = 3;
          // 
          // gb_CheckOutPeriods
          // 
          this.gb_CheckOutPeriods.Controls.Add(this.nub_VideoCheckOutPeriod);
          this.gb_CheckOutPeriods.Controls.Add(this.lbl_VideoCheckOutPeriod);
          this.gb_CheckOutPeriods.Controls.Add(this.nud_DVDPeriod);
          this.gb_CheckOutPeriods.Controls.Add(this.lbl_DVDPeriod);
          this.gb_CheckOutPeriods.Controls.Add(this.nud_AdultCheckOutPeriod);
          this.gb_CheckOutPeriods.Controls.Add(this.nud_ChildrenCheckOutPeriod);
          this.gb_CheckOutPeriods.Controls.Add(this.lbl_AdultCheckOutPeriod);
          this.gb_CheckOutPeriods.Controls.Add(this.lbl_ChildrenCheckOutPeriod);
          this.gb_CheckOutPeriods.Dock = System.Windows.Forms.DockStyle.Top;
          this.gb_CheckOutPeriods.Location = new System.Drawing.Point(0, 0);
          this.gb_CheckOutPeriods.Name = "gb_CheckOutPeriods";
          this.gb_CheckOutPeriods.Size = new System.Drawing.Size(369, 111);
          this.gb_CheckOutPeriods.TabIndex = 4;
          this.gb_CheckOutPeriods.TabStop = false;
          this.gb_CheckOutPeriods.Text = "Check Out Periods (Days)";
          // 
          // nub_VideoCheckOutPeriod
          // 
          this.nub_VideoCheckOutPeriod.Location = new System.Drawing.Point(142, 80);
          this.nub_VideoCheckOutPeriod.Name = "nub_VideoCheckOutPeriod";
          this.nub_VideoCheckOutPeriod.Size = new System.Drawing.Size(89, 20);
          this.nub_VideoCheckOutPeriod.TabIndex = 7;
          // 
          // lbl_VideoCheckOutPeriod
          // 
          this.lbl_VideoCheckOutPeriod.AutoSize = true;
          this.lbl_VideoCheckOutPeriod.Location = new System.Drawing.Point(139, 64);
          this.lbl_VideoCheckOutPeriod.Name = "lbl_VideoCheckOutPeriod";
          this.lbl_VideoCheckOutPeriod.Size = new System.Drawing.Size(39, 13);
          this.lbl_VideoCheckOutPeriod.TabIndex = 6;
          this.lbl_VideoCheckOutPeriod.Text = "Videos";
          // 
          // nud_DVDPeriod
          // 
          this.nud_DVDPeriod.Location = new System.Drawing.Point(142, 32);
          this.nud_DVDPeriod.Name = "nud_DVDPeriod";
          this.nud_DVDPeriod.Size = new System.Drawing.Size(89, 20);
          this.nud_DVDPeriod.TabIndex = 5;
          // 
          // lbl_DVDPeriod
          // 
          this.lbl_DVDPeriod.AutoSize = true;
          this.lbl_DVDPeriod.Location = new System.Drawing.Point(139, 16);
          this.lbl_DVDPeriod.Name = "lbl_DVDPeriod";
          this.lbl_DVDPeriod.Size = new System.Drawing.Size(35, 13);
          this.lbl_DVDPeriod.TabIndex = 4;
          this.lbl_DVDPeriod.Text = "DVDs";
          // 
          // gb_CheckOutLimits
          // 
          this.gb_CheckOutLimits.Controls.Add(this.numericUpDown3);
          this.gb_CheckOutLimits.Controls.Add(this.numericUpDown2);
          this.gb_CheckOutLimits.Controls.Add(this.numericUpDown1);
          this.gb_CheckOutLimits.Controls.Add(this.label3);
          this.gb_CheckOutLimits.Controls.Add(this.label2);
          this.gb_CheckOutLimits.Controls.Add(this.label1);
          this.gb_CheckOutLimits.Controls.Add(this.nud_AdultBookLimit);
          this.gb_CheckOutLimits.Controls.Add(this.lbl_AdultBooks);
          this.gb_CheckOutLimits.Dock = System.Windows.Forms.DockStyle.Left;
          this.gb_CheckOutLimits.Location = new System.Drawing.Point(0, 0);
          this.gb_CheckOutLimits.Name = "gb_CheckOutLimits";
          this.gb_CheckOutLimits.Size = new System.Drawing.Size(246, 116);
          this.gb_CheckOutLimits.TabIndex = 5;
          this.gb_CheckOutLimits.TabStop = false;
          this.gb_CheckOutLimits.Text = "Check out limits";
          // 
          // numericUpDown3
          // 
          this.numericUpDown3.Location = new System.Drawing.Point(142, 75);
          this.numericUpDown3.Name = "numericUpDown3";
          this.numericUpDown3.Size = new System.Drawing.Size(89, 20);
          this.numericUpDown3.TabIndex = 7;
          // 
          // numericUpDown2
          // 
          this.numericUpDown2.Location = new System.Drawing.Point(142, 32);
          this.numericUpDown2.Name = "numericUpDown2";
          this.numericUpDown2.Size = new System.Drawing.Size(89, 20);
          this.numericUpDown2.TabIndex = 6;
          // 
          // numericUpDown1
          // 
          this.numericUpDown1.Location = new System.Drawing.Point(9, 75);
          this.numericUpDown1.Name = "numericUpDown1";
          this.numericUpDown1.Size = new System.Drawing.Size(89, 20);
          this.numericUpDown1.TabIndex = 5;
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(139, 59);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(39, 13);
          this.label3.TabIndex = 4;
          this.label3.Text = "Videos";
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(6, 59);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(77, 13);
          this.label2.TabIndex = 3;
          this.label2.Text = "Children books";
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(139, 16);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(35, 13);
          this.label1.TabIndex = 2;
          this.label1.Text = "DVDs";
          // 
          // nud_AdultBookLimit
          // 
          this.nud_AdultBookLimit.Location = new System.Drawing.Point(9, 32);
          this.nud_AdultBookLimit.Name = "nud_AdultBookLimit";
          this.nud_AdultBookLimit.Size = new System.Drawing.Size(89, 20);
          this.nud_AdultBookLimit.TabIndex = 1;
          // 
          // lbl_AdultBooks
          // 
          this.lbl_AdultBooks.AutoSize = true;
          this.lbl_AdultBooks.Location = new System.Drawing.Point(6, 16);
          this.lbl_AdultBooks.Name = "lbl_AdultBooks";
          this.lbl_AdultBooks.Size = new System.Drawing.Size(63, 13);
          this.lbl_AdultBooks.TabIndex = 0;
          this.lbl_AdultBooks.Text = "Adult books";
          // 
          // gb_AgeDelimiter
          // 
          this.gb_AgeDelimiter.Controls.Add(this.numericUpDown4);
          this.gb_AgeDelimiter.Dock = System.Windows.Forms.DockStyle.Right;
          this.gb_AgeDelimiter.Location = new System.Drawing.Point(252, 0);
          this.gb_AgeDelimiter.Name = "gb_AgeDelimiter";
          this.gb_AgeDelimiter.Size = new System.Drawing.Size(117, 116);
          this.gb_AgeDelimiter.TabIndex = 6;
          this.gb_AgeDelimiter.TabStop = false;
          this.gb_AgeDelimiter.Text = "Age Delimiter";
          // 
          // numericUpDown4
          // 
          this.numericUpDown4.Location = new System.Drawing.Point(16, 32);
          this.numericUpDown4.Name = "numericUpDown4";
          this.numericUpDown4.Size = new System.Drawing.Size(89, 20);
          this.numericUpDown4.TabIndex = 0;
          // 
          // pnl_groupboxes
          // 
          this.pnl_groupboxes.Controls.Add(this.gb_AgeDelimiter);
          this.pnl_groupboxes.Controls.Add(this.gb_CheckOutLimits);
          this.pnl_groupboxes.Dock = System.Windows.Forms.DockStyle.Top;
          this.pnl_groupboxes.Location = new System.Drawing.Point(0, 111);
          this.pnl_groupboxes.Name = "pnl_groupboxes";
          this.pnl_groupboxes.Size = new System.Drawing.Size(369, 116);
          this.pnl_groupboxes.TabIndex = 7;
          // 
          // btn_Save
          // 
          this.btn_Save.Location = new System.Drawing.Point(124, 295);
          this.btn_Save.Name = "btn_Save";
          this.btn_Save.Size = new System.Drawing.Size(75, 23);
          this.btn_Save.TabIndex = 8;
          this.btn_Save.Text = "Save";
          this.btn_Save.UseVisualStyleBackColor = true;
          // 
          // btn_reset
          // 
          this.btn_reset.Location = new System.Drawing.Point(286, 295);
          this.btn_reset.Name = "btn_reset";
          this.btn_reset.Size = new System.Drawing.Size(75, 23);
          this.btn_reset.TabIndex = 9;
          this.btn_reset.Text = "Reset";
          this.btn_reset.UseVisualStyleBackColor = true;
          // 
          // groupBox1
          // 
          this.groupBox1.Controls.Add(this.textBox1);
          this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
          this.groupBox1.Location = new System.Drawing.Point(0, 227);
          this.groupBox1.Name = "groupBox1";
          this.groupBox1.Size = new System.Drawing.Size(369, 62);
          this.groupBox1.TabIndex = 10;
          this.groupBox1.TabStop = false;
          this.groupBox1.Text = "Database String";
          // 
          // textBox1
          // 
          this.textBox1.Location = new System.Drawing.Point(9, 20);
          this.textBox1.Name = "textBox1";
          this.textBox1.Size = new System.Drawing.Size(348, 20);
          this.textBox1.TabIndex = 0;
          // 
          // btn_close
          // 
          this.btn_close.Location = new System.Drawing.Point(205, 295);
          this.btn_close.Name = "btn_close";
          this.btn_close.Size = new System.Drawing.Size(75, 23);
          this.btn_close.TabIndex = 11;
          this.btn_close.Text = "Close";
          this.btn_close.UseVisualStyleBackColor = true;
          this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
          // 
          // ConfigEditor
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(369, 330);
          this.ControlBox = false;
          this.Controls.Add(this.btn_close);
          this.Controls.Add(this.groupBox1);
          this.Controls.Add(this.btn_reset);
          this.Controls.Add(this.btn_Save);
          this.Controls.Add(this.pnl_groupboxes);
          this.Controls.Add(this.gb_CheckOutPeriods);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          this.Name = "ConfigEditor";
          this.ShowIcon = false;
          this.ShowInTaskbar = false;
          this.Text = "Configuration Editor";
          ((System.ComponentModel.ISupportInitialize)(this.nud_AdultCheckOutPeriod)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.nud_ChildrenCheckOutPeriod)).EndInit();
          this.gb_CheckOutPeriods.ResumeLayout(false);
          this.gb_CheckOutPeriods.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.nub_VideoCheckOutPeriod)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.nud_DVDPeriod)).EndInit();
          this.gb_CheckOutLimits.ResumeLayout(false);
          this.gb_CheckOutLimits.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.nud_AdultBookLimit)).EndInit();
          this.gb_AgeDelimiter.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
          this.pnl_groupboxes.ResumeLayout(false);
          this.groupBox1.ResumeLayout(false);
          this.groupBox1.PerformLayout();
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_AdultCheckOutPeriod;
        private System.Windows.Forms.Label lbl_AdultCheckOutPeriod;
        private System.Windows.Forms.Label lbl_ChildrenCheckOutPeriod;
        private System.Windows.Forms.NumericUpDown nud_ChildrenCheckOutPeriod;
        private System.Windows.Forms.GroupBox gb_CheckOutPeriods;
        private System.Windows.Forms.NumericUpDown nud_DVDPeriod;
        private System.Windows.Forms.Label lbl_DVDPeriod;
        private System.Windows.Forms.Label lbl_VideoCheckOutPeriod;
        private System.Windows.Forms.NumericUpDown nub_VideoCheckOutPeriod;
        private System.Windows.Forms.GroupBox gb_CheckOutLimits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_AdultBookLimit;
        private System.Windows.Forms.Label lbl_AdultBooks;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_AgeDelimiter;
        private System.Windows.Forms.Panel pnl_groupboxes;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_close;
    }
}