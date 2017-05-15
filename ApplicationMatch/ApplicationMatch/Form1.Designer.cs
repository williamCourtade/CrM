namespace ApplicationMatch
{
    partial class Match
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Match));
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_equipe1 = new System.Windows.Forms.Label();
            this.gb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.lbl_info);
            this.gb_info.Location = new System.Drawing.Point(22, 137);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(375, 350);
            this.gb_info.TabIndex = 0;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Temps forts ";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(6, 26);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(102, 13);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "0\' : Engagement de ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(515, 263);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(103, 40);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "00:00";
            // 
            // lbl_equipe1
            // 
            this.lbl_equipe1.AutoSize = true;
            this.lbl_equipe1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipe1.Location = new System.Drawing.Point(12, 25);
            this.lbl_equipe1.Name = "lbl_equipe1";
            this.lbl_equipe1.Size = new System.Drawing.Size(661, 55);
            this.lbl_equipe1.TabIndex = 3;
            this.lbl_equipe1.Text = "EQUIPE 1  SCORE EQUIPE2";
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 499);
            this.Controls.Add(this.lbl_equipe1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_info);
            this.Name = "Match";
            this.Text = "Match";
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_equipe1;
    }
}

