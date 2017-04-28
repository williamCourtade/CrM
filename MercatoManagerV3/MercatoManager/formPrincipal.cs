using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercatoManager
{
    public partial class formPrincipal : Form
    {
        //Déclaration de la variable index
        int index;
        List<Joueur> joueurDemandeTransfert = new List<Joueur>();

        public formPrincipal(int indexEqp)
        {
            //Instanciation de la variable index
            index = indexEqp;
            InitializeComponent();
        }

        public void chargerJoueurDeLEqp()
        {
            lb_joueur.Items.Clear();
            foreach (Joueur unJoueur in Equipe.lesEqp[index].JoueursDeLequipe)
            {
                lb_joueur.Items.Add(unJoueur.Nom);
            }
        }

        private void formPrincipale_Load(object sender, EventArgs e)
        {
            //Affichage du nom et des joueurs de l'équipe
            lbl_nomEquipe.Text = Equipe.lesEqp[index].Nom;
            chargerJoueurDeLEqp();
            this.Show();
        }

        private void lb_joueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On récupère l'id du joueur sélectionné
            int monId = lb_joueur.SelectedIndex;
            //Evite l'erreur de non sélection d'un joueur au réaffichage de le fenêtre
            if (monId == -1)
                monId = 0;
            //On récupère la valeur du joueur et on la converti en million
            int valeur = Equipe.lesEqp[index].JoueursDeLequipe[monId].Valeur/1000000;
            //La groupBox devient visible
            gb_infoJoueur.Visible = true;
            //On récupère et on affiche les infos
            gb_infoJoueur.Text = Equipe.lesEqp[index].JoueursDeLequipe[monId].Nom;
            lbl_note.Text = Equipe.lesEqp[index].JoueursDeLequipe[monId].Note.ToString();
            lbl_valeur.Text = valeur + " millions";
            lbl_poste.Text = Equipe.lesEqp[index].JoueursDeLequipe[monId].Poste.ToString();
        }

        private void bt_suivant_Click(object sender, EventArgs e)
        {
            //FONCTION TRANSFERT ALEATOIRE
            joueurDemandeTransfert = transfertAleatoire(index);
            //chargement de la liste des joueurs
            chargerJoueurDeLEqp();
            //Ajout de 7 jours
            dateTimePicker.Value = dateTimePicker.Value.AddDays(7);
            //si une offre de transfert est disponible pour un de nos joueurs alors on affiche la postille de notification
            if (joueurDemandeTransfert.Count() >= 1)
                pb_notif.Visible = true;
            //sinon on ne l'affiche pas
            else
                pb_notif.Visible = false;
        }

        //Au clic sur "chercherJoueur" dans le menu on affiche le formulaire transfert
        private void chercherJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new transfert(index);
            form.ShowDialog();
        }

        private void vendreJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new VendreJoueur(joueurDemandeTransfert);
            form.ShowDialog();
        }


        public static List<Joueur> transfertAleatoire(int index)
        {
            //Declarations et instanciations des variables
            List<Joueur> lesJoueursPasTransfereCetteSemaine = Joueur.getAllPlayers();
            List<Equipe> lesAutresEquipes = Equipe.getLesAutresEquipes(index);
            List<Joueur> joueurADemande = new List<Joueur>();
            //Pour chaque équipe autre que l'équipe entraîné
            foreach (Equipe monEquipe in lesAutresEquipes)
            {
                Random rnd = new Random();
                //Nombre aléatoire
                int nbTransfert = rnd.Next(0, 2);
                //Pour chaque joueur n'ayant pas été transféré cette semaine
                for (int i = 0; i < nbTransfert; i++)
                {
                    //L'id d'un joueur aléatoire
                    int idJoueur = rnd.Next(0, lesJoueursPasTransfereCetteSemaine.Count());

                    //Si le joueur fait parti de notre équipe
                    if (lesJoueursPasTransfereCetteSemaine[idJoueur].IdEquipe == index)
                        //Ajout à la liste joueurADemande
                        joueurADemande.Add(lesJoueursPasTransfereCetteSemaine[idJoueur]);
                    //Si le joueur ne fait pas parti de l'équipe
                    else
                    {
                        //On essai de la changer d'équipe
                        monEquipe.changerJoueurDEquipe(lesJoueursPasTransfereCetteSemaine[idJoueur]);
                        //Et on le supprime de la liste 
                        lesJoueursPasTransfereCetteSemaine.Remove(lesJoueursPasTransfereCetteSemaine[idJoueur]);
                    }
                }
            }
            return joueurADemande;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Match();
            form.ShowDialog();
        }
    }
}
