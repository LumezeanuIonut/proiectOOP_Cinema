namespace Test_WFA
{
    partial class FormModificareRez
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
            this.ModifyRezTitle = new System.Windows.Forms.Label();
            this.modRez_tb = new System.Windows.Forms.TextBox();
            this.modRezLabel = new System.Windows.Forms.Label();
            this.textDurata = new System.Windows.Forms.TextBox();
            this.durataLabel = new System.Windows.Forms.Label();
            this.gb_DataRez = new System.Windows.Forms.GroupBox();
            this.dataFinalizariiLabel = new System.Windows.Forms.Label();
            this.dataInceputLabel = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.OKButton = new System.Windows.Forms.Button();
            this.gb_TipBilet = new System.Windows.Forms.GroupBox();
            this.BiletActiune = new System.Windows.Forms.RadioButton();
            this.BiletDrama = new System.Windows.Forms.RadioButton();
            this.gb_DataRez.SuspendLayout();
            this.gb_TipBilet.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyRezTitle
            // 
            this.ModifyRezTitle.AutoSize = true;
            this.ModifyRezTitle.Location = new System.Drawing.Point(317, 41);
            this.ModifyRezTitle.Name = "ModifyRezTitle";
            this.ModifyRezTitle.Size = new System.Drawing.Size(130, 16);
            this.ModifyRezTitle.TabIndex = 0;
            this.ModifyRezTitle.Text = "Modificare rezervare";
            // 
            // modRez_tb
            // 
            this.modRez_tb.Location = new System.Drawing.Point(216, 99);
            this.modRez_tb.Name = "modRez_tb";
            this.modRez_tb.Size = new System.Drawing.Size(332, 22);
            this.modRez_tb.TabIndex = 1;
            this.modRez_tb.TextChanged += new System.EventHandler(this.modRez_tb_TextChanged);
            // 
            // modRezLabel
            // 
            this.modRezLabel.AutoSize = true;
            this.modRezLabel.Location = new System.Drawing.Point(66, 102);
            this.modRezLabel.Name = "modRezLabel";
            this.modRezLabel.Size = new System.Drawing.Size(144, 20);
            this.modRezLabel.TabIndex = 2;
            this.modRezLabel.Text = "Alegere rezervare";
            this.modRezLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textDurata
            // 
            this.textDurata.Location = new System.Drawing.Point(216, 151);
            this.textDurata.Name = "textDurata";
            this.textDurata.Size = new System.Drawing.Size(200, 22);
            this.textDurata.TabIndex = 11;
            // 
            // durataLabel
            // 
            this.durataLabel.AutoSize = true;
            this.durataLabel.Location = new System.Drawing.Point(66, 157);
            this.durataLabel.Name = "durataLabel";
            this.durataLabel.Size = new System.Drawing.Size(105, 16);
            this.durataLabel.TabIndex = 10;
            this.durataLabel.Text = "Durata rezervarii";
            // 
            // gb_DataRez
            // 
            this.gb_DataRez.Controls.Add(this.dataFinalizariiLabel);
            this.gb_DataRez.Controls.Add(this.dataInceputLabel);
            this.gb_DataRez.Controls.Add(this.dateTimePicker2);
            this.gb_DataRez.Controls.Add(this.dateTimePicker1);
            this.gb_DataRez.Location = new System.Drawing.Point(70, 301);
            this.gb_DataRez.Name = "gb_DataRez";
            this.gb_DataRez.Size = new System.Drawing.Size(549, 97);
            this.gb_DataRez.TabIndex = 14;
            this.gb_DataRez.TabStop = false;
            this.gb_DataRez.Text = "Data rezervare";
            // 
            // dataFinalizariiLabel
            // 
            this.dataFinalizariiLabel.AutoSize = true;
            this.dataFinalizariiLabel.Location = new System.Drawing.Point(15, 69);
            this.dataFinalizariiLabel.Name = "dataFinalizariiLabel";
            this.dataFinalizariiLabel.Size = new System.Drawing.Size(90, 16);
            this.dataFinalizariiLabel.TabIndex = 3;
            this.dataFinalizariiLabel.Text = "Data finalizarii";
            // 
            // dataInceputLabel
            // 
            this.dataInceputLabel.AutoSize = true;
            this.dataInceputLabel.Location = new System.Drawing.Point(15, 33);
            this.dataInceputLabel.Name = "dataInceputLabel";
            this.dataInceputLabel.Size = new System.Drawing.Size(90, 16);
            this.dataInceputLabel.TabIndex = 2;
            this.dataInceputLabel.Text = "Data inceperii";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(134, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(388, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(388, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(660, 392);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(92, 35);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // gb_TipBilet
            // 
            this.gb_TipBilet.Controls.Add(this.BiletActiune);
            this.gb_TipBilet.Controls.Add(this.BiletDrama);
            this.gb_TipBilet.Location = new System.Drawing.Point(70, 208);
            this.gb_TipBilet.Name = "gb_TipBilet";
            this.gb_TipBilet.Size = new System.Drawing.Size(377, 72);
            this.gb_TipBilet.TabIndex = 12;
            this.gb_TipBilet.TabStop = false;
            this.gb_TipBilet.Text = "Tip Bilet";
            // 
            // BiletActiune
            // 
            this.BiletActiune.AutoSize = true;
            this.BiletActiune.Location = new System.Drawing.Point(18, 40);
            this.BiletActiune.Name = "BiletActiune";
            this.BiletActiune.Size = new System.Drawing.Size(72, 20);
            this.BiletActiune.TabIndex = 4;
            this.BiletActiune.TabStop = true;
            this.BiletActiune.Text = "Actiune";
            this.BiletActiune.UseVisualStyleBackColor = true;
            // 
            // BiletDrama
            // 
            this.BiletDrama.AutoSize = true;
            this.BiletDrama.Location = new System.Drawing.Point(217, 40);
            this.BiletDrama.Name = "BiletDrama";
            this.BiletDrama.Size = new System.Drawing.Size(69, 20);
            this.BiletDrama.TabIndex = 5;
            this.BiletDrama.TabStop = true;
            this.BiletDrama.Text = "Drama";
            this.BiletDrama.UseVisualStyleBackColor = true;
            // 
            // FormModificareRez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textDurata);
            this.Controls.Add(this.durataLabel);
            this.Controls.Add(this.gb_DataRez);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.gb_TipBilet);
            this.Controls.Add(this.modRezLabel);
            this.Controls.Add(this.modRez_tb);
            this.Controls.Add(this.ModifyRezTitle);
            this.Name = "FormModificareRez";
            this.Text = "FormModificareRez";
            this.Load += new System.EventHandler(this.FormModificareRez_Load);
            this.gb_DataRez.ResumeLayout(false);
            this.gb_DataRez.PerformLayout();
            this.gb_TipBilet.ResumeLayout(false);
            this.gb_TipBilet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyRezTitle;
        private System.Windows.Forms.TextBox modRez_tb;
        private System.Windows.Forms.Label modRezLabel;
        private System.Windows.Forms.TextBox textDurata;
        private System.Windows.Forms.Label durataLabel;
        private System.Windows.Forms.GroupBox gb_DataRez;
        private System.Windows.Forms.Label dataFinalizariiLabel;
        private System.Windows.Forms.Label dataInceputLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.GroupBox gb_TipBilet;
        private System.Windows.Forms.RadioButton BiletActiune;
        private System.Windows.Forms.RadioButton BiletDrama;
    }
}