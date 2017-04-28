namespace MercatoManager
{
    partial class formPrincipal
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
            this.lbl_nomEquipe = new System.Windows.Forms.Label();
            this.lb_joueur = new System.Windows.Forms.ListBox();
            this.monMenu = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectorLeagueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passeDécissiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendreJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derniersTransfertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_infoJoueur = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_poste = new System.Windows.Forms.Label();
            this.lbl_valeur = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_notif = new System.Windows.Forms.PictureBox();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monMenu.SuspendLayout();
            this.gb_infoJoueur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notif)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nomEquipe
            // 
            this.lbl_nomEquipe.AutoSize = true;
            this.lbl_nomEquipe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_nomEquipe.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEquipe.Location = new System.Drawing.Point(12, 39);
            this.lbl_nomEquipe.Name = "lbl_nomEquipe";
            this.lbl_nomEquipe.Size = new System.Drawing.Size(79, 26);
            this.lbl_nomEquipe.TabIndex = 0;
            this.lbl_nomEquipe.Text = "EQUIPE";
            // 
            // lb_joueur
            // 
            this.lb_joueur.FormattingEnabled = true;
            this.lb_joueur.Location = new System.Drawing.Point(12, 123);
            this.lb_joueur.Name = "lb_joueur";
            this.lb_joueur.Size = new System.Drawing.Size(289, 199);
            this.lb_joueur.TabIndex = 1;
            this.lb_joueur.SelectedIndexChanged += new System.EventHandler(this.lb_joueur_SelectedIndexChanged);
            // 
            // monMenu
            // 
            this.monMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.monMenu.Font = new System.Drawing.Font("Verdana", 10F);
            this.monMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.monMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.classementToolStripMenuItem,
            this.mercatoToolStripMenuItem,
            this.testToolStripMenuItem});
            this.monMenu.Location = new System.Drawing.Point(0, 0);
            this.monMenu.Name = "monMenu";
            this.monMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.monMenu.Size = new System.Drawing.Size(815, 25);
            this.monMenu.TabIndex = 2;
            this.monMenu.Text = "Menu";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // classementToolStripMenuItem
            // 
            this.classementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectorLeagueToolStripMenuItem,
            this.butToolStripMenuItem,
            this.passeDécissiveToolStripMenuItem});
            this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
            this.classementToolStripMenuItem.Size = new System.Drawing.Size(101, 21);
            this.classementToolStripMenuItem.Text = "Classement";
            // 
            // collectorLeagueToolStripMenuItem
            // 
            this.collectorLeagueToolStripMenuItem.Name = "collectorLeagueToolStripMenuItem";
            this.collectorLeagueToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.collectorLeagueToolStripMenuItem.Text = "Collector League";
            // 
            // butToolStripMenuItem
            // 
            this.butToolStripMenuItem.Name = "butToolStripMenuItem";
            this.butToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.butToolStripMenuItem.Text = "Meilleur buteur";
            // 
            // passeDécissiveToolStripMenuItem
            // 
            this.passeDécissiveToolStripMenuItem.Name = "passeDécissiveToolStripMenuItem";
            this.passeDécissiveToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.passeDécissiveToolStripMenuItem.Text = "Meilleur passeur décissif";
            // 
            // mercatoToolStripMenuItem
            // 
            this.mercatoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mercatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chercherJoueurToolStripMenuItem,
            this.vendreJoueurToolStripMenuItem,
            this.derniersTransfertsToolStripMenuItem});
            this.mercatoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mercatoToolStripMenuItem.Name = "mercatoToolStripMenuItem";
            this.mercatoToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.mercatoToolStripMenuItem.Text = "Mercato";
            // 
            // chercherJoueurToolStripMenuItem
            // 
            this.chercherJoueurToolStripMenuItem.Name = "chercherJoueurToolStripMenuItem";
            this.chercherJoueurToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.chercherJoueurToolStripMenuItem.Text = "Chercher joueur";
            this.chercherJoueurToolStripMenuItem.Click += new System.EventHandler(this.chercherJoueurToolStripMenuItem_Click);
            // 
            // vendreJoueurToolStripMenuItem
            // 
            this.vendreJoueurToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vendreJoueurToolStripMenuItem.Name = "vendreJoueurToolStripMenuItem";
            this.vendreJoueurToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.vendreJoueurToolStripMenuItem.Text = "Vendre joueur";
            this.vendreJoueurToolStripMenuItem.Click += new System.EventHandler(this.vendreJoueurToolStripMenuItem_Click);
            // 
            // derniersTransfertsToolStripMenuItem
            // 
            this.derniersTransfertsToolStripMenuItem.Name = "derniersTransfertsToolStripMenuItem";
            this.derniersTransfertsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.derniersTransfertsToolStripMenuItem.Text = "Derniers transferts";
            // 
            // bt_suivant
            // 
            this.bt_suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_suivant.Location = new System.Drawing.Point(728, 0);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(75, 23);
            this.bt_suivant.TabIndex = 3;
            this.bt_suivant.Text = "Suivant";
            this.bt_suivant.UseVisualStyleBackColor = true;
            this.bt_suivant.Click += new System.EventHandler(this.bt_suivant_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(487, 1);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mes joueurs";
            // 
            // gb_infoJoueur
            // 
            this.gb_infoJoueur.Controls.Add(this.pictureBox1);
            this.gb_infoJoueur.Controls.Add(this.lbl_poste);
            this.gb_infoJoueur.Controls.Add(this.lbl_valeur);
            this.gb_infoJoueur.Controls.Add(this.lbl_note);
            this.gb_infoJoueur.Controls.Add(this.label4);
            this.gb_infoJoueur.Controls.Add(this.label3);
            this.gb_infoJoueur.Controls.Add(this.label2);
            this.gb_infoJoueur.Location = new System.Drawing.Point(411, 93);
            this.gb_infoJoueur.Name = "gb_infoJoueur";
            this.gb_infoJoueur.Size = new System.Drawing.Size(340, 244);
            this.gb_infoJoueur.TabIndex = 6;
            this.gb_infoJoueur.TabStop = false;
            this.gb_infoJoueur.Text = "Informations";
            this.gb_infoJoueur.Visible = false;
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
            this.lbl_poste.Location = new System.Drawing.Point(55, 166);
            this.lbl_poste.Name = "lbl_poste";
            this.lbl_poste.Size = new System.Drawing.Size(35, 13);
            this.lbl_poste.TabIndex = 5;
            this.lbl_poste.Text = "label5";
            // 
            // lbl_valeur
            // 
            this.lbl_valeur.AutoSize = true;
            this.lbl_valeur.Location = new System.Drawing.Point(55, 132);
            this.lbl_valeur.Name = "lbl_valeur";
            this.lbl_valeur.Size = new System.Drawing.Size(35, 13);
            this.lbl_valeur.TabIndex = 4;
            this.lbl_valeur.Text = "label5";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(55, 95);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(35, 13);
            this.lbl_note.TabIndex = 3;
            this.lbl_note.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Poste :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valeur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Note :";
            // 
            // pb_notif
            // 
            this.pb_notif.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_notif.Image = global::MercatoManager.Properties.Resources.pb_notif;
            this.pb_notif.Location = new System.Drawing.Point(242, -2);
            this.pb_notif.Name = "pb_notif";
            this.pb_notif.Size = new System.Drawing.Size(18, 17);
            this.pb_notif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_notif.TabIndex = 7;
            this.pb_notif.TabStop = false;
            this.pb_notif.Visible = false;
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 378);
            this.Controls.Add(this.pb_notif);
            this.Controls.Add(this.gb_infoJoueur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.lb_joueur);
            this.Controls.Add(this.lbl_nomEquipe);
            this.Controls.Add(this.monMenu);
            this.MainMenuStrip = this.monMenu;
            this.Name = "formPrincipal";
            this.Text = "Mercato Manager";
            this.Load += new System.EventHandler(this.formPrincipale_Load);
            this.monMenu.ResumeLayout(false);
            this.monMenu.PerformLayout();
            this.gb_infoJoueur.ResumeLayout(false);
            this.gb_infoJoueur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomEquipe;
        private System.Windows.Forms.ListBox lb_joueur;
        private System.Windows.Forms.MenuStrip monMenu;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectorLeagueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passeDécissiveToolStripMenuItem;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_infoJoueur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_poste;
        private System.Windows.Forms.Label lbl_valeur;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem chercherJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendreJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derniersTransfertsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_notif;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}