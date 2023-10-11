namespace UI
{
    partial class Вход
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
			this.password_txt = new System.Windows.Forms.TextBox();
			this.login_txt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbltext = new System.Windows.Forms.Label();
			this.button_login = new System.Windows.Forms.Button();
			this.but_registr = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// password_txt
			// 
			this.password_txt.Location = new System.Drawing.Point(12, 239);
			this.password_txt.Name = "password_txt";
			this.password_txt.Size = new System.Drawing.Size(100, 20);
			this.password_txt.TabIndex = 0;
			// 
			// login_txt
			// 
			this.login_txt.Location = new System.Drawing.Point(12, 175);
			this.login_txt.Name = "login_txt";
			this.login_txt.Size = new System.Drawing.Size(100, 20);
			this.login_txt.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Логин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 211);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пароль";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.lbltext);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 128);
			this.panel1.TabIndex = 4;
			// 
			// lbltext
			// 
			this.lbltext.AutoSize = true;
			this.lbltext.Font = new System.Drawing.Font("Segoe Print", 26.25F);
			this.lbltext.ForeColor = System.Drawing.Color.White;
			this.lbltext.Location = new System.Drawing.Point(26, 9);
			this.lbltext.Name = "lbltext";
			this.lbltext.Size = new System.Drawing.Size(274, 61);
			this.lbltext.TabIndex = 1;
			this.lbltext.Text = "Авторизация";
			// 
			// button_login
			// 
			this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.button_login.Location = new System.Drawing.Point(241, 393);
			this.button_login.Name = "button_login";
			this.button_login.Size = new System.Drawing.Size(75, 23);
			this.button_login.TabIndex = 5;
			this.button_login.Text = "Войти";
			this.button_login.UseVisualStyleBackColor = false;
			this.button_login.Click += new System.EventHandler(this.button_login_Click);
			// 
			// but_registr
			// 
			this.but_registr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.but_registr.Location = new System.Drawing.Point(12, 393);
			this.but_registr.Name = "but_registr";
			this.but_registr.Size = new System.Drawing.Size(95, 23);
			this.but_registr.TabIndex = 6;
			this.but_registr.Text = "Регистрация";
			this.but_registr.UseVisualStyleBackColor = false;
			this.but_registr.Click += new System.EventHandler(this.but_registr_Click);
			// 
			// Вход
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 428);
			this.Controls.Add(this.but_registr);
			this.Controls.Add(this.button_login);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.login_txt);
			this.Controls.Add(this.password_txt);
			this.Name = "Вход";
			this.Text = "auth";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button but_registr;
    }
}