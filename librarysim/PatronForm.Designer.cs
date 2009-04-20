namespace librarysim
{
  partial class PatronForm
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
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lblName = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblPhoneNumber = new System.Windows.Forms.Label();
      this.txtPhoneNumber = new System.Windows.Forms.TextBox();
      this.lblAddress = new System.Windows.Forms.Label();
      this.lblGender = new System.Windows.Forms.Label();
      this.lblBirthday = new System.Windows.Forms.Label();
      this.dtpDOB = new System.Windows.Forms.DateTimePicker();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.cmbGender = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(189, 153);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(5, 153);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(13, 13);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(35, 13);
      this.lblName.TabIndex = 2;
      this.lblName.Text = "Name";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(97, 10);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(167, 20);
      this.txtName.TabIndex = 0;
      // 
      // lblPhoneNumber
      // 
      this.lblPhoneNumber.AutoSize = true;
      this.lblPhoneNumber.Location = new System.Drawing.Point(13, 39);
      this.lblPhoneNumber.Name = "lblPhoneNumber";
      this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
      this.lblPhoneNumber.TabIndex = 2;
      this.lblPhoneNumber.Text = "Phone Number";
      // 
      // txtPhoneNumber
      // 
      this.txtPhoneNumber.Location = new System.Drawing.Point(97, 36);
      this.txtPhoneNumber.Name = "txtPhoneNumber";
      this.txtPhoneNumber.Size = new System.Drawing.Size(167, 20);
      this.txtPhoneNumber.TabIndex = 1;
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.Location = new System.Drawing.Point(13, 65);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(45, 13);
      this.lblAddress.TabIndex = 2;
      this.lblAddress.Text = "Address";
      // 
      // lblGender
      // 
      this.lblGender.AutoSize = true;
      this.lblGender.Location = new System.Drawing.Point(13, 91);
      this.lblGender.Name = "lblGender";
      this.lblGender.Size = new System.Drawing.Size(42, 13);
      this.lblGender.TabIndex = 2;
      this.lblGender.Text = "Gender";
      // 
      // lblBirthday
      // 
      this.lblBirthday.AutoSize = true;
      this.lblBirthday.Location = new System.Drawing.Point(13, 117);
      this.lblBirthday.Name = "lblBirthday";
      this.lblBirthday.Size = new System.Drawing.Size(45, 13);
      this.lblBirthday.TabIndex = 2;
      this.lblBirthday.Text = "Birthday";
      // 
      // dtpDOB
      // 
      this.dtpDOB.Location = new System.Drawing.Point(64, 114);
      this.dtpDOB.Name = "dtpDOB";
      this.dtpDOB.Size = new System.Drawing.Size(200, 20);
      this.dtpDOB.TabIndex = 4;
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(97, 62);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(167, 20);
      this.txtAddress.TabIndex = 2;
      // 
      // cmbGender
      // 
      this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbGender.FormattingEnabled = true;
      this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
      this.cmbGender.Location = new System.Drawing.Point(97, 87);
      this.cmbGender.Name = "cmbGender";
      this.cmbGender.Size = new System.Drawing.Size(167, 21);
      this.cmbGender.TabIndex = 3;
      // 
      // PatronForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(275, 185);
      this.ControlBox = false;
      this.Controls.Add(this.cmbGender);
      this.Controls.Add(this.dtpDOB);
      this.Controls.Add(this.lblBirthday);
      this.Controls.Add(this.lblGender);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.lblAddress);
      this.Controls.Add(this.txtPhoneNumber);
      this.Controls.Add(this.lblPhoneNumber);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "PatronForm";
      this.Text = "Patron Form";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblPhoneNumber;
    private System.Windows.Forms.TextBox txtPhoneNumber;
    private System.Windows.Forms.Label lblAddress;
    private System.Windows.Forms.Label lblGender;
    private System.Windows.Forms.Label lblBirthday;
    private System.Windows.Forms.DateTimePicker dtpDOB;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.ComboBox cmbGender;
  }
}