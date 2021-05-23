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
        public class Carta
        {
            public string Nome;
            public int Colore;
            public int Valore;
            public PictureBox Immagine;
            public string percorsoImmagini = @"Carte Uno/";
            public void Carta1()
            {
                Nome = "Blu_0";
                Colore = 0;
                Valore = 0;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
                Immagine.Location=new Point(428, 248);
                
            }
            public void Carta2()
            {
                Nome = "Blu_1";
                Colore = 0;
                Valore = 1;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta3()
            {
                Nome = "Blu_1";
                Colore = 0;
                Valore = 1;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta4()
            {
                Nome = "Blu_2";
                Colore = 0;
                Valore = 2;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta5()
            {
                Nome = "Blu_2";
                Colore = 0;
                Valore = 2;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta6()
            {
                Nome = "Blu_3";
                Colore = 0;
                Valore = 3;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta7()
            {
                Nome = "Blu_3";
                Colore = 0;
                Valore = 3;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta8()
            {
                Nome = "Blu_4";
                Colore = 0;
                Valore = 4;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta9()
            {
                Nome = "Blu_4";
                Colore = 0;
                Valore = 4;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta10()
            {
                Nome = "Blu_5";
                Colore = 0;
                Valore = 5;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta11()
            {
                Nome = "Blu_5";
                Colore = 0;
                Valore = 5;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta12()
            {
                Nome = "Blu_6";
                Colore = 0;
                Valore = 6;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta13()
            {
                Nome = "Blu_6";
                Colore = 0;
                Valore = 6;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta14()
            {
                Nome = "Blu_7";
                Colore = 0;
                Valore = 7;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta15()
            {
                Nome = "Blu_7";
                Colore = 0;
                Valore = 7;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta16()
            {
                Nome = "Blu_8";
                Colore = 0;
                Valore = 8;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta17()
            {
                Nome = "Blu_8";
                Colore = 0;
                Valore = 8;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta18()
            {
                Nome = "Blu_9";
                Colore = 0;
                Valore = 9;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta19()
            {
                Nome = "Blu_9";
                Colore = 0;
                Valore = 9;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta20()
            {
                Nome = "Blu_CambioGiro";
                Colore = 0;
                Valore = 10;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta21()
            {
                Nome = "Blu_CambioGiro";
                Colore = 0;
                Valore = 10;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta22()
            {
                Nome = "Blu_PescaDue";
                Colore = 0;
                Valore = 11;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta23()
            {
                Nome = "Blu_PescaDue";
                Colore = 0;
                Valore = 11;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta24()
            {
                Nome = "Blu_SaltaTurno";
                Colore = 0;
                Valore = 12;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta25()
            {
                Nome = "Blu_SaltaTurno";
                Colore = 0;
                Valore = 12;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta26()
            {
                Nome = "Giallo_0";
                Colore = 1;
                Valore = 0;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta27()
            {
                Nome = "Giallo_1";
                Colore = 1;
                Valore = 1;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta28()
            {
                Nome = "Giallo_1";
                Colore = 1;
                Valore = 1;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta29()
            {
                Nome = "Giallo_2";
                Colore = 1;
                Valore = 2;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta30()
            {
                Nome = "Giallo_2";
                Colore = 1;
                Valore = 2;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta31()
            {
                Nome = "Giallo_3";
                Colore = 1;
                Valore = 3;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta32()
            {
                Nome = "Giallo_3";
                Colore = 1;
                Valore = 3;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta33()
            {
                Nome = "Giallo_4";
                Colore = 1;
                Valore = 4;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta34()
            {
                Nome = "Giallo_4";
                Colore = 1;
                Valore = 4;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta35()
            {
                Nome = "Giallo_5";
                Colore = 1;
                Valore = 5;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta36()
            {
                Nome = "Giallo_5";
                Colore = 1;
                Valore = 5;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta37()
            {
                Nome = "Giallo_6";
                Colore = 1;
                Valore = 6;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta38()
            {
                Nome = "Giallo_6";
                Colore = 1;
                Valore = 6;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta39()
            {
                Nome = "Giallo_7";
                Colore = 1;
                Valore = 7;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta40()
            {
                Nome = "Giallo_7";
                Colore = 1;
                Valore = 7;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta41()
            {
                Nome = "Giallo_8";
                Colore = 1;
                Valore = 8;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta42()
            {
                Nome = "Giallo_8";
                Colore = 1;
                Valore = 8;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta43()
            {
                Nome = "Giallo_9";
                Colore = 1;
                Valore = 9;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta44()
            {
                Nome = "Giallo_9";
                Colore = 1;
                Valore = 9;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta45()
            {
                Nome = "Giallo_CambioGiro";
                Colore = 1;
                Valore = 10;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta46()
            {
                Nome = "Giallo_CambioGiro";
                Colore = 1;
                Valore = 10;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta47()
            {
                Nome = "Giallo_PescaDue";
                Colore = 1;
                Valore = 11;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta48()
            {
                Nome = "Giallo_PescaDue";
                Colore = 1;
                Valore = 11;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta49()
            {
                Nome = "Giallo_SaltaTurno";
                Colore = 1;
                Valore = 12;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta50()
            {
                Nome = "Giallo_SaltaTurno";
                Colore = 1;
                Valore = 12;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta51()
            {
                Nome = "Rosso_0";
                Colore = 2;
                Valore = 0;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta52()
            {
                Nome = "Rosso_1";
                Colore = 2;
                Valore = 1;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta53()
            {
                Nome = "Rosso_1";
                Colore = 2;
                Valore = 1;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta54()
            {
                Nome = "Rosso_2";
                Colore = 2;
                Valore = 2;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta55()
            {
                Nome = "Rosso_2";
                Colore = 2;
                Valore = 2;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta56()
            {
                Nome = "Rosso_3";
                Colore = 2;
                Valore = 3;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta57()
            {
                Nome = "Rosso_3";
                Colore = 2;
                Valore = 3;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta58()
            {
                Nome = "Rosso_4";
                Colore = 2;
                Valore = 4;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta59()
            {
                Nome = "Rosso_4";
                Colore = 2;
                Valore = 4;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta60()
            {
                Nome = "Rosso_5";
                Colore = 2;
                Valore = 5;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta61()
            {
                Nome = "Rosso_5";
                Colore = 2;
                Valore = 5;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta62()
            {
                Nome = "Rosso_6";
                Colore = 2;
                Valore = 6;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta63()
            {
                Nome = "Rosso_6";
                Colore = 2;
                Valore = 6;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta64()
            {
                Nome = "Rosso_7";
                Colore = 2;
                Valore = 7;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta65()
            {
                Nome = "Rosso_7";
                Colore = 2;
                Valore = 7;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta66()
            {
                Nome = "Rosso_8";
                Colore = 2;
                Valore = 8;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta67()
            {
                Nome = "Rosso_8";
                Colore = 2;
                Valore = 8;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta68()
            {
                Nome = "Rosso_9";
                Colore = 2;
                Valore = 9;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta69()
            {
                Nome = "Rosso_9";
                Colore = 2;
                Valore = 9;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta70()
            {
                Nome = "Rosso_CambioGiro";
                Colore = 2;
                Valore = 10;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta71()
            {
                Nome = "Rosso_CambioGiro";
                Colore = 2;
                Valore = 10;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta72()
            {
                Nome = "Rosso_PescaDue";
                Colore = 2;
                Valore = 11;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta73()
            {
                Nome = "Rosso_PescaDue";
                Colore = 2;
                Valore = 11;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta74()
            {
                Nome = "Rosso_SaltaTurno";
                Colore = 2;
                Valore = 12;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta75()
            {
                Nome = "Rosso_SaltaTurno";
                Colore = 2;
                Valore = 12;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta76()
            {
                Nome = "Verde_0";
                Colore = 3;
                Valore = 0;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta77()
            {
                Nome = "Verde_1";
                Colore = 3;
                Valore = 1;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta78()
            {
                Nome = "Verde_1";
                Colore = 3;
                Valore = 1;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta79()
            {
                Nome = "Verde_2";
                Colore = 3;
                Valore = 2;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta80()
            {
                Nome = "Verde_2";
                Colore = 3;
                Valore = 2;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta81()
            {
                Nome = "Verde_3";
                Colore = 3;
                Valore = 3;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta82()
            {
                Nome = "Verde_3";
                Colore = 3;
                Valore = 3;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta83()
            {
                Nome = "Verde_4";
                Colore = 3;
                Valore = 4;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta84()
            {
                Nome = "Verde_4";
                Colore = 3;
                Valore = 4;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta85()
            {
                Nome = "Verde_5";
                Colore = 3;
                Valore = 5;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta86()
            {
                Nome = "Verde_5";
                Colore = 3;
                Valore = 5;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta87()
            {
                Nome = "Verde_6";
                Colore = 3;
                Valore = 6;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta88()
            {
                Nome = "Verde_6";
                Colore = 3;
                Valore = 6;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta89()
            {
                Nome = "Verde_7";
                Colore = 3;
                Valore = 7;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta90()
            {
                Nome = "Verde_7";
                Colore = 3;
                Valore = 7;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta91()
            {
                Nome = "Verde_8";
                Colore = 3;
                Valore = 8;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta92()
            {
                Nome = "Verde_8";
                Colore = 3;
                Valore = 8;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta93()
            {
                Nome = "Verde_9";
                Colore = 3;
                Valore = 9;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta94()
            {
                Nome = "Verde_9";
                Colore = 3;
                Valore = 9;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta95()
            {
                Nome = "Verde_CambioGiro";
                Colore = 3;
                Valore = 10;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta96()
            {
                Nome = "Verde_CambioGiro";
                Colore = 3;
                Valore = 10;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta97()
            {
                Nome = "Verde_PescaDue";
                Colore = 3;
                Valore = 11;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta98()
            {
                Nome = "Verde_PescaDue";
                Colore = 3;
                Valore = 11;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta99()
            {
                Nome = "Verde_SaltaTurno";
                Colore = 3;
                Valore = 12;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            public void Carta100()
            {
                Nome = "Verde_SaltaTurno";
                Colore = 3;
                Valore = 12;
                Immagine = new PictureBox();
                Immagine.Width = 110;
                Immagine.Height = 170;
                Immagine.Image = Image.FromFile(percorsoImmagini + Nome + ".png");
            }
            
        }
        public Form2()
        {
            InitializeComponent();
        }
        
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
            CreaMazzo();
            MostraCarte();
            MescolaMazzo();
        }
        public List<Carta> Mazzo;
        
        public void CreaMazzo()
        {
            
            for (int i = 0; i < 100; i++) 
            {
                Mazzo.Add(new Carta());
            }
            
        }
        public void MostraCarte()
        {
            
            foreach (object carte in Mazzo) 
            {
                
            }
        }
        public void MescolaMazzo()
        {

        }
    }
    
}
