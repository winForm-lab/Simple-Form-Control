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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flashTrackBar1 = new Microsoft.Samples.WinForms.Cs.FlashTrackBar.FlashTrackBar();
            this.firstControl1 = new Simple_Form_Control.FirstControl();
            this.attributesDemoControl1 = new AttributesDemoControlLibrary.AttributesDemoControl();
            this.SuspendLayout();
            // 
            // flashTrackBar1
            // 
            this.flashTrackBar1.BackColor = System.Drawing.Color.Black;
            this.flashTrackBar1.DarkenBy = ((byte)(218));
            this.flashTrackBar1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.flashTrackBar1, "flashTrackBar1");
            this.flashTrackBar1.Name = "flashTrackBar1";
            this.flashTrackBar1.Value = 72;
            // 
            // firstControl1
            // 
            resources.ApplyResources(this.firstControl1, "firstControl1");
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attributesDemoControl1
            // 
            this.attributesDemoControl1.AlertForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.attributesDemoControl1, "attributesDemoControl1");
            this.attributesDemoControl1.DataMember = "";
            this.attributesDemoControl1.DataSource = null;
            this.attributesDemoControl1.Name = "attributesDemoControl1";
            this.attributesDemoControl1.Threshold = null;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.attributesDemoControl1);
            this.Controls.Add(this.flashTrackBar1);
            this.Controls.Add(this.firstControl1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FirstControl firstControl1;
        private Microsoft.Samples.WinForms.Cs.FlashTrackBar.FlashTrackBar flashTrackBar1;
        private AttributesDemoControlLibrary.AttributesDemoControl attributesDemoControl1;
    }
}

