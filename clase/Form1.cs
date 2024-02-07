namespace Clase_Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kg,cv;

            try
            {
                kg = double.Parse(maskedTextBox1.Text);
                if (kg <= 0 || kg > 500000)
                {
                    MessageBox.Show("No puede ser negativo ni cero ni mayor a 500000", "Advertencia");
                    maskedTextBox1.Text = "";


                }
                else
                {
                    cv = kg * 2.20462;
                    textBox2.Text = cv.ToString();
                    cv = kg * 1000;
                    textBox1.Text = cv.ToString();
}

}
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
          
        }
    }
}