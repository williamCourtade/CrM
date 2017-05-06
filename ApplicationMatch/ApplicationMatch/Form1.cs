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
            Random random = new Random();
            pourcentage = random.Next(1, 100);
            if (pourcentage < 10)
                texte = "But";
            else
            {
                if (pourcentage < 25)
                    texte = "Faute";
                else
                {
                    if (pourcentage < 50)
                        texte = "Hors jeu";
                    else
                        texte = "Coup Franc";
                }
            }
            return texte;
        }

        private void preparerAction()
        {
            int pourcent;
            Random rnd = new Random();
            pourcent = rnd.Next(1, 100);
            if (pourcent < 15)
            {
                lbl_info.Text += Environment.NewLine + minute + "' : " +actionAleatoire();
            }
        }
    }
}
