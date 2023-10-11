namespace UI
{
    partial class Insertframe
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
            this.nam = new System.Windows.Forms.TextBox();
            this.surnam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rei = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.typ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.insertinto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lbltext);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 163);
            this.panel1.TabIndex = 0;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Segoe Print", 26.25F);
            this.lbltext.ForeColor = System.Drawing.Color.White;
            this.lbltext.Location = new System.Drawing.Point(45, 9);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(448, 61);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Добавление участника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // nam
            // 
            this.nam.Location = new System.Drawing.Point(25, 192);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(100, 20);
            this.nam.TabIndex = 2;
            // 
            // surnam
            // 
            this.surnam.Location = new System.Drawing.Point(25, 242);
            this.surnam.Name = "surnam";
            this.surnam.Size = new System.Drawing.Size(100, 20);
            this.surnam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // zva
            // 
            this.zva.Location = new System.Drawing.Point(25, 340);
            this.zva.Name = "zva";
            this.zva.Size = new System.Drawing.Size(100, 20);
            this.zva.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Звание";
            // 
            // rei
            // 
            this.rei.Location = new System.Drawing.Point(25, 290);
            this.rei.Name = "rei";
            this.rei.Size = new System.Drawing.Size(100, 20);
            this.rei.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Рейтинг";
            // 
            // sta
            // 
            this.sta.Location = new System.Drawing.Point(25, 436);
            this.sta.Name = "sta";
            this.sta.Size = new System.Drawing.Size(100, 20);
            this.sta.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Статистика";
            // 
            // typ
            // 
            this.typ.Location = new System.Drawing.Point(25, 386);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(100, 20);
            this.typ.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Тип";
            // 
            // insertinto
            // 
            this.insertinto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.insertinto.Location = new System.Drawing.Point(389, 517);
            this.insertinto.Name = "insertinto";
            this.insertinto.Size = new System.Drawing.Size(132, 23);
            this.insertinto.TabIndex = 13;
            this.insertinto.Text = "Добавление участника";
            this.insertinto.UseVisualStyleBackColor = false;
            this.insertinto.Click += new System.EventHandler(this.insertinto_Click);
            // 
            // Insertframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 552);
            this.Controls.Add(this.insertinto);
            this.Controls.Add(this.sta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rei);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surnam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Insertframe";
            this.Text = "Добавление участника";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nam;
        private System.Windows.Forms.TextBox surnam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rei;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox typ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button insertinto;
    }
}