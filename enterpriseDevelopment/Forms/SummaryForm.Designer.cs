﻿namespace enterpriseDevelopment.Forms
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
            this.dateCountStart = new System.Windows.Forms.DateTimePicker();
            this.dateCountEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showByCB = new System.Windows.Forms.ComboBox();
            this.listVSummary = new MaterialSkin.Controls.MaterialListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mainBtn = new System.Windows.Forms.Button();
            this.predictBtn = new System.Windows.Forms.Button();
            this.eventsBtn = new System.Windows.Forms.Button();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.closePanel = new System.Windows.Forms.Panel();
            this.showSumBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelToggle1 = new System.Windows.Forms.Panel();
            this.eventsRepeatBtn = new System.Windows.Forms.Button();
            this.recurringToggleBtn = new System.Windows.Forms.Button();
            this.panelToogle2 = new System.Windows.Forms.Panel();
            this.repeatBtn = new System.Windows.Forms.Button();
            this.allEventBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelToggle1.SuspendLayout();
            this.panelToogle2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateCountStart
            // 
            this.dateCountStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCountStart.Location = new System.Drawing.Point(429, 441);
            this.dateCountStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateCountStart.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dateCountStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateCountStart.Name = "dateCountStart";
            this.dateCountStart.Size = new System.Drawing.Size(102, 20);
            this.dateCountStart.TabIndex = 3;
            // 
            // dateCountEnd
            // 
            this.dateCountEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCountEnd.Location = new System.Drawing.Point(605, 441);
            this.dateCountEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateCountEnd.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dateCountEnd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateCountEnd.Name = "dateCountEnd";
            this.dateCountEnd.Size = new System.Drawing.Size(102, 20);
            this.dateCountEnd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(424, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(606, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "End date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(794, 407);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Show by";
            // 
            // showByCB
            // 
            this.showByCB.FormattingEnabled = true;
            this.showByCB.Items.AddRange(new object[] {
            "Transactions",
            "Days",
            "Months",
            "Years"});
            this.showByCB.Location = new System.Drawing.Point(799, 440);
            this.showByCB.Margin = new System.Windows.Forms.Padding(2);
            this.showByCB.Name = "showByCB";
            this.showByCB.Size = new System.Drawing.Size(82, 21);
            this.showByCB.TabIndex = 10;
            this.showByCB.Text = "Transactions";
            // 
            // listVSummary
            // 
            this.listVSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVSummary.Depth = 0;
            this.listVSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listVSummary.FullRowSelect = true;
            this.listVSummary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listVSummary.HideSelection = false;
            this.listVSummary.Location = new System.Drawing.Point(309, 86);
            this.listVSummary.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listVSummary.MouseState = MaterialSkin.MouseState.OUT;
            this.listVSummary.Name = "listVSummary";
            this.listVSummary.OwnerDraw = true;
            this.listVSummary.Size = new System.Drawing.Size(680, 267);
            this.listVSummary.TabIndex = 12;
            this.listVSummary.UseCompatibleStateImageBehavior = false;
            this.listVSummary.View = System.Windows.Forms.View.Details;
            this.listVSummary.SizeChanged += new System.EventHandler(this.listVSummary_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.mainBtn);
            this.panel1.Controls.Add(this.predictBtn);
            this.panel1.Controls.Add(this.eventsBtn);
            this.panel1.Controls.Add(this.transactionBtn);
            this.panel1.Controls.Add(this.summaryBtn);
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
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(226, 549);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 25);
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseEnter += new System.EventHandler(this.ContactBtn_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.ContactBtn_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(215, 462);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 37);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseEnter += new System.EventHandler(this.summaryBtn_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.summaryBtn_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(215, 382);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 25);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseEnter += new System.EventHandler(this.transactionBtn_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.transactionBtn_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(215, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.eventsBtn_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.eventsBtn_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(215, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 30);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.predictBtn_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.predictBtn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(215, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.mainBtn_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.mainBtn_MouseLeave);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Location = new System.Drawing.Point(185, 272);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(99, 82);
            this.panel11.TabIndex = 18;
            this.panel11.Visible = false;
            this.panel11.MouseEnter += new System.EventHandler(this.eventsBtn_MouseEnter);
            this.panel11.MouseLeave += new System.EventHandler(this.eventsBtn_MouseLeave);
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
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Location = new System.Drawing.Point(185, 518);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(99, 82);
            this.panel10.TabIndex = 17;
            this.panel10.Visible = false;
            this.panel10.MouseEnter += new System.EventHandler(this.ContactBtn_MouseEnter);
            this.panel10.MouseLeave += new System.EventHandler(this.ContactBtn_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Location = new System.Drawing.Point(185, 436);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(99, 82);
            this.panel8.TabIndex = 16;
            this.panel8.Visible = false;
            this.panel8.MouseEnter += new System.EventHandler(this.summaryBtn_MouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.summaryBtn_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Location = new System.Drawing.Point(185, 354);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(99, 82);
            this.panel7.TabIndex = 15;
            this.panel7.Visible = false;
            this.panel7.MouseEnter += new System.EventHandler(this.transactionBtn_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.transactionBtn_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(185, 190);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(99, 82);
            this.panel5.TabIndex = 13;
            this.panel5.Visible = false;
            this.panel5.MouseEnter += new System.EventHandler(this.predictBtn_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.predictBtn_MouseLeave);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(185, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(99, 82);
            this.panel4.TabIndex = 12;
            this.panel4.Visible = false;
            this.panel4.MouseEnter += new System.EventHandler(this.mainBtn_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.mainBtn_MouseLeave);
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
            this.summaryBtn.MouseEnter += new System.EventHandler(this.summaryBtn_MouseEnter);
            this.summaryBtn.MouseLeave += new System.EventHandler(this.summaryBtn_MouseLeave);
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
            this.ContactBtn.Click += new System.EventHandler(this.ContactBtn_Click);
            this.ContactBtn.MouseEnter += new System.EventHandler(this.ContactBtn_MouseEnter);
            this.ContactBtn.MouseLeave += new System.EventHandler(this.ContactBtn_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.closePanel);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(277, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 48);
            this.panel2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(226, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 37);
            this.label9.TabIndex = 2;
            this.label9.Text = "FINACIAL REPORT";
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
            // showSumBtn
            // 
            this.showSumBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.showSumBtn.FlatAppearance.BorderSize = 0;
            this.showSumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSumBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSumBtn.ForeColor = System.Drawing.Color.White;
            this.showSumBtn.Location = new System.Drawing.Point(309, 518);
            this.showSumBtn.Name = "showSumBtn";
            this.showSumBtn.Size = new System.Drawing.Size(680, 51);
            this.showSumBtn.TabIndex = 21;
            this.showSumBtn.Text = "Action";
            this.showSumBtn.UseVisualStyleBackColor = false;
            this.showSumBtn.Click += new System.EventHandler(this.showSumBtn_Click);
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
            // panelToggle1
            // 
            this.panelToggle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panelToggle1.Controls.Add(this.eventsRepeatBtn);
            this.panelToggle1.Controls.Add(this.recurringToggleBtn);
            this.panelToggle1.Location = new System.Drawing.Point(289, 354);
            this.panelToggle1.MaximumSize = new System.Drawing.Size(127, 82);
            this.panelToggle1.MinimumSize = new System.Drawing.Size(0, 82);
            this.panelToggle1.Name = "panelToggle1";
            this.panelToggle1.Size = new System.Drawing.Size(0, 82);
            this.panelToggle1.TabIndex = 22;
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
            this.eventsRepeatBtn.Click += new System.EventHandler(this.eventsRepeatBtn_Click);
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
            this.recurringToggleBtn.Click += new System.EventHandler(this.recurringToggleBtn_Click);
            // 
            // panelToogle2
            // 
            this.panelToogle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panelToogle2.Controls.Add(this.repeatBtn);
            this.panelToogle2.Controls.Add(this.allEventBtn);
            this.panelToogle2.Location = new System.Drawing.Point(289, 272);
            this.panelToogle2.MaximumSize = new System.Drawing.Size(127, 82);
            this.panelToogle2.MinimumSize = new System.Drawing.Size(0, 82);
            this.panelToogle2.Name = "panelToogle2";
            this.panelToogle2.Size = new System.Drawing.Size(0, 82);
            this.panelToogle2.TabIndex = 26;
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
            this.repeatBtn.Click += new System.EventHandler(this.repeatBtn_Click);
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
            this.allEventBtn.Click += new System.EventHandler(this.allEventBtn_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1025, 597);
            this.Controls.Add(this.panelToogle2);
            this.Controls.Add(this.panelToggle1);
            this.Controls.Add(this.showSumBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listVSummary);
            this.Controls.Add(this.showByCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateCountEnd);
            this.Controls.Add(this.dateCountStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SummaryForm_FormClosed);
            this.Click += new System.EventHandler(this.SummaryForm_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelToggle1.ResumeLayout(false);
            this.panelToogle2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateCountStart;
        private System.Windows.Forms.DateTimePicker dateCountEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox showByCB;
        private MaterialSkin.Controls.MaterialListView listVSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.Button predictBtn;
        private System.Windows.Forms.Button eventsBtn;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button showSumBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelToggle1;
        private System.Windows.Forms.Button eventsRepeatBtn;
        private System.Windows.Forms.Button recurringToggleBtn;
        private System.Windows.Forms.Panel panelToogle2;
        private System.Windows.Forms.Button repeatBtn;
        private System.Windows.Forms.Button allEventBtn;
    }
}