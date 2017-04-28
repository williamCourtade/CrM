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
    public partial class transfert : Form
    {
        //Déclaration de la variable index
        int index;
        public transfert(int idEquipe)
        {
            //Instanciation de la variable index
            index = idEquipe;
            InitializeComponent();
        }

        private void chargerJoueur()
        {
            lb_joueurs.Items.Clear();
            //Pour chaque équipe
            foreach (Equipe monEquipe in Equipe.lesEqp)
            {
                //Sauf pour l'équipe entraînée
                if (monEquipe.Nom != Equipe.lesEqp[index].Nom)
                {
                    //On ajoute tous les joueurs dans la listbox joueur
                    foreach (Joueur monJoueur in monEquipe.JoueursDeLequipe)
                    {
                        lb_joueurs.Items.Add(monJoueur.Nom);
                    }
                }
            }
        }

        private void transfert_Load(object sender, EventArgs e)
        {
            chargerJoueur();
            lb_joueurs.SelectedIndex = 0;
            lb_position.SelectedIndex = 0;
            lbl_budget.Text = (Equipe.lesEqp[index].Budget / 1000000)+" millions d'€";
        }


        private void bt_acheter_Click(object sender, EventArgs e)
        {
            //Création d'un nouveau joueur
            Joueur joueurTransfere;
            //On récupère le nom du joueur sélectionné
            string nomJoueurSelect = lb_joueurs.SelectedItem.ToString();
            //Appel de la méthode trouverJoueur
            joueurTransfere = Joueur.trouverJoueur(nomJoueurSelect);
            //Si le joueur a été trouvé
            if (joueurTransfere != null)
            {
                //On le transfert à notre équipe
                Equipe.lesEqp[index].changerJoueurDEquipe(joueurTransfere); 
                //On rafraichi la liste de joueur qui ne sont pas de l'équipe
                chargerJoueur();
                //Rafraichissement du budget de transfert
                lbl_budget.Text = (Equipe.lesEqp[index].Budget / 1000000) + " millions d'€";
                lb_joueurs.SelectedIndex = 0;
            }
         }

        private void lb_joueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On récupère l'id du joueur sélectionné
            Joueur monJoueur = null;
            int idEquipeDuJoueur;
            int idIndex = lb_joueurs.SelectedIndex;
            if (idIndex == -1)
                idIndex = 0;
            monJoueur = Joueur.trouverJoueur(lb_joueurs.SelectedItem.ToString());
            idEquipeDuJoueur = monJoueur.IdEquipe;
            Equipe monEquipe = Equipe.trouverEquipe(idEquipeDuJoueur);
            //On récupère la valeur du joueur et on la converti en million
            int valeur = monJoueur.Valeur / 1000000;
            //La groupBox devient visible
            gb_infoJoueur.Visible = true;
            //On récupère et on affiche les infos
            gb_infoJoueur.Text = monJoueur.Nom;
            lbl_note.Text = monJoueur.Note.ToString();
            lbl_valeur.Text = valeur + " millions";
            lbl_poste.Text = monJoueur.Poste.ToString();
            lbl_equipe.Text = monEquipe.Nom;
        }

        private void bt_chercher_Click(object sender, EventArgs e)
        {
            if (lb_position.Text == "Tous")
                chargerJoueur();
            else
                chargerJoueur(lb_position.Text);
            lb_joueurs.SelectedIndex = 0;
        }

        private void chargerJoueur(string position)
        {
            char pos = position[0];
            lb_joueurs.Items.Clear();
            //Pour chaque équipe
            foreach (Equipe monEquipe in Equipe.lesEqp)
            {
                //Sauf pour l'équipe entraînée
                if (monEquipe.Nom != Equipe.lesEqp[index].Nom)
                {
                    //On ajoute tous les joueurs dans la listbox joueur
                    foreach (Joueur monJoueur in monEquipe.JoueursDeLequipe)
                    {
                        if(monJoueur.Poste == (char)pos)
                            lb_joueurs.Items.Add(monJoueur.Nom);
                    }
                }
            }
        }
        
    }
}
