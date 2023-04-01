namespace valo_auto_instalock
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addProfile = new System.Windows.Forms.GroupBox();
            this.txtButtonName = new System.Windows.Forms.TextBox();
            this.txtLY = new System.Windows.Forms.TextBox();
            this.lblLY = new System.Windows.Forms.Label();
            this.txtLX = new System.Windows.Forms.TextBox();
            this.lblLX = new System.Windows.Forms.Label();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.txtPY = new System.Windows.Forms.TextBox();
            this.txtPX = new System.Windows.Forms.TextBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblPY = new System.Windows.Forms.Label();
            this.lblPX = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.coorAndLang = new System.Windows.Forms.GroupBox();
            this.btnChangeLanguage = new System.Windows.Forms.Button();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.IY = new System.Windows.Forms.TextBox();
            this.IX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profiles = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.addProfile.SuspendLayout();
            this.coorAndLang.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addProfile
            // 
            this.addProfile.Controls.Add(this.txtButtonName);
            this.addProfile.Controls.Add(this.txtLY);
            this.addProfile.Controls.Add(this.lblLY);
            this.addProfile.Controls.Add(this.txtLX);
            this.addProfile.Controls.Add(this.lblLX);
            this.addProfile.Controls.Add(this.btnSaveProfile);
            this.addProfile.Controls.Add(this.txtPY);
            this.addProfile.Controls.Add(this.txtPX);
            this.addProfile.Controls.Add(this.txtProfileName);
            this.addProfile.Controls.Add(this.lblPY);
            this.addProfile.Controls.Add(this.lblPX);
            this.addProfile.Controls.Add(this.lblName);
            this.addProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProfile.Location = new System.Drawing.Point(12, 38);
            this.addProfile.Name = "addProfile";
            this.addProfile.Size = new System.Drawing.Size(410, 219);
            this.addProfile.TabIndex = 4;
            this.addProfile.TabStop = false;
            this.addProfile.Text = "Profil Ekle";
            // 
            // txtButtonName
            // 
            this.txtButtonName.Location = new System.Drawing.Point(32, 184);
            this.txtButtonName.Name = "txtButtonName";
            this.txtButtonName.Size = new System.Drawing.Size(100, 26);
            this.txtButtonName.TabIndex = 15;
            this.txtButtonName.Visible = false;
            // 
            // txtLY
            // 
            this.txtLY.Location = new System.Drawing.Point(189, 153);
            this.txtLY.MaxLength = 4;
            this.txtLY.Name = "txtLY";
            this.txtLY.Size = new System.Drawing.Size(213, 26);
            this.txtLY.TabIndex = 14;
            // 
            // lblLY
            // 
            this.lblLY.AutoSize = true;
            this.lblLY.Location = new System.Drawing.Point(32, 153);
            this.lblLY.Name = "lblLY";
            this.lblLY.Size = new System.Drawing.Size(134, 20);
            this.lblLY.TabIndex = 13;
            this.lblLY.Text = "Son Y koordinatı :";
            // 
            // txtLX
            // 
            this.txtLX.Location = new System.Drawing.Point(189, 121);
            this.txtLX.MaxLength = 4;
            this.txtLX.Name = "txtLX";
            this.txtLX.Size = new System.Drawing.Size(213, 26);
            this.txtLX.TabIndex = 12;
            // 
            // lblLX
            // 
            this.lblLX.AutoSize = true;
            this.lblLX.Location = new System.Drawing.Point(32, 124);
            this.lblLX.Name = "lblLX";
            this.lblLX.Size = new System.Drawing.Size(134, 20);
            this.lblLX.TabIndex = 11;
            this.lblLX.Text = "Son X koordinatı :";
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(189, 182);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(213, 31);
            this.btnSaveProfile.TabIndex = 10;
            this.btnSaveProfile.Text = "Kaydet";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.txtSaveProfile_Click);
            // 
            // txtPY
            // 
            this.txtPY.Location = new System.Drawing.Point(191, 89);
            this.txtPY.MaxLength = 4;
            this.txtPY.Name = "txtPY";
            this.txtPY.Size = new System.Drawing.Size(211, 26);
            this.txtPY.TabIndex = 9;
            // 
            // txtPX
            // 
            this.txtPX.Location = new System.Drawing.Point(191, 57);
            this.txtPX.MaxLength = 4;
            this.txtPX.Name = "txtPX";
            this.txtPX.Size = new System.Drawing.Size(211, 26);
            this.txtPX.TabIndex = 8;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(191, 25);
            this.txtProfileName.MaxLength = 22;
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(211, 26);
            this.txtProfileName.TabIndex = 5;
            // 
            // lblPY
            // 
            this.lblPY.AutoSize = true;
            this.lblPY.Location = new System.Drawing.Point(45, 92);
            this.lblPY.Name = "lblPY";
            this.lblPY.Size = new System.Drawing.Size(121, 20);
            this.lblPY.TabIndex = 7;
            this.lblPY.Text = "İlk Y koordinatı :";
            // 
            // lblPX
            // 
            this.lblPX.AutoSize = true;
            this.lblPX.Location = new System.Drawing.Point(45, 57);
            this.lblPX.Name = "lblPX";
            this.lblPX.Size = new System.Drawing.Size(121, 20);
            this.lblPX.TabIndex = 6;
            this.lblPX.Text = "İlk X koordinatı :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Profil adı :";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(542, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.Location = new System.Drawing.Point(506, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // coorAndLang
            // 
            this.coorAndLang.Controls.Add(this.btnChangeLanguage);
            this.coorAndLang.Controls.Add(this.cmbLanguage);
            this.coorAndLang.Controls.Add(this.IY);
            this.coorAndLang.Controls.Add(this.IX);
            this.coorAndLang.Controls.Add(this.label2);
            this.coorAndLang.Controls.Add(this.label1);
            this.coorAndLang.Location = new System.Drawing.Point(429, 38);
            this.coorAndLang.Name = "coorAndLang";
            this.coorAndLang.Size = new System.Drawing.Size(143, 219);
            this.coorAndLang.TabIndex = 10;
            this.coorAndLang.TabStop = false;
            this.coorAndLang.Text = "Koordinat ve Dil";
            // 
            // btnChangeLanguage
            // 
            this.btnChangeLanguage.Location = new System.Drawing.Point(10, 182);
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Size = new System.Drawing.Size(121, 30);
            this.btnChangeLanguage.TabIndex = 9;
            this.btnChangeLanguage.Text = "Onayla";
            this.btnChangeLanguage.UseVisualStyleBackColor = true;
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Türkçe",
            "English"});
            this.cmbLanguage.Location = new System.Drawing.Point(10, 147);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 28);
            this.cmbLanguage.TabIndex = 8;
            // 
            // IY
            // 
            this.IY.Enabled = false;
            this.IY.Location = new System.Drawing.Point(32, 61);
            this.IY.Name = "IY";
            this.IY.Size = new System.Drawing.Size(95, 26);
            this.IY.TabIndex = 7;
            // 
            // IX
            // 
            this.IX.Enabled = false;
            this.IX.Location = new System.Drawing.Point(32, 25);
            this.IX.Name = "IX";
            this.IX.Size = new System.Drawing.Size(95, 26);
            this.IX.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.silToolStripMenuItem.Text = "Sil/Delete";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // profiles
            // 
            this.profiles.AutoScroll = true;
            this.profiles.ContextMenuStrip = this.contextMenuStrip1;
            this.profiles.Location = new System.Drawing.Point(12, 264);
            this.profiles.Name = "profiles";
            this.profiles.Size = new System.Drawing.Size(560, 270);
            this.profiles.TabIndex = 12;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 546);
            this.Controls.Add(this.profiles);
            this.Controls.Add(this.coorAndLang);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.addProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addProfile.ResumeLayout(false);
            this.addProfile.PerformLayout();
            this.coorAndLang.ResumeLayout(false);
            this.coorAndLang.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox addProfile;
        private System.Windows.Forms.TextBox txtPY;
        private System.Windows.Forms.TextBox txtPX;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblPY;
        private System.Windows.Forms.Label lblPX;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.TextBox txtLY;
        private System.Windows.Forms.Label lblLY;
        private System.Windows.Forms.TextBox txtLX;
        private System.Windows.Forms.Label lblLX;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.GroupBox coorAndLang;
        private System.Windows.Forms.Button btnChangeLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.TextBox IY;
        private System.Windows.Forms.TextBox IX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Panel profiles;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtButtonName;
    }
}

