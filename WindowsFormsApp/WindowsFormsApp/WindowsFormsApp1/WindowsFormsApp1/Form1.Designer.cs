namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.combCity = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.gbFruits = new System.Windows.Forms.GroupBox();
            this.cbFruitO = new System.Windows.Forms.CheckBox();
            this.cbFruitM = new System.Windows.Forms.CheckBox();
            this.cbFruitB = new System.Windows.Forms.CheckBox();
            this.pnGender = new System.Windows.Forms.Panel();
            this.rbGenderO = new System.Windows.Forms.RadioButton();
            this.rbGenderF = new System.Windows.Forms.RadioButton();
            this.rbGenderM = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.rtAdress = new System.Windows.Forms.RichTextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblWeb = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.linkWeb = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbFruits.SuspendLayout();
            this.pnGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(23, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // combCity
            // 
            this.combCity.FormattingEnabled = true;
            this.combCity.Location = new System.Drawing.Point(23, 140);
            this.combCity.Name = "combCity";
            this.combCity.Size = new System.Drawing.Size(144, 21);
            this.combCity.TabIndex = 1;
            this.combCity.SelectedIndexChanged += new System.EventHandler(this.combCity_SelectedIndexChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 56);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Enter Name Below :";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 124);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(69, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Choose City :";
            // 
            // gbFruits
            // 
            this.gbFruits.Controls.Add(this.cbFruitO);
            this.gbFruits.Controls.Add(this.cbFruitM);
            this.gbFruits.Controls.Add(this.cbFruitB);
            this.gbFruits.Location = new System.Drawing.Point(310, 61);
            this.gbFruits.Name = "gbFruits";
            this.gbFruits.Size = new System.Drawing.Size(139, 100);
            this.gbFruits.TabIndex = 4;
            this.gbFruits.TabStop = false;
            this.gbFruits.Text = "Select Fruit";
            // 
            // cbFruitO
            // 
            this.cbFruitO.AutoSize = true;
            this.cbFruitO.Location = new System.Drawing.Point(22, 67);
            this.cbFruitO.Name = "cbFruitO";
            this.cbFruitO.Size = new System.Drawing.Size(61, 17);
            this.cbFruitO.TabIndex = 2;
            this.cbFruitO.Text = "Orange";
            this.cbFruitO.UseVisualStyleBackColor = true;
            // 
            // cbFruitM
            // 
            this.cbFruitM.AutoSize = true;
            this.cbFruitM.Location = new System.Drawing.Point(22, 43);
            this.cbFruitM.Name = "cbFruitM";
            this.cbFruitM.Size = new System.Drawing.Size(59, 17);
            this.cbFruitM.TabIndex = 1;
            this.cbFruitM.Text = "Mango";
            this.cbFruitM.UseVisualStyleBackColor = true;
            // 
            // cbFruitB
            // 
            this.cbFruitB.AutoSize = true;
            this.cbFruitB.Location = new System.Drawing.Point(22, 19);
            this.cbFruitB.Name = "cbFruitB";
            this.cbFruitB.Size = new System.Drawing.Size(63, 17);
            this.cbFruitB.TabIndex = 0;
            this.cbFruitB.Text = "Banana";
            this.cbFruitB.UseVisualStyleBackColor = true;
            // 
            // pnGender
            // 
            this.pnGender.Controls.Add(this.rbGenderO);
            this.pnGender.Controls.Add(this.rbGenderF);
            this.pnGender.Controls.Add(this.rbGenderM);
            this.pnGender.Controls.Add(this.lblGender);
            this.pnGender.Location = new System.Drawing.Point(310, 208);
            this.pnGender.Name = "pnGender";
            this.pnGender.Size = new System.Drawing.Size(139, 128);
            this.pnGender.TabIndex = 5;
            this.pnGender.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbGenderO
            // 
            this.rbGenderO.AutoSize = true;
            this.rbGenderO.Location = new System.Drawing.Point(22, 95);
            this.rbGenderO.Name = "rbGenderO";
            this.rbGenderO.Size = new System.Drawing.Size(51, 17);
            this.rbGenderO.TabIndex = 3;
            this.rbGenderO.TabStop = true;
            this.rbGenderO.Text = "Other";
            this.rbGenderO.UseVisualStyleBackColor = true;
            // 
            // rbGenderF
            // 
            this.rbGenderF.AutoSize = true;
            this.rbGenderF.Location = new System.Drawing.Point(22, 72);
            this.rbGenderF.Name = "rbGenderF";
            this.rbGenderF.Size = new System.Drawing.Size(59, 17);
            this.rbGenderF.TabIndex = 2;
            this.rbGenderF.TabStop = true;
            this.rbGenderF.Text = "Female";
            this.rbGenderF.UseVisualStyleBackColor = true;
            // 
            // rbGenderM
            // 
            this.rbGenderM.AutoSize = true;
            this.rbGenderM.Location = new System.Drawing.Point(22, 49);
            this.rbGenderM.Name = "rbGenderM";
            this.rbGenderM.Size = new System.Drawing.Size(48, 17);
            this.rbGenderM.TabIndex = 1;
            this.rbGenderM.TabStop = true;
            this.rbGenderM.Text = "Male";
            this.rbGenderM.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(22, 13);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(81, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Choose Gender";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(20, 190);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(73, 13);
            this.lblAdress.TabIndex = 6;
            this.lblAdress.Text = "Enter Address";
            // 
            // rtAdress
            // 
            this.rtAdress.Location = new System.Drawing.Point(23, 226);
            this.rtAdress.Name = "rtAdress";
            this.rtAdress.Size = new System.Drawing.Size(144, 96);
            this.rtAdress.TabIndex = 7;
            this.rtAdress.Text = "";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(24, 360);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(61, 13);
            this.lbldate.TabIndex = 8;
            this.lbldate.Text = "Enter DOB.";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(27, 393);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(141, 20);
            this.dtDate.TabIndex = 9;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(307, 360);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(49, 13);
            this.lblWeb.TabIndex = 10;
            this.lblWeb.Text = "Website:";
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(206, 476);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 11;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // linkWeb
            // 
            this.linkWeb.AutoSize = true;
            this.linkWeb.Location = new System.Drawing.Point(313, 393);
            this.linkWeb.Name = "linkWeb";
            this.linkWeb.Size = new System.Drawing.Size(136, 13);
            this.linkWeb.TabIndex = 12;
            this.linkWeb.TabStop = true;
            this.linkWeb.Text = "www.belgiumcampus.ac.za";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 229);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkWeb);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.lblWeb);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.rtAdress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.pnGender);
            this.Controls.Add(this.gbFruits);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.combCity);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFruits.ResumeLayout(false);
            this.gbFruits.PerformLayout();
            this.pnGender.ResumeLayout(false);
            this.pnGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox combCity;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.GroupBox gbFruits;
        private System.Windows.Forms.CheckBox cbFruitO;
        private System.Windows.Forms.CheckBox cbFruitM;
        private System.Windows.Forms.CheckBox cbFruitB;
        private System.Windows.Forms.Panel pnGender;
        private System.Windows.Forms.RadioButton rbGenderO;
        private System.Windows.Forms.RadioButton rbGenderF;
        private System.Windows.Forms.RadioButton rbGenderM;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.RichTextBox rtAdress;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.LinkLabel linkWeb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

