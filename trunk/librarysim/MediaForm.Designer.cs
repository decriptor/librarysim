namespace librarysim
{
  partial class MediaForm
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.lblTitle = new System.Windows.Forms.Label();
      this.txtTitle = new System.Windows.Forms.TextBox();
      this.lblDescription = new System.Windows.Forms.Label();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.lblCheckedIn = new System.Windows.Forms.Label();
      this.lblCheckedOut = new System.Windows.Forms.Label();
      this.dtpCheckedIn = new System.Windows.Forms.DateTimePicker();
      this.dtpCheckedOut = new System.Windows.Forms.DateTimePicker();
      this.cbReserved = new System.Windows.Forms.CheckBox();
      this.lblPatronID = new System.Windows.Forms.Label();
      this.txtPatronID = new System.Windows.Forms.TextBox();
      this.cmbType = new System.Windows.Forms.ComboBox();
      this.lblTypr = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(15, 203);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(225, 203);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Location = new System.Drawing.Point(12, 64);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(27, 13);
      this.lblTitle.TabIndex = 9;
      this.lblTitle.Text = "Title";
      // 
      // txtTitle
      // 
      this.txtTitle.Location = new System.Drawing.Point(100, 61);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new System.Drawing.Size(200, 20);
      this.txtTitle.TabIndex = 1;
      // 
      // lblDescription
      // 
      this.lblDescription.AutoSize = true;
      this.lblDescription.Location = new System.Drawing.Point(12, 89);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(60, 13);
      this.lblDescription.TabIndex = 9;
      this.lblDescription.Text = "Description";
      // 
      // txtDescription
      // 
      this.txtDescription.Location = new System.Drawing.Point(101, 86);
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(199, 20);
      this.txtDescription.TabIndex = 2;
      // 
      // lblCheckedIn
      // 
      this.lblCheckedIn.AutoSize = true;
      this.lblCheckedIn.Location = new System.Drawing.Point(12, 115);
      this.lblCheckedIn.Name = "lblCheckedIn";
      this.lblCheckedIn.Size = new System.Drawing.Size(62, 13);
      this.lblCheckedIn.TabIndex = 9;
      this.lblCheckedIn.Text = "Checked In";
      // 
      // lblCheckedOut
      // 
      this.lblCheckedOut.AutoSize = true;
      this.lblCheckedOut.Location = new System.Drawing.Point(12, 140);
      this.lblCheckedOut.Name = "lblCheckedOut";
      this.lblCheckedOut.Size = new System.Drawing.Size(70, 13);
      this.lblCheckedOut.TabIndex = 9;
      this.lblCheckedOut.Text = "Checked Out";
      // 
      // dtpCheckedIn
      // 
      this.dtpCheckedIn.Location = new System.Drawing.Point(100, 112);
      this.dtpCheckedIn.Name = "dtpCheckedIn";
      this.dtpCheckedIn.Size = new System.Drawing.Size(200, 20);
      this.dtpCheckedIn.TabIndex = 3;
      // 
      // dtpCheckedOut
      // 
      this.dtpCheckedOut.Location = new System.Drawing.Point(100, 138);
      this.dtpCheckedOut.Name = "dtpCheckedOut";
      this.dtpCheckedOut.Size = new System.Drawing.Size(200, 20);
      this.dtpCheckedOut.TabIndex = 4;
      // 
      // cbReserved
      // 
      this.cbReserved.AutoSize = true;
      this.cbReserved.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.cbReserved.Location = new System.Drawing.Point(10, 166);
      this.cbReserved.Name = "cbReserved";
      this.cbReserved.Size = new System.Drawing.Size(72, 17);
      this.cbReserved.TabIndex = 5;
      this.cbReserved.Text = "Reserved";
      this.cbReserved.UseVisualStyleBackColor = true;
      // 
      // lblPatronID
      // 
      this.lblPatronID.AutoSize = true;
      this.lblPatronID.Location = new System.Drawing.Point(12, 9);
      this.lblPatronID.Name = "lblPatronID";
      this.lblPatronID.Size = new System.Drawing.Size(82, 13);
      this.lblPatronID.TabIndex = 14;
      this.lblPatronID.Text = "Checked out by";
      // 
      // txtPatronID
      // 
      this.txtPatronID.Location = new System.Drawing.Point(100, 6);
      this.txtPatronID.Name = "txtPatronID";
      this.txtPatronID.ReadOnly = true;
      this.txtPatronID.Size = new System.Drawing.Size(200, 20);
      this.txtPatronID.TabIndex = 15;
      this.txtPatronID.TabStop = false;
      // 
      // cmbType
      // 
      this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Items.AddRange(new object[] {
            "DVD",
            "VHS",
            "CD"});
      this.cmbType.Location = new System.Drawing.Point(101, 32);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new System.Drawing.Size(199, 21);
      this.cmbType.TabIndex = 0;
      // 
      // lblTypr
      // 
      this.lblTypr.AutoSize = true;
      this.lblTypr.Location = new System.Drawing.Point(12, 35);
      this.lblTypr.Name = "lblTypr";
      this.lblTypr.Size = new System.Drawing.Size(31, 13);
      this.lblTypr.TabIndex = 16;
      this.lblTypr.Text = "Type";
      // 
      // MediaForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(323, 234);
      this.ControlBox = false;
      this.Controls.Add(this.cmbType);
      this.Controls.Add(this.lblTypr);
      this.Controls.Add(this.txtPatronID);
      this.Controls.Add(this.lblPatronID);
      this.Controls.Add(this.cbReserved);
      this.Controls.Add(this.dtpCheckedOut);
      this.Controls.Add(this.dtpCheckedIn);
      this.Controls.Add(this.lblCheckedOut);
      this.Controls.Add(this.lblCheckedIn);
      this.Controls.Add(this.txtDescription);
      this.Controls.Add(this.lblDescription);
      this.Controls.Add(this.txtTitle);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "MediaForm";
      this.Text = "Media";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.Label lblCheckedIn;
    private System.Windows.Forms.Label lblCheckedOut;
    private System.Windows.Forms.DateTimePicker dtpCheckedIn;
    private System.Windows.Forms.DateTimePicker dtpCheckedOut;
    private System.Windows.Forms.CheckBox cbReserved;
    private System.Windows.Forms.Label lblPatronID;
    private System.Windows.Forms.TextBox txtPatronID;
    private System.Windows.Forms.ComboBox cmbType;
    private System.Windows.Forms.Label lblTypr;
  }
}