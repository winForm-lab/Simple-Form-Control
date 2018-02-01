namespace Simple_Form_Control.CustomControls
{
    partial class Form1
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
            this.customControl11 = new Simple_Form_Control.CustomControl1();
            this.customControl12 = new Simple_Form_Control.CustomControl1();
            this.SuspendLayout();
            // 
            // customControl11
            // 
            this.customControl11.Location = new System.Drawing.Point(53, 82);
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(75, 23);
            this.customControl11.TabIndex = 0;
            this.customControl11.Text = "customControl11";
            // 
            // customControl12
            // 
            this.customControl12.Location = new System.Drawing.Point(75, 32);
            this.customControl12.Name = "customControl12";
            this.customControl12.Size = new System.Drawing.Size(75, 23);
            this.customControl12.TabIndex = 1;
            this.customControl12.Text = "customControl12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.customControl12);
            this.Controls.Add(this.customControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl1 customControl11;
        private CustomControl1 customControl12;
    }
}