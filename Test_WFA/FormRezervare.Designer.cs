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
            this.OKButton = new System.Windows.Forms.Button();
            this.gb_DataRez = new System.Windows.Forms.GroupBox();
            this.dataFinalizariiLabel = new System.Windows.Forms.Label();
            this.dataInceputLabel = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TitluRezervare = new System.Windows.Forms.Label();
            this.filmLabel = new System.Windows.Forms.Label();
            this.film_tb = new System.Windows.Forms.TextBox();
            this.gb_DataRez.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(706, 408);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(92, 35);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // gb_DataRez
            // 
            this.gb_DataRez.Controls.Add(this.dataFinalizariiLabel);
            this.gb_DataRez.Controls.Add(this.dataInceputLabel);
            this.gb_DataRez.Controls.Add(this.dateTimePicker2);
            this.gb_DataRez.Controls.Add(this.dateTimePicker1);
            this.gb_DataRez.Location = new System.Drawing.Point(60, 230);
            this.gb_DataRez.Name = "gb_DataRez";
            this.gb_DataRez.Size = new System.Drawing.Size(549, 97);
            this.gb_DataRez.TabIndex = 9;
            this.gb_DataRez.TabStop = false;
            this.gb_DataRez.Text = "Data rezervare";
            this.gb_DataRez.Enter += new System.EventHandler(this.gb_DataRez_Enter);
            // 
            // dataFinalizariiLabel
            // 
            this.dataFinalizariiLabel.AutoSize = true;
            this.dataFinalizariiLabel.Location = new System.Drawing.Point(15, 69);
            this.dataFinalizariiLabel.Name = "dataFinalizariiLabel";
            this.dataFinalizariiLabel.Size = new System.Drawing.Size(90, 16);
            this.dataFinalizariiLabel.TabIndex = 3;
            this.dataFinalizariiLabel.Text = "Data finalizarii";
            this.dataFinalizariiLabel.Click += new System.EventHandler(this.label2_Click);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(388, 22);
            this.dateTimePicker1.TabIndex = 0;
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
            // filmLabel
            // 
            this.filmLabel.AutoSize = true;
            this.filmLabel.Location = new System.Drawing.Point(57, 79);
            this.filmLabel.Name = "filmLabel";
            this.filmLabel.Size = new System.Drawing.Size(35, 16);
            this.filmLabel.TabIndex = 10;
            this.filmLabel.Text = "Film ";
            this.filmLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // film_tb
            // 
            this.film_tb.Location = new System.Drawing.Point(134, 73);
            this.film_tb.Name = "film_tb";
            this.film_tb.Size = new System.Drawing.Size(448, 22);
            this.film_tb.TabIndex = 11;
            // 
            // FormRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 574);
            this.Controls.Add(this.film_tb);
            this.Controls.Add(this.filmLabel);
            this.Controls.Add(this.TitluRezervare);
            this.Controls.Add(this.gb_DataRez);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRezervare";
            this.Text = "RezervareForm";
            this.Load += new System.EventHandler(this.FormRezervare_Load);
            this.gb_DataRez.ResumeLayout(false);
            this.gb_DataRez.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.GroupBox gb_DataRez;
        private System.Windows.Forms.Label dataFinalizariiLabel;
        private System.Windows.Forms.Label dataInceputLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label TitluRezervare;
        private System.Windows.Forms.Label filmLabel;
        private System.Windows.Forms.TextBox film_tb;
    }
}

