using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercatoManager
{
    public class Equipe
    {
        private int id;
        private string nom;
        private int budget;
        private List<Joueur> joueursDeLequipe = new List<Joueur>();
        public static List<Equipe> lesEqp = new List<Equipe>();

        #region ATTRIBUTS PUBLIC

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public int Budget
        {
            get
            {
                return budget;
            }

            set
            {
                budget = value;
            }
        }

        public List<Joueur> JoueursDeLequipe
        {
            get
            {
                return joueursDeLequipe;
            }

            set
            {
                joueursDeLequipe = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }


        #endregion

        #region CONSTRUCTEUR
        public Equipe(string p_nom, int p_bugdet, List<Joueur> p_Joueur, int p_id)
        {
            id = p_id;
            nom = p_nom;
            budget = p_bugdet;
            lesEqp.Add(this);
            joueursDeLequipe = p_Joueur;
        }
        #endregion

        #region METHODES
        public double calculerNoteEquipe()
        {
            double noteEquipe=0;
            foreach(Joueur monJoeur in joueursDeLequipe)
            {
                noteEquipe += monJoeur.Note;
            }
            if(joueursDeLequipe.Count()!=0)
                noteEquipe = noteEquipe / joueursDeLequipe.Count();
            return noteEquipe;
        }

        public static List<Joueur> transfertAleatoire(int index)
        {
            //Declarations et instanciations des variables
            List<Joueur> lesJoueursPasTransfereCetteSemaine = Joueur.getAllPlayers();
            List<Equipe> lesAutresEquipes = Equipe.getLesAutresEquipes(index);
            List<Joueur> joueurADemande = new List<Joueur>();
            //Pour chaque équipe autre que l'équipe entraîné
            foreach(Equipe monEquipe in lesAutresEquipes)
            {
                demandeTransfere uneDemande = null;
                Random rnd = new Random();
                //Nombre aléatoire
                int nbTransfert = rnd.Next(0, 1);
                //Pour chaque joueur n'ayant pas été transféré cette semaine
                for (int i=0; i<nbTransfert; i++)
                {
                    //L'id d'un joueur aléatoire
                    int idJoueur = rnd.Next(1, lesJoueursPasTransfereCetteSemaine.Count());

                    //Si le joueur fait parti de notre équipe
                    if (lesJoueursPasTransfereCetteSemaine[idJoueur].IdEquipe == index)
                    {
                        //Ajout à la liste joueurADemande
                        joueurADemande.Add(lesJoueursPasTransfereCetteSemaine[idJoueur]);
                        uneDemande = new demandeTransfere(monEquipe.id, lesJoueursPasTransfereCetteSemaine[idJoueur].id);

                    }
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

        public static Equipe trouverEquipe(int indexEquipe)
        {
            Equipe equipeTrouvee = null;
            foreach (Equipe monEquipe in Equipe.lesEqp)
            {
                if (monEquipe.Id == indexEquipe)
                    equipeTrouvee = monEquipe;
            }
            return equipeTrouvee;
        }

        public void changerJoueurDEquipe(Joueur monJoueur)
        {
            //On récupère l'id de l'équipe du joueur
            int indexAncienneEquipe = monJoueur.IdEquipe;
            //Si le budget de votre équipe est suffisant et que l'équipe a au moins 5 joueurs
            if ((monJoueur.Valeur <= this.budget) && (Equipe.lesEqp[indexAncienneEquipe].JoueursDeLequipe.Count()>=5))
            {
                //Ajout du joueur à sa nouvelle équipe
                this.joueursDeLequipe.Add(monJoueur);
                //Soustraction du budget de la nouvelle équipe
                this.budget -= monJoueur.Valeur;
                monJoueur.IdEquipe = this.Id;
                //Suppression du joueur de la liste des joueurs de son ancienne équipe
                Equipe.lesEqp[indexAncienneEquipe].JoueursDeLequipe.Remove(monJoueur);
                //Ajout du budget à son ancienne équipe
                Equipe.lesEqp[indexAncienneEquipe].Budget += monJoueur.Valeur;
                
            }
        }

        public static List<Equipe> getLesAutresEquipes(int indexMonEquipe)
        {
            List<Equipe> lesEquipes = new List<Equipe>();
            foreach(Equipe monEquipe in Equipe.lesEqp)
            {
                if(monEquipe.id != indexMonEquipe)
                {
                    lesEquipes.Add(monEquipe);
                }
            }
            return lesEquipes;
        }
        #endregion

    }
}
