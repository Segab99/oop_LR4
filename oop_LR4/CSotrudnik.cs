using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_LR4
{
    class CSotrudnik : CPerson
    {
        private string tableNumb_;
        public string TableNumb { get => tableNumb_; set => tableNumb_ = value.ToUpper(); }
        public CSotrudnik(StreamReader objReader) : base(objReader)
        {
            tableNumb_ = objReader.ReadLine();
        }

        public CSotrudnik(string f, string n, string o, string t) : base(f, n, o)
        {
            TableNumb = t;
        }
        public override void WriteData(StreamWriter objWriter)
        {
            base.WriteData(objWriter);
            objWriter.WriteLine(tableNumb_);
        }
        public override string FullData => base.FullData + " " + tableNumb_;
    }
}
