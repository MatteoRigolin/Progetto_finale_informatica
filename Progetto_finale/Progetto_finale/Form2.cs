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
        public enum ColoriCarte { blu, giallo, rosso, verde } //elenco di colori
        public enum ValoriCarte { zero, uno, due, tre, quattro, cinque, sei, sette, otto, nove, cambioGiro, pescaDue, saltaTurno }//elenco di valori
        public class Carta : Form2 //classe per creare gli oggetti carta con colore, valore, fronte e retro immagine
        {
            
            public ColoriCarte Colore { get; set; } 
            public ValoriCarte Valore { get; set; }
            public Image Immagine { get; set; }
            public Image RetroImmagine { get; set; }
        }
        const int numeroCarte = 52; //numero di carte nel mazzo iniziale
        public Carta[] Mazzo; //array iniziale che contiene tutte le carte
        public Carta[] ManoGiocatore; //carte in mano al giocatore
        public Carta[] ManoBot; //carte in mano al bot
        public Carta[] MazzoPesca; //carte rimaste nel mazzo per pescare
        public Carta[] MazzoScarti; //carte scartate durante la partita
        Image[] immaginiCarte = new Image[52]; //immagini fronte di ogni carta
        Image[] retroCarte = new Image[52]; //immagini retro di ogni carta

        public void MazzoDiCarte()//inizializza il mazzo
        {
            Mazzo = new Carta[numeroCarte];
            CreaMazzo();
        }

        public void CreaMazzo()//crea le carte per ogni colore e valore, con rispettivi fronte e retro, come elementi dell'array mazzo
        {
            int i = 0;
            foreach (ColoriCarte colore in Enum.GetValues(typeof(ColoriCarte)))
            {
                foreach (ValoriCarte valore in Enum.GetValues(typeof(ValoriCarte)))
                {
                    Mazzo[i] = new Carta { Colore = colore, Valore = valore, Immagine = AssegnaImmagine(i), RetroImmagine = AssegnaRetro(i) };

                    i++;
                }
            }
            MescolaCarte();

        }
        public Image AssegnaImmagine(int i)//assegna le immagini ad ogni carta del mazzo
        {
            switch (i)
            {
                case 0:
                    immaginiCarte[i] = Properties.Resources._0;
                    break;
                case 1:
                    immaginiCarte[i] = Properties.Resources._1;
                    break;
                case 2:
                    immaginiCarte[i] = Properties.Resources._2;
                    break;
                case 3:
                    immaginiCarte[i] = Properties.Resources._3;
                    break;
                case 4:
                    immaginiCarte[i] = Properties.Resources._4;
                    break;
                case 5:
                    immaginiCarte[i] = Properties.Resources._5;
                    break;
                case 6:
                    immaginiCarte[i] = Properties.Resources._6;
                    break;
                case 7:
                    immaginiCarte[i] = Properties.Resources._7;
                    break;
                case 8:
                    immaginiCarte[i] = Properties.Resources._8;
                    break;
                case 9:
                    immaginiCarte[i] = Properties.Resources._9;
                    break;
                case 10:
                    immaginiCarte[i] = Properties.Resources._10;
                    break;
                case 11:
                    immaginiCarte[i] = Properties.Resources._11;
                    break;
                case 12:
                    immaginiCarte[i] = Properties.Resources._12;
                    break;
                case 13:
                    immaginiCarte[i] = Properties.Resources._13;
                    break;
                case 14:
                    immaginiCarte[i] = Properties.Resources._14;
                    break;
                case 15:
                    immaginiCarte[i] = Properties.Resources._15;
                    break;
                case 16:
                    immaginiCarte[i] = Properties.Resources._16;
                    break;
                case 17:
                    immaginiCarte[i] = Properties.Resources._17;
                    break;
                case 18:
                    immaginiCarte[i] = Properties.Resources._18;
                    break;
                case 19:
                    immaginiCarte[i] = Properties.Resources._19;
                    break;
                case 20:
                    immaginiCarte[i] = Properties.Resources._20;
                    break;
                case 21:
                    immaginiCarte[i] = Properties.Resources._21;
                    break;
                case 22:
                    immaginiCarte[i] = Properties.Resources._22;
                    break;
                case 23:
                    immaginiCarte[i] = Properties.Resources._23;
                    break;
                case 24:
                    immaginiCarte[i] = Properties.Resources._24;
                    break;
                case 25:
                    immaginiCarte[i] = Properties.Resources._25;
                    break;
                case 26:
                    immaginiCarte[i] = Properties.Resources._26;
                    break;
                case 27:
                    immaginiCarte[i] = Properties.Resources._27;
                    break;
                case 28:
                    immaginiCarte[i] = Properties.Resources._28;
                    break;
                case 29:
                    immaginiCarte[i] = Properties.Resources._29;
                    break;
                case 30:
                    immaginiCarte[i] = Properties.Resources._30;
                    break;
                case 31:
                    immaginiCarte[i] = Properties.Resources._31;
                    break;
                case 32:
                    immaginiCarte[i] = Properties.Resources._32;
                    break;
                case 33:
                    immaginiCarte[i] = Properties.Resources._33;
                    break;
                case 34:
                    immaginiCarte[i] = Properties.Resources._34;
                    break;
                case 35:
                    immaginiCarte[i] = Properties.Resources._35;
                    break;
                case 36:
                    immaginiCarte[i] = Properties.Resources._36;
                    break;
                case 37:
                    immaginiCarte[i] = Properties.Resources._37;
                    break;
                case 38:
                    immaginiCarte[i] = Properties.Resources._38;
                    break;
                case 39:
                    immaginiCarte[i] = Properties.Resources._39;
                    break;
                case 40:
                    immaginiCarte[i] = Properties.Resources._40;
                    break;
                case 41:
                    immaginiCarte[i] = Properties.Resources._41;
                    break;
                case 42:
                    immaginiCarte[i] = Properties.Resources._42;
                    break;
                case 43:
                    immaginiCarte[i] = Properties.Resources._43;
                    break;
                case 44:
                    immaginiCarte[i] = Properties.Resources._44;
                    break;
                case 45:
                    immaginiCarte[i] = Properties.Resources._45;
                    break;
                case 46:
                    immaginiCarte[i] = Properties.Resources._46;
                    break;
                case 47:
                    immaginiCarte[i] = Properties.Resources._47;
                    break;
                case 48:
                    immaginiCarte[i] = Properties.Resources._48;
                    break;
                case 49:
                    immaginiCarte[i] = Properties.Resources._49;
                    break;
                case 50:
                    immaginiCarte[i] = Properties.Resources._50;
                    break;
                case 51:
                    immaginiCarte[i] = Properties.Resources._51;
                    break;
            }
            return immaginiCarte[i];
        }
        public Image AssegnaRetro(int i)//assegna il retro ad ogni carta del mazzo
        {
            retroCarte[i] = Properties.Resources._52;
            return retroCarte[i];
        }
        
        public void MescolaCarte()//mescola il mazzo scambiando una carta randomica con un'altra e ripete l'operazione 1000 volte
        {
            Random random = new Random();
            Carta temp;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < numeroCarte; j++)
                {
                    int secondaCarta = random.Next(13);
                    temp = Mazzo[j];
                    Mazzo[j] = Mazzo[secondaCarta];
                    Mazzo[secondaCarta] = temp;
                }
            }
        }
        public void OrganizzaMazzo()//divide il mazzo in quattro array
        {
            ManoGiocatore = new Carta[7];
            ManoBot = new Carta[7];
            MazzoPesca = new Carta[37];
            MazzoScarti = new Carta[1];
            OrganizzaCarte();
        }
        public void OrganizzaCarte()//assegna le carte ai vari array
        {
            for (int i = 0; i < ManoGiocatore.Length; i++)//crea la mano del giocatore e quella del bot
            {
                int j = i + 7;
                ManoGiocatore[i] = Mazzo[i];
                ManoBot[i] = Mazzo[j];
            }
            MazzoScarti[0] = Mazzo[14]; //assegna la prima carta del mazzo scarti per iniziare la pertita
            for (int i = 0; i < MazzoPesca.Length; i++)//crea il nuovo mazzo pesca con le carte restanti
            {
                int j = i + 15;
                MazzoPesca[i] = Mazzo[j];
            }
        }
        
        public Form2()
        {
            InitializeComponent();
        }
        public int numeroTurni;//contatore dei turni
        private void Form2_Load(object sender, EventArgs e)//funzioni eseguite appena dopo il caricamento del form
        {
            MazzoDiCarte();
            OrganizzaMazzo();
            Partita();
        } 
        public void Partita()//determina l'inizio della partita
        {
            MostraCarte();
            numeroTurni = 1;//imposta il contatore a 1
            if (numeroTurni % 2 == 0)//se il contatore è pari tocca al bot
            {
                TurnoBot();
            }
            else if (numeroTurni % 2 == 1)//se il contatore è dispari tocca al giocatore
            {
                TurnoGiocatore();
            }
        }
        
        public void MostraCarte()//esegue il display delle carte tramite delle picturebox che vengono create
        {
            MostraManoGiocatore();
            MostraManoBot();
            MostraMazzoPesca();
            MostraMazzoScarti();
        }
        public void MostraManoGiocatore()
        {
            for (int i = 0; i < ManoGiocatore.Length; i++)//display carte in mano al giocatore
            {
                var nuovaPictureBox = new PictureBox();
                int x = 110 + (116 * i);
                int y = 510;
                nuovaPictureBox.Width = 110;
                nuovaPictureBox.Height = 170;
                nuovaPictureBox.Image = ManoGiocatore[i].Immagine; //devono essere visibili dall'utente
                nuovaPictureBox.Location = new Point(x, y);
                this.Controls.Add(nuovaPictureBox);
            }
        }
        public void MostraManoBot()
        {
            for (int i = 0; i < ManoBot.Length; i++)//display carte in mano al bot
            {
                var nuovaPictureBox = new PictureBox();
                int x = 110 + (116 * i);
                int y = 70;
                nuovaPictureBox.Width = 110;
                nuovaPictureBox.Height = 170;
                nuovaPictureBox.Image = ManoBot[i].RetroImmagine; //devono essere girate e quindi non visibili all'utente
                nuovaPictureBox.Location = new Point(x, y);
                this.Controls.Add(nuovaPictureBox);
            }
        }
        public void MostraMazzoPesca()
        {
            for (int i = 0; i < MazzoPesca.Length; i++)//display delle carte del mazzo pesca
            {
                var nuovaPictureBox = new PictureBox();
                nuovaPictureBox.Width = 110;
                nuovaPictureBox.Height = 170;
                nuovaPictureBox.Image = MazzoPesca[i].RetroImmagine; //devono essere coperte
                nuovaPictureBox.Location = new Point(495, 285); //le carte sono tutte sovrapposte una sopra l'altra
                this.Controls.Add(nuovaPictureBox);
            }
        }
        public void MostraMazzoScarti()
        {
            for (int i = 0; i < MazzoScarti.Length; i++)//display delle carte del mazzo scarti
            {
                var nuovaPictureBox = new PictureBox();
                nuovaPictureBox.Width = 110;
                nuovaPictureBox.Height = 170;
                nuovaPictureBox.Image = MazzoScarti[i].Immagine;//devono essere visibili ai giocatori
                nuovaPictureBox.Location = new Point(611, 285);//le carte sono tutte una sopra l'altra
                this.Controls.Add(nuovaPictureBox);
            }
        }
        public void TurnoBot()//turno del bot
        {
            //i bottoni vengono nascosti
            passaturnoBtn.Hide();
            pescaBtn.Hide();
        }
        public void TurnoGiocatore()//turno del giocatore
        {
            
        }
        public void PescaCarta()//funzione per pescare
        {
            if (MazzoPesca.Length == 0)
            {
                MessageBox.Show("Pareggio!\nNon ci sono più carte nel mazzo");
            }
            else
            {
                if (ManoGiocatore.Length < 10)
                {
                    Array.Resize(ref ManoGiocatore, ManoGiocatore.Length + 1);//aumento la lunghezza della mano
                    ManoGiocatore[ManoGiocatore.Length - 1] = MazzoPesca[MazzoPesca.Length - 1]; //il nuovo spazio diventa uguale alla carta in cima al mazzo pesca
                    MazzoPesca[MazzoPesca.Length - 1] = null;//la carta pescata nel mazzo pesca diventa uno spazio vuoto
                    Array.Resize(ref MazzoPesca, MazzoPesca.Length - 1); //il mazzo pesca viene accorciato di uno spazio
                    MostraManoGiocatore(); //rieseguo il diplay della mano
                    MostraMazzoPesca(); //rieseguo il display del mazzo pesca
                }
                else
                {
                    MessageBox.Show("Non puoi più pescare carte\nla tua mano è piena");
                }
            }
        }

        private void passaturnoBtn_Click(object sender, EventArgs e)//bottone passa il turno
        {

        }

        private void pescaBtn_Click(object sender, EventArgs e)//bottone pesca
        {
            PescaCarta();
        }

        private void esciBtn_Click(object sender, EventArgs e)//bottone per uscire
        {
            DialogResult dialog = MessageBox.Show("Vuoi uscire dalla partita?", "Esci", MessageBoxButtons.YesNo);//chiede conferma all'utente se vuole uscire tramite una messagebox
            if (dialog == DialogResult.Yes)//se preme yes viene spostato nella schermata iniziale
            {
                Form1 temp = new Form1();
                temp.Region = this.Region;
                temp.Show();
                this.Hide();
            }
        }
    }
}
