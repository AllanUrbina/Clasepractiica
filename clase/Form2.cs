using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Practica
{
  
    public partial class Form2 : Form
    {
        Form1  f1 =new Form1();
        Form3 f3 =new Form3();  
        public Form2()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void form1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            f1.IsMdiContainer = true;
            f1.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.IsMdiContainer = true;
            f3.Show();
        }
    }
}
