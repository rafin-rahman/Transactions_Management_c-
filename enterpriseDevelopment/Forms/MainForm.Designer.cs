namespace enterpriseDevelopment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contactBtn = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.nagivationLinePanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closePanel = new System.Windows.Forms.Panel();
            this.repeatBtn = new System.Windows.Forms.Button();
            this.recurringBGWorker = new System.ComponentModel.BackgroundWorker();
            this.singleTransactionBtn = new System.Windows.Forms.Button();
            this.transactionToggle = new System.Windows.Forms.Panel();
            this.recurringTransactionBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelToogle2 = new System.Windows.Forms.Panel();
            this.singleEventBtn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.transactionToggle.SuspendLayout();
            this.panelToogle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
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
            this.contactBtn.Size = new System.Drawing.Size(284, 79);
            this.contactBtn.TabIndex = 0;
            this.contactBtn.Text = "  Contact";
            this.contactBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactBtn.UseVisualStyleBackColor = true;
            this.contactBtn.Click += new System.EventHandler(this.contactBtn_Click);
            this.contactBtn.MouseEnter += new System.EventHandler(this.contactBtn_MouseEnter);
            this.contactBtn.MouseLeave += new System.EventHandler(this.contactBtn_MouseLeave);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.navigationPanel.Controls.Add(this.nagivationLinePanel);
            this.navigationPanel.Controls.Add(this.logoBox);
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
            this.navigationPanel.TabIndex = 1;
            // 
            // nagivationLinePanel
            // 
            this.nagivationLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.nagivationLinePanel.Location = new System.Drawing.Point(0, 104);
            this.nagivationLinePanel.Name = "nagivationLinePanel";
            this.nagivationLinePanel.Size = new System.Drawing.Size(284, 5);
            this.nagivationLinePanel.TabIndex = 3;
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(-14, 1);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(266, 102);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 25;
            this.logoBox.TabStop = false;
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
            this.contactBoxPanel.Size = new System.Drawing.Size(99, 79);
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
            this.eventsBtn.Click += new System.EventHandler(this.event_Click);
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
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.headerPanel.Controls.Add(this.closePanel);
            this.headerPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.headerPanel.Location = new System.Drawing.Point(282, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(744, 48);
            this.headerPanel.TabIndex = 2;
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
            // recurringBGWorker
            // 
            this.recurringBGWorker.WorkerReportsProgress = true;
            this.recurringBGWorker.WorkerSupportsCancellation = true;
            this.recurringBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.recurringBGWorker_DoWork);
            this.recurringBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.recurringBGWorker_ProgressChanged);
            // 
            // singleTransactionBtn
            // 
            this.singleTransactionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.singleTransactionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.singleTransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleTransactionBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleTransactionBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.singleTransactionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.singleTransactionBtn.Location = new System.Drawing.Point(0, 0);
            this.singleTransactionBtn.Name = "singleTransactionBtn";
            this.singleTransactionBtn.Size = new System.Drawing.Size(0, 39);
            this.singleTransactionBtn.TabIndex = 3;
            this.singleTransactionBtn.Text = "All transactions";
            this.singleTransactionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.singleTransactionBtn.UseVisualStyleBackColor = false;
            this.singleTransactionBtn.Click += new System.EventHandler(this.singleTransactionBtn_Click);
            // 
            // transactionToggle
            // 
            this.transactionToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.transactionToggle.Controls.Add(this.recurringTransactionBtn);
            this.transactionToggle.Controls.Add(this.singleTransactionBtn);
            this.transactionToggle.Location = new System.Drawing.Point(290, 354);
            this.transactionToggle.MaximumSize = new System.Drawing.Size(127, 82);
            this.transactionToggle.MinimumSize = new System.Drawing.Size(0, 82);
            this.transactionToggle.Name = "transactionToggle";
            this.transactionToggle.Size = new System.Drawing.Size(0, 82);
            this.transactionToggle.TabIndex = 9;
            // 
            // recurringTransactionBtn
            // 
            this.recurringTransactionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.recurringTransactionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.recurringTransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recurringTransactionBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recurringTransactionBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recurringTransactionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recurringTransactionBtn.Location = new System.Drawing.Point(0, 39);
            this.recurringTransactionBtn.Name = "recurringTransactionBtn";
            this.recurringTransactionBtn.Size = new System.Drawing.Size(0, 43);
            this.recurringTransactionBtn.TabIndex = 8;
            this.recurringTransactionBtn.Text = "Periodic ";
            this.recurringTransactionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recurringTransactionBtn.UseVisualStyleBackColor = false;
            this.recurringTransactionBtn.Click += new System.EventHandler(this.recurringTransactionBtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelToogle2
            // 
            this.panelToogle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panelToogle2.Controls.Add(this.repeatBtn);
            this.panelToogle2.Controls.Add(this.singleEventBtn);
            this.panelToogle2.Location = new System.Drawing.Point(290, 272);
            this.panelToogle2.MaximumSize = new System.Drawing.Size(127, 82);
            this.panelToogle2.MinimumSize = new System.Drawing.Size(0, 82);
            this.panelToogle2.Name = "panelToogle2";
            this.panelToogle2.Size = new System.Drawing.Size(0, 82);
            this.panelToogle2.TabIndex = 10;
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
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChart.Legends.Add(legend2);
            this.pieChart.Location = new System.Drawing.Point(658, 108);
            this.pieChart.Name = "pieChart";
            this.pieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "MonthlyTransaction";
            this.pieChart.Series.Add(series2);
            this.pieChart.Size = new System.Drawing.Size(300, 300);
            this.pieChart.TabIndex = 11;
            this.pieChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1025, 597);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.panelToogle2);
            this.Controls.Add(this.transactionToggle);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summaryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.transactionToggle.ResumeLayout(false);
            this.panelToogle2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contactBtn;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button eventsBtn;
        private System.Windows.Forms.Button repeatBtn;
        private System.Windows.Forms.Button recurringTransactionBtn;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Button predictBtn;
        private System.ComponentModel.BackgroundWorker recurringBGWorker;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.Panel eventBoxPanel;
        private System.Windows.Forms.Panel contactBoxPanel;
        private System.Windows.Forms.Panel summaryBoxPanel;
        private System.Windows.Forms.Panel transactionBoxPanel;
        private System.Windows.Forms.Panel predictionBoxPanel;
        private System.Windows.Forms.PictureBox contactIcon;
        private System.Windows.Forms.PictureBox summaryIcon;
        private System.Windows.Forms.PictureBox transactionIcon;
        private System.Windows.Forms.PictureBox eventIcon;
        private System.Windows.Forms.PictureBox predictionIcon;
        private System.Windows.Forms.PictureBox mainIcon;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Panel nagivationLinePanel;
        private System.Windows.Forms.Button singleTransactionBtn;
        private System.Windows.Forms.Panel transactionToggle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelToogle2;
        private System.Windows.Forms.Button singleEventBtn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel mainBoxPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
    }
}

