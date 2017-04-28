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
    public partial class VendreJoueur : Form
    {
        List<Joueur> lesDemandes = new List<Joueur>();
        public VendreJoueur(List<Joueur> p_lesDemandes)
        {
            lesDemandes = p_lesDemandes;
            InitializeComponent();
        }

        private void VendreJoueur_Load(object sender, EventArgs e)
        {
            string nomEquipe;
            foreach(Joueur monTransfert in lesDemandes)
            {
                nomEquipe = Equipe.trouverEquipe(monTransfert.IdEquipe).Nom;
                lb_transfert.Items.Add(monTransfert.Nom + " à " + nomEquipe + " ?");
            }
        }
    }
}
