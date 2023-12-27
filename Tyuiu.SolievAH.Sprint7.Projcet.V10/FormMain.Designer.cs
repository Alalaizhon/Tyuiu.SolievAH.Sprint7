
namespace Tyuiu.SolievAH.Sprint7.Projcet.V10
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu_SAH = new System.Windows.Forms.Panel();
            this.buttonCustomer_SAH = new System.Windows.Forms.Button();
            this.buttonHelp_SAH = new System.Windows.Forms.Button();
            this.buttonOrder_SAH = new System.Windows.Forms.Button();
            this.panelLogo_SAH = new System.Windows.Forms.Panel();
            this.panelDesktop_SAH = new System.Windows.Forms.Panel();
            this.buttonAbout_SAH = new System.Windows.Forms.Button();
            this.panelMenu_SAH.SuspendLayout();
            this.panelLogo_SAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu_SAH
            // 
            this.panelMenu_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(73)))));
            this.panelMenu_SAH.Controls.Add(this.buttonHelp_SAH);
            this.panelMenu_SAH.Controls.Add(this.buttonCustomer_SAH);
            this.panelMenu_SAH.Controls.Add(this.buttonOrder_SAH);
            this.panelMenu_SAH.Controls.Add(this.panelLogo_SAH);
            this.panelMenu_SAH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu_SAH.Location = new System.Drawing.Point(0, 0);
            this.panelMenu_SAH.Name = "panelMenu_SAH";
            this.panelMenu_SAH.Size = new System.Drawing.Size(220, 570);
            this.panelMenu_SAH.TabIndex = 0;
            // 
            // buttonCustomer_SAH
            // 
            this.buttonCustomer_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomer_SAH.FlatAppearance.BorderSize = 0;
            this.buttonCustomer_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomer_SAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCustomer_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustomer_SAH.Image")));
            this.buttonCustomer_SAH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer_SAH.Location = new System.Drawing.Point(0, 188);
            this.buttonCustomer_SAH.Name = "buttonCustomer_SAH";
            this.buttonCustomer_SAH.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonCustomer_SAH.Size = new System.Drawing.Size(220, 60);
            this.buttonCustomer_SAH.TabIndex = 4;
            this.buttonCustomer_SAH.Text = "    Клиенты";
            this.buttonCustomer_SAH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer_SAH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCustomer_SAH.UseVisualStyleBackColor = true;
            this.buttonCustomer_SAH.Click += new System.EventHandler(this.buttonCustomer_SAH_Click);
            // 
            // buttonHelp_SAH
            // 
            this.buttonHelp_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp_SAH.FlatAppearance.BorderSize = 0;
            this.buttonHelp_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHelp_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAH.Image")));
            this.buttonHelp_SAH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp_SAH.Location = new System.Drawing.Point(0, 248);
            this.buttonHelp_SAH.Name = "buttonHelp_SAH";
            this.buttonHelp_SAH.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonHelp_SAH.Size = new System.Drawing.Size(220, 60);
            this.buttonHelp_SAH.TabIndex = 2;
            this.buttonHelp_SAH.Text = "    Помощь";
            this.buttonHelp_SAH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp_SAH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHelp_SAH.UseVisualStyleBackColor = true;
            this.buttonHelp_SAH.Click += new System.EventHandler(this.buttonHelp_SAH_Click);
            // 
            // buttonOrder_SAH
            // 
            this.buttonOrder_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrder_SAH.FlatAppearance.BorderSize = 0;
            this.buttonOrder_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder_SAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOrder_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonOrder_SAH.Image")));
            this.buttonOrder_SAH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrder_SAH.Location = new System.Drawing.Point(0, 128);
            this.buttonOrder_SAH.Name = "buttonOrder_SAH";
            this.buttonOrder_SAH.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonOrder_SAH.Size = new System.Drawing.Size(220, 60);
            this.buttonOrder_SAH.TabIndex = 1;
            this.buttonOrder_SAH.Text = "    Заказы";
            this.buttonOrder_SAH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrder_SAH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrder_SAH.UseVisualStyleBackColor = true;
            this.buttonOrder_SAH.Click += new System.EventHandler(this.buttonOrder_SAH_Click);
            // 
            // panelLogo_SAH
            // 
            this.panelLogo_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo_SAH.Controls.Add(this.buttonAbout_SAH);
            this.panelLogo_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo_SAH.Location = new System.Drawing.Point(0, 0);
            this.panelLogo_SAH.Name = "panelLogo_SAH";
            this.panelLogo_SAH.Size = new System.Drawing.Size(220, 128);
            this.panelLogo_SAH.TabIndex = 0;
            // 
            // panelDesktop_SAH
            // 
            this.panelDesktop_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.panelDesktop_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop_SAH.Location = new System.Drawing.Point(220, 0);
            this.panelDesktop_SAH.Name = "panelDesktop_SAH";
            this.panelDesktop_SAH.Size = new System.Drawing.Size(806, 570);
            this.panelDesktop_SAH.TabIndex = 1;
            // 
            // buttonAbout_SAH
            // 
            this.buttonAbout_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(182)))));
            this.buttonAbout_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAbout_SAH.FlatAppearance.BorderSize = 0;
            this.buttonAbout_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout_SAH.Image")));
            this.buttonAbout_SAH.Location = new System.Drawing.Point(0, 0);
            this.buttonAbout_SAH.Name = "buttonAbout_SAH";
            this.buttonAbout_SAH.Size = new System.Drawing.Size(220, 128);
            this.buttonAbout_SAH.TabIndex = 0;
            this.buttonAbout_SAH.UseVisualStyleBackColor = false;
            this.buttonAbout_SAH.Click += new System.EventHandler(this.buttonAbout_SAH_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 570);
            this.Controls.Add(this.panelDesktop_SAH);
            this.Controls.Add(this.panelMenu_SAH);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Order Stranding";
            this.panelMenu_SAH.ResumeLayout(false);
            this.panelLogo_SAH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu_SAH;
        private System.Windows.Forms.Button buttonOrder_SAH;
        private System.Windows.Forms.Panel panelLogo_SAH;
        private System.Windows.Forms.Panel panelDesktop_SAH;
        private System.Windows.Forms.Button buttonHelp_SAH;
        private System.Windows.Forms.Button buttonCustomer_SAH;
        private System.Windows.Forms.Button buttonAbout_SAH;
    }
}

