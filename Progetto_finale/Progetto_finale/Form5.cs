using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace Progetto_finale
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }
        public string nome; //nome dell'utente
        public int vittorie; //variabile provvisoria per le vittorie dell'utente per evitare che il programma dia errore
        public static string nomeFile = "NomiGiocatori.txt"; //nome del file dove vengono salvati i nomi dei giocatori
        public static string percorsoFile = AppDomain.CurrentDomain.BaseDirectory + nomeFile;//percorso del file di salvataggio
        private void button1_Click(object sender, EventArgs e)//Bottone per spostare l'utente nel form di gioco
        {
            if (textBox1.Text == "")//Se l'utente non inserisce un nome gli viene mostrato un messaggio
            {
                MessageBox.Show("Inserisci un nome da giocatore prima di giocare");
            }
            else
            {
                //Il testo della textbox diventa il nome del giocatore che viene passato alla funzione SalvaNomi
                nome = textBox1.Text;
                Salvataggio();
                SalvaNomi(nome, vittorie);
                //Dopo aver inserito e salvato il nome, il form5 viene nascosto e viene mostrato il form2
                Form2 temp = new Form2();
                temp.Region = this.Region;
                temp.Show();
                this.Hide();
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Cliccando nasconde il form attuale e mostra il form1
        {
            Form1 temp = new Form1();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public static void Salvataggio() //Se il file non esiste allora viene creato
        {
            if (!File.Exists(percorsoFile))
            {
                using(StreamWriter sw = File.CreateText(percorsoFile))
                {

                }
            }
        }
        public void SalvaNomi(string nome, int vittorie)
        {
            bool giocatoreEsistente = false;
            var listaNomi=File.ReadAllLines(percorsoFile);//crea un array di string dove ogni elemento corrisponde ad una riga
            if (listaNomi.ToArray().Length != 0)//controlla se il file è vuoto
            {
                for (int i = 0; i < listaNomi.ToArray().Length; i++)//si ripete tante volte quante sono le righe del file
                {
                    string[] infoGiocatore = listaNomi[i].Split(','); //divide gli elementi con delle virgole
                    if (nome == infoGiocatore[0])//controlla se il nome del giocatore è già presente nel file
                    {
                        if (vittorie > Convert.ToInt32(infoGiocatore[1]))//controlla se il numero di vittorie totalizzate dal giocatore è maggiore del numero precedente dello stesso
                        {
                            infoGiocatore[1] = vittorie.ToString();//converte il numero int in string
                            listaNomi[i] = $"{infoGiocatore[0]},{infoGiocatore[1]}";
                            File.WriteAllLines(percorsoFile, listaNomi);
                        }
                        else
                        {
                            giocatoreEsistente = true;//se il giocatore è già presente nel file, ma le sue vittorie erano meno rispetto a
                        }
                    }
                    else
                    {
                        if (i == listaNomi.ToArray().Length - 1 && giocatoreEsistente == false)//quando si sono controllate tutte le righe del file e il giocatore non è stato individuato al suo interno
                        {
                            nuovoGiocatore(listaNomi.ToArray(), ref nome, ref vittorie);
                        }
                    }
                }
            }
            else//nel caso il file sia vuoto viene creata la prima riga
            {
                nuovoGiocatore(listaNomi.ToArray(), ref nome, ref vittorie);
            }
            
        }
        private void nuovoGiocatore(string[] listaNomi, ref string nome, ref int vittorie)//aggiunge un nuovo giocatore alla fine della lista e aumenta la lunghezza del file
        {
            Array.Resize(ref listaNomi, listaNomi.Length + 1); 
            listaNomi[listaNomi.Length - 1] = $"{nome}, {vittorie}";
            File.WriteAllLines(percorsoFile, listaNomi);
        }
        

        private void button3_Click(object sender, EventArgs e)//Cliccando nasconde il form attuale e mostra il form3
        {
            Form3 temp = new Form3();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }
    }
}
