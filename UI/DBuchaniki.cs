using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace UI
{
     class DBuchaniki
    {
       
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gur";
            MySqlConnection connection = new MySqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine("MySQL connection! \n"+ex.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return connection;
        }
        public static void insert(uchaniki std)
        {
            string sql = "INSERT INTO uchast VALUES(NULL,@name,@surname,@reit,@zvan,@type,@stat)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql,connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@name",MySqlDbType.VarChar).Value= std.Name;
            cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = std.Surname;
            cmd.Parameters.Add("@reit", MySqlDbType.VarChar).Value = std.Reit;
            cmd.Parameters.Add("@zvan", MySqlDbType.VarChar).Value = std.Zvan;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = std.Type;
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = std.Stat;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Участник добавлен.","Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(MySqlException ex) {
                Console.WriteLine("Участник не добавлен. \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        public static void update(uchaniki std,string id)
        {
            string sql = "UPDATE uchast SET Имя=@name,Фамилия=@surname,Рейтинг=@reit,Звание=@zvan,Тип=@type,Статистика=@stat WHERE ID=@id";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = std.Surname;
            cmd.Parameters.Add("@reit", MySqlDbType.Int16).Value = Convert.ToInt16(std.Reit);
            cmd.Parameters.Add("@zvan", MySqlDbType.VarChar).Value = std.Zvan;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = std.Type;
            cmd.Parameters.Add("@stat", MySqlDbType.VarChar).Value = std.Stat;
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
            string sql = "DELETE FROM uchast WHERE ID = @id";
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
       public static void displaysearch(string query,DataGridView dgv)
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
