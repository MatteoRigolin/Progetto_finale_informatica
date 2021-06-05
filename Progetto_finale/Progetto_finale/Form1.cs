//Author: Matteo Rigolin
//Data: 2 Maggio 2021
//Creare un gioco funzionante usando windows form c#
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

        private void giocaBtn_Click(object sender, EventArgs e)//Cliccando nasconde il form attuale e mostra il form5
        {
            Form5 temp = new Form5();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void regoleBtn_Click(object sender, EventArgs e)//Cliccandoci mostra il form4 e nasconde quello attuale
        {
            Form4 temp = new Form4();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void esciBtn_Click(object sender, EventArgs e)//Cliccandoci permette all'utente di uscire solo dopo aver confermato un messggio di avviso
        {
            DialogResult dialog = MessageBox.Show("Vuoi uscire dal gioco?", "Esci", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
