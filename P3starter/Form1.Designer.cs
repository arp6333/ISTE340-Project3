namespace P3
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.tb_aboutQuote = new System.Windows.Forms.RichTextBox();
            this.tb_aboutDesc = new System.Windows.Forms.RichTextBox();
            this.lbl_quoteAuthor = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tabDegrees = new System.Windows.Forms.TabPage();
            this.rtbGrad = new System.Windows.Forms.RichTextBox();
            this.rtbUndergrad = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabMinors = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rtbMinors = new System.Windows.Forms.RichTextBox();
            this.tabEmployment = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.tbIntroTitle = new System.Windows.Forms.TextBox();
            this.tabPeople = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.rtbPeople = new System.Windows.Forms.RichTextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabResearch = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.rtbResearch = new System.Windows.Forms.RichTextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabResources = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.rtbResources = new System.Windows.Forms.RichTextBox();
            this.tbSubtitle = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tabNews = new System.Windows.Forms.TabPage();
            this.rtbNews = new System.Windows.Forms.RichTextBox();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button17 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.tabDegrees.SuspendLayout();
            this.tabMinors.SuspendLayout();
            this.tabEmployment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabResearch.SuspendLayout();
            this.tabResources.SuspendLayout();
            this.tabNews.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Controls.Add(this.tabDegrees);
            this.tabControl1.Controls.Add(this.tabMinors);
            this.tabControl1.Controls.Add(this.tabEmployment);
            this.tabControl1.Controls.Add(this.tabPeople);
            this.tabControl1.Controls.Add(this.tabResearch);
            this.tabControl1.Controls.Add(this.tabResources);
            this.tabControl1.Controls.Add(this.tabNews);
            this.tabControl1.Controls.Add(this.tabContact);
            this.tabControl1.Location = new System.Drawing.Point(48, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1104, 635);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.DarkOrange;
            this.tabAbout.Controls.Add(this.tb_aboutQuote);
            this.tabAbout.Controls.Add(this.tb_aboutDesc);
            this.tabAbout.Controls.Add(this.lbl_quoteAuthor);
            this.tabAbout.Controls.Add(this.tb_title);
            this.tabAbout.Location = new System.Drawing.Point(4, 29);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAbout.Size = new System.Drawing.Size(1096, 602);
            this.tabAbout.TabIndex = 0;
            this.tabAbout.Text = "About";
            // 
            // tb_aboutQuote
            // 
            this.tb_aboutQuote.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_aboutQuote.Location = new System.Drawing.Point(81, 347);
            this.tb_aboutQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_aboutQuote.Name = "tb_aboutQuote";
            this.tb_aboutQuote.ReadOnly = true;
            this.tb_aboutQuote.Size = new System.Drawing.Size(930, 104);
            this.tb_aboutQuote.TabIndex = 13;
            this.tb_aboutQuote.Text = "";
            // 
            // tb_aboutDesc
            // 
            this.tb_aboutDesc.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_aboutDesc.Location = new System.Drawing.Point(81, 100);
            this.tb_aboutDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_aboutDesc.Name = "tb_aboutDesc";
            this.tb_aboutDesc.ReadOnly = true;
            this.tb_aboutDesc.Size = new System.Drawing.Size(930, 198);
            this.tb_aboutDesc.TabIndex = 12;
            this.tb_aboutDesc.Text = "";
            // 
            // lbl_quoteAuthor
            // 
            this.lbl_quoteAuthor.AutoSize = true;
            this.lbl_quoteAuthor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quoteAuthor.Location = new System.Drawing.Point(478, 456);
            this.lbl_quoteAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quoteAuthor.Name = "lbl_quoteAuthor";
            this.lbl_quoteAuthor.Size = new System.Drawing.Size(124, 20);
            this.lbl_quoteAuthor.TabIndex = 11;
            this.lbl_quoteAuthor.Text = "Quote Author";
            // 
            // tb_title
            // 
            this.tb_title.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_title.Location = new System.Drawing.Point(272, 29);
            this.tb_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_title.Name = "tb_title";
            this.tb_title.ReadOnly = true;
            this.tb_title.Size = new System.Drawing.Size(609, 42);
            this.tb_title.TabIndex = 10;
            // 
            // tabDegrees
            // 
            this.tabDegrees.BackColor = System.Drawing.Color.DarkOrange;
            this.tabDegrees.Controls.Add(this.rtbGrad);
            this.tabDegrees.Controls.Add(this.rtbUndergrad);
            this.tabDegrees.Controls.Add(this.textBox2);
            this.tabDegrees.Controls.Add(this.textBox1);
            this.tabDegrees.Location = new System.Drawing.Point(4, 29);
            this.tabDegrees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDegrees.Name = "tabDegrees";
            this.tabDegrees.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDegrees.Size = new System.Drawing.Size(1096, 602);
            this.tabDegrees.TabIndex = 1;
            this.tabDegrees.Text = "Degrees";
            this.tabDegrees.ToolTipText = "Click here to see the people in the department.";
            // 
            // rtbGrad
            // 
            this.rtbGrad.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGrad.Location = new System.Drawing.Point(560, 56);
            this.rtbGrad.Name = "rtbGrad";
            this.rtbGrad.ReadOnly = true;
            this.rtbGrad.Size = new System.Drawing.Size(529, 538);
            this.rtbGrad.TabIndex = 3;
            this.rtbGrad.Text = "";
            // 
            // rtbUndergrad
            // 
            this.rtbUndergrad.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUndergrad.Location = new System.Drawing.Point(7, 56);
            this.rtbUndergrad.Name = "rtbUndergrad";
            this.rtbUndergrad.ReadOnly = true;
            this.rtbUndergrad.Size = new System.Drawing.Size(533, 538);
            this.rtbUndergrad.TabIndex = 2;
            this.rtbUndergrad.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(752, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(142, 42);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Graduate";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(157, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 42);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Undergraduate";
            // 
            // tabMinors
            // 
            this.tabMinors.BackColor = System.Drawing.Color.DarkOrange;
            this.tabMinors.Controls.Add(this.textBox3);
            this.tabMinors.Controls.Add(this.rtbMinors);
            this.tabMinors.Location = new System.Drawing.Point(4, 29);
            this.tabMinors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMinors.Name = "tabMinors";
            this.tabMinors.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMinors.Size = new System.Drawing.Size(1096, 602);
            this.tabMinors.TabIndex = 2;
            this.tabMinors.Text = "Minors";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(516, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(89, 37);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Minors";
            // 
            // rtbMinors
            // 
            this.rtbMinors.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMinors.Location = new System.Drawing.Point(70, 54);
            this.rtbMinors.Name = "rtbMinors";
            this.rtbMinors.ReadOnly = true;
            this.rtbMinors.Size = new System.Drawing.Size(956, 494);
            this.rtbMinors.TabIndex = 3;
            this.rtbMinors.Text = "";
            // 
            // tabEmployment
            // 
            this.tabEmployment.BackColor = System.Drawing.Color.DarkOrange;
            this.tabEmployment.Controls.Add(this.button17);
            this.tabEmployment.Controls.Add(this.button6);
            this.tabEmployment.Controls.Add(this.button5);
            this.tabEmployment.Controls.Add(this.dataGridView1);
            this.tabEmployment.Controls.Add(this.button4);
            this.tabEmployment.Controls.Add(this.button3);
            this.tabEmployment.Controls.Add(this.button2);
            this.tabEmployment.Controls.Add(this.button1);
            this.tabEmployment.Controls.Add(this.rtbContent);
            this.tabEmployment.Controls.Add(this.tbIntroTitle);
            this.tabEmployment.Location = new System.Drawing.Point(4, 29);
            this.tabEmployment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabEmployment.Name = "tabEmployment";
            this.tabEmployment.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabEmployment.Size = new System.Drawing.Size(1096, 602);
            this.tabEmployment.TabIndex = 3;
            this.tabEmployment.Text = "Employment";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(814, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(265, 39);
            this.button6.TabIndex = 10;
            this.button6.Text = "Employment Information";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(511, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(277, 39);
            this.button5.TabIndex = 9;
            this.button5.Text = "Coop Information";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(511, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(568, 496);
            this.dataGridView1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(377, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Careers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(245, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Employers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(92, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Degree Stats";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Intro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent.Location = new System.Drawing.Point(7, 98);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(465, 496);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            // 
            // tbIntroTitle
            // 
            this.tbIntroTitle.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIntroTitle.Location = new System.Drawing.Point(255, 11);
            this.tbIntroTitle.Name = "tbIntroTitle";
            this.tbIntroTitle.ReadOnly = true;
            this.tbIntroTitle.Size = new System.Drawing.Size(703, 42);
            this.tbIntroTitle.TabIndex = 0;
            // 
            // tabPeople
            // 
            this.tabPeople.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPeople.Controls.Add(this.textBox6);
            this.tabPeople.Controls.Add(this.rtbPeople);
            this.tabPeople.Controls.Add(this.button8);
            this.tabPeople.Controls.Add(this.button7);
            this.tabPeople.Controls.Add(this.listBox1);
            this.tabPeople.Controls.Add(this.pictureBox1);
            this.tabPeople.Location = new System.Drawing.Point(4, 29);
            this.tabPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPeople.Name = "tabPeople";
            this.tabPeople.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPeople.Size = new System.Drawing.Size(1096, 602);
            this.tabPeople.TabIndex = 4;
            this.tabPeople.Text = "People";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(124, 8);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(162, 32);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "Select a Person";
            // 
            // rtbPeople
            // 
            this.rtbPeople.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPeople.Location = new System.Drawing.Point(365, 8);
            this.rtbPeople.Name = "rtbPeople";
            this.rtbPeople.Size = new System.Drawing.Size(724, 221);
            this.rtbPeople.TabIndex = 12;
            this.rtbPeople.Text = "";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(208, 45);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(151, 39);
            this.button8.TabIndex = 11;
            this.button8.Text = "Staff";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(33, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 39);
            this.button7.TabIndex = 10;
            this.button7.Text = "Faculty";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(33, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 504);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(496, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabResearch
            // 
            this.tabResearch.BackColor = System.Drawing.Color.DarkOrange;
            this.tabResearch.Controls.Add(this.textBox5);
            this.tabResearch.Controls.Add(this.textBox4);
            this.tabResearch.Controls.Add(this.rtbResearch);
            this.tabResearch.Controls.Add(this.listBox2);
            this.tabResearch.Controls.Add(this.button10);
            this.tabResearch.Controls.Add(this.button9);
            this.tabResearch.Location = new System.Drawing.Point(4, 29);
            this.tabResearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResearch.Name = "tabResearch";
            this.tabResearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResearch.Size = new System.Drawing.Size(1096, 602);
            this.tabResearch.TabIndex = 5;
            this.tabResearch.Text = "Research";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(197, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(171, 32);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "Select Research";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(745, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(98, 32);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Citations";
            // 
            // rtbResearch
            // 
            this.rtbResearch.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResearch.Location = new System.Drawing.Point(469, 69);
            this.rtbResearch.Name = "rtbResearch";
            this.rtbResearch.Size = new System.Drawing.Size(609, 525);
            this.rtbResearch.TabIndex = 14;
            this.rtbResearch.Text = "";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(110, 150);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(326, 444);
            this.listBox2.TabIndex = 13;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged_1);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(110, 105);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(326, 39);
            this.button10.TabIndex = 12;
            this.button10.Text = "Sort by Faculty";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(110, 60);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(326, 39);
            this.button9.TabIndex = 11;
            this.button9.Text = "Sort by Interest Area";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabResources
            // 
            this.tabResources.BackColor = System.Drawing.Color.DarkOrange;
            this.tabResources.Controls.Add(this.button16);
            this.tabResources.Controls.Add(this.button15);
            this.tabResources.Controls.Add(this.button14);
            this.tabResources.Controls.Add(this.button13);
            this.tabResources.Controls.Add(this.button12);
            this.tabResources.Controls.Add(this.button11);
            this.tabResources.Controls.Add(this.rtbResources);
            this.tabResources.Controls.Add(this.tbSubtitle);
            this.tabResources.Controls.Add(this.tbTitle);
            this.tabResources.Location = new System.Drawing.Point(4, 29);
            this.tabResources.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResources.Name = "tabResources";
            this.tabResources.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResources.Size = new System.Drawing.Size(1096, 602);
            this.tabResources.TabIndex = 6;
            this.tabResources.Text = "Resources";
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(147, 531);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(184, 39);
            this.button16.TabIndex = 21;
            this.button16.Text = "Coop Enrollment";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(167, 445);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(151, 39);
            this.button15.TabIndex = 20;
            this.button15.Text = "Forms";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(122, 351);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(237, 39);
            this.button14.TabIndex = 19;
            this.button14.Text = "Student Ambassadors";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(122, 261);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(237, 39);
            this.button13.TabIndex = 18;
            this.button13.Text = "Tutors and Lab Info";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(147, 171);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(193, 39);
            this.button12.TabIndex = 17;
            this.button12.Text = "Student Services";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(167, 92);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(151, 39);
            this.button11.TabIndex = 16;
            this.button11.Text = "Study Abroad";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // rtbResources
            // 
            this.rtbResources.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResources.Location = new System.Drawing.Point(399, 79);
            this.rtbResources.Name = "rtbResources";
            this.rtbResources.Size = new System.Drawing.Size(701, 505);
            this.rtbResources.TabIndex = 15;
            this.rtbResources.Text = "";
            // 
            // tbSubtitle
            // 
            this.tbSubtitle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubtitle.Location = new System.Drawing.Point(17, 46);
            this.tbSubtitle.Name = "tbSubtitle";
            this.tbSubtitle.Size = new System.Drawing.Size(533, 27);
            this.tbSubtitle.TabIndex = 1;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(431, 8);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(201, 32);
            this.tbTitle.TabIndex = 0;
            // 
            // tabNews
            // 
            this.tabNews.BackColor = System.Drawing.Color.DarkOrange;
            this.tabNews.Controls.Add(this.rtbNews);
            this.tabNews.Location = new System.Drawing.Point(4, 29);
            this.tabNews.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNews.Name = "tabNews";
            this.tabNews.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNews.Size = new System.Drawing.Size(1096, 602);
            this.tabNews.TabIndex = 7;
            this.tabNews.Text = "News";
            // 
            // rtbNews
            // 
            this.rtbNews.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNews.Location = new System.Drawing.Point(7, 8);
            this.rtbNews.Name = "rtbNews";
            this.rtbNews.Size = new System.Drawing.Size(1082, 586);
            this.rtbNews.TabIndex = 16;
            this.rtbNews.Text = "";
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.webBrowser1);
            this.tabContact.Location = new System.Drawing.Point(4, 29);
            this.tabContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabContact.Name = "tabContact";
            this.tabContact.Size = new System.Drawing.Size(1096, 602);
            this.tabContact.TabIndex = 8;
            this.tabContact.Text = "Contact";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1096, 602);
            this.webBrowser1.TabIndex = 0;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(73, 11);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(141, 41);
            this.button17.TabIndex = 11;
            this.button17.Text = "View Map";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "C# consumes ist.rit.edu/api";
            this.tabControl1.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.tabDegrees.ResumeLayout(false);
            this.tabDegrees.PerformLayout();
            this.tabMinors.ResumeLayout(false);
            this.tabMinors.PerformLayout();
            this.tabEmployment.ResumeLayout(false);
            this.tabEmployment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPeople.ResumeLayout(false);
            this.tabPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabResearch.ResumeLayout(false);
            this.tabResearch.PerformLayout();
            this.tabResources.ResumeLayout(false);
            this.tabResources.PerformLayout();
            this.tabNews.ResumeLayout(false);
            this.tabContact.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.RichTextBox tb_aboutQuote;
        private System.Windows.Forms.RichTextBox tb_aboutDesc;
        private System.Windows.Forms.Label lbl_quoteAuthor;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TabPage tabDegrees;
        private System.Windows.Forms.TabPage tabMinors;
        private System.Windows.Forms.TabPage tabEmployment;
        private System.Windows.Forms.TabPage tabPeople;
        private System.Windows.Forms.TabPage tabResearch;
        private System.Windows.Forms.TabPage tabResources;
        private System.Windows.Forms.TabPage tabNews;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox rtbGrad;
        private System.Windows.Forms.RichTextBox rtbUndergrad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox rtbMinors;
        private System.Windows.Forms.TextBox tbIntroTitle;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RichTextBox rtbPeople;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox rtbResearch;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbSubtitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.RichTextBox rtbResources;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.RichTextBox rtbNews;
        private System.Windows.Forms.Button button17;
    }
}

