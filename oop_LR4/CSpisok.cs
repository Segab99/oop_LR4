using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_LR4
{
    class CSpisok
    {
        private int kw;
        private CPerson[] MasPerson = new CPerson[100];
        private string nameFile;
        private string GetStringData(int i)
        {
            return MasPerson[i].FullData;
        }
        private CPerson GetData(int i)
        {
            return MasPerson[i];
        }

        public CSpisok()
        {
            int i = 0;
            nameFile = "temp.txt";
            
            try
            {
                StreamReader reader = new StreamReader(nameFile, Encoding.GetEncoding(1251));
                while (!reader.EndOfStream)
                {
                    i = i + 1;
                    MasPerson[i] = new CPerson(reader);
                }
            
                kw = i;
                reader.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Файл не temp.txt найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
            
        }
        public CSpisok(string s)
        {
            int i = 0;
            s = s + ".txt";
            nameFile = s;
            
            try
            {
                StreamReader reader = new StreamReader(nameFile, Encoding.GetEncoding(1251));
                while (!reader.EndOfStream)
                {
                    i = i + 1;
                    MasPerson[i] = new CPerson(reader);
                }
                kw = i;
                reader.Close();
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Файл не найден! Будет создан новый файл", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FileStream file1 = new FileStream(nameFile, FileMode.Create);
                StreamReader reader = new StreamReader(file1, Encoding.GetEncoding(1251));
                while (!reader.EndOfStream)
                {
                    i = i + 1;
                    MasPerson[i] = new CPerson(reader);
                }
                kw = i;
                reader.Close();
            }
                       
        }

        public string PersonListS(int i)
        {
            return GetStringData(i);
        }
        public CPerson PersonListP(int i)
        {
            return GetData(i);
        }
        public int Kw_pers
        {
            get => kw ;
        }
        public void AddPerson(CPerson value)
        {
            kw++;
            MasPerson[kw] = value;
        }
        public void DeletePerson(int id)
        {
            CPerson[] nArray = new CPerson[MasPerson.Length - 1];
            
            kw--;
            for (int i = 1; i < MasPerson.Length; i++)
            {
                if (i < id)
                {
                    nArray[i] = MasPerson[i];
                }
                else if (i > id)
                {
                    nArray[i - 1] = MasPerson[i];
                }
            }
            for (int i = 1; i <= kw; i++)
            {
                MasPerson[i] = nArray[i];
            }

        }

        ~CSpisok()
        {
            FileStream file1 = new FileStream(nameFile, FileMode.Create);
            StreamWriter f = new StreamWriter(file1,Encoding.GetEncoding(1251));
            for (int i = 1; i <= kw; i++)
            {
                MasPerson[i].WriteData(f);
            }
            f.Close();
        }

    }
}
