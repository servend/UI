using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class DBtur
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gur";
            MySqlConnection connection = new MySqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("MySQL connection! \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
        public static void insert(tur std)
        {
            string sql = "INSERT INTO turtable VALUES(@ID,@name,@surname,@reit,@zvan,@type,@stat,@itog)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = std.ID;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = std.Tur1;
            cmd.Parameters.Add("@reit", MySqlDbType.VarChar).Value = std.Tur2;
            cmd.Parameters.Add("@zvan", MySqlDbType.VarChar).Value = std.Tur3;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = std.Tur4;
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = std.Final;
            cmd.Parameters.Add("@itog", MySqlDbType.VarChar).Value = std.Itog;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Участник добавлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Участник не добавлен. \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        public static void update(tur std, string id)
        {
            string sql = "UPDATE turtable SET Имя=@name,тур1=@surname,тур2=@reit,тур3=@zvan,тур4=@type,финал=@stat,Итоговыйрейтинг=@itog WHERE ID=@id";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = std.Tur1;
            cmd.Parameters.Add("@reit", MySqlDbType.VarChar).Value = std.Tur2;
            cmd.Parameters.Add("@zvan", MySqlDbType.VarChar).Value = std.Tur3;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = std.Tur4;
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = std.Final;
            cmd.Parameters.Add("@itog", MySqlDbType.VarChar).Value = std.Itog;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Участник обновлен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Участник не обновлен. \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void delete(string id)
        {
            string sql = "DELETE FROM turtable WHERE ID = @id";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int64).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Участник удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Участник не удален. \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        public static void displaysearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            connection.Close();
        }
    }





















}

