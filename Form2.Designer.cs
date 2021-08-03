
namespace BigBanTheory_Project4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.nameBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.middleBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.numBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addressBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.changeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.backBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.saveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // nameBox
            // 
            this.nameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.nameBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameBox.HintText = "ex: Piotr";
            this.nameBox.isPassword = false;
            this.nameBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.nameBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.nameBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nameBox.LineThickness = 4;
            this.nameBox.Location = new System.Drawing.Point(186, 50);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(203, 33);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(87, 64);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 19);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Name:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(93, 161);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(56, 19);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Email:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(55, 111);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(94, 19);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Last Name:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(19, 214);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(130, 19);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Phone Number:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(75, 264);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(74, 19);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "Address:";
            // 
            // middleBox
            // 
            this.middleBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.middleBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.middleBox.HintForeColor = System.Drawing.Color.White;
            this.middleBox.HintText = "ex: piotr.j@gmail.com";
            this.middleBox.isPassword = false;
            this.middleBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.middleBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.middleBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.middleBox.LineThickness = 4;
            this.middleBox.Location = new System.Drawing.Point(186, 147);
            this.middleBox.Margin = new System.Windows.Forms.Padding(4);
            this.middleBox.Name = "middleBox";
            this.middleBox.Size = new System.Drawing.Size(203, 33);
            this.middleBox.TabIndex = 3;
            this.middleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lastBox
            // 
            this.lastBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lastBox.HintForeColor = System.Drawing.Color.White;
            this.lastBox.HintText = "ex: Lewandowski";
            this.lastBox.isPassword = false;
            this.lastBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.lastBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lastBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lastBox.LineThickness = 4;
            this.lastBox.Location = new System.Drawing.Point(186, 97);
            this.lastBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(203, 33);
            this.lastBox.TabIndex = 2;
            this.lastBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numBox
            // 
            this.numBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.numBox.HintForeColor = System.Drawing.Color.White;
            this.numBox.HintText = "ex: +48 564 321 965 ";
            this.numBox.isPassword = false;
            this.numBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.numBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.numBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.numBox.LineThickness = 4;
            this.numBox.Location = new System.Drawing.Point(186, 197);
            this.numBox.Margin = new System.Windows.Forms.Padding(4);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(203, 33);
            this.numBox.TabIndex = 4;
            this.numBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addressBox
            // 
            this.addressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.addressBox.HintForeColor = System.Drawing.Color.White;
            this.addressBox.HintText = "ex: Stoklosy 2";
            this.addressBox.isPassword = false;
            this.addressBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.addressBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.addressBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.addressBox.LineThickness = 4;
            this.addressBox.Location = new System.Drawing.Point(186, 250);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(203, 33);
            this.addressBox.TabIndex = 5;
            this.addressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(396, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(396, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(396, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(396, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(253, 372);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "\'*\'  required fields";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(396, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "*";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.male.Location = new System.Drawing.Point(186, 311);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(57, 21);
            this.male.TabIndex = 20;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.female.Location = new System.Drawing.Point(319, 311);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(73, 21);
            this.female.TabIndex = 21;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // changeBtn
            // 
            this.changeBtn.ActiveBorderThickness = 1;
            this.changeBtn.ActiveCornerRadius = 20;
            this.changeBtn.ActiveFillColor = System.Drawing.Color.Gray;
            this.changeBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.changeBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.changeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.changeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeBtn.BackgroundImage")));
            this.changeBtn.ButtonText = "Edit";
            this.changeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.changeBtn.IdleBorderThickness = 2;
            this.changeBtn.IdleCornerRadius = 20;
            this.changeBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.changeBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.changeBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.changeBtn.Location = new System.Drawing.Point(484, 198);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(147, 60);
            this.changeBtn.TabIndex = 6;
            this.changeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click_1);
            // 
            // backBtn
            // 
            this.backBtn.ActiveBorderThickness = 1;
            this.backBtn.ActiveCornerRadius = 20;
            this.backBtn.ActiveFillColor = System.Drawing.Color.Gray;
            this.backBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.backBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.ButtonText = "Back";
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.backBtn.IdleBorderThickness = 2;
            this.backBtn.IdleCornerRadius = 20;
            this.backBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.backBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.backBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.backBtn.Location = new System.Drawing.Point(59, 336);
            this.backBtn.Margin = new System.Windows.Forms.Padding(5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(147, 60);
            this.backBtn.TabIndex = 7;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.ActiveBorderThickness = 1;
            this.saveBtn.ActiveCornerRadius = 20;
            this.saveBtn.ActiveFillColor = System.Drawing.Color.Gray;
            this.saveBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.saveBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.ButtonText = "Save";
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.saveBtn.IdleBorderThickness = 2;
            this.saveBtn.IdleCornerRadius = 20;
            this.saveBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.saveBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.saveBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.saveBtn.Location = new System.Drawing.Point(484, 336);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(147, 60);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BigBanTheory_Project4.Properties.Resources.icons8_person_100__1_;
            this.pictureBox1.Location = new System.Drawing.Point(495, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(396, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "*";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.path.Location = new System.Drawing.Point(451, 283);
            this.path.Name = "path";
            this.path.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.path.Size = new System.Drawing.Size(0, 24);
            this.path.TabIndex = 23;
            this.path.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(687, 441);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.middleBox);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox numBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox middleBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 changeBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 backBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 saveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label path;
    }
}