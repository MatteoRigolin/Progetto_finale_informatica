using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_finale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 temp = new Form5();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 temp = new Form3();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 temp = new Form4();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Vuoi uscire dal gioco?", "Esci", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
