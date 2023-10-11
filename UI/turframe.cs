using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace UI
{
    public partial class Регистрация_на_турнир : Form
    {
        private readonly UI _parent;
        public string name,id;
        public int tur1,tur2,tur3,tur4,final,itog,Id;

        private void turframe_Shown(object sender, EventArgs e)
        {
            DBuchaniki.displaysearch("SELECT ID,Имя FROM uchast", dataGridView2);
        }

        private void turframe_Click(object sender, EventArgs e)
        {
            DBuchaniki.displaysearch("SELECT ID,Имя FROM uchast", dataGridView2);
        }

        private void focus(object sender, EventArgs e)
        {
            DBuchaniki.displaysearch("SELECT ID,Имя FROM uchast", dataGridView2);
        }

       

        public Регистрация_на_турнир(UI parent)
        {
            InitializeComponent();
            _parent = parent;
            DBuchaniki.displaysearch("SELECT ID,Имя FROM uchast", dataGridView2);
        }
        public void Updatetur()
        {
            DBuchaniki.displaysearch("SELECT ID,Имя FROM uchast", dataGridView2);
            lbltext.Text = "Обновить данные";
            inserttur.Text = "Обновить";
            i.Text = Id.ToString();
            nam.Text = name;
            tu1.Text = tur1.ToString();
            tu2.Text = tur2.ToString();
            tu3.Text = tur3.ToString();
            tu4.Text = tur4.ToString();
            fina.Text = final.ToString();
            ito.Text = itog.ToString();
        }
        public void Cleartur()
        {
            i.Text=nam.Text = tu1.Text = tu2.Text = tu3.Text = tu4.Text = fina.Text = ito.Text = string.Empty;
        }

        private void inserttur_Click(object sender, EventArgs e)
        {
            DBuchaniki.displaysearch("SELECT ID,Имя FROM uchast", dataGridView2);
            bool test = ito.Text.All(char.IsDigit);
            if (test == false)
            {
                MessageBox.Show("Неправильный рейтинг");
                return;
            }
            bool test1 = tu1.Text.All(char.IsDigit);
            if (test1 == false)
            {
                MessageBox.Show("Неправильный 1ый тур");
                return;
            }
            bool test2 = tu2.Text.All(char.IsDigit);
            if (test2 == false)
            {
                MessageBox.Show("Неправильный рейтинг");
                return;
            }
            bool test3 = tu3.Text.All(char.IsDigit);
            if (test3 == false)
            {
                MessageBox.Show("Неправильный рейтинг");
                return;
            }
            bool test4 = tu4.Text.All(char.IsDigit);
            if (test == false)
            {
                MessageBox.Show("Неправильный рейтинг");
                return;
            }

            if (tu1.Text.Trim().Length < 1)
            {
                MessageBox.Show("Пустой 1ый тур участника>1"); return;
            }
            if (nam.Text.Trim().Length < 3)
            {
                MessageBox.Show("Пустое имя студента>3"); return;
            }
            if (tu2.Text.Trim().Length < 1)
            {
                MessageBox.Show("Пустой 2ой тур участника>1"); return;
            }
            if (tu3.Text.Trim().Length < 1)
            {
                MessageBox.Show("Пустой 3ий тур участника>1"); return;
            }
            if (tu4.Text.Trim().Length < 1)
            {
                MessageBox.Show("Пустой 4ый тур участника>1>3"); return;
            }
            if (fina.Text.Trim().Length < 1)
            {
                MessageBox.Show("Пустой финальный тур участника>1"); return;
            }
            if (i.Text.Trim().Length < 1)
            {
                MessageBox.Show("Пустой ID участника>1"); return;
            }
            if (inserttur.Text == "Добавление участника")
            {
                DBuchaniki.displaysearch("SELECT ID,Имя FROM uchast", dataGridView2);
                int I = Convert.ToInt32(i.Text);
                int tur1 = Convert.ToInt32(tu1.Text);
                int tur2 = Convert.ToInt32(tu2.Text);
                int tur3 = Convert.ToInt32(tu3.Text);
                int tur4 = Convert.ToInt32(tu4.Text);
                int final = Convert.ToInt32(fina.Text);
                int itog = Convert.ToInt32(ito.Text);
                tur std = new tur(I,nam.Text.Trim(),tur1,tur2,tur3,tur4,final,itog );
                DBtur.insert(std);
                Cleartur();
            }
            if (inserttur.Text == "Обновить")
            {
                DBuchaniki.displaysearch("SELECT ID,Имя FROM uchast", dataGridView2);
                int I = Convert.ToInt32(i.Text);
                int tur1 = Convert.ToInt32(tu1.Text);
                int tur2 = Convert.ToInt32(tu2.Text);
                int tur3 = Convert.ToInt32(tu3.Text);
                int tur4 = Convert.ToInt32(tu4.Text);
                int final = Convert.ToInt32(fina.Text);
                int itog = Convert.ToInt32(ito.Text);
                tur std = new tur(I, nam.Text.Trim(), tur1, tur2, tur3, tur4, final, itog);
                DBtur.update(std, I.ToString());
                lbltext.Text = "Добавление участника";
                inserttur.Text = "Добавление участника";
                Close();
            }
            DBuchaniki.displaysearch("SELECT ID,Имя FROM uchast", dataGridView2);
            _parent.displaytur();
        }
    }
    }

