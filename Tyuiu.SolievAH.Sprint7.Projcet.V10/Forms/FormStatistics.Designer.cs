
namespace Tyuiu.SolievAH.Sprint7.Projcet.V10.Forms
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDone_SAH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartMid_SAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMid_SAH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.buttonDone_SAH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 43);
            this.panel1.TabIndex = 0;
            // 
            // buttonDone_SAH
            // 
            this.buttonDone_SAH.FlatAppearance.BorderSize = 0;
            this.buttonDone_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SAH.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SAH.ForeColor = System.Drawing.Color.White;
            this.buttonDone_SAH.Location = new System.Drawing.Point(126, 0);
            this.buttonDone_SAH.Name = "buttonDone_SAH";
            this.buttonDone_SAH.Size = new System.Drawing.Size(162, 44);
            this.buttonDone_SAH.TabIndex = 1;
            this.buttonDone_SAH.Text = "PUSH PUSH PUSH";
            this.buttonDone_SAH.UseVisualStyleBackColor = true;
            this.buttonDone_SAH.Click += new System.EventHandler(this.buttonDone_SAH_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.chartMid_SAH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 289);
            this.panel2.TabIndex = 1;
            // 
            // chartMid_SAH
            // 
            this.chartMid_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.chartMid_SAH.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.chartMid_SAH.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            chartArea1.Name = "ChartArea1";
            this.chartMid_SAH.ChartAreas.Add(chartArea1);
            this.chartMid_SAH.Location = new System.Drawing.Point(0, 0);
            this.chartMid_SAH.Name = "chartMid_SAH";
            this.chartMid_SAH.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.YValuesPerPoint = 2;
            this.chartMid_SAH.Series.Add(series1);
            this.chartMid_SAH.Size = new System.Drawing.Size(432, 300);
            this.chartMid_SAH.TabIndex = 0;
            this.chartMid_SAH.Text = "Price Mid";
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 332);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMid_SAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMid_SAH;
        private System.Windows.Forms.Button buttonDone_SAH;
    }
}