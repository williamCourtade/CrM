namespace MercatoManager
{
    partial class ChoixEquipe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lb_equipe = new System.Windows.Forms.ListBox();
            this.gb_infoEquip = new System.Windows.Forms.GroupBox();
            this.lb_joueur = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_budget = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_valider = new System.Windows.Forms.Button();
            this.gb_infoEquip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(237, 9);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(286, 29);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "MERCATO MANAGER";
            // 
            // lb_equipe
            // 
            this.lb_equipe.FormattingEnabled = true;
            this.lb_equipe.Location = new System.Drawing.Point(46, 108);
            this.lb_equipe.Name = "lb_equipe";
            this.lb_equipe.Size = new System.Drawing.Size(243, 264);
            this.lb_equipe.TabIndex = 1;
            this.lb_equipe.SelectedIndexChanged += new System.EventHandler(this.lb_equipe_SelectedIndexChanged);
            // 
            // gb_infoEquip
            // 
            this.gb_infoEquip.Controls.Add(this.lb_joueur);
            this.gb_infoEquip.Controls.Add(this.label6);
            this.gb_infoEquip.Controls.Add(this.lbl_budget);
            this.gb_infoEquip.Controls.Add(this.lbl_nom);
            this.gb_infoEquip.Controls.Add(this.label3);
            this.gb_infoEquip.Controls.Add(this.label2);
            this.gb_infoEquip.Location = new System.Drawing.Point(421, 108);
            this.gb_infoEquip.Name = "gb_infoEquip";
            this.gb_infoEquip.Size = new System.Drawing.Size(322, 264);
            this.gb_infoEquip.TabIndex = 2;
            this.gb_infoEquip.TabStop = false;
            this.gb_infoEquip.Text = "Info";
            this.gb_infoEquip.Visible = false;
            // 
            // lb_joueur
            // 
            this.lb_joueur.FormattingEnabled = true;
            this.lb_joueur.Location = new System.Drawing.Point(70, 95);
            this.lb_joueur.Name = "lb_joueur";
            this.lb_joueur.Size = new System.Drawing.Size(246, 160);
            this.lb_joueur.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Joueurs :";
            // 
            // lbl_budget
            // 
            this.lbl_budget.AutoSize = true;
            this.lbl_budget.Location = new System.Drawing.Point(67, 61);
            this.lbl_budget.Name = "lbl_budget";
            this.lbl_budget.Size = new System.Drawing.Size(35, 13);
            this.lbl_budget.TabIndex = 2;
            this.lbl_budget.Text = "label5";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(67, 30);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "label4";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Budget :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choississez une equipe";
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(319, 362);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(75, 23);
            this.bt_valider.TabIndex = 4;
            this.bt_valider.Text = "Choisir";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // ChoixEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 397);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_infoEquip);
            this.Controls.Add(this.lb_equipe);
            this.Controls.Add(this.lbl_titre);
            this.Name = "ChoixEquipe";
            this.Text = "Choix Equipe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_infoEquip.ResumeLayout(false);
            this.gb_infoEquip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.ListBox lb_equipe;
        private System.Windows.Forms.GroupBox gb_infoEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_budget;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_joueur;
        private System.Windows.Forms.Button bt_valider;
    }
}

