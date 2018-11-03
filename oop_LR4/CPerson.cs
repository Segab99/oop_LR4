using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_LR4
{
    class CPerson
    {
        private string fam;
        private string name;
        private string otch;
        private  string GetFullData()
        {
            return fam + " " + name + " " + otch;
        }

        public string Fam
        {
            set => fam = value.ToUpper();
            get => fam;
        }
        public string Name
        {
            set => name = value.ToLower();
            get => name;
        }
        public string Otch
        {
            set => otch = value.ToLower();
            get => otch;
        }
        virtual public string FullData
        {
            get => GetFullData();
        }
        virtual public void WriteData(StreamWriter objWriter)
        {
            
            objWriter.WriteLine(fam);
            objWriter.WriteLine(name);
            objWriter.WriteLine(otch);
            
        }

        public CPerson(StreamReader objReader)
        {
            
            Fam = objReader.ReadLine();
            Name = objReader.ReadLine();
            Otch = objReader.ReadLine();
            
        }
        public CPerson(string f, string n, string o)
        {
            Fam = f;
            Name = n;
            Otch = o;
        }
        
        
    }
}
