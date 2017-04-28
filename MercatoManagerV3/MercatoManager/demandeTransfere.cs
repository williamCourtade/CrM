using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercatoManager
{
    public class demandeTransfere
    {
        int idEquipe;
        int idJoueur;

        #region attributs public
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

        public int IdJoueur
        {
            get
            {
                return idJoueur;
            }

            set
            {
                idJoueur = value;
            }
        }
        #endregion

        #region Constructeur
        public demandeTransfere(int idE, int idJ)
        {
            idEquipe = idE;
            idJoueur = idJ;
        }
        #endregion

    }
}
