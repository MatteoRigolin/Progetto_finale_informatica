using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Progetto_finale
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Inserisci un nome da giocatore prima di giocare");
            }
            else
            {
                Form2 temp = new Form2();
                temp.Region = this.Region;
                temp.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
