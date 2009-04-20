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
            this.components = new System.ComponentModel.Container();
            this.dtp_DateSelector = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lsv_AllBooksMedia = new System.Windows.Forms.ListView();
            this.chBook_patronID = new System.Windows.Forms.ColumnHeader();
            this.chBook_type = new System.Windows.Forms.ColumnHeader();
            this.chBook_title = new System.Windows.Forms.ColumnHeader();
            this.chBook_author = new System.Windows.Forms.ColumnHeader();
            this.chBook_description = new System.Windows.Forms.ColumnHeader();
            this.chBook_dueDate = new System.Windows.Forms.ColumnHeader();
            this.chBook_checkedOut = new System.Windows.Forms.ColumnHeader();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.lsv_CheckedOutByPatron = new System.Windows.Forms.ListView();
            this.chBookByPatron_PatronID = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_Type = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_Title = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_Author = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_Description = new System.Windows.Forms.ColumnHeader();
            this.chBookByPatron_DueDate = new System.Windows.Forms.ColumnHeader();
            this.btn_checkInOut = new System.Windows.Forms.Button();
            this.gb_Patrons = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.lsv_Patron = new System.Windows.Forms.ListView();
            this.chPatron_name = new System.Windows.Forms.ColumnHeader();
            this.chPatron_age = new System.Windows.Forms.ColumnHeader();
            this.cms_Patron = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPatronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_filteringfields = new System.Windows.Forms.GroupBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_TargetAudience = new System.Windows.Forms.Label();
            this.cb_TargetAudience = new System.Windows.Forms.ComboBox();
            this.cb_FilterMedia = new System.Windows.Forms.CheckBox();
            this.cb_FilterBooks = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gb_PatronCheckedOut = new System.Windows.Forms.GroupBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gb_Patrons.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cms_Patron.SuspendLayout();
            this.gb_filteringfields.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gb_PatronCheckedOut.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_DateSelector
            // 
            this.dtp_DateSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DateSelector.Location = new System.Drawing.Point(543, 14);
            this.dtp_DateSelector.Name = "dtp_DateSelector";
            this.dtp_DateSelector.Size = new System.Drawing.Size(200, 20);
            this.dtp_DateSelector.TabIndex = 0;
            this.dtp_DateSelector.ValueChanged += new System.EventHandler(this.dtp_DateSelector_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
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
            this.configToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_about});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tsmi_about
            // 
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(107, 22);
            this.tsmi_about.Text = "&About";
            this.tsmi_about.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 730);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabel1.Text = "tsl_";
            // 
            // lsv_AllBooksMedia
            // 
            this.lsv_AllBooksMedia.AllowColumnReorder = true;
            this.lsv_AllBooksMedia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBook_patronID,
            this.chBook_type,
            this.chBook_title,
            this.chBook_author,
            this.chBook_description,
            this.chBook_dueDate,
            this.chBook_checkedOut});
            this.lsv_AllBooksMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_AllBooksMedia.FullRowSelect = true;
            this.lsv_AllBooksMedia.GridLines = true;
            this.lsv_AllBooksMedia.HideSelection = false;
            this.lsv_AllBooksMedia.LabelWrap = false;
            this.lsv_AllBooksMedia.Location = new System.Drawing.Point(0, 0);
            this.lsv_AllBooksMedia.MultiSelect = false;
            this.lsv_AllBooksMedia.Name = "lsv_AllBooksMedia";
            this.lsv_AllBooksMedia.ShowItemToolTips = true;
            this.lsv_AllBooksMedia.Size = new System.Drawing.Size(746, 264);
            this.lsv_AllBooksMedia.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_AllBooksMedia.TabIndex = 6;
            this.lsv_AllBooksMedia.UseCompatibleStateImageBehavior = false;
            this.lsv_AllBooksMedia.View = System.Windows.Forms.View.Details;
            // 
            // chBook_patronID
            // 
            this.chBook_patronID.Text = "Patron";
            this.chBook_patronID.Width = 76;
            // 
            // chBook_type
            // 
            this.chBook_type.Text = "Type";
            // 
            // chBook_title
            // 
            this.chBook_title.Text = "Title";
            this.chBook_title.Width = 154;
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
            this.chBook_dueDate.Text = "Due Date";
            this.chBook_dueDate.Width = 82;
            // 
            // chBook_checkedOut
            // 
            this.chBook_checkedOut.Text = "Checked Out";
            this.chBook_checkedOut.Width = 76;
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CheckIn.Location = new System.Drawing.Point(663, 3);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(77, 23);
            this.btn_CheckIn.TabIndex = 13;
            this.btn_CheckIn.Text = "Check In";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // lsv_CheckedOutByPatron
            // 
            this.lsv_CheckedOutByPatron.AllowColumnReorder = true;
            this.lsv_CheckedOutByPatron.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBookByPatron_PatronID,
            this.chBookByPatron_Type,
            this.chBookByPatron_Title,
            this.chBookByPatron_Author,
            this.chBookByPatron_Description,
            this.chBookByPatron_DueDate});
            this.lsv_CheckedOutByPatron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_CheckedOutByPatron.FullRowSelect = true;
            this.lsv_CheckedOutByPatron.GridLines = true;
            this.lsv_CheckedOutByPatron.HideSelection = false;
            this.lsv_CheckedOutByPatron.LabelWrap = false;
            this.lsv_CheckedOutByPatron.Location = new System.Drawing.Point(3, 16);
            this.lsv_CheckedOutByPatron.MultiSelect = false;
            this.lsv_CheckedOutByPatron.Name = "lsv_CheckedOutByPatron";
            this.lsv_CheckedOutByPatron.ShowItemToolTips = true;
            this.lsv_CheckedOutByPatron.Size = new System.Drawing.Size(740, 308);
            this.lsv_CheckedOutByPatron.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_CheckedOutByPatron.TabIndex = 14;
            this.lsv_CheckedOutByPatron.UseCompatibleStateImageBehavior = false;
            this.lsv_CheckedOutByPatron.View = System.Windows.Forms.View.Details;
            // 
            // chBookByPatron_PatronID
            // 
            this.chBookByPatron_PatronID.Text = "Patron";
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
            this.chBookByPatron_DueDate.Text = "Due Date";
            this.chBookByPatron_DueDate.Width = 80;
            // 
            // btn_checkInOut
            // 
            this.btn_checkInOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_checkInOut.Location = new System.Drawing.Point(663, 38);
            this.btn_checkInOut.Name = "btn_checkInOut";
            this.btn_checkInOut.Size = new System.Drawing.Size(77, 23);
            this.btn_checkInOut.TabIndex = 21;
            this.btn_checkInOut.Text = "Check Out";
            this.btn_checkInOut.UseVisualStyleBackColor = true;
            this.btn_checkInOut.Click += new System.EventHandler(this.btn_checkInOut_Click);
            // 
            // gb_Patrons
            // 
            this.gb_Patrons.Controls.Add(this.splitContainer1);
            this.gb_Patrons.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_Patrons.Location = new System.Drawing.Point(0, 24);
            this.gb_Patrons.Name = "gb_Patrons";
            this.gb_Patrons.Size = new System.Drawing.Size(254, 706);
            this.gb_Patrons.TabIndex = 22;
            this.gb_Patrons.TabStop = false;
            this.gb_Patrons.Text = "Patrons";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_LastName);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_LastName);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_FirstName);
            this.splitContainer1.Panel1.Controls.Add(this.tb_FirstName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsv_Patron);
            this.splitContainer1.Size = new System.Drawing.Size(248, 687);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.TabIndex = 6;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(115, 22);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(100, 20);
            this.tb_LastName.TabIndex = 13;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(112, 6);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 12;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(6, 6);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 11;
            this.lbl_FirstName.Text = "First Name";
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(9, 22);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(100, 20);
            this.tb_FirstName.TabIndex = 10;
            // 
            // lsv_Patron
            // 
            this.lsv_Patron.AllowColumnReorder = true;
            this.lsv_Patron.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPatron_name,
            this.chPatron_age});
            this.lsv_Patron.ContextMenuStrip = this.cms_Patron;
            this.lsv_Patron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_Patron.FullRowSelect = true;
            this.lsv_Patron.GridLines = true;
            this.lsv_Patron.HideSelection = false;
            this.lsv_Patron.LabelWrap = false;
            this.lsv_Patron.Location = new System.Drawing.Point(0, 0);
            this.lsv_Patron.MultiSelect = false;
            this.lsv_Patron.Name = "lsv_Patron";
            this.lsv_Patron.ShowItemToolTips = true;
            this.lsv_Patron.Size = new System.Drawing.Size(248, 631);
            this.lsv_Patron.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_Patron.TabIndex = 6;
            this.lsv_Patron.UseCompatibleStateImageBehavior = false;
            this.lsv_Patron.View = System.Windows.Forms.View.Details;
            this.lsv_Patron.SelectedIndexChanged += new System.EventHandler(this.lsv_Patron_SelectedIndexChanged);
            // 
            // chPatron_name
            // 
            this.chPatron_name.Text = "Name";
            this.chPatron_name.Width = 178;
            // 
            // chPatron_age
            // 
            this.chPatron_age.Text = "Age";
            this.chPatron_age.Width = 71;
            // 
            // cms_Patron
            // 
            this.cms_Patron.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPatronToolStripMenuItem,
            this.viewDetailsToolStripMenuItem,
            this.deletePatronToolStripMenuItem});
            this.cms_Patron.Name = "cms_Patron";
            this.cms_Patron.Size = new System.Drawing.Size(146, 70);
            // 
            // editPatronToolStripMenuItem
            // 
            this.editPatronToolStripMenuItem.Name = "editPatronToolStripMenuItem";
            this.editPatronToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editPatronToolStripMenuItem.Text = "Edit Patron";
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            // 
            // deletePatronToolStripMenuItem
            // 
            this.deletePatronToolStripMenuItem.Name = "deletePatronToolStripMenuItem";
            this.deletePatronToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deletePatronToolStripMenuItem.Text = "Delete Patron";
            // 
            // gb_filteringfields
            // 
            this.gb_filteringfields.Controls.Add(this.btn_filter);
            this.gb_filteringfields.Controls.Add(this.lbl_Type);
            this.gb_filteringfields.Controls.Add(this.lbl_TargetAudience);
            this.gb_filteringfields.Controls.Add(this.btn_checkInOut);
            this.gb_filteringfields.Controls.Add(this.cb_TargetAudience);
            this.gb_filteringfields.Controls.Add(this.cb_FilterMedia);
            this.gb_filteringfields.Controls.Add(this.cb_FilterBooks);
            this.gb_filteringfields.Controls.Add(this.dtp_DateSelector);
            this.gb_filteringfields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_filteringfields.Location = new System.Drawing.Point(0, 0);
            this.gb_filteringfields.Name = "gb_filteringfields";
            this.gb_filteringfields.Size = new System.Drawing.Size(746, 68);
            this.gb_filteringfields.TabIndex = 23;
            this.gb_filteringfields.TabStop = false;
            this.gb_filteringfields.Text = "Filtering Fields";
            // 
            // btn_filter
            // 
            this.btn_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filter.Location = new System.Drawing.Point(582, 39);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 22;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(144, 21);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(31, 13);
            this.lbl_Type.TabIndex = 7;
            this.lbl_Type.Text = "Type";
            // 
            // lbl_TargetAudience
            // 
            this.lbl_TargetAudience.AutoSize = true;
            this.lbl_TargetAudience.Location = new System.Drawing.Point(6, 21);
            this.lbl_TargetAudience.Name = "lbl_TargetAudience";
            this.lbl_TargetAudience.Size = new System.Drawing.Size(86, 13);
            this.lbl_TargetAudience.TabIndex = 6;
            this.lbl_TargetAudience.Text = "Target Audience";
            // 
            // cb_TargetAudience
            // 
            this.cb_TargetAudience.FormattingEnabled = true;
            this.cb_TargetAudience.Location = new System.Drawing.Point(9, 37);
            this.cb_TargetAudience.Name = "cb_TargetAudience";
            this.cb_TargetAudience.Size = new System.Drawing.Size(121, 21);
            this.cb_TargetAudience.TabIndex = 5;
            // 
            // cb_FilterMedia
            // 
            this.cb_FilterMedia.AutoSize = true;
            this.cb_FilterMedia.Location = new System.Drawing.Point(209, 37);
            this.cb_FilterMedia.Name = "cb_FilterMedia";
            this.cb_FilterMedia.Size = new System.Drawing.Size(55, 17);
            this.cb_FilterMedia.TabIndex = 4;
            this.cb_FilterMedia.Text = "Media";
            this.cb_FilterMedia.UseVisualStyleBackColor = true;
            // 
            // cb_FilterBooks
            // 
            this.cb_FilterBooks.AutoSize = true;
            this.cb_FilterBooks.Location = new System.Drawing.Point(147, 37);
            this.cb_FilterBooks.Name = "cb_FilterBooks";
            this.cb_FilterBooks.Size = new System.Drawing.Size(56, 17);
            this.cb_FilterBooks.TabIndex = 3;
            this.cb_FilterBooks.Text = "Books";
            this.cb_FilterBooks.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gb_filteringfields);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lsv_AllBooksMedia);
            this.splitContainer2.Size = new System.Drawing.Size(746, 336);
            this.splitContainer2.SplitterDistance = 68;
            this.splitContainer2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 366);
            this.panel1.TabIndex = 25;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gb_PatronCheckedOut);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btn_CheckIn);
            this.splitContainer3.Size = new System.Drawing.Size(746, 366);
            this.splitContainer3.SplitterDistance = 327;
            this.splitContainer3.TabIndex = 0;
            // 
            // gb_PatronCheckedOut
            // 
            this.gb_PatronCheckedOut.Controls.Add(this.lsv_CheckedOutByPatron);
            this.gb_PatronCheckedOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_PatronCheckedOut.Location = new System.Drawing.Point(0, 0);
            this.gb_PatronCheckedOut.Name = "gb_PatronCheckedOut";
            this.gb_PatronCheckedOut.Size = new System.Drawing.Size(746, 327);
            this.gb_PatronCheckedOut.TabIndex = 0;
            this.gb_PatronCheckedOut.TabStop = false;
            this.gb_PatronCheckedOut.Text = "Books and Media Checked Out by ";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(254, 24);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.panel1);
            this.splitContainer4.Size = new System.Drawing.Size(746, 706);
            this.splitContainer4.SplitterDistance = 336;
            this.splitContainer4.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 752);
            this.Controls.Add(this.splitContainer4);
            this.Controls.Add(this.gb_Patrons);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Library Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gb_Patrons.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.cms_Patron.ResumeLayout(false);
            this.gb_filteringfields.ResumeLayout(false);
            this.gb_filteringfields.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.gb_PatronCheckedOut.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_DateSelector;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView lsv_AllBooksMedia;
        private System.Windows.Forms.ColumnHeader chBook_title;
        private System.Windows.Forms.ColumnHeader chBook_patronID;
        private System.Windows.Forms.ColumnHeader chBook_type;
        private System.Windows.Forms.ColumnHeader chBook_author;
        private System.Windows.Forms.ColumnHeader chBook_description;
        private System.Windows.Forms.ColumnHeader chBook_checkedOut;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.ColumnHeader chBook_dueDate;
        private System.Windows.Forms.ListView lsv_CheckedOutByPatron;
        private System.Windows.Forms.ColumnHeader chBookByPatron_PatronID;
        private System.Windows.Forms.ColumnHeader chBookByPatron_Type;
        private System.Windows.Forms.ColumnHeader chBookByPatron_Title;
        private System.Windows.Forms.ColumnHeader chBookByPatron_Author;
        private System.Windows.Forms.ColumnHeader chBookByPatron_Description;
        private System.Windows.Forms.ColumnHeader chBookByPatron_DueDate;
        private System.Windows.Forms.Button btn_checkInOut;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gb_Patrons;
        private System.Windows.Forms.GroupBox gb_filteringfields;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.ListView lsv_Patron;
        private System.Windows.Forms.ColumnHeader chPatron_name;
        private System.Windows.Forms.ColumnHeader chPatron_age;
        private System.Windows.Forms.CheckBox cb_FilterMedia;
        private System.Windows.Forms.CheckBox cb_FilterBooks;
        private System.Windows.Forms.Label lbl_TargetAudience;
        private System.Windows.Forms.ComboBox cb_TargetAudience;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gb_PatronCheckedOut;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ContextMenuStrip cms_Patron;
        private System.Windows.Forms.ToolStripMenuItem editPatronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatronToolStripMenuItem;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
    }
}

