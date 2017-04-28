using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercatoManager
{
    public class Joueur
    {
        public int id=0;
        private string nom;
        private int note;
        private int valeur;
        private char poste;
        private int idEquipe;

        #region ATTRIBUTS PUBLICS
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

        public int Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public int Valeur
        {
            get
            {
                return valeur;
            }

            set
            {
                valeur = value;
            }
        }

        public char Poste
        {
            get
            {
                return poste;
            }

            set
            {
                poste = value;
            }
        }

        public int IdEquipe
        {
            get
            {
                return idEquipe;
            }

            set
            {
                idEquipe = value;
            }
        }
        #endregion

        #region Constructeur
        public Joueur(string p_nom, int p_note, int p_valeur, char p_poste, int p_idEquipe)
        {
            id = id++;
            nom = p_nom;
            note = p_note;
            valeur = p_valeur;
            poste = p_poste;
            IdEquipe = p_idEquipe;
        }
        #endregion

        #region Methodes
        public static Joueur trouverJoueur(string nomJoueur)
        {
            Joueur joueurTrouve = null;
            foreach(Equipe monEquipe in Equipe.lesEqp)
            {
                foreach(Joueur monJoueur in monEquipe.JoueursDeLequipe)
                {
                    if (monJoueur.nom == nomJoueur)
                        joueurTrouve = monJoueur;
                }
            }
            return joueurTrouve;
        }

        public static List<Joueur> getAllPlayers()
        {
            List<Joueur> tousLesJoueurs = new List<Joueur>();
            foreach(Equipe monEquipe in Equipe.lesEqp)
            {
                foreach(Joueur monJoueur in monEquipe.JoueursDeLequipe)
                {
                    tousLesJoueurs.Add(monJoueur);
                }
            }
            return tousLesJoueurs;
        }
        #endregion
    }
}
