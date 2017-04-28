namespace MercatoManager
{
    partial class VendreJoueur
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
            this.lb_transfert = new System.Windows.Forms.ListBox();
            this.bt_vendre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_transfert
            // 
            this.lb_transfert.FormattingEnabled = true;
            this.lb_transfert.Location = new System.Drawing.Point(12, 34);
            this.lb_transfert.Name = "lb_transfert";
            this.lb_transfert.Size = new System.Drawing.Size(241, 264);
            this.lb_transfert.TabIndex = 0;
            // 
            // bt_vendre
            // 
            this.bt_vendre.Location = new System.Drawing.Point(269, 275);
            this.bt_vendre.Name = "bt_vendre";
            this.bt_vendre.Size = new System.Drawing.Size(75, 23);
            this.bt_vendre.TabIndex = 1;
            this.bt_vendre.Text = "Vendre";
            this.bt_vendre.UseVisualStyleBackColor = true;
            // 
            // VendreJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 365);
            this.Controls.Add(this.bt_vendre);
            this.Controls.Add(this.lb_transfert);
            this.Name = "VendreJoueur";
            this.Text = "VendreJoueur";
            this.Load += new System.EventHandler(this.VendreJoueur_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_transfert;
        private System.Windows.Forms.Button bt_vendre;
    }
}