using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UI
{
    
    public partial class Вход : Form
    {
        Регистрация regi;
        public bool i = false;
        public int b = 0;
        public Вход()
        {
            InitializeComponent();
            regi = new Регистрация();
        }
        
        private void button_login_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1");
            for (int t = 0; t < 2; t++)
            {
                
                string sql = "SELECT * FROM registr  WHERE login=@login and password=@password and admin=@admin  ";
                MySqlConnection connection = DBauth.GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_txt.Text;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_txt.Text;
                cmd.Parameters.Add("@admin", MySqlDbType.VarChar).Value = t.ToString();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    {
                        if (t == 1) { b = 1; Console.WriteLine("Вы админ"); }

                        else  { b = 2; }
                    }
                }
 
            }
            if (b == 1 | b ==2)
            {
                MessageBox.Show("Вы успешно вошли!");
                i = true;
                Close();
            }
            else if(b==0){ MessageBox.Show("Неверный логин или пароль"); }
        }
        private void but_registr_Click(object sender, EventArgs e)
        {
            regi.ShowDialog();
        }
    }
}
