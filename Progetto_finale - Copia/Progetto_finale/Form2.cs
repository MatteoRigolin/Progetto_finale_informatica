using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Progetto_finale
{
    public partial class Form2 : Form
    {
        //class Carta : Form2
        //{
        //    public enum ColoriCarte { blu, rosso, verde, giallo }
        //    public enum ValoriCarte { zero, uno, due, tre, quattro, cinque, sei, sette, otto, nove, cambioGiro, pescaDue, saltaTurno }
        //    public ColoriCarte Colore { get; set; }
        //    public ValoriCarte Valore { get; set; }

        //}
        //class MazzoDiCarte : Carta
        //{
        //    const int numeroCarte = 104;
        //    private Carta[] Mazzo;
        //    public MazzoDiCarte()
        //    {
        //        Mazzo = new Carta[numeroCarte];
        //    }
        //    public Carta[] OttieniCarta { get { return Mazzo; } }
        //    public void CreaMazzo()
        //    {
        //        int i = 0;
        //        foreach (ColoriCarte colori in Enum.GetValues(typeof(ColoriCarte)))
        //        {
        //            foreach (ValoriCarte valori in Enum.GetValues(typeof(ValoriCarte)))
        //            {
        //                Mazzo[i] = new Carta { Colore = colori, Valore = valori };
        //                i++;
        //            }
        //        }
        //        MescolaCarte();
        //    }
        //    public void MescolaCarte()
        //    {
        //        Random random = new Random();
        //        Carta temp;
        //        for (int i = 0; i < 1000; i++)
        //        {
        //            for (int j = 0; j < numeroCarte; j++)
        //            {
        //                int secondaCarta = random.Next(13);
        //                temp = Mazzo[j];
        //                Mazzo[j] = Mazzo[secondaCarta];
        //                Mazzo[secondaCarta] = temp;
        //            }
        //        }
        //    }
        //}
        public Form2()
        {
            InitializeComponent();
            Immagini = new PictureBox[52];
        }
        public static string percorsoImmagini = @"Carte/";
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Vuoi uscire dalla partita?", "Esci", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Form1 temp = new Form1();
                temp.Region = this.Region;
                temp.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreaControlli();
            MostraControlli();
        }
        public PictureBox[] Immagini;
        private void CreaControlli()
        {
            for (var i = 0; i < 52; i++)
            {
                var nuovaPictureBox = new PictureBox();
                nuovaPictureBox.Width = 110;
                nuovaPictureBox.Height = 170;
                nuovaPictureBox.BorderStyle = BorderStyle.Fixed3D;
                Immagini[i] = AssegnaImmagine(nuovaPictureBox, i);
            }
        }
        private PictureBox AssegnaImmagine(PictureBox pb, int i)
        {
            Image img = Image.FromFile(percorsoImmagini + i.ToString() + ".png");
            pb.SizeMode = PictureBoxSizeMode.CenterImage;
            return pb;
        }
        private void MostraControlli()
        {
            for (var i = 0; i < 52; i++)
            {
                Immagini[i].Location = new Point(400, 260);
                this.Controls.Add(Immagini[i]);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
