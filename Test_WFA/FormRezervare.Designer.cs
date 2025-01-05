namespace Test_WFA
{
    partial class FormRezervare
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
            this.BiletActiune = new System.Windows.Forms.RadioButton();
            this.BiletDrama = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.gb_TipBilet = new System.Windows.Forms.GroupBox();
            this.gb_DataRez = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataInceputLabel = new System.Windows.Forms.Label();
            this.dataFinalizariiLabel = new System.Windows.Forms.Label();
            this.durataLabel = new System.Windows.Forms.Label();
            this.textDurata = new System.Windows.Forms.TextBox();
            this.TitluRezervare = new System.Windows.Forms.Label();
            this.gb_TipBilet.SuspendLayout();
            this.gb_DataRez.SuspendLayout();
            this.SuspendLayout();
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
            this.BiletActiune.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(610, 390);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(92, 35);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // gb_TipBilet
            // 
            this.gb_TipBilet.Controls.Add(this.BiletActiune);
            this.gb_TipBilet.Controls.Add(this.BiletDrama);
            this.gb_TipBilet.Location = new System.Drawing.Point(12, 145);
            this.gb_TipBilet.Name = "gb_TipBilet";
            this.gb_TipBilet.Size = new System.Drawing.Size(377, 72);
            this.gb_TipBilet.TabIndex = 3;
            this.gb_TipBilet.TabStop = false;
            this.gb_TipBilet.Text = "Tip Bilet";
            // 
            // gb_DataRez
            // 
            this.gb_DataRez.Controls.Add(this.dataFinalizariiLabel);
            this.gb_DataRez.Controls.Add(this.dataInceputLabel);
            this.gb_DataRez.Controls.Add(this.dateTimePicker2);
            this.gb_DataRez.Controls.Add(this.dateTimePicker1);
            this.gb_DataRez.Location = new System.Drawing.Point(12, 238);
            this.gb_DataRez.Name = "gb_DataRez";
            this.gb_DataRez.Size = new System.Drawing.Size(549, 97);
            this.gb_DataRez.TabIndex = 9;
            this.gb_DataRez.TabStop = false;
            this.gb_DataRez.Text = "Data rezervare";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(388, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(134, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(388, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dataInceputLabel
            // 
            this.dataInceputLabel.AutoSize = true;
            this.dataInceputLabel.Location = new System.Drawing.Point(15, 33);
            this.dataInceputLabel.Name = "dataInceputLabel";
            this.dataInceputLabel.Size = new System.Drawing.Size(113, 20);
            this.dataInceputLabel.TabIndex = 2;
            this.dataInceputLabel.Text = "Data inceperii";
            // 
            // dataFinalizariiLabel
            // 
            this.dataFinalizariiLabel.AutoSize = true;
            this.dataFinalizariiLabel.Location = new System.Drawing.Point(15, 69);
            this.dataFinalizariiLabel.Name = "dataFinalizariiLabel";
            this.dataFinalizariiLabel.Size = new System.Drawing.Size(113, 20);
            this.dataFinalizariiLabel.TabIndex = 3;
            this.dataFinalizariiLabel.Text = "Data finalizarii";
            this.dataFinalizariiLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // durataLabel
            // 
            this.durataLabel.AutoSize = true;
            this.durataLabel.Location = new System.Drawing.Point(12, 94);
            this.durataLabel.Name = "durataLabel";
            this.durataLabel.Size = new System.Drawing.Size(105, 16);
            this.durataLabel.TabIndex = 1;
            this.durataLabel.Text = "Durata rezervarii";
            // 
            // textDurata
            // 
            this.textDurata.Location = new System.Drawing.Point(123, 91);
            this.textDurata.Name = "textDurata";
            this.textDurata.Size = new System.Drawing.Size(200, 22);
            this.textDurata.TabIndex = 3;
            // 
            // TitluRezervare
            // 
            this.TitluRezervare.AutoSize = true;
            this.TitluRezervare.Location = new System.Drawing.Point(319, 20);
            this.TitluRezervare.Name = "TitluRezervare";
            this.TitluRezervare.Size = new System.Drawing.Size(121, 16);
            this.TitluRezervare.TabIndex = 0;
            this.TitluRezervare.Text = "Rezervare bilet film";
            this.TitluRezervare.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 574);
            this.Controls.Add(this.TitluRezervare);
            this.Controls.Add(this.textDurata);
            this.Controls.Add(this.durataLabel);
            this.Controls.Add(this.gb_DataRez);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.gb_TipBilet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRezervare";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRezervare_Load);
            this.gb_TipBilet.ResumeLayout(false);
            this.gb_TipBilet.PerformLayout();
            this.gb_DataRez.ResumeLayout(false);
            this.gb_DataRez.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton BiletActiune;
        private System.Windows.Forms.RadioButton BiletDrama;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.GroupBox gb_TipBilet;
        private System.Windows.Forms.GroupBox gb_DataRez;
        private System.Windows.Forms.Label dataFinalizariiLabel;
        private System.Windows.Forms.Label dataInceputLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label durataLabel;
        private System.Windows.Forms.TextBox textDurata;
        private System.Windows.Forms.Label TitluRezervare;
    }
}

