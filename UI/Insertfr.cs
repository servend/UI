using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Insertframe : Form
    {
        private readonly UI _parent;
        public string id, name, surname, zvan, type,stat;
        public int reit;
        public Insertframe(UI parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void Updateinf()
        {
            lbltext.Text = "Обновить данные";
            insertinto.Text = "Обновить";
            nam.Text = name;
            surnam.Text = surname;
            rei.Text = reit.ToString();
            zva.Text = zvan;
            typ.Text = type;    
            sta.Text = stat;
        }
        public void Clear()
        {
            nam.Text = surnam.Text = zva.Text =sta.Text=typ.Text=rei.Text=string.Empty;
        }
        private void insertinto_Click(object sender, EventArgs e)
        {
            bool test = rei.Text.All(char.IsDigit);
            if (test==false)
            {
                MessageBox.Show("Неправильный рейтинг");
                return;
            }
            if (rei.Text.Trim().Length < 3)
            {
                MessageBox.Show("Пустой рейтинг студента>3"); return;
            }
            if (nam.Text.Trim().Length < 3) 
            {
                MessageBox.Show("Пустое имя студента>3");return;
            }
            if (surnam.Text.Trim().Length < 3)
            {
                MessageBox.Show("Пустая Фамилия студента>3"); return;
            }
            if (zva.Text.Trim().Length < 3)
            {
                MessageBox.Show("Пустое звание студента>3"); return;
            }
            if (typ.Text.Trim().Length < 3)
            {
                MessageBox.Show("Пустой тип студента>3"); return;
            }
            if (sta.Text.Trim().Length < 3)
            {
                MessageBox.Show("Пустая статистика студента>3"); return;
            }
            if (insertinto.Text=="Добавление участника")
            {
                int reiti = Convert.ToInt32(rei.Text);
                uchaniki std = new uchaniki(nam.Text.Trim(), surnam.Text.Trim(),reiti, zva.Text.Trim(),typ.Text.Trim(), sta.Text.Trim());
                DBuchaniki.insert(std);
                Clear();
            }
            if(insertinto.Text== "Обновить")
            {
                reit= Convert.ToInt32(rei.Text);
                uchaniki std = new uchaniki(nam.Text.Trim(), surnam.Text.Trim(), reit, zva.Text.Trim(), typ.Text.Trim(), sta.Text.Trim());
                DBuchaniki.update(std,id);
                lbltext.Text = "Добавление участника";
                insertinto.Text = "Добавление участника";
                Close();
            }
            _parent.display();
        }
    }
}
