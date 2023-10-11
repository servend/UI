using System;
using System.Windows.Forms;
namespace UI
{
    public partial class UI : Form
    {
        Insertframe form;
        Регистрация_на_турнир form1;
        Вход author;
        public UI()
        {
            InitializeComponent();
            form = new Insertframe(this);
            form1 = new Регистрация_на_турнир(this);
            author= new Вход();
        }

       public void display()
        {
           DBuchaniki.displaysearch("SELECT ID,Имя,Фамилия,Рейтинг,Звание,Тип,Статистика FROM uchast", dataGridView);
        }
        public void displaytur()
        {
            DBtur.displaysearch("SELECT ID,Имя,тур1,тур2,тур3,тур4,Финал,Итоговыйрейтинг FROM turtable", dataGridView1);
        }
        public void displayitog()
        {
            DBuchaniki.displaysearch("SELECT uchast.ID, uchast.Имя,uchast.Рейтинг, turtable.Итоговыйрейтинг,uchast.Звание,uchast.Тип FROM uchast INNER JOIN turtable ON turtable.ID=uchast.ID", dataGridView3);
        }
        private void insert_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }
  
        private void UI_Load(object sender, EventArgs e)
        {
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 0)
            {
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.surname = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.reit = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
                form.zvan = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.type = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.stat = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.Updateinf();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы хотите удалить все значения в строке?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBuchaniki.delete(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
					displayitog();
					display();
					displaytur();
				}
                return;
            }
        }
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            DBuchaniki.displaysearch("select * from uchast where concat(ID,Имя,Фамилия,Рейтинг,Звание,Тип,Статистика) LIKE '%" + searchtxt.Text+"%'",dataGridView);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Cleartur();
            form1.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form1.Cleartur();
                form1.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                form1.name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form1.tur1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                form1.tur2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                form1.tur3 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                form1.tur4 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                form1.final = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                form1.itog = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
                form1.Updatetur();
                form1.ShowDialog();
				displayitog();
				display();
				displaytur();
			}
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы хотите удалить все значения в строке?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBtur.delete(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
					displayitog();
					display();
					displaytur();
				}
                return;
            }
        }


        private void focus(object sender, EventArgs e)
        {
            display();
        }

        private void focus1(object sender, EventArgs e)
        {
            displaytur();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBuchaniki.displaysearch("select * from turtable where concat(ID,Имя,тур1,тур2,тур3,тур4,Финал,ИтоговыйРейтинг) LIKE '%" + textBox1.Text + "%'", dataGridView1);
        }

        private void login(object sender, EventArgs e)
        {
            author.ShowDialog();
            if(author.i == false)
            {
                Close();
            }
            if(author.b == 2)
            { 
                insert.Enabled = false;
                inserttur.Enabled = false;
                dataGridView.Enabled = false;
                dataGridView1.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void focus2(object sender, EventArgs e)
        { displayitog();        }

        private void panel6_Click(object sender, EventArgs e)
        {
            displayitog();
        }

        private void UI_Shown(object sender, EventArgs e)
        {
            displayitog();
            display();
            displaytur();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DBuchaniki.displaysearch("select * from turtable where concat(ID,Имя,тур1,тур2,тур3,тур4,Финал,ИтоговыйРейтинг) LIKE '%" + textBox1.Text + "%'", dataGridView1);
        }
    }
}
