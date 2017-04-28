using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MercatoManager
{
    public partial class ChoixEquipe : Form
    {
        public SqlConnection laConnection = new SqlConnection();
        public ChoixEquipe()
        {

            InitializeComponent();
            //laConnection.ConnectionString = "Data Source= S458-139-1\\SQLSERVER;Initial Catalog=collectorManager;Integrated Security=True";
            laConnection.ConnectionString = "Data Source= PC-DE-WILLIAM\\SQLSERVER;Initial Catalog=collectorManager;Integrated Security=True";
        }

        //A chaque changement d'équipe sélectionnée dans la listbox
        private void lb_equipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On récupère l'id du de l'équipe sélectionnée
            int monId = lb_equipe.SelectedIndex;
            //On rend visible le groupbox
            gb_infoEquip.Visible = true;
            //On affiche les infos de l'équipe
            //lbl_nom.Text = Equipe.lesEqp[monId].Nom;
            //int budget = Equipe.lesEqp[monId].Budget / 1000000;
            //lbl_budget.Text = budget + " Millions";
            //Création d'une liste des joueurs appartenant à l'équipe sélectionnée
            //List<Joueur> mesJoueurs = Equipe.lesEqp[monId].JoueursDeLequipe;
            //On vide la listbox de joueur
            lb_joueur.Items.Clear();
            //Pour chaque joueur de l'équipe : ajout à la listbox de joueur
            lb_joueur.DataSource = MaJListeJoueur(lb_equipe.SelectedIndex);
            
        }

        //Au chargement du formulaire
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Joueur> lesJoueurs = new List<Joueur>();
            // Ajout de chaque équipe à la listebox
            lb_equipe.DataSource = MaJListeEquipe();
            lb_equipe.SelectedIndex = 0;
        }

        //MISE A JOUR DE LA LISTE DES JOUEURS 
        private List<string> MaJListeJoueur(int idEqp)
        {
            //instanciation d'une liste
            List<string> lesJoueurs = new List<string>();
            try
            {
                laConnection.Open();
                SqlCommand cmd;
                SqlDataReader lecteur;
                string reqSql = "Select * from Joueur where idEqp="+ idEqp;
                cmd = new SqlCommand(reqSql, laConnection);
                lecteur = cmd.ExecuteReader();
                while (lecteur.Read())
                {
                    string leJoueur = lecteur["nom"].ToString();
                    leJoueur += lecteur["note"].ToString();
                    lesJoueurs.Add(leJoueur);
                }
                laConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //retour du résultat
            return lesJoueurs;
        }

        //MISE A JOUR DE LA LISTE DES EQUIPES
        private List<string> MaJListeEquipe()
        {
            //instanciation d'une liste
            List<string> lesEquipes = new List<string>();
            try
            {
                laConnection.Open();
                SqlCommand cmd;
                SqlDataReader lecteur;
                string reqSql = "Select * from Equipe";
                cmd = new SqlCommand(reqSql, laConnection);
                lecteur = cmd.ExecuteReader();
                while (lecteur.Read())
                {
                    string lEquipe = lecteur["nom"].ToString();
                    lesEquipes.Add(lEquipe);
                }
                laConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //retour du résultat
            return lesEquipes;
        }

        //Ouverture de formulaire formPrincipal au clic du bouton valider
        private void bt_valider_Click(object sender, EventArgs e)
        {
            Form form = new formPrincipal(lb_equipe.SelectedIndex);
            form.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
