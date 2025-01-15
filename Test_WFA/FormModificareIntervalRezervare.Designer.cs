namespace Test_WFA
{
    partial class FormModificareIntervalRezervare
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
            this.label1 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.rezervare_label = new System.Windows.Forms.Label();
            this.rezervare_tb = new System.Windows.Forms.TextBox();
            this.inceput_dtp = new System.Windows.Forms.DateTimePicker();
            this.inceput_gb = new System.Windows.Forms.GroupBox();
            this.sf_gb = new System.Windows.Forms.GroupBox();
            this.sf_dtp = new System.Windows.Forms.DateTimePicker();
            this.inceput_gb.SuspendLayout();
            this.sf_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificare interval rezervare ";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(687, 396);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // rezervare_label
            // 
            this.rezervare_label.AutoSize = true;
            this.rezervare_label.Location = new System.Drawing.Point(53, 88);
            this.rezervare_label.Name = "rezervare_label";
            this.rezervare_label.Size = new System.Drawing.Size(70, 16);
            this.rezervare_label.TabIndex = 2;
            this.rezervare_label.Text = "Rezervare";
            // 
            // rezervare_tb
            // 
            this.rezervare_tb.Location = new System.Drawing.Point(133, 82);
            this.rezervare_tb.Name = "rezervare_tb";
            this.rezervare_tb.Size = new System.Drawing.Size(368, 22);
            this.rezervare_tb.TabIndex = 3;
            this.rezervare_tb.TextChanged += new System.EventHandler(this.rezervare_tb_TextChanged);
            // 
            // inceput_dtp
            // 
            this.inceput_dtp.Location = new System.Drawing.Point(35, 43);
            this.inceput_dtp.Name = "inceput_dtp";
            this.inceput_dtp.Size = new System.Drawing.Size(278, 22);
            this.inceput_dtp.TabIndex = 4;
            // 
            // inceput_gb
            // 
            this.inceput_gb.Controls.Add(this.inceput_dtp);
            this.inceput_gb.Location = new System.Drawing.Point(42, 189);
            this.inceput_gb.Name = "inceput_gb";
            this.inceput_gb.Size = new System.Drawing.Size(352, 100);
            this.inceput_gb.TabIndex = 8;
            this.inceput_gb.TabStop = false;
            this.inceput_gb.Text = "Inceput rezervare";
            // 
            // sf_gb
            // 
            this.sf_gb.Controls.Add(this.sf_dtp);
            this.sf_gb.Location = new System.Drawing.Point(421, 189);
            this.sf_gb.Name = "sf_gb";
            this.sf_gb.Size = new System.Drawing.Size(352, 100);
            this.sf_gb.TabIndex = 9;
            this.sf_gb.TabStop = false;
            this.sf_gb.Text = "Sfarsit rezervare";
            // 
            // sf_dtp
            // 
            this.sf_dtp.Location = new System.Drawing.Point(35, 43);
            this.sf_dtp.Name = "sf_dtp";
            this.sf_dtp.Size = new System.Drawing.Size(278, 22);
            this.sf_dtp.TabIndex = 4;
            // 
            // FormModificareIntervalRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sf_gb);
            this.Controls.Add(this.inceput_gb);
            this.Controls.Add(this.rezervare_tb);
            this.Controls.Add(this.rezervare_label);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label1);
            this.Name = "FormModificareIntervalRezervare";
            this.Text = "FormModificareIntervalRezervare";
            this.Load += new System.EventHandler(this.FormModificareIntervalRezervare_Load);
            this.inceput_gb.ResumeLayout(false);
            this.sf_gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label rezervare_label;
        private System.Windows.Forms.TextBox rezervare_tb;
        private System.Windows.Forms.DateTimePicker inceput_dtp;
        private System.Windows.Forms.GroupBox inceput_gb;
        private System.Windows.Forms.GroupBox sf_gb;
        private System.Windows.Forms.DateTimePicker sf_dtp;
    }
}