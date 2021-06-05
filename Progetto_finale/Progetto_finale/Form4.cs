using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Progetto_finale
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Cliccandoci mostra il form1 e nasconde quello attuale
        {
            Form1 temp = new Form1();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }
    }
}
