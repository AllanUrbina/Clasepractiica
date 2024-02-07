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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio, vida_util, salvamento;



            try
            {


                precio = double.Parse(maskedTextBox1.Text);
                if (precio <= 0 || precio > 500000)
                {
                    MessageBox.Show("No puede ser negativo ni cero ni mayor a 500000", "Advertencia");
                    maskedTextBox1.Text = "";


                }
                vida_util = double.Parse(maskedTextBox1.Text);
                if (vida_util <= 1 || vida_util > 2)
                {
                    MessageBox.Show("No puede ser negativo ni cero ni mayor a 500000", "Advertencia");
                    maskedTextBox1.Text = "";


                }
                else
                {
                    salvamento = precio * 01.10;

                }
            }



            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
