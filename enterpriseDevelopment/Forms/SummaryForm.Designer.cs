namespace enterpriseDevelopment.Forms
{
    partial class SummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.subLbl1 = new System.Windows.Forms.Label();
            this.subLbl2 = new System.Windows.Forms.Label();
            this.subLvl3 = new System.Windows.Forms.Label();
            this.showByComboBox = new System.Windows.Forms.ComboBox();
            this.listViewSummary = new MaterialSkin.Controls.MaterialListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.contactIcon = new System.Windows.Forms.PictureBox();
            this.summaryIcon = new System.Windows.Forms.PictureBox();
            this.transactionIcon = new System.Windows.Forms.PictureBox();
            this.eventIcon = new System.Windows.Forms.PictureBox();
            this.predictionIcon = new System.Windows.Forms.PictureBox();
            this.mainIcon = new System.Windows.Forms.PictureBox();
            this.eventBoxPanel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.contactBoxPanel = new System.Windows.Forms.Panel();
            this.summaryBoxPanel = new System.Windows.Forms.Panel();
            this.transactionBoxPanel = new System.Windows.Forms.Panel();
            this.predictionBoxPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mainBoxPanel = new System.Windows.Forms.Panel();
            this.mainBtn = new System.Windows.Forms.Button();
            this.predictBtn = new System.Windows.Forms.Button();
            this.eventsBtn = new System.Windows.Forms.Button();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.summaryBtn0 = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.closePanel = new System.Windows.Forms.Panel();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.transactionToogle = new System.Windows.Forms.Panel();
            this.eventsRepeatBtn = new System.Windows.Forms.Button();
            this.recurringToggleBtn = new System.Windows.Forms.Button();
            this.eventToogle = new System.Windows.Forms.Panel();
            this.repeatBtn = new System.Windows.Forms.Button();
            this.allEventBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).BeginInit();
            this.eventBoxPanel.SuspendLayout();
            this.predictionBoxPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.transactionToogle.SuspendLayout();
            this.eventToogle.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(429, 441);
            this.startDate.Margin = new System.Windows.Forms.Padding(2);
            this.startDate.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.startDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(102, 20);
            this.startDate.TabIndex = 3;
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(605, 441);
            this.endDate.Margin = new System.Windows.Forms.Padding(2);
            this.endDate.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.endDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(102, 20);
            this.endDate.TabIndex = 4;
            // 
            // subLbl1
            // 
            this.subLbl1.AutoSize = true;
            this.subLbl1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.subLbl1.Location = new System.Drawing.Point(424, 407);
            this.subLbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subLbl1.Name = "subLbl1";
            this.subLbl1.Size = new System.Drawing.Size(111, 29);
            this.subLbl1.TabIndex = 5;
            this.subLbl1.Text = "Start date";
            // 
            // subLbl2
            // 
            this.subLbl2.AutoSize = true;
            this.subLbl2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.subLbl2.Location = new System.Drawing.Point(606, 407);
            this.subLbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subLbl2.Name = "subLbl2";
            this.subLbl2.Size = new System.Drawing.Size(101, 29);
            this.subLbl2.TabIndex = 6;
            this.subLbl2.Text = "End date";
            // 
            // subLvl3
            // 
            this.subLvl3.AutoSize = true;
            this.subLvl3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.subLvl3.Location = new System.Drawing.Point(794, 407);
            this.subLvl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subLvl3.Name = "subLvl3";
            this.subLvl3.Size = new System.Drawing.Size(97, 29);
            this.subLvl3.TabIndex = 9;
            this.subLvl3.Text = "Show by";
            // 
            // showByComboBox
            // 
            this.showByComboBox.FormattingEnabled = true;
            this.showByComboBox.Items.AddRange(new object[] {
            "Transactions",
            "Days",
            "Months",
            "Years"});
            this.showByComboBox.Location = new System.Drawing.Point(799, 440);
            this.showByComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.showByComboBox.Name = "showByComboBox";
            this.showByComboBox.Size = new System.Drawing.Size(92, 21);
            this.showByComboBox.TabIndex = 10;
            this.showByComboBox.Text = "Transactions";
            // 
            // listViewSummary
            // 
            this.listViewSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSummary.Depth = 0;
            this.listViewSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewSummary.FullRowSelect = true;
            this.listViewSummary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSummary.HideSelection = false;
            this.listViewSummary.Location = new System.Drawing.Point(309, 86);
            this.listViewSummary.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewSummary.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewSummary.Name = "listViewSummary";
            this.listViewSummary.OwnerDraw = true;
            this.listViewSummary.Size = new System.Drawing.Size(680, 267);
            this.listViewSummary.TabIndex = 12;
            this.listViewSummary.UseCompatibleStateImageBehavior = false;
            this.listViewSummary.View = System.Windows.Forms.View.Details;
            this.listViewSummary.SizeChanged += new System.EventHandler(this.listViewSummary_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.contactIcon);
            this.panel1.Controls.Add(this.summaryIcon);
            this.panel1.Controls.Add(this.transactionIcon);
            this.panel1.Controls.Add(this.eventIcon);
            this.panel1.Controls.Add(this.predictionIcon);
            this.panel1.Controls.Add(this.mainIcon);
            this.panel1.Controls.Add(this.eventBoxPanel);
            this.panel1.Controls.Add(this.contactBoxPanel);
            this.panel1.Controls.Add(this.summaryBoxPanel);
            this.panel1.Controls.Add(this.transactionBoxPanel);
            this.panel1.Controls.Add(this.predictionBoxPanel);
            this.panel1.Controls.Add(this.mainBoxPanel);
            this.panel1.Controls.Add(this.mainBtn);
            this.panel1.Controls.Add(this.predictBtn);
            this.panel1.Controls.Add(this.eventsBtn);
            this.panel1.Controls.Add(this.transactionBtn);
            this.panel1.Controls.Add(this.summaryBtn0);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 597);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 5);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-14, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(266, 102);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // contactIcon
            // 
            this.contactIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactIcon.BackgroundImage")));
            this.contactIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contactIcon.Location = new System.Drawing.Point(226, 549);
            this.contactIcon.Name = "contactIcon";
            this.contactIcon.Size = new System.Drawing.Size(26, 25);
            this.contactIcon.TabIndex = 24;
            this.contactIcon.TabStop = false;
            this.contactIcon.MouseEnter += new System.EventHandler(this.contactBtn_MouseEnter);
            this.contactIcon.MouseLeave += new System.EventHandler(this.contactBtn_MouseLeave);
            // 
            // summaryIcon
            // 
            this.summaryIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("summaryIcon.BackgroundImage")));
            this.summaryIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.summaryIcon.Location = new System.Drawing.Point(215, 462);
            this.summaryIcon.Name = "summaryIcon";
            this.summaryIcon.Size = new System.Drawing.Size(37, 37);
            this.summaryIcon.TabIndex = 23;
            this.summaryIcon.TabStop = false;
            this.summaryIcon.MouseEnter += new System.EventHandler(this.summaryBtn_MouseEnter);
            this.summaryIcon.MouseLeave += new System.EventHandler(this.summaryBtn_MouseLeave);
            // 
            // transactionIcon
            // 
            this.transactionIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transactionIcon.BackgroundImage")));
            this.transactionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transactionIcon.Location = new System.Drawing.Point(215, 382);
            this.transactionIcon.Name = "transactionIcon";
            this.transactionIcon.Size = new System.Drawing.Size(37, 25);
            this.transactionIcon.TabIndex = 22;
            this.transactionIcon.TabStop = false;
            this.transactionIcon.MouseEnter += new System.EventHandler(this.transactionBtn_MouseEnter);
            this.transactionIcon.MouseLeave += new System.EventHandler(this.transactionBtn_MouseLeave);
            // 
            // eventIcon
            // 
            this.eventIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eventIcon.BackgroundImage")));
            this.eventIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eventIcon.Location = new System.Drawing.Point(215, 299);
            this.eventIcon.Name = "eventIcon";
            this.eventIcon.Size = new System.Drawing.Size(37, 35);
            this.eventIcon.TabIndex = 21;
            this.eventIcon.TabStop = false;
            this.eventIcon.MouseEnter += new System.EventHandler(this.eventsBtn_MouseEnter);
            this.eventIcon.MouseLeave += new System.EventHandler(this.eventsBtn_MouseLeave);
            // 
            // predictionIcon
            // 
            this.predictionIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("predictionIcon.BackgroundImage")));
            this.predictionIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.predictionIcon.Location = new System.Drawing.Point(215, 219);
            this.predictionIcon.Name = "predictionIcon";
            this.predictionIcon.Size = new System.Drawing.Size(25, 30);
            this.predictionIcon.TabIndex = 20;
            this.predictionIcon.TabStop = false;
            this.predictionIcon.MouseEnter += new System.EventHandler(this.predictBtn_MouseEnter);
            this.predictionIcon.MouseLeave += new System.EventHandler(this.predictBtn_MouseLeave);
            // 
            // mainIcon
            // 
            this.mainIcon.BackColor = System.Drawing.Color.Transparent;
            this.mainIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainIcon.BackgroundImage")));
            this.mainIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainIcon.Location = new System.Drawing.Point(215, 143);
            this.mainIcon.Name = "mainIcon";
            this.mainIcon.Size = new System.Drawing.Size(25, 25);
            this.mainIcon.TabIndex = 19;
            this.mainIcon.TabStop = false;
            this.mainIcon.MouseEnter += new System.EventHandler(this.mainBtn_MouseEnter);
            this.mainIcon.MouseLeave += new System.EventHandler(this.mainBtn_MouseLeave);
            // 
            // eventBoxPanel
            // 
            this.eventBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eventBoxPanel.Controls.Add(this.panel12);
            this.eventBoxPanel.Controls.Add(this.panel13);
            this.eventBoxPanel.Location = new System.Drawing.Point(185, 272);
            this.eventBoxPanel.Name = "eventBoxPanel";
            this.eventBoxPanel.Size = new System.Drawing.Size(99, 82);
            this.eventBoxPanel.TabIndex = 18;
            this.eventBoxPanel.Visible = false;
            this.eventBoxPanel.MouseEnter += new System.EventHandler(this.eventsBtn_MouseEnter);
            this.eventBoxPanel.MouseLeave += new System.EventHandler(this.eventsBtn_MouseLeave);
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(0, 82);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(12, 82);
            this.panel12.TabIndex = 17;
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(0, 82);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(12, 82);
            this.panel13.TabIndex = 14;
            // 
            // contactBoxPanel
            // 
            this.contactBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactBoxPanel.Location = new System.Drawing.Point(185, 518);
            this.contactBoxPanel.Name = "contactBoxPanel";
            this.contactBoxPanel.Size = new System.Drawing.Size(99, 82);
            this.contactBoxPanel.TabIndex = 17;
            this.contactBoxPanel.Visible = false;
            this.contactBoxPanel.MouseEnter += new System.EventHandler(this.contactBtn_MouseEnter);
            this.contactBoxPanel.MouseLeave += new System.EventHandler(this.contactBtn_MouseLeave);
            // 
            // summaryBoxPanel
            // 
            this.summaryBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.summaryBoxPanel.Location = new System.Drawing.Point(185, 436);
            this.summaryBoxPanel.Name = "summaryBoxPanel";
            this.summaryBoxPanel.Size = new System.Drawing.Size(99, 82);
            this.summaryBoxPanel.TabIndex = 16;
            this.summaryBoxPanel.Visible = false;
            this.summaryBoxPanel.MouseEnter += new System.EventHandler(this.summaryBtn_MouseEnter);
            this.summaryBoxPanel.MouseLeave += new System.EventHandler(this.summaryBtn_MouseLeave);
            // 
            // transactionBoxPanel
            // 
            this.transactionBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transactionBoxPanel.Location = new System.Drawing.Point(185, 354);
            this.transactionBoxPanel.Name = "transactionBoxPanel";
            this.transactionBoxPanel.Size = new System.Drawing.Size(99, 82);
            this.transactionBoxPanel.TabIndex = 15;
            this.transactionBoxPanel.Visible = false;
            this.transactionBoxPanel.MouseEnter += new System.EventHandler(this.transactionBtn_MouseEnter);
            this.transactionBoxPanel.MouseLeave += new System.EventHandler(this.transactionBtn_MouseLeave);
            // 
            // predictionBoxPanel
            // 
            this.predictionBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.predictionBoxPanel.Controls.Add(this.panel9);
            this.predictionBoxPanel.Controls.Add(this.panel6);
            this.predictionBoxPanel.Location = new System.Drawing.Point(185, 190);
            this.predictionBoxPanel.Name = "predictionBoxPanel";
            this.predictionBoxPanel.Size = new System.Drawing.Size(99, 82);
            this.predictionBoxPanel.TabIndex = 13;
            this.predictionBoxPanel.Visible = false;
            this.predictionBoxPanel.MouseEnter += new System.EventHandler(this.predictBtn_MouseEnter);
            this.predictionBoxPanel.MouseLeave += new System.EventHandler(this.predictBtn_MouseLeave);
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(0, 82);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(12, 82);
            this.panel9.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(12, 82);
            this.panel6.TabIndex = 14;
            // 
            // mainBoxPanel
            // 
            this.mainBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainBoxPanel.Location = new System.Drawing.Point(185, 108);
            this.mainBoxPanel.Name = "mainBoxPanel";
            this.mainBoxPanel.Size = new System.Drawing.Size(99, 82);
            this.mainBoxPanel.TabIndex = 12;
            this.mainBoxPanel.Visible = false;
            this.mainBoxPanel.MouseEnter += new System.EventHandler(this.mainBtn_MouseEnter);
            this.mainBoxPanel.MouseLeave += new System.EventHandler(this.mainBtn_MouseLeave);
            // 
            // mainBtn
            // 
            this.mainBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainBtn.FlatAppearance.BorderSize = 0;
            this.mainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBtn.Font = new System.Drawing.Font("Calibri", 22F);
            this.mainBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mainBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainBtn.Location = new System.Drawing.Point(0, 107);
            this.mainBtn.Margin = new System.Windows.Forms.Padding(2);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(284, 82);
            this.mainBtn.TabIndex = 11;
            this.mainBtn.Text = "  Main";
            this.mainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            this.mainBtn.MouseEnter += new System.EventHandler(this.mainBtn_MouseEnter);
            this.mainBtn.MouseLeave += new System.EventHandler(this.mainBtn_MouseLeave);
            // 
            // predictBtn
            // 
            this.predictBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.predictBtn.FlatAppearance.BorderSize = 0;
            this.predictBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.predictBtn.Font = new System.Drawing.Font("Calibri", 22F);
            this.predictBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.predictBtn.Location = new System.Drawing.Point(0, 189);
            this.predictBtn.Margin = new System.Windows.Forms.Padding(2);
            this.predictBtn.Name = "predictBtn";
            this.predictBtn.Size = new System.Drawing.Size(284, 82);
            this.predictBtn.TabIndex = 10;
            this.predictBtn.Text = "  Prediction";
            this.predictBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.predictBtn.UseVisualStyleBackColor = true;
            this.predictBtn.Click += new System.EventHandler(this.predictBtn_Click);
            this.predictBtn.MouseEnter += new System.EventHandler(this.predictBtn_MouseEnter);
            this.predictBtn.MouseLeave += new System.EventHandler(this.predictBtn_MouseLeave);
            // 
            // eventsBtn
            // 
            this.eventsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsBtn.FlatAppearance.BorderSize = 0;
            this.eventsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventsBtn.Font = new System.Drawing.Font("Calibri", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eventsBtn.Location = new System.Drawing.Point(0, 271);
            this.eventsBtn.Name = "eventsBtn";
            this.eventsBtn.Size = new System.Drawing.Size(284, 82);
            this.eventsBtn.TabIndex = 6;
            this.eventsBtn.Text = "  Events";
            this.eventsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventsBtn.UseVisualStyleBackColor = true;
            this.eventsBtn.Click += new System.EventHandler(this.eventsBtn_Click);
            this.eventsBtn.MouseEnter += new System.EventHandler(this.eventsBtn_MouseEnter);
            this.eventsBtn.MouseLeave += new System.EventHandler(this.eventsBtn_MouseLeave);
            // 
            // transactionBtn
            // 
            this.transactionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionBtn.FlatAppearance.BorderSize = 0;
            this.transactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionBtn.Font = new System.Drawing.Font("Calibri", 22F);
            this.transactionBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transactionBtn.Location = new System.Drawing.Point(0, 354);
            this.transactionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(284, 82);
            this.transactionBtn.TabIndex = 5;
            this.transactionBtn.Text = "  Transactions";
            this.transactionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            this.transactionBtn.MouseEnter += new System.EventHandler(this.transactionBtn_MouseEnter);
            this.transactionBtn.MouseLeave += new System.EventHandler(this.transactionBtn_MouseLeave);
            // 
            // summaryBtn0
            // 
            this.summaryBtn0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryBtn0.FlatAppearance.BorderSize = 0;
            this.summaryBtn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.summaryBtn0.Font = new System.Drawing.Font("Calibri", 22F);
            this.summaryBtn0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.summaryBtn0.Location = new System.Drawing.Point(0, 436);
            this.summaryBtn0.Margin = new System.Windows.Forms.Padding(2);
            this.summaryBtn0.Name = "summaryBtn0";
            this.summaryBtn0.Size = new System.Drawing.Size(284, 82);
            this.summaryBtn0.TabIndex = 9;
            this.summaryBtn0.Text = "  Summary";
            this.summaryBtn0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.summaryBtn0.UseVisualStyleBackColor = true;
            this.summaryBtn0.MouseEnter += new System.EventHandler(this.summaryBtn_MouseEnter);
            this.summaryBtn0.MouseLeave += new System.EventHandler(this.summaryBtn_MouseLeave);
            // 
            // ContactBtn
            // 
            this.ContactBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Calibri", 22F);
            this.ContactBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ContactBtn.Location = new System.Drawing.Point(0, 518);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(284, 82);
            this.ContactBtn.TabIndex = 0;
            this.ContactBtn.Text = "  Contact";
            this.ContactBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactBtn.UseVisualStyleBackColor = true;
            this.ContactBtn.Click += new System.EventHandler(this.contactBtn_Click);
            this.ContactBtn.MouseEnter += new System.EventHandler(this.contactBtn_MouseEnter);
            this.ContactBtn.MouseLeave += new System.EventHandler(this.contactBtn_MouseLeave);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.headerPanel.Controls.Add(this.headerLbl);
            this.headerPanel.Controls.Add(this.closePanel);
            this.headerPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.headerPanel.Location = new System.Drawing.Point(277, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(750, 48);
            this.headerPanel.TabIndex = 14;
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerLbl.Location = new System.Drawing.Point(226, 9);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(283, 37);
            this.headerLbl.TabIndex = 2;
            this.headerLbl.Text = "FINACIAL REPORT";
            // 
            // closePanel
            // 
            this.closePanel.BackgroundImage = global::enterpriseDevelopment.Properties.Resources.close;
            this.closePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePanel.Location = new System.Drawing.Point(690, 7);
            this.closePanel.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.closePanel.Name = "closePanel";
            this.closePanel.Padding = new System.Windows.Forms.Padding(5);
            this.closePanel.Size = new System.Drawing.Size(32, 30);
            this.closePanel.TabIndex = 0;
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            this.closePanel.MouseEnter += new System.EventHandler(this.closePanel_MouseEnter);
            this.closePanel.MouseLeave += new System.EventHandler(this.closePanel_MouseLeave);
            // 
            // summaryBtn
            // 
            this.summaryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.summaryBtn.FlatAppearance.BorderSize = 0;
            this.summaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.summaryBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryBtn.ForeColor = System.Drawing.Color.White;
            this.summaryBtn.Location = new System.Drawing.Point(309, 518);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(680, 51);
            this.summaryBtn.TabIndex = 21;
            this.summaryBtn.Text = "Action";
            this.summaryBtn.UseVisualStyleBackColor = false;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // transactionToogle
            // 
            this.transactionToogle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.transactionToogle.Controls.Add(this.eventsRepeatBtn);
            this.transactionToogle.Controls.Add(this.recurringToggleBtn);
            this.transactionToogle.Location = new System.Drawing.Point(289, 354);
            this.transactionToogle.MaximumSize = new System.Drawing.Size(127, 82);
            this.transactionToogle.MinimumSize = new System.Drawing.Size(0, 82);
            this.transactionToogle.Name = "transactionToogle";
            this.transactionToogle.Size = new System.Drawing.Size(0, 82);
            this.transactionToogle.TabIndex = 22;
            // 
            // eventsRepeatBtn
            // 
            this.eventsRepeatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.eventsRepeatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventsRepeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventsRepeatBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsRepeatBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eventsRepeatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eventsRepeatBtn.Location = new System.Drawing.Point(0, 39);
            this.eventsRepeatBtn.Name = "eventsRepeatBtn";
            this.eventsRepeatBtn.Size = new System.Drawing.Size(0, 43);
            this.eventsRepeatBtn.TabIndex = 8;
            this.eventsRepeatBtn.Text = "Periodic ";
            this.eventsRepeatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventsRepeatBtn.UseVisualStyleBackColor = false;
            this.eventsRepeatBtn.Click += new System.EventHandler(this.reucurringTransactionBtn_Click);
            // 
            // recurringToggleBtn
            // 
            this.recurringToggleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.recurringToggleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.recurringToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recurringToggleBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recurringToggleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recurringToggleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recurringToggleBtn.Location = new System.Drawing.Point(0, 0);
            this.recurringToggleBtn.Name = "recurringToggleBtn";
            this.recurringToggleBtn.Size = new System.Drawing.Size(0, 39);
            this.recurringToggleBtn.TabIndex = 3;
            this.recurringToggleBtn.Text = "All transactions";
            this.recurringToggleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recurringToggleBtn.UseVisualStyleBackColor = false;
            this.recurringToggleBtn.Click += new System.EventHandler(this.singleTransactionBtn_Click);
            // 
            // eventToogle
            // 
            this.eventToogle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.eventToogle.Controls.Add(this.repeatBtn);
            this.eventToogle.Controls.Add(this.allEventBtn);
            this.eventToogle.Location = new System.Drawing.Point(289, 272);
            this.eventToogle.MaximumSize = new System.Drawing.Size(127, 82);
            this.eventToogle.MinimumSize = new System.Drawing.Size(0, 82);
            this.eventToogle.Name = "eventToogle";
            this.eventToogle.Size = new System.Drawing.Size(0, 82);
            this.eventToogle.TabIndex = 26;
            // 
            // repeatBtn
            // 
            this.repeatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.repeatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.repeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.repeatBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repeatBtn.Location = new System.Drawing.Point(0, 39);
            this.repeatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.repeatBtn.Name = "repeatBtn";
            this.repeatBtn.Size = new System.Drawing.Size(0, 44);
            this.repeatBtn.TabIndex = 7;
            this.repeatBtn.Text = "Periodic";
            this.repeatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.repeatBtn.UseVisualStyleBackColor = false;
            this.repeatBtn.Click += new System.EventHandler(this.recurringEventBtn_Click);
            // 
            // allEventBtn
            // 
            this.allEventBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.allEventBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.allEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allEventBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.allEventBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allEventBtn.Location = new System.Drawing.Point(0, 0);
            this.allEventBtn.Name = "allEventBtn";
            this.allEventBtn.Size = new System.Drawing.Size(0, 39);
            this.allEventBtn.TabIndex = 11;
            this.allEventBtn.Text = "All events";
            this.allEventBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allEventBtn.UseVisualStyleBackColor = false;
            this.allEventBtn.Click += new System.EventHandler(this.eventBtn_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1025, 597);
            this.Controls.Add(this.eventToogle);
            this.Controls.Add(this.transactionToogle);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewSummary);
            this.Controls.Add(this.showByComboBox);
            this.Controls.Add(this.subLvl3);
            this.Controls.Add(this.subLbl2);
            this.Controls.Add(this.subLbl1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SummaryForm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).EndInit();
            this.eventBoxPanel.ResumeLayout(false);
            this.predictionBoxPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.transactionToogle.ResumeLayout(false);
            this.eventToogle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label subLbl1;
        private System.Windows.Forms.Label subLbl2;
        private System.Windows.Forms.Label subLvl3;
        private System.Windows.Forms.ComboBox showByComboBox;
        private MaterialSkin.Controls.MaterialListView listViewSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox contactIcon;
        private System.Windows.Forms.PictureBox summaryIcon;
        private System.Windows.Forms.PictureBox transactionIcon;
        private System.Windows.Forms.PictureBox eventIcon;
        private System.Windows.Forms.PictureBox predictionIcon;
        private System.Windows.Forms.PictureBox mainIcon;
        private System.Windows.Forms.Panel eventBoxPanel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel contactBoxPanel;
        private System.Windows.Forms.Panel summaryBoxPanel;
        private System.Windows.Forms.Panel transactionBoxPanel;
        private System.Windows.Forms.Panel predictionBoxPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel mainBoxPanel;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.Button predictBtn;
        private System.Windows.Forms.Button eventsBtn;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button summaryBtn0;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel transactionToogle;
        private System.Windows.Forms.Button eventsRepeatBtn;
        private System.Windows.Forms.Button recurringToggleBtn;
        private System.Windows.Forms.Panel eventToogle;
        private System.Windows.Forms.Button repeatBtn;
        private System.Windows.Forms.Button allEventBtn;
    }
}