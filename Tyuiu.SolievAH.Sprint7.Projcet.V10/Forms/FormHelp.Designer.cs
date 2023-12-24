
namespace Tyuiu.SolievAH.Sprint7.Projcet.V10.Forms
{
    partial class FormHelp
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
            this.labelTitle_SAH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle_SAH
            // 
            this.labelTitle_SAH.AutoSize = true;
            this.labelTitle_SAH.Location = new System.Drawing.Point(326, 38);
            this.labelTitle_SAH.Name = "labelTitle_SAH";
            this.labelTitle_SAH.Size = new System.Drawing.Size(52, 13);
            this.labelTitle_SAH.TabIndex = 0;
            this.labelTitle_SAH.Text = "ПОмощь";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle_SAH);
            this.Name = "FormHelp";
            this.Text = "FormHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle_SAH;
    }
}