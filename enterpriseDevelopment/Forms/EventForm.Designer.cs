namespace enterpriseDevelopment
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.panelLine = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.contactIcon = new System.Windows.Forms.PictureBox();
            this.summaryIcon = new System.Windows.Forms.PictureBox();
            this.transactionIcon = new System.Windows.Forms.PictureBox();
            this.eventIcon = new System.Windows.Forms.PictureBox();
            this.predictionIcon = new System.Windows.Forms.PictureBox();
            this.mainIcon = new System.Windows.Forms.PictureBox();
            this.eventBoxPanel = new System.Windows.Forms.Panel();
            this.contactBoxPanel = new System.Windows.Forms.Panel();
            this.summaryBoxPanel = new System.Windows.Forms.Panel();
            this.transactionBoxPanel = new System.Windows.Forms.Panel();
            this.predictionBoxPanel = new System.Windows.Forms.Panel();
            this.mainBoxPanel = new System.Windows.Forms.Panel();
            this.mainBtn = new System.Windows.Forms.Button();
            this.predictBtn = new System.Windows.Forms.Button();
            this.eventsBtn = new System.Windows.Forms.Button();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.contactBtn = new System.Windows.Forms.Button();
            this.addLbl = new System.Windows.Forms.Label();
            this.editLbl = new System.Windows.Forms.Label();
            this.deleteLbl = new System.Windows.Forms.Label();
            this.listViewEvent = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.transactionTooglePanel = new System.Windows.Forms.Panel();
            this.eventsRepeatBtn = new System.Windows.Forms.Button();
            this.recurringToggleBtn = new System.Windows.Forms.Button();
            this.eventTooglePanel = new System.Windows.Forms.Panel();
            this.repeatBtn = new System.Windows.Forms.Button();
            this.singleEventBtn = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).BeginInit();
            this.transactionTooglePanel.SuspendLayout();
            this.eventTooglePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(421, 462);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(60, 60);
            this.addBtn.TabIndex = 1;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.Location = new System.Drawing.Point(623, 462);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(60, 60);
            this.editBtn.TabIndex = 2;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(812, 462);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(60, 60);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.headerPanel.Controls.Add(this.headerLbl);
            this.headerPanel.Controls.Add(this.closeBtn);
            this.headerPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.headerPanel.Location = new System.Drawing.Point(282, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(742, 48);
            this.headerPanel.TabIndex = 3;
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLbl.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerLbl.Location = new System.Drawing.Point(104, 7);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(512, 37);
            this.headerLbl.TabIndex = 1;
            this.headerLbl.Text = "PLANNED TASKS / APPOINTMENT";
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::enterpriseDevelopment.Properties.Resources.close;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Location = new System.Drawing.Point(690, 7);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(5);
            this.closeBtn.Size = new System.Drawing.Size(32, 30);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.navigationPanel.Controls.Add(this.panelLine);
            this.navigationPanel.Controls.Add(this.pictureBox7);
            this.navigationPanel.Controls.Add(this.contactIcon);
            this.navigationPanel.Controls.Add(this.summaryIcon);
            this.navigationPanel.Controls.Add(this.transactionIcon);
            this.navigationPanel.Controls.Add(this.eventIcon);
            this.navigationPanel.Controls.Add(this.predictionIcon);
            this.navigationPanel.Controls.Add(this.mainIcon);
            this.navigationPanel.Controls.Add(this.eventBoxPanel);
            this.navigationPanel.Controls.Add(this.contactBoxPanel);
            this.navigationPanel.Controls.Add(this.summaryBoxPanel);
            this.navigationPanel.Controls.Add(this.transactionBoxPanel);
            this.navigationPanel.Controls.Add(this.predictionBoxPanel);
            this.navigationPanel.Controls.Add(this.mainBoxPanel);
            this.navigationPanel.Controls.Add(this.mainBtn);
            this.navigationPanel.Controls.Add(this.predictBtn);
            this.navigationPanel.Controls.Add(this.eventsBtn);
            this.navigationPanel.Controls.Add(this.transactionBtn);
            this.navigationPanel.Controls.Add(this.summaryBtn);
            this.navigationPanel.Controls.Add(this.contactBtn);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(284, 597);
            this.navigationPanel.TabIndex = 6;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelLine.Location = new System.Drawing.Point(0, 104);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(284, 5);
            this.panelLine.TabIndex = 3;
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
            this.eventBoxPanel.Location = new System.Drawing.Point(185, 272);
            this.eventBoxPanel.Name = "eventBoxPanel";
            this.eventBoxPanel.Size = new System.Drawing.Size(99, 82);
            this.eventBoxPanel.TabIndex = 18;
            this.eventBoxPanel.Visible = false;
            this.eventBoxPanel.MouseEnter += new System.EventHandler(this.eventsBtn_MouseEnter);
            this.eventBoxPanel.MouseLeave += new System.EventHandler(this.eventsBtn_MouseLeave);
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
            this.predictionBoxPanel.Location = new System.Drawing.Point(185, 190);
            this.predictionBoxPanel.Name = "predictionBoxPanel";
            this.predictionBoxPanel.Size = new System.Drawing.Size(99, 82);
            this.predictionBoxPanel.TabIndex = 13;
            this.predictionBoxPanel.Visible = false;
            this.predictionBoxPanel.MouseEnter += new System.EventHandler(this.predictBtn_MouseEnter);
            this.predictionBoxPanel.MouseLeave += new System.EventHandler(this.predictBtn_MouseLeave);
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
            // summaryBtn
            // 
            this.summaryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryBtn.FlatAppearance.BorderSize = 0;
            this.summaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.summaryBtn.Font = new System.Drawing.Font("Calibri", 22F);
            this.summaryBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.summaryBtn.Location = new System.Drawing.Point(0, 436);
            this.summaryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(284, 82);
            this.summaryBtn.TabIndex = 9;
            this.summaryBtn.Text = "  Summary";
            this.summaryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            this.summaryBtn.MouseEnter += new System.EventHandler(this.summaryBtn_MouseEnter);
            this.summaryBtn.MouseLeave += new System.EventHandler(this.summaryBtn_MouseLeave);
            // 
            // contactBtn
            // 
            this.contactBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactBtn.FlatAppearance.BorderSize = 0;
            this.contactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactBtn.Font = new System.Drawing.Font("Calibri", 22F);
            this.contactBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contactBtn.Location = new System.Drawing.Point(0, 518);
            this.contactBtn.Margin = new System.Windows.Forms.Padding(2);
            this.contactBtn.Name = "contactBtn";
            this.contactBtn.Size = new System.Drawing.Size(284, 82);
            this.contactBtn.TabIndex = 0;
            this.contactBtn.Text = "  Contact";
            this.contactBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactBtn.UseVisualStyleBackColor = true;
            this.contactBtn.Click += new System.EventHandler(this.contactBtn_Click);
            this.contactBtn.MouseEnter += new System.EventHandler(this.contactBtn_MouseEnter);
            this.contactBtn.MouseLeave += new System.EventHandler(this.contactBtn_MouseLeave);
            // 
            // addLbl
            // 
            this.addLbl.AutoSize = true;
            this.addLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.addLbl.Location = new System.Drawing.Point(379, 540);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(150, 23);
            this.addLbl.TabIndex = 7;
            this.addLbl.Text = "Add event or task";
            // 
            // editLbl
            // 
            this.editLbl.AutoSize = true;
            this.editLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.editLbl.Location = new System.Drawing.Point(591, 540);
            this.editLbl.Name = "editLbl";
            this.editLbl.Size = new System.Drawing.Size(117, 23);
            this.editLbl.TabIndex = 8;
            this.editLbl.Text = "Edit selection";
            // 
            // deleteLbl
            // 
            this.deleteLbl.AutoSize = true;
            this.deleteLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.deleteLbl.Location = new System.Drawing.Point(776, 540);
            this.deleteLbl.Name = "deleteLbl";
            this.deleteLbl.Size = new System.Drawing.Size(140, 23);
            this.deleteLbl.TabIndex = 9;
            this.deleteLbl.Text = "Delete selection";
            // 
            // listViewEvent
            // 
            this.listViewEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewEvent.Depth = 0;
            this.listViewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewEvent.FullRowSelect = true;
            this.listViewEvent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEvent.HideSelection = false;
            this.listViewEvent.Location = new System.Drawing.Point(306, 86);
            this.listViewEvent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewEvent.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewEvent.Name = "listViewEvent";
            this.listViewEvent.OwnerDraw = true;
            this.listViewEvent.Size = new System.Drawing.Size(707, 350);
            this.listViewEvent.TabIndex = 10;
            this.listViewEvent.UseCompatibleStateImageBehavior = false;
            this.listViewEvent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Task";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Location";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Contact";
            this.columnHeader5.Width = 151;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date";
            this.columnHeader6.Width = 171;
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
            // transactionTooglePanel
            // 
            this.transactionTooglePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.transactionTooglePanel.Controls.Add(this.eventsRepeatBtn);
            this.transactionTooglePanel.Controls.Add(this.recurringToggleBtn);
            this.transactionTooglePanel.Location = new System.Drawing.Point(287, 354);
            this.transactionTooglePanel.MaximumSize = new System.Drawing.Size(127, 82);
            this.transactionTooglePanel.MinimumSize = new System.Drawing.Size(0, 82);
            this.transactionTooglePanel.Name = "transactionTooglePanel";
            this.transactionTooglePanel.Size = new System.Drawing.Size(0, 82);
            this.transactionTooglePanel.TabIndex = 11;
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
            this.eventsRepeatBtn.Click += new System.EventHandler(this.recurringTransactionBtn_Click);
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
            // eventTooglePanel
            // 
            this.eventTooglePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.eventTooglePanel.Controls.Add(this.repeatBtn);
            this.eventTooglePanel.Controls.Add(this.singleEventBtn);
            this.eventTooglePanel.Location = new System.Drawing.Point(287, 272);
            this.eventTooglePanel.MaximumSize = new System.Drawing.Size(127, 82);
            this.eventTooglePanel.MinimumSize = new System.Drawing.Size(0, 82);
            this.eventTooglePanel.Name = "eventTooglePanel";
            this.eventTooglePanel.Size = new System.Drawing.Size(0, 82);
            this.eventTooglePanel.TabIndex = 11;
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
            // 
            // singleEventBtn
            // 
            this.singleEventBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.singleEventBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.singleEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleEventBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.singleEventBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.singleEventBtn.Location = new System.Drawing.Point(0, 0);
            this.singleEventBtn.Name = "singleEventBtn";
            this.singleEventBtn.Size = new System.Drawing.Size(0, 39);
            this.singleEventBtn.TabIndex = 11;
            this.singleEventBtn.Text = "All events";
            this.singleEventBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.singleEventBtn.UseVisualStyleBackColor = false;
            this.singleEventBtn.Click += new System.EventHandler(this.singleEventBtn_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 597);
            this.Controls.Add(this.eventTooglePanel);
            this.Controls.Add(this.transactionTooglePanel);
            this.Controls.Add(this.listViewEvent);
            this.Controls.Add(this.deleteLbl);
            this.Controls.Add(this.editLbl);
            this.Controls.Add(this.addLbl);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Activated += new System.EventHandler(this.EventForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventForm_FormClosed);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).EndInit();
            this.transactionTooglePanel.ResumeLayout(false);
            this.eventTooglePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel closeBtn;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox contactIcon;
        private System.Windows.Forms.PictureBox summaryIcon;
        private System.Windows.Forms.PictureBox transactionIcon;
        private System.Windows.Forms.PictureBox eventIcon;
        private System.Windows.Forms.PictureBox predictionIcon;
        private System.Windows.Forms.PictureBox mainIcon;
        private System.Windows.Forms.Panel eventBoxPanel;
        private System.Windows.Forms.Panel contactBoxPanel;
        private System.Windows.Forms.Panel summaryBoxPanel;
        private System.Windows.Forms.Panel transactionBoxPanel;
        private System.Windows.Forms.Panel predictionBoxPanel;
        private System.Windows.Forms.Panel mainBoxPanel;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.Button predictBtn;
        private System.Windows.Forms.Button eventsBtn;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Button contactBtn;
        private System.Windows.Forms.Label addLbl;
        private System.Windows.Forms.Label editLbl;
        private System.Windows.Forms.Label deleteLbl;
        private System.Windows.Forms.Label headerLbl;
        private MaterialSkin.Controls.MaterialListView listViewEvent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel transactionTooglePanel;
        private System.Windows.Forms.Button eventsRepeatBtn;
        private System.Windows.Forms.Button recurringToggleBtn;
        private System.Windows.Forms.Panel eventTooglePanel;
        private System.Windows.Forms.Button repeatBtn;
        private System.Windows.Forms.Button singleEventBtn;
    }
}