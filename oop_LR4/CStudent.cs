using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_LR4
{
    class CStudent : CPerson
    {
        private string group_;
        private string kurs_;
        

        public CStudent(StreamReader objReader) : base(objReader)
        {
            group_ = objReader.ReadLine();
            kurs_ = objReader.ReadLine();
        }

        public CStudent(string f, string n, string o, string g, string k) : base(f, n, o)
        {
            group_ = g;
            kurs_ = k;
        }

        public string Kurs
        {
            set
            {
                if (Convert.ToInt32(value) < 1) value = "1";
                if(Convert.ToInt32(value) > 5) value = "5";
                kurs_ = value;
            }
        }
        public string Group { set => group_ = value.ToUpper(); }
        public override string FullData => base.FullData + " " + group_ + " " + kurs_;
        public override void WriteData(StreamWriter objWriter)
        {
            base.WriteData(objWriter);
            objWriter.WriteLine(group_);
            objWriter.WriteLine(kurs_);
        }
    }
}
