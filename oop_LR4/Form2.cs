using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_LR4
{   
    public partial class Form2 : Form
    {
        CSpisok spisok;
        
        public Form2()
        {
            InitializeComponent();
            spisok = new CSpisok();
        }
        public Form2(string filename)
        {
            InitializeComponent();
            spisok = new CSpisok(filename);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                CPerson person = new CPerson(textBox1.Text, textBox2.Text, textBox3.Text);
                spisok.AddPerson(person);
                label_kw.Text = Convert.ToString(spisok.Kw_pers);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            spisok.PersonListP(Convert.ToInt32(textBox7.Text)).Fam = textBox4.Text;
            spisok.PersonListP(Convert.ToInt32(textBox7.Text)).Name = textBox5.Text;
            spisok.PersonListP(Convert.ToInt32(textBox7.Text)).Otch = textBox6.Text;
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text=="")
            {
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                return;
            }
            try
            {

                if ((Convert.ToInt32(textBox7.Text) < Convert.ToInt32("1")) || (Convert.ToInt32(textBox7.Text) > Convert.ToInt32("9")))
                {
                    textBox7.Text = "";
                    return;
                }
                if (Convert.ToInt32(textBox7.Text) > spisok.Kw_pers)
                {
                    MessageBox.Show("Нет такого номера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox7.Text = "";
                    return;
                }
                textBox4.Text = spisok.PersonListP(Convert.ToInt32(textBox7.Text)).Fam;
                textBox5.Text = spisok.PersonListP(Convert.ToInt32(textBox7.Text)).Name;
                textBox6.Text = spisok.PersonListP(Convert.ToInt32(textBox7.Text)).Otch;

            }
            catch (Exception)
            {
                MessageBox.Show("Неверный тип данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox7.Text = "";
                                
            }
            

        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            
            label_kw.Text = Convert.ToString(spisok.Kw_pers);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            spisok.DeletePerson(Convert.ToInt32(textBox8.Text));
            label_kw.Text = Convert.ToString(spisok.Kw_pers);
            textBox8.Text = "";
            labelFIO.Text = "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "") labelFIO.Text = "";
            try
            {
                if ((Convert.ToInt32(textBox8.Text) < Convert.ToInt32("1")) || (Convert.ToInt32(textBox8.Text) > Convert.ToInt32("9")))
                    {
                        return;
                    }
                if (Convert.ToInt32(textBox8.Text) > spisok.Kw_pers)
                            {
                                    MessageBox.Show("Нет такого номера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                                    return;
                            }
                labelFIO.Text = spisok.PersonListS(Convert.ToInt32(textBox8.Text));

            }
            
            catch(Exception)
            {
                MessageBox.Show("Неверный тип данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            
            
        }
    }
}
