namespace UI
{
    partial class Регистрация
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbltext = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.login_txt = new System.Windows.Forms.TextBox();
			this.password_txt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.password1_txt = new System.Windows.Forms.TextBox();
			this.but_registr = new System.Windows.Forms.Button();
			this.notadmin = new System.Windows.Forms.RadioButton();
			this.admin = new System.Windows.Forms.RadioButton();
			this.admin_txt = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.lbltext);
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 128);
			this.panel1.TabIndex = 9;
			// 
			// lbltext
			// 
			this.lbltext.AutoSize = true;
			this.lbltext.Font = new System.Drawing.Font("Segoe Print", 26.25F);
			this.lbltext.ForeColor = System.Drawing.Color.White;
			this.lbltext.Location = new System.Drawing.Point(26, 16);
			this.lbltext.Name = "lbltext";
			this.lbltext.Size = new System.Drawing.Size(267, 61);
			this.lbltext.TabIndex = 1;
			this.lbltext.Text = "Регистрация";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 181);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Пароль";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Логин";
			// 
			// login_txt
			// 
			this.login_txt.Location = new System.Drawing.Point(12, 158);
			this.login_txt.Name = "login_txt";
			this.login_txt.Size = new System.Drawing.Size(100, 20);
			this.login_txt.TabIndex = 6;
			// 
			// password_txt
			// 
			this.password_txt.Location = new System.Drawing.Point(12, 197);
			this.password_txt.Name = "password_txt";
			this.password_txt.Size = new System.Drawing.Size(100, 20);
			this.password_txt.TabIndex = 5;
			this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 227);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Повторите пароль";
			// 
			// password1_txt
			// 
			this.password1_txt.Location = new System.Drawing.Point(12, 243);
			this.password1_txt.Name = "password1_txt";
			this.password1_txt.Size = new System.Drawing.Size(100, 20);
			this.password1_txt.TabIndex = 10;
			// 
			// but_registr
			// 
			this.but_registr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.but_registr.Location = new System.Drawing.Point(219, 462);
			this.but_registr.Name = "but_registr";
			this.but_registr.Size = new System.Drawing.Size(95, 23);
			this.but_registr.TabIndex = 12;
			this.but_registr.Text = "Регистрация";
			this.but_registr.UseVisualStyleBackColor = false;
			this.but_registr.Click += new System.EventHandler(this.but_registr_Click);
			// 
			// notadmin
			// 
			this.notadmin.AutoSize = true;
			this.notadmin.Location = new System.Drawing.Point(15, 291);
			this.notadmin.Name = "notadmin";
			this.notadmin.Size = new System.Drawing.Size(62, 17);
			this.notadmin.TabIndex = 13;
			this.notadmin.TabStop = true;
			this.notadmin.Text = "Ученик";
			this.notadmin.UseVisualStyleBackColor = true;
			this.notadmin.CheckedChanged += new System.EventHandler(this.notadmin_CheckedChanged);
			// 
			// admin
			// 
			this.admin.AutoSize = true;
			this.admin.Location = new System.Drawing.Point(146, 291);
			this.admin.Name = "admin";
			this.admin.Size = new System.Drawing.Size(67, 17);
			this.admin.TabIndex = 14;
			this.admin.TabStop = true;
			this.admin.Text = "Учитель";
			this.admin.UseVisualStyleBackColor = true;
			this.admin.CheckedChanged += new System.EventHandler(this.admin_CheckedChanged);
			// 
			// admin_txt
			// 
			this.admin_txt.Enabled = false;
			this.admin_txt.Location = new System.Drawing.Point(146, 315);
			this.admin_txt.Name = "admin_txt";
			this.admin_txt.Size = new System.Drawing.Size(100, 20);
			this.admin_txt.TabIndex = 15;
			this.admin_txt.TextChanged += new System.EventHandler(this.admin_txt_TextChanged);
			// 
			// Регистрация
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 497);
			this.Controls.Add(this.admin_txt);
			this.Controls.Add(this.admin);
			this.Controls.Add(this.notadmin);
			this.Controls.Add(this.but_registr);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.password1_txt);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.login_txt);
			this.Controls.Add(this.password_txt);
			this.Name = "Регистрация";
			this.Text = "reg";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password1_txt;
        private System.Windows.Forms.Button but_registr;
        private System.Windows.Forms.RadioButton notadmin;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.TextBox admin_txt;
    }
}