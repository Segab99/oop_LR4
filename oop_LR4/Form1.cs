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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void FileOK_Click(object sender, EventArgs e)
        {
             
            if (EditFileName.Text == "")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                Form2 form2 = new Form2(EditFileName.Text);
                form2.Show();
                
            }
            
            
        }
    }
}
