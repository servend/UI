using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UI
{
    public partial class Регистрация : Form
    {

        public Регистрация()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            login_txt.Text = password_txt.Text = admin_txt.Text = string.Empty;
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_registr_Click(object sender, EventArgs e)
        {
                if (password1_txt.Text == password_txt.Text) {
                    string sql = "INSERT INTO registr VALUES(@login,@password,@admin)";
                    MySqlConnection connection = DBauth.GetConnection();
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_txt.Text;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_txt.Text;
                    try
                    {
                        if (admin_txt.Text == "3435" & admin.Checked == true)
                        {
                            cmd.Parameters.Add("@admin", MySqlDbType.VarChar).Value = "1";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Вы зарегистрированы.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            Close();
                        }
                        else if (admin_txt.Text != "3435" & admin.Checked == true)
                        {
                            MessageBox.Show("Неправильный админский пароль");
                        }
                        else if (admin.Checked == false & notadmin.Checked == true)
                        {
                            cmd.Parameters.Add("@admin", MySqlDbType.VarChar).Value = "0";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Вы зарегистрированы.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                    catch (MySqlException ex)
                    {
                     MessageBox.Show("Вы не зарегистрированы. \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                    connection.Close();
                }
                else { MessageBox.Show("Пароли не совпадают"); }
            }


            private void admin_CheckedChanged(object sender, EventArgs e)
            {
                if (notadmin.Checked == true)
                {
                    admin.Checked = false;
                }
                else
                {
                    admin_txt.Enabled = true;
                }

            }

            private void notadmin_CheckedChanged(object sender, EventArgs e)
            {
                if (admin.Checked == true)
                {
                    notadmin.Checked = false;
                }
                else
                {
                    admin_txt.Enabled = false;
                }
            }

            private void admin_txt_TextChanged(object sender, EventArgs e)
            {

            }
        }
    } 
