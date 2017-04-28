namespace MercatoManager
{
    partial class transfert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_joueurs = new System.Windows.Forms.ListBox();
            this.bt_acheter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_budget = new System.Windows.Forms.Label();
            this.gb_infoJoueur = new System.Windows.Forms.GroupBox();
            this.lbl_equipe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_poste = new System.Windows.Forms.Label();
            this.lbl_valeur = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_position = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_chercher = new System.Windows.Forms.Button();
            this.gb_infoJoueur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_joueurs
            // 
            this.lb_joueurs.FormattingEnabled = true;
            this.lb_joueurs.Location = new System.Drawing.Point(34, 184);
            this.lb_joueurs.Name = "lb_joueurs";
            this.lb_joueurs.Size = new System.Drawing.Size(283, 277);
            this.lb_joueurs.TabIndex = 0;
            this.lb_joueurs.SelectedIndexChanged += new System.EventHandler(this.lb_joueurs_SelectedIndexChanged);
            // 
            // bt_acheter
            // 
            this.bt_acheter.Location = new System.Drawing.Point(471, 347);
            this.bt_acheter.Name = "bt_acheter";
            this.bt_acheter.Size = new System.Drawing.Size(100, 44);
            this.bt_acheter.TabIndex = 1;
            this.bt_acheter.Text = "Acheter";
            this.bt_acheter.UseVisualStyleBackColor = true;
            this.bt_acheter.Click += new System.EventHandler(this.bt_acheter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Votre budget :";
            // 
            // lbl_budget
            // 
            this.lbl_budget.AutoSize = true;
            this.lbl_budget.Location = new System.Drawing.Point(93, 22);
            this.lbl_budget.Name = "lbl_budget";
            this.lbl_budget.Size = new System.Drawing.Size(22, 13);
            this.lbl_budget.TabIndex = 3;
            this.lbl_budget.Text = "     ";
            // 
            // gb_infoJoueur
            // 
            this.gb_infoJoueur.Controls.Add(this.lbl_equipe);
            this.gb_infoJoueur.Controls.Add(this.label5);
            this.gb_infoJoueur.Controls.Add(this.pictureBox1);
            this.gb_infoJoueur.Controls.Add(this.lbl_poste);
            this.gb_infoJoueur.Controls.Add(this.lbl_valeur);
            this.gb_infoJoueur.Controls.Add(this.lbl_note);
            this.gb_infoJoueur.Controls.Add(this.label4);
            this.gb_infoJoueur.Controls.Add(this.label3);
            this.gb_infoJoueur.Controls.Add(this.label2);
            this.gb_infoJoueur.Location = new System.Drawing.Point(338, 9);
            this.gb_infoJoueur.Name = "gb_infoJoueur";
            this.gb_infoJoueur.Size = new System.Drawing.Size(340, 244);
            this.gb_infoJoueur.TabIndex = 7;
            this.gb_infoJoueur.TabStop = false;
            this.gb_infoJoueur.Text = "Informations";
            this.gb_infoJoueur.Visible = false;
            // 
            // lbl_equipe
            // 
            this.lbl_equipe.AutoSize = true;
            this.lbl_equipe.Location = new System.Drawing.Point(65, 109);
            this.lbl_equipe.Name = "lbl_equipe";
            this.lbl_equipe.Size = new System.Drawing.Size(35, 13);
            this.lbl_equipe.TabIndex = 8;
            this.lbl_equipe.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Equipe :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(194, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 89);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_poste
            // 
            this.lbl_poste.AutoSize = true;
            this.lbl_poste.Location = new System.Drawing.Point(65, 211);
            this.lbl_poste.Name = "lbl_poste";
            this.lbl_poste.Size = new System.Drawing.Size(35, 13);
            this.lbl_poste.TabIndex = 5;
            this.lbl_poste.Text = "label5";
            // 
            // lbl_valeur
            // 
            this.lbl_valeur.AutoSize = true;
            this.lbl_valeur.Location = new System.Drawing.Point(65, 177);
            this.lbl_valeur.Name = "lbl_valeur";
            this.lbl_valeur.Size = new System.Drawing.Size(35, 13);
            this.lbl_valeur.TabIndex = 4;
            this.lbl_valeur.Text = "label5";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(65, 140);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(35, 13);
            this.lbl_note.TabIndex = 3;
            this.lbl_note.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Poste :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valeur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Note :";
            // 
            // lb_position
            // 
            this.lb_position.FormattingEnabled = true;
            this.lb_position.Items.AddRange(new object[] {
            "Tous",
            "Gardien",
            "Defenseur",
            "Milieu",
            "Attaquant"});
            this.lb_position.Location = new System.Drawing.Point(86, 71);
            this.lb_position.Name = "lb_position";
            this.lb_position.ScrollAlwaysVisible = true;
            this.lb_position.Size = new System.Drawing.Size(120, 17);
            this.lb_position.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Position :";
            // 
            // bt_chercher
            // 
            this.bt_chercher.Location = new System.Drawing.Point(107, 108);
            this.bt_chercher.Name = "bt_chercher";
            this.bt_chercher.Size = new System.Drawing.Size(75, 23);
            this.bt_chercher.TabIndex = 10;
            this.bt_chercher.Text = "Chercher";
            this.bt_chercher.UseVisualStyleBackColor = true;
            this.bt_chercher.Click += new System.EventHandler(this.bt_chercher_Click);
            // 
            // transfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 486);
            this.Controls.Add(this.bt_chercher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_position);
            this.Controls.Add(this.gb_infoJoueur);
            this.Controls.Add(this.lbl_budget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_acheter);
            this.Controls.Add(this.lb_joueurs);
            this.Name = "transfert";
            this.Text = "transfert";
            this.Load += new System.EventHandler(this.transfert_Load);
            this.gb_infoJoueur.ResumeLayout(false);
            this.gb_infoJoueur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_joueurs;
        private System.Windows.Forms.Button bt_acheter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_budget;
        private System.Windows.Forms.GroupBox gb_infoJoueur;
        private System.Windows.Forms.Label lbl_equipe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_poste;
        private System.Windows.Forms.Label lbl_valeur;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_chercher;
    }
}