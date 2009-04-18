namespace librarysim
{
    partial class MainForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Patron = new System.Windows.Forms.Label();
            this.lsv_Patron = new System.Windows.Forms.ListView();
            this.chPatron_ID = new System.Windows.Forms.ColumnHeader();
            this.chPatron_name = new System.Windows.Forms.ColumnHeader();
            this.chPatron_phoneNumber = new System.Windows.Forms.ColumnHeader();
            this.chPatron_address = new System.Windows.Forms.ColumnHeader();
            this.chPatron_gender = new System.Windows.Forms.ColumnHeader();
            this.chPatron_dob = new System.Windows.Forms.ColumnHeader();
            this.chPatron_Type = new System.Windows.Forms.ColumnHeader();
            this.lsv_Book = new System.Windows.Forms.ListView();
            this.chBook_ID = new System.Windows.Forms.ColumnHeader();
            this.chBook_patronID = new System.Windows.Forms.ColumnHeader();
            this.chBook_type = new System.Windows.Forms.ColumnHeader();
            this.chBook_title = new System.Windows.Forms.ColumnHeader();
            this.chBook_author = new System.Windows.Forms.ColumnHeader();
            this.chBook_description = new System.Windows.Forms.ColumnHeader();
            this.chBook_dueDate = new System.Windows.Forms.ColumnHeader();
            this.chBook_reserved = new System.Windows.Forms.ColumnHeader();
            this.chBook_checkedOut = new System.Windows.Forms.ColumnHeader();
            this.lbl_Book = new System.Windows.Forms.Label();
            this.btn_checkOut = new System.Windows.Forms.Button();
            this.btn_checkInByPatron = new System.Windows.Forms.Button();
            this.lsv_BookByPatron = new System.Windows.Forms.ListView();
            this.chBookByPatron_ID = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_PatronID = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_Type = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_Title = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_Author = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_Description = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_DueDate = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_Reserved = new System.Windows.Forms.ColumnHeader();
            this.lbl_BookByPatron = new System.Windows.Forms.Label();
            this.lbl_selectedPatron = new System.Windows.Forms.Label();
            this.lsv_Overdue = new System.Windows.Forms.ListView();
            this.chOverdue_ID = new System.Windows.Forms.ColumnHeader();
            this.chOverdue_PatronID = new System.Windows.Forms.ColumnHeader();
            this.chOverdue_Type = new System.Windows.Forms.ColumnHeader();
            this.chOverdue_Title = new System.Windows.Forms.ColumnHeader();
            this.chOverdue_Author = new System.Windows.Forms.ColumnHeader();
            this.chOverdue_Description = new System.Windows.Forms.ColumnHeader();
            this.chOverdue_DueDate = new System.Windows.Forms.ColumnHeader();
            this.chOverdue_Reserved = new System.Windows.Forms.ColumnHeader();
            this.lbl_OverdueBooks = new System.Windows.Forms.Label();
            this.btn_checkInByOverdue = new System.Windows.Forms.Button();
            this.btn_checkInByAll = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(738, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.mediaToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // patronToolStripMenuItem
            // 
            this.patronToolStripMenuItem.Name = "patronToolStripMenuItem";
            this.patronToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.patronToolStripMenuItem.Text = "Patron";
            this.patronToolStripMenuItem.Click += new System.EventHandler(this.patronToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.mediaToolStripMenuItem.Text = "Media";
            this.mediaToolStripMenuItem.Click += new System.EventHandler(this.mediaToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 687);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(950, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabel1.Text = "tsl_";
            // 
            // lbl_Patron
            // 
            this.lbl_Patron.AutoSize = true;
            this.lbl_Patron.Location = new System.Drawing.Point(-3, 38);
            this.lbl_Patron.Name = "lbl_Patron";
            this.lbl_Patron.Size = new System.Drawing.Size(38, 13);
            this.lbl_Patron.TabIndex = 4;
            this.lbl_Patron.Text = "Patron";
            // 
            // lsv_Patron
            // 
            this.lsv_Patron.AllowColumnReorder = true;
            this.lsv_Patron.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPatron_ID,
            this.chPatron_name,
            this.chPatron_phoneNumber,
            this.chPatron_address,
            this.chPatron_gender,
            this.chPatron_dob,
            this.chPatron_Type});
            this.lsv_Patron.FullRowSelect = true;
            this.lsv_Patron.GridLines = true;
            this.lsv_Patron.HideSelection = false;
            this.lsv_Patron.LabelWrap = false;
            this.lsv_Patron.Location = new System.Drawing.Point(0, 53);
            this.lsv_Patron.MultiSelect = false;
            this.lsv_Patron.Name = "lsv_Patron";
            this.lsv_Patron.ShowItemToolTips = true;
            this.lsv_Patron.Size = new System.Drawing.Size(257, 629);
            this.lsv_Patron.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_Patron.TabIndex = 5;
            this.lsv_Patron.UseCompatibleStateImageBehavior = false;
            this.lsv_Patron.View = System.Windows.Forms.View.Details;
            // 
            // chPatron_ID
            // 
            this.chPatron_ID.Text = "ID";
            this.chPatron_ID.Width = 27;
            // 
            // chPatron_name
            // 
            this.chPatron_name.Text = "Name";
            this.chPatron_name.Width = 141;
            // 
            // chPatron_phoneNumber
            // 
            this.chPatron_phoneNumber.DisplayIndex = 3;
            this.chPatron_phoneNumber.Text = "Phone Number";
            this.chPatron_phoneNumber.Width = 88;
            // 
            // chPatron_address
            // 
            this.chPatron_address.DisplayIndex = 4;
            this.chPatron_address.Text = "Address";
            this.chPatron_address.Width = 102;
            // 
            // chPatron_gender
            // 
            this.chPatron_gender.DisplayIndex = 5;
            this.chPatron_gender.Text = "Gender";
            this.chPatron_gender.Width = 47;
            // 
            // chPatron_dob
            // 
            this.chPatron_dob.DisplayIndex = 6;
            this.chPatron_dob.Text = "Date of Birth";
            this.chPatron_dob.Width = 71;
            // 
            // chPatron_Type
            // 
            this.chPatron_Type.DisplayIndex = 2;
            this.chPatron_Type.Text = "Type";
            // 
            // lsv_Book
            // 
            this.lsv_Book.AllowColumnReorder = true;
            this.lsv_Book.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBook_ID,
            this.chBook_patronID,
            this.chBook_type,
            this.chBook_title,
            this.chBook_author,
            this.chBook_description,
            this.chBook_dueDate,
            this.chBook_reserved,
            this.chBook_checkedOut});
            this.lsv_Book.FullRowSelect = true;
            this.lsv_Book.GridLines = true;
            this.lsv_Book.HideSelection = false;
            this.lsv_Book.LabelWrap = false;
            this.lsv_Book.Location = new System.Drawing.Point(263, 53);
            this.lsv_Book.MultiSelect = false;
            this.lsv_Book.Name = "lsv_Book";
            this.lsv_Book.ShowItemToolTips = true;
            this.lsv_Book.Size = new System.Drawing.Size(592, 318);
            this.lsv_Book.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_Book.TabIndex = 6;
            this.lsv_Book.UseCompatibleStateImageBehavior = false;
            this.lsv_Book.View = System.Windows.Forms.View.Details;
            // 
            // chBook_ID
            // 
            this.chBook_ID.Text = "ID";
            this.chBook_ID.Width = 26;
            // 
            // chBook_patronID
            // 
            this.chBook_patronID.Text = "Patron ID";
            this.chBook_patronID.Width = 57;
            // 
            // chBook_type
            // 
            this.chBook_type.Text = "Type";
            // 
            // chBook_title
            // 
            this.chBook_title.Text = "Title";
            this.chBook_title.Width = 141;
            // 
            // chBook_author
            // 
            this.chBook_author.Text = "Author";
            this.chBook_author.Width = 79;
            // 
            // chBook_description
            // 
            this.chBook_description.Text = "Description";
            this.chBook_description.Width = 84;
            // 
            // chBook_dueDate
            // 
            this.chBook_dueDate.DisplayIndex = 7;
            this.chBook_dueDate.Text = "Due Date";
            this.chBook_dueDate.Width = 82;
            // 
            // chBook_reserved
            // 
            this.chBook_reserved.DisplayIndex = 6;
            this.chBook_reserved.Text = "Reserved";
            this.chBook_reserved.Width = 58;
            // 
            // chBook_checkedOut
            // 
            this.chBook_checkedOut.Text = "Checked Out";
            this.chBook_checkedOut.Width = 76;
            // 
            // lbl_Book
            // 
            this.lbl_Book.AutoSize = true;
            this.lbl_Book.Location = new System.Drawing.Point(263, 38);
            this.lbl_Book.Name = "lbl_Book";
            this.lbl_Book.Size = new System.Drawing.Size(104, 13);
            this.lbl_Book.TabIndex = 7;
            this.lbl_Book.Text = "All Books and Media";
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.Location = new System.Drawing.Point(861, 53);
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(77, 23);
            this.btn_checkOut.TabIndex = 12;
            this.btn_checkOut.Text = "Check Out";
            this.btn_checkOut.UseVisualStyleBackColor = true;
            // 
            // btn_checkInByPatron
            // 
            this.btn_checkInByPatron.Location = new System.Drawing.Point(861, 391);
            this.btn_checkInByPatron.Name = "btn_checkInByPatron";
            this.btn_checkInByPatron.Size = new System.Drawing.Size(77, 23);
            this.btn_checkInByPatron.TabIndex = 13;
            this.btn_checkInByPatron.Text = "Check In";
            this.btn_checkInByPatron.UseVisualStyleBackColor = true;
            // 
            // lsv_BookByPatron
            // 
            this.lsv_BookByPatron.AllowColumnReorder = true;
            this.lsv_BookByPatron.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBookByPatron_ID,
            this.chBookByPatron_PatronID,
            this.chBookByPatron_Type,
            this.chBookByPatron_Title,
            this.chBookByPatron_Author,
            this.chBookByPatron_Description,
            this.chBookByPatron_DueDate,
            this.chBookByPatron_Reserved});
            this.lsv_BookByPatron.FullRowSelect = true;
            this.lsv_BookByPatron.GridLines = true;
            this.lsv_BookByPatron.HideSelection = false;
            this.lsv_BookByPatron.LabelWrap = false;
            this.lsv_BookByPatron.Location = new System.Drawing.Point(263, 391);
            this.lsv_BookByPatron.MultiSelect = false;
            this.lsv_BookByPatron.Name = "lsv_BookByPatron";
            this.lsv_BookByPatron.ShowItemToolTips = true;
            this.lsv_BookByPatron.Size = new System.Drawing.Size(592, 131);
            this.lsv_BookByPatron.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_BookByPatron.TabIndex = 14;
            this.lsv_BookByPatron.UseCompatibleStateImageBehavior = false;
            this.lsv_BookByPatron.View = System.Windows.Forms.View.Details;
            // 
            // chBookByPatron_ID
            // 
            this.chBookByPatron_ID.Text = "ID";
            this.chBookByPatron_ID.Width = 26;
            // 
            // chBookByPatron_PatronID
            // 
            this.chBookByPatron_PatronID.Text = "Patron ID";
            this.chBookByPatron_PatronID.Width = 57;
            // 
            // chBookByPatron_Type
            // 
            this.chBookByPatron_Type.Text = "Type";
            // 
            // chBookByPatron_Title
            // 
            this.chBookByPatron_Title.Text = "Title";
            this.chBookByPatron_Title.Width = 141;
            // 
            // chBookByPatron_Author
            // 
            this.chBookByPatron_Author.Text = "Author";
            this.chBookByPatron_Author.Width = 79;
            // 
            // chBookByPatron_Description
            // 
            this.chBookByPatron_Description.Text = "Description";
            this.chBookByPatron_Description.Width = 84;
            // 
            // chBookByPatron_DueDate
            // 
            this.chBookByPatron_DueDate.DisplayIndex = 7;
            this.chBookByPatron_DueDate.Text = "Due Date";
            this.chBookByPatron_DueDate.Width = 80;
            // 
            // chBookByPatron_Reserved
            // 
            this.chBookByPatron_Reserved.DisplayIndex = 6;
            this.chBookByPatron_Reserved.Text = "Reserved";
            // 
            // lbl_BookByPatron
            // 
            this.lbl_BookByPatron.AutoSize = true;
            this.lbl_BookByPatron.Location = new System.Drawing.Point(260, 375);
            this.lbl_BookByPatron.Name = "lbl_BookByPatron";
            this.lbl_BookByPatron.Size = new System.Drawing.Size(207, 13);
            this.lbl_BookByPatron.TabIndex = 15;
            this.lbl_BookByPatron.Text = "Books and Media Checked Out by Patron:";
            // 
            // lbl_selectedPatron
            // 
            this.lbl_selectedPatron.AutoSize = true;
            this.lbl_selectedPatron.Location = new System.Drawing.Point(462, 375);
            this.lbl_selectedPatron.Name = "lbl_selectedPatron";
            this.lbl_selectedPatron.Size = new System.Drawing.Size(115, 13);
            this.lbl_selectedPatron.TabIndex = 16;
            this.lbl_selectedPatron.Text = "(Selected Patron Here)";
            // 
            // lsv_Overdue
            // 
            this.lsv_Overdue.AllowColumnReorder = true;
            this.lsv_Overdue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOverdue_ID,
            this.chOverdue_PatronID,
            this.chOverdue_Type,
            this.chOverdue_Title,
            this.chOverdue_Author,
            this.chOverdue_Description,
            this.chOverdue_DueDate,
            this.chOverdue_Reserved});
            this.lsv_Overdue.FullRowSelect = true;
            this.lsv_Overdue.GridLines = true;
            this.lsv_Overdue.HideSelection = false;
            this.lsv_Overdue.LabelWrap = false;
            this.lsv_Overdue.Location = new System.Drawing.Point(263, 541);
            this.lsv_Overdue.MultiSelect = false;
            this.lsv_Overdue.Name = "lsv_Overdue";
            this.lsv_Overdue.ShowItemToolTips = true;
            this.lsv_Overdue.Size = new System.Drawing.Size(592, 141);
            this.lsv_Overdue.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_Overdue.TabIndex = 17;
            this.lsv_Overdue.UseCompatibleStateImageBehavior = false;
            this.lsv_Overdue.View = System.Windows.Forms.View.Details;
            // 
            // chOverdue_ID
            // 
            this.chOverdue_ID.Text = "ID";
            this.chOverdue_ID.Width = 26;
            // 
            // chOverdue_PatronID
            // 
            this.chOverdue_PatronID.Text = "Patron ID";
            this.chOverdue_PatronID.Width = 57;
            // 
            // chOverdue_Type
            // 
            this.chOverdue_Type.Text = "Type";
            // 
            // chOverdue_Title
            // 
            this.chOverdue_Title.Text = "Title";
            this.chOverdue_Title.Width = 141;
            // 
            // chOverdue_Author
            // 
            this.chOverdue_Author.Text = "Author";
            this.chOverdue_Author.Width = 79;
            // 
            // chOverdue_Description
            // 
            this.chOverdue_Description.Text = "Description";
            this.chOverdue_Description.Width = 84;
            // 
            // chOverdue_DueDate
            // 
            this.chOverdue_DueDate.DisplayIndex = 7;
            this.chOverdue_DueDate.Text = "Due Date";
            this.chOverdue_DueDate.Width = 80;
            // 
            // chOverdue_Reserved
            // 
            this.chOverdue_Reserved.DisplayIndex = 6;
            this.chOverdue_Reserved.Text = "Reserved";
            // 
            // lbl_OverdueBooks
            // 
            this.lbl_OverdueBooks.AutoSize = true;
            this.lbl_OverdueBooks.Location = new System.Drawing.Point(260, 525);
            this.lbl_OverdueBooks.Name = "lbl_OverdueBooks";
            this.lbl_OverdueBooks.Size = new System.Drawing.Size(134, 13);
            this.lbl_OverdueBooks.TabIndex = 18;
            this.lbl_OverdueBooks.Text = "Overdue Books and Media";
            // 
            // btn_checkInByOverdue
            // 
            this.btn_checkInByOverdue.Location = new System.Drawing.Point(861, 541);
            this.btn_checkInByOverdue.Name = "btn_checkInByOverdue";
            this.btn_checkInByOverdue.Size = new System.Drawing.Size(77, 23);
            this.btn_checkInByOverdue.TabIndex = 20;
            this.btn_checkInByOverdue.Text = "Check In";
            this.btn_checkInByOverdue.UseVisualStyleBackColor = true;
            // 
            // btn_checkInByAll
            // 
            this.btn_checkInByAll.Location = new System.Drawing.Point(861, 82);
            this.btn_checkInByAll.Name = "btn_checkInByAll";
            this.btn_checkInByAll.Size = new System.Drawing.Size(77, 23);
            this.btn_checkInByAll.TabIndex = 21;
            this.btn_checkInByAll.Text = "Check In";
            this.btn_checkInByAll.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 709);
            this.Controls.Add(this.btn_checkInByAll);
            this.Controls.Add(this.btn_checkInByOverdue);
            this.Controls.Add(this.lbl_OverdueBooks);
            this.Controls.Add(this.lsv_Overdue);
            this.Controls.Add(this.lbl_selectedPatron);
            this.Controls.Add(this.lbl_BookByPatron);
            this.Controls.Add(this.lsv_BookByPatron);
            this.Controls.Add(this.btn_checkInByPatron);
            this.Controls.Add(this.btn_checkOut);
            this.Controls.Add(this.lbl_Book);
            this.Controls.Add(this.lsv_Book);
            this.Controls.Add(this.lsv_Patron);
            this.Controls.Add(this.lbl_Patron);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Library Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbl_Patron;
        private System.Windows.Forms.ListView lsv_Patron;
        private System.Windows.Forms.ColumnHeader chPatron_ID;
        private System.Windows.Forms.ColumnHeader chPatron_name;
        private System.Windows.Forms.ColumnHeader chPatron_phoneNumber;
        private System.Windows.Forms.ColumnHeader chPatron_address;
        private System.Windows.Forms.ColumnHeader chPatron_gender;
        private System.Windows.Forms.ColumnHeader chPatron_dob;
        private System.Windows.Forms.ListView lsv_Book;
        private System.Windows.Forms.ColumnHeader chBook_ID;
        private System.Windows.Forms.ColumnHeader chBook_title;
        private System.Windows.Forms.ColumnHeader chBook_patronID;
        private System.Windows.Forms.ColumnHeader chBook_type;
        private System.Windows.Forms.ColumnHeader chBook_author;
        private System.Windows.Forms.ColumnHeader chBook_description;
        private System.Windows.Forms.Label lbl_Book;
        private System.Windows.Forms.ColumnHeader chBook_checkedOut;
        private System.Windows.Forms.ColumnHeader chBook_reserved;
        private System.Windows.Forms.ColumnHeader chPatron_Type;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.Button btn_checkOut;
        private System.Windows.Forms.Button btn_checkInByPatron;
        private System.Windows.Forms.ColumnHeader chBook_dueDate;
        private System.Windows.Forms.ListView lsv_BookByPatron;
        private System.Windows.Forms.ColumnHeader chBookByPatron_ID;
        private System.Windows.Forms.ColumnHeader chBookByPatron_PatronID;
        private System.Windows.Forms.ColumnHeader chBookByPatron_Type;
        private System.Windows.Forms.ColumnHeader chBookByPatron_Title;
        private System.Windows.Forms.ColumnHeader chBookByPatron_Author;
        private System.Windows.Forms.ColumnHeader chBookByPatron_Description;
        private System.Windows.Forms.ColumnHeader chBookByPatron_DueDate;
        private System.Windows.Forms.ColumnHeader chBookByPatron_Reserved;
        private System.Windows.Forms.Label lbl_BookByPatron;
        private System.Windows.Forms.Label lbl_selectedPatron;
        private System.Windows.Forms.ListView lsv_Overdue;
        private System.Windows.Forms.ColumnHeader chOverdue_ID;
        private System.Windows.Forms.ColumnHeader chOverdue_PatronID;
        private System.Windows.Forms.ColumnHeader chOverdue_Type;
        private System.Windows.Forms.ColumnHeader chOverdue_Title;
        private System.Windows.Forms.ColumnHeader chOverdue_Author;
        private System.Windows.Forms.ColumnHeader chOverdue_Description;
        private System.Windows.Forms.ColumnHeader chOverdue_DueDate;
        private System.Windows.Forms.ColumnHeader chOverdue_Reserved;
        private System.Windows.Forms.Label lbl_OverdueBooks;
        private System.Windows.Forms.Button btn_checkInByOverdue;
        private System.Windows.Forms.Button btn_checkInByAll;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

