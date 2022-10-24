using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1_TextChanged.Text))
            {
                MessageBox.Show(" Llene el campo solicitado");
            }
            else
            {
                string mensaje = textBox1_TexrChanged.Text;
                Form2 f2 = new Form2("");
                f2.mensaje1 = mensaje;
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2_TexrChanged.Text))
            {
                MessageBox.Show("Favor  llene el campo solicitado");
            }
            else
            {
                string mensaje = textBox2_TexrChanged.Text;
                Form2 f2 = new Form2(mensaje);
                f2.Show();
            }
        }
    }
}

