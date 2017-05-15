using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationMatch
{
    public partial class Match : Form
    {
        public Match()
        {
            InitializeComponent();
        }

        int seconde = 0;
        int minute = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (minute < 90)
            {
                if (seconde < 59)
                    seconde++;
                else
                {
                    seconde = 0;
                    minute++;
                    preparerAction();
                }
                string temps;
                if (minute < 10)
                    temps = "0" + minute.ToString();
                else
                    temps = minute.ToString();
                if (seconde < 10)
                    temps += ":0" + seconde.ToString();
                else
                    temps += ":" + seconde.ToString();
                lbl_time.Text = temps;
            }
        }

        private string actionAleatoire()
        {
            string texte="";
            int pourcentage;
            pourcentage = rnd.Next(1, 100);

            //il y a 15% de chance qu'il y ai un but sur une action
            if (pourcentage < 15)
                texte = "But";
            else
            {
                //Il y a 10% qu'il y ai une faute (25-10)
                if (pourcentage < 25)
                {
                    texte = "Faute";
                    //Appel de la méthode, 15% qu'il y ai un carton jaune
                    if (uneFaute())
                        texte += " et carton jaune !";
                    unCoupFranc();
                }
                else
                {
                    //il y a 15% qu'il y ai un HJ
                    if (pourcentage < 40)
                        texte = "Hors jeu";
                    else
                    {
                        //il y a 25% qu'il y ai une touche
                        if (pourcentage < 65)
                            texte = "Touche";
                        else
                        {
                            //20% qu'il y ai un corner
                            if (pourcentage < 85)
                                texte = "Corner";
                            //15% qu'il y ai un beau dribble
                            else
                                texte = "Magnifique dribble !";
                        }

                    }
                }
            }
            return texte;
        }

        Random rnd = new Random();

        private void unCoupFranc()
        {
            int aleatoire = rnd.Next(1, 100);
            string txt="";
            //centre à 75%
            if (aleatoire < 75)
            {
                lbl_info.Text += Environment.NewLine + minute + "' : Coup franc en direction du point de pénalty";
                if (aleatoire <= 20)
                    txt = "Tête et but de l'attaquant !";
                else
                    txt = "Le défenseur dégage le ballon";
            }
            //Cf direct à 25%
            else
            {
                lbl_info.Text += Environment.NewLine + minute + "' : Coup franc tiré directement";
                if (aleatoire < 90)
                    txt = "Le gardien intercepte le ballon";
                else
                    txt = "But en pleine lucarne !";
            }
            lbl_info.Text += Environment.NewLine + minute + "' : " + txt;
        }

        private bool uneFaute()
        {
            bool carton = false;
            int aleatoire = rnd.Next(1, 100);
            if(aleatoire<=25)
                carton = true;
            return carton;
        }

        private void preparerAction()
        {
            int pourcent;
            
            pourcent = rnd.Next(1, 100);
            if (minute != 45)
            {
                if (pourcent < 20)
                {
                    lbl_info.Text += Environment.NewLine + minute + "' : " + actionAleatoire();
                }
                if (minute == 90)
                    lbl_info.Text += Environment.NewLine + minute + "' : Fin du match";
            }
            else
                lbl_info.Text += Environment.NewLine + minute + "' : Mi-Temps";
        }
    }
}
