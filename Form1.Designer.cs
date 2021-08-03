
namespace BigBanTheory_Project4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exitBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.showBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // exitBtn
            // 
            this.exitBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.BorderRadius = 7;
            this.exitBtn.ButtonText = "Exit";
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.DisabledColor = System.Drawing.Color.Gray;
            this.exitBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.exitBtn.Iconimage = global::BigBanTheory_Project4.Properties.Resources.icons8_exit_100;
            this.exitBtn.Iconimage_right = null;
            this.exitBtn.Iconimage_right_Selected = null;
            this.exitBtn.Iconimage_Selected = null;
            this.exitBtn.IconMarginLeft = 15;
            this.exitBtn.IconMarginRight = 0;
            this.exitBtn.IconRightVisible = true;
            this.exitBtn.IconRightZoom = 0D;
            this.exitBtn.IconVisible = true;
            this.exitBtn.IconZoom = 90D;
            this.exitBtn.IsTab = false;
            this.exitBtn.Location = new System.Drawing.Point(56, 173);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.exitBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.exitBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.exitBtn.selected = false;
            this.exitBtn.Size = new System.Drawing.Size(232, 49);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Textcolor = System.Drawing.Color.Black;
            this.exitBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.showBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.showBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showBtn.BorderRadius = 7;
            this.showBtn.ButtonText = "Show Contact";
            this.showBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showBtn.DisabledColor = System.Drawing.Color.Gray;
            this.showBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.showBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.showBtn.Iconimage = global::BigBanTheory_Project4.Properties.Resources.icons8_new_contact_100;
            this.showBtn.Iconimage_right = null;
            this.showBtn.Iconimage_right_Selected = null;
            this.showBtn.Iconimage_Selected = null;
            this.showBtn.IconMarginLeft = 10;
            this.showBtn.IconMarginRight = 0;
            this.showBtn.IconRightVisible = true;
            this.showBtn.IconRightZoom = 0D;
            this.showBtn.IconVisible = true;
            this.showBtn.IconZoom = 90D;
            this.showBtn.IsTab = false;
            this.showBtn.Location = new System.Drawing.Point(56, 112);
            this.showBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showBtn.Name = "showBtn";
            this.showBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.showBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.showBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.showBtn.selected = false;
            this.showBtn.Size = new System.Drawing.Size(232, 49);
            this.showBtn.TabIndex = 4;
            this.showBtn.Text = "Show Contact";
            this.showBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showBtn.Textcolor = System.Drawing.Color.White;
            this.showBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.BorderRadius = 7;
            this.addBtn.ButtonText = "Add Contact";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addBtn.Iconimage = global::BigBanTheory_Project4.Properties.Resources.icons8_add_male_user_100;
            this.addBtn.Iconimage_right = null;
            this.addBtn.Iconimage_right_Selected = null;
            this.addBtn.Iconimage_Selected = null;
            this.addBtn.IconMarginLeft = 7;
            this.addBtn.IconMarginRight = 0;
            this.addBtn.IconRightVisible = true;
            this.addBtn.IconRightZoom = 0D;
            this.addBtn.IconVisible = true;
            this.addBtn.IconZoom = 90D;
            this.addBtn.IsTab = true;
            this.addBtn.Location = new System.Drawing.Point(56, 50);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.addBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.addBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addBtn.selected = false;
            this.addBtn.Size = new System.Drawing.Size(232, 49);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Contact";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Textcolor = System.Drawing.Color.Black;
            this.addBtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(345, 273);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton exitBtn;
        private Bunifu.Framework.UI.BunifuFlatButton showBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addBtn;
    }
}

