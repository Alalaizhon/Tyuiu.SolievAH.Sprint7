
namespace Tyuiu.SolievAH.Sprint7.Projcet.V10.Forms
{
    partial class FormCustomer
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
            this.panelInfo_SAH = new System.Windows.Forms.Panel();
            this.textBoxAccountNumb_SAH = new System.Windows.Forms.TextBox();
            this.buttonRemoveOrdr_SAH = new System.Windows.Forms.Button();
            this.buttonAddCustomer_SAH = new System.Windows.Forms.Button();
            this.textBoxPhoneNum_SAH = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelPhoneNum_SAH = new System.Windows.Forms.Label();
            this.labelAdress_SAH = new System.Windows.Forms.Label();
            this.labelNumber_SAH = new System.Windows.Forms.Label();
            this.labelName_SAH = new System.Windows.Forms.Label();
            this.textBoxAdress_SAH = new System.Windows.Forms.TextBox();
            this.textBoxFullName_SAH = new System.Windows.Forms.TextBox();
            this.panelDesktop_SAH = new System.Windows.Forms.Panel();
            this.dataGridViewCustomer_SAH = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSort_SAH = new System.Windows.Forms.TextBox();
            this.labelSearch_SAH = new System.Windows.Forms.Label();
            this.textBoxSearch_SAH = new System.Windows.Forms.TextBox();
            this.labelSort_SAH = new System.Windows.Forms.Label();
            this.buttonSort_SAH = new System.Windows.Forms.Button();
            this.buttonSaveFile_SAH = new System.Windows.Forms.Button();
            this.buttonOpenFileCustomer_SAH = new System.Windows.Forms.Button();
            this.openFileDialog_SAH = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_SAH = new System.Windows.Forms.SaveFileDialog();
            this.panelInfo_SAH.SuspendLayout();
            this.panelDesktop_SAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer_SAH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo_SAH
            // 
            this.panelInfo_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.panelInfo_SAH.Controls.Add(this.textBoxAccountNumb_SAH);
            this.panelInfo_SAH.Controls.Add(this.buttonRemoveOrdr_SAH);
            this.panelInfo_SAH.Controls.Add(this.buttonAddCustomer_SAH);
            this.panelInfo_SAH.Controls.Add(this.textBoxPhoneNum_SAH);
            this.panelInfo_SAH.Controls.Add(this.labelInfo);
            this.panelInfo_SAH.Controls.Add(this.labelPhoneNum_SAH);
            this.panelInfo_SAH.Controls.Add(this.labelAdress_SAH);
            this.panelInfo_SAH.Controls.Add(this.labelNumber_SAH);
            this.panelInfo_SAH.Controls.Add(this.labelName_SAH);
            this.panelInfo_SAH.Controls.Add(this.textBoxAdress_SAH);
            this.panelInfo_SAH.Controls.Add(this.textBoxFullName_SAH);
            this.panelInfo_SAH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo_SAH.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_SAH.Name = "panelInfo_SAH";
            this.panelInfo_SAH.Size = new System.Drawing.Size(192, 450);
            this.panelInfo_SAH.TabIndex = 0;
            // 
            // textBoxAccountNumb_SAH
            // 
            this.textBoxAccountNumb_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.textBoxAccountNumb_SAH.Location = new System.Drawing.Point(6, 145);
            this.textBoxAccountNumb_SAH.Name = "textBoxAccountNumb_SAH";
            this.textBoxAccountNumb_SAH.Size = new System.Drawing.Size(72, 20);
            this.textBoxAccountNumb_SAH.TabIndex = 47;
            this.textBoxAccountNumb_SAH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAccountNumb_SAH_KeyPress);
            // 
            // buttonRemoveOrdr_SAH
            // 
            this.buttonRemoveOrdr_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.buttonRemoveOrdr_SAH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRemoveOrdr_SAH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(182)))));
            this.buttonRemoveOrdr_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveOrdr_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRemoveOrdr_SAH.Location = new System.Drawing.Point(0, 354);
            this.buttonRemoveOrdr_SAH.Name = "buttonRemoveOrdr_SAH";
            this.buttonRemoveOrdr_SAH.Size = new System.Drawing.Size(192, 46);
            this.buttonRemoveOrdr_SAH.TabIndex = 44;
            this.buttonRemoveOrdr_SAH.Text = "Удалить Клиента";
            this.buttonRemoveOrdr_SAH.UseVisualStyleBackColor = false;
            this.buttonRemoveOrdr_SAH.Click += new System.EventHandler(this.buttonRemoveOrdr_SAH_Click);
            // 
            // buttonAddCustomer_SAH
            // 
            this.buttonAddCustomer_SAH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddCustomer_SAH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(182)))));
            this.buttonAddCustomer_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCustomer_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddCustomer_SAH.Location = new System.Drawing.Point(0, 400);
            this.buttonAddCustomer_SAH.Name = "buttonAddCustomer_SAH";
            this.buttonAddCustomer_SAH.Size = new System.Drawing.Size(192, 50);
            this.buttonAddCustomer_SAH.TabIndex = 46;
            this.buttonAddCustomer_SAH.Text = "Добавить клиента";
            this.buttonAddCustomer_SAH.UseVisualStyleBackColor = true;
            this.buttonAddCustomer_SAH.Click += new System.EventHandler(this.buttonAddCustomer_SAH_Click);
            // 
            // textBoxPhoneNum_SAH
            // 
            this.textBoxPhoneNum_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.textBoxPhoneNum_SAH.Location = new System.Drawing.Point(6, 183);
            this.textBoxPhoneNum_SAH.Name = "textBoxPhoneNum_SAH";
            this.textBoxPhoneNum_SAH.Size = new System.Drawing.Size(81, 20);
            this.textBoxPhoneNum_SAH.TabIndex = 44;
            this.textBoxPhoneNum_SAH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNum_SAH_KeyPress_1);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInfo.Location = new System.Drawing.Point(3, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(189, 17);
            this.labelInfo.TabIndex = 43;
            this.labelInfo.Text = "Введите данные заказчика";
            // 
            // labelPhoneNum_SAH
            // 
            this.labelPhoneNum_SAH.AutoSize = true;
            this.labelPhoneNum_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPhoneNum_SAH.Location = new System.Drawing.Point(6, 167);
            this.labelPhoneNum_SAH.Name = "labelPhoneNum_SAH";
            this.labelPhoneNum_SAH.Size = new System.Drawing.Size(95, 13);
            this.labelPhoneNum_SAH.TabIndex = 39;
            this.labelPhoneNum_SAH.Text = "Номер Телефона";
            // 
            // labelAdress_SAH
            // 
            this.labelAdress_SAH.AutoSize = true;
            this.labelAdress_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAdress_SAH.Location = new System.Drawing.Point(6, 89);
            this.labelAdress_SAH.Name = "labelAdress_SAH";
            this.labelAdress_SAH.Size = new System.Drawing.Size(38, 13);
            this.labelAdress_SAH.TabIndex = 40;
            this.labelAdress_SAH.Text = "Адрес";
            // 
            // labelNumber_SAH
            // 
            this.labelNumber_SAH.AutoSize = true;
            this.labelNumber_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNumber_SAH.Location = new System.Drawing.Point(6, 129);
            this.labelNumber_SAH.Name = "labelNumber_SAH";
            this.labelNumber_SAH.Size = new System.Drawing.Size(72, 13);
            this.labelNumber_SAH.TabIndex = 41;
            this.labelNumber_SAH.Text = "Номер счета";
            // 
            // labelName_SAH
            // 
            this.labelName_SAH.AutoSize = true;
            this.labelName_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelName_SAH.Location = new System.Drawing.Point(6, 41);
            this.labelName_SAH.Name = "labelName_SAH";
            this.labelName_SAH.Size = new System.Drawing.Size(131, 13);
            this.labelName_SAH.TabIndex = 42;
            this.labelName_SAH.Text = "Фамилия Имя Отчество";
            // 
            // textBoxAdress_SAH
            // 
            this.textBoxAdress_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.textBoxAdress_SAH.Location = new System.Drawing.Point(6, 105);
            this.textBoxAdress_SAH.Name = "textBoxAdress_SAH";
            this.textBoxAdress_SAH.Size = new System.Drawing.Size(170, 20);
            this.textBoxAdress_SAH.TabIndex = 37;
            // 
            // textBoxFullName_SAH
            // 
            this.textBoxFullName_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.textBoxFullName_SAH.Location = new System.Drawing.Point(6, 60);
            this.textBoxFullName_SAH.Name = "textBoxFullName_SAH";
            this.textBoxFullName_SAH.Size = new System.Drawing.Size(170, 20);
            this.textBoxFullName_SAH.TabIndex = 38;
            // 
            // panelDesktop_SAH
            // 
            this.panelDesktop_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.panelDesktop_SAH.Controls.Add(this.dataGridViewCustomer_SAH);
            this.panelDesktop_SAH.Controls.Add(this.panel1);
            this.panelDesktop_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop_SAH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelDesktop_SAH.Location = new System.Drawing.Point(192, 0);
            this.panelDesktop_SAH.Name = "panelDesktop_SAH";
            this.panelDesktop_SAH.Size = new System.Drawing.Size(608, 450);
            this.panelDesktop_SAH.TabIndex = 1;
            // 
            // dataGridViewCustomer_SAH
            // 
            this.dataGridViewCustomer_SAH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(182)))));
            this.dataGridViewCustomer_SAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer_SAH.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewCustomer_SAH.Location = new System.Drawing.Point(206, 100);
            this.dataGridViewCustomer_SAH.Name = "dataGridViewCustomer_SAH";
            this.dataGridViewCustomer_SAH.RowHeadersWidth = 10;
            this.dataGridViewCustomer_SAH.Size = new System.Drawing.Size(402, 350);
            this.dataGridViewCustomer_SAH.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.textBoxSort_SAH);
            this.panel1.Controls.Add(this.labelSearch_SAH);
            this.panel1.Controls.Add(this.textBoxSearch_SAH);
            this.panel1.Controls.Add(this.labelSort_SAH);
            this.panel1.Controls.Add(this.buttonSort_SAH);
            this.panel1.Controls.Add(this.buttonSaveFile_SAH);
            this.panel1.Controls.Add(this.buttonOpenFileCustomer_SAH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 100);
            this.panel1.TabIndex = 45;
            // 
            // textBoxSort_SAH
            // 
            this.textBoxSort_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSort_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.textBoxSort_SAH.Location = new System.Drawing.Point(428, 70);
            this.textBoxSort_SAH.Name = "textBoxSort_SAH";
            this.textBoxSort_SAH.Size = new System.Drawing.Size(87, 20);
            this.textBoxSort_SAH.TabIndex = 54;
            // 
            // labelSearch_SAH
            // 
            this.labelSearch_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch_SAH.AutoSize = true;
            this.labelSearch_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.labelSearch_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSearch_SAH.Location = new System.Drawing.Point(333, 54);
            this.labelSearch_SAH.Name = "labelSearch_SAH";
            this.labelSearch_SAH.Size = new System.Drawing.Size(39, 13);
            this.labelSearch_SAH.TabIndex = 53;
            this.labelSearch_SAH.Text = "Поиск";
            // 
            // textBoxSearch_SAH
            // 
            this.textBoxSearch_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.textBoxSearch_SAH.Location = new System.Drawing.Point(336, 70);
            this.textBoxSearch_SAH.Name = "textBoxSearch_SAH";
            this.textBoxSearch_SAH.Size = new System.Drawing.Size(86, 20);
            this.textBoxSearch_SAH.TabIndex = 52;
            this.textBoxSearch_SAH.TextChanged += new System.EventHandler(this.textBoxSearch_SAH_TextChanged_1);
            // 
            // labelSort_SAH
            // 
            this.labelSort_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSort_SAH.AutoSize = true;
            this.labelSort_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.labelSort_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSort_SAH.Location = new System.Drawing.Point(428, 52);
            this.labelSort_SAH.Name = "labelSort_SAH";
            this.labelSort_SAH.Size = new System.Drawing.Size(67, 13);
            this.labelSort_SAH.TabIndex = 51;
            this.labelSort_SAH.Text = "Сортировка";
            // 
            // buttonSort_SAH
            // 
            this.buttonSort_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSort_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.buttonSort_SAH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(182)))));
            this.buttonSort_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSort_SAH.Location = new System.Drawing.Point(519, 54);
            this.buttonSort_SAH.Name = "buttonSort_SAH";
            this.buttonSort_SAH.Size = new System.Drawing.Size(86, 36);
            this.buttonSort_SAH.TabIndex = 50;
            this.buttonSort_SAH.Text = "Сортировать";
            this.buttonSort_SAH.UseVisualStyleBackColor = false;
            this.buttonSort_SAH.Click += new System.EventHandler(this.buttonSort_SAH_Click_1);
            // 
            // buttonSaveFile_SAH
            // 
            this.buttonSaveFile_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFile_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.buttonSaveFile_SAH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(182)))));
            this.buttonSaveFile_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSaveFile_SAH.Location = new System.Drawing.Point(427, 3);
            this.buttonSaveFile_SAH.Name = "buttonSaveFile_SAH";
            this.buttonSaveFile_SAH.Size = new System.Drawing.Size(86, 36);
            this.buttonSaveFile_SAH.TabIndex = 48;
            this.buttonSaveFile_SAH.Text = "Сохранить файл";
            this.buttonSaveFile_SAH.UseVisualStyleBackColor = false;
            this.buttonSaveFile_SAH.Click += new System.EventHandler(this.buttonSaveFile_SAH_Click_1);
            // 
            // buttonOpenFileCustomer_SAH
            // 
            this.buttonOpenFileCustomer_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFileCustomer_SAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.buttonOpenFileCustomer_SAH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(182)))));
            this.buttonOpenFileCustomer_SAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFileCustomer_SAH.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOpenFileCustomer_SAH.Location = new System.Drawing.Point(519, 3);
            this.buttonOpenFileCustomer_SAH.Name = "buttonOpenFileCustomer_SAH";
            this.buttonOpenFileCustomer_SAH.Size = new System.Drawing.Size(86, 36);
            this.buttonOpenFileCustomer_SAH.TabIndex = 49;
            this.buttonOpenFileCustomer_SAH.Text = "Открыть Клиентов";
            this.buttonOpenFileCustomer_SAH.UseVisualStyleBackColor = false;
            this.buttonOpenFileCustomer_SAH.Click += new System.EventHandler(this.buttonOpenFile_SAH_Click);
            // 
            // openFileDialog_SAH
            // 
            this.openFileDialog_SAH.FileName = "openFileDialog1";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop_SAH);
            this.Controls.Add(this.panelInfo_SAH);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.panelInfo_SAH.ResumeLayout(false);
            this.panelInfo_SAH.PerformLayout();
            this.panelDesktop_SAH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer_SAH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo_SAH;
        private System.Windows.Forms.Panel panelDesktop_SAH;
        private System.Windows.Forms.TextBox textBoxPhoneNum_SAH;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelPhoneNum_SAH;
        private System.Windows.Forms.Label labelAdress_SAH;
        private System.Windows.Forms.Label labelNumber_SAH;
        private System.Windows.Forms.Label labelName_SAH;
        private System.Windows.Forms.TextBox textBoxAdress_SAH;
        private System.Windows.Forms.TextBox textBoxFullName_SAH;
        private System.Windows.Forms.Button buttonAddCustomer_SAH;
        private System.Windows.Forms.TextBox textBoxAccountNumb_SAH;
        private System.Windows.Forms.Button buttonRemoveOrdr_SAH;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SAH;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SAH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSort_SAH;
        private System.Windows.Forms.Label labelSearch_SAH;
        private System.Windows.Forms.TextBox textBoxSearch_SAH;
        private System.Windows.Forms.Label labelSort_SAH;
        private System.Windows.Forms.Button buttonSort_SAH;
        private System.Windows.Forms.Button buttonSaveFile_SAH;
        private System.Windows.Forms.Button buttonOpenFileCustomer_SAH;
        private System.Windows.Forms.DataGridView dataGridViewCustomer_SAH;
    }
}