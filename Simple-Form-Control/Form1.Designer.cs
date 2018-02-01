namespace Simple_Form_Control
{
    partial class Form1
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
            this.flashTrackBar1 = new Microsoft.Samples.WinForms.Cs.FlashTrackBar.FlashTrackBar();
            this.firstControl1 = new Simple_Form_Control.FirstControl();
            this.SuspendLayout();
            // 
            // flashTrackBar1
            // 
            this.flashTrackBar1.BackColor = System.Drawing.Color.Black;
            this.flashTrackBar1.DarkenBy = ((byte)(218));
            this.flashTrackBar1.ForeColor = System.Drawing.Color.White;
            this.flashTrackBar1.Location = new System.Drawing.Point(36, 133);
            this.flashTrackBar1.Name = "flashTrackBar1";
            this.flashTrackBar1.Size = new System.Drawing.Size(289, 58);
            this.flashTrackBar1.TabIndex = 3;
            this.flashTrackBar1.Text = "flashTrackBar1";
            this.flashTrackBar1.Value = 72;
            // 
            // firstControl1
            // 
            this.firstControl1.Location = new System.Drawing.Point(12, 12);
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.Size = new System.Drawing.Size(249, 53);
            this.firstControl1.TabIndex = 2;
            this.firstControl1.Text = "sss";
            this.firstControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 269);
            this.Controls.Add(this.flashTrackBar1);
            this.Controls.Add(this.firstControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private FirstControl firstControl1;
        private Microsoft.Samples.WinForms.Cs.FlashTrackBar.FlashTrackBar flashTrackBar1;
    }
}

