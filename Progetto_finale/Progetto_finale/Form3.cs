using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Progetto_finale
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)//mostra il nome del primo classificato
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e) //mostra il nome del secondo classificato
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)//mostra il nome del terzo classificato
        {

        }

        private void button2_Click(object sender, EventArgs e)//Cliccandoci mostra il form5 e nasconde quello attuale
        {
            Form5 temp = new Form5();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }
    }
}
