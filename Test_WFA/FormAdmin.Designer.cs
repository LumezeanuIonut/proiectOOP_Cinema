﻿namespace Test_WFA
{
    partial class FormAdmin
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
            this.addFilmButton = new System.Windows.Forms.Button();
            this.remFilmButton = new System.Windows.Forms.Button();
            this.remClientButton = new System.Windows.Forms.Button();
            this.TotRezHistButton = new System.Windows.Forms.Button();
            this.clientRezHistButton = new System.Windows.Forms.Button();
            this.totWinButton = new System.Windows.Forms.Button();
            this.clientWinButton = new System.Windows.Forms.Button();
            this.adaugareAdmin_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFilmButton
            // 
            this.addFilmButton.Location = new System.Drawing.Point(35, 43);
            this.addFilmButton.Name = "addFilmButton";
            this.addFilmButton.Size = new System.Drawing.Size(730, 23);
            this.addFilmButton.TabIndex = 0;
            this.addFilmButton.Text = "Adaugare film";
            this.addFilmButton.UseVisualStyleBackColor = true;
            this.addFilmButton.Click += new System.EventHandler(this.addFilmButton_Click);
            // 
            // remFilmButton
            // 
            this.remFilmButton.Location = new System.Drawing.Point(35, 133);
            this.remFilmButton.Name = "remFilmButton";
            this.remFilmButton.Size = new System.Drawing.Size(730, 23);
            this.remFilmButton.TabIndex = 1;
            this.remFilmButton.Text = "Stergere film";
            this.remFilmButton.UseVisualStyleBackColor = true;
            this.remFilmButton.Click += new System.EventHandler(this.remFilmButton_Click);
            // 
            // remClientButton
            // 
            this.remClientButton.Location = new System.Drawing.Point(35, 222);
            this.remClientButton.Name = "remClientButton";
            this.remClientButton.Size = new System.Drawing.Size(730, 23);
            this.remClientButton.TabIndex = 3;
            this.remClientButton.Text = "Stergere client";
            this.remClientButton.UseVisualStyleBackColor = true;
            this.remClientButton.Click += new System.EventHandler(this.stergereClientButton_Click);
            // 
            // TotRezHistButton
            // 
            this.TotRezHistButton.Location = new System.Drawing.Point(35, 268);
            this.TotRezHistButton.Name = "TotRezHistButton";
            this.TotRezHistButton.Size = new System.Drawing.Size(730, 23);
            this.TotRezHistButton.TabIndex = 4;
            this.TotRezHistButton.Text = "Vizualizare istoric inchirieri filme (per total)";
            this.TotRezHistButton.UseVisualStyleBackColor = true;
            this.TotRezHistButton.Click += new System.EventHandler(this.TotRezHistButton_Click);
            // 
            // clientRezHistButton
            // 
            this.clientRezHistButton.Location = new System.Drawing.Point(35, 316);
            this.clientRezHistButton.Name = "clientRezHistButton";
            this.clientRezHistButton.Size = new System.Drawing.Size(730, 23);
            this.clientRezHistButton.TabIndex = 5;
            this.clientRezHistButton.Text = "Vizualizare istoric inchirieri filme ale unui client ";
            this.clientRezHistButton.UseVisualStyleBackColor = true;
            this.clientRezHistButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // totWinButton
            // 
            this.totWinButton.Location = new System.Drawing.Point(35, 364);
            this.totWinButton.Name = "totWinButton";
            this.totWinButton.Size = new System.Drawing.Size(730, 23);
            this.totWinButton.TabIndex = 6;
            this.totWinButton.Text = "Vizualizare castiguri totale ";
            this.totWinButton.UseVisualStyleBackColor = true;
            this.totWinButton.Click += new System.EventHandler(this.totWinButton_Click);
            // 
            // clientWinButton
            // 
            this.clientWinButton.Location = new System.Drawing.Point(35, 409);
            this.clientWinButton.Name = "clientWinButton";
            this.clientWinButton.Size = new System.Drawing.Size(730, 23);
            this.clientWinButton.TabIndex = 7;
            this.clientWinButton.Text = "Vizualizare castiguri pentru o anumita persoana";
            this.clientWinButton.UseVisualStyleBackColor = true;
            this.clientWinButton.Click += new System.EventHandler(this.clientWinButton_Click);
            // 
            // adaugareAdmin_button
            // 
            this.adaugareAdmin_button.Location = new System.Drawing.Point(35, 87);
            this.adaugareAdmin_button.Name = "adaugareAdmin_button";
            this.adaugareAdmin_button.Size = new System.Drawing.Size(730, 23);
            this.adaugareAdmin_button.TabIndex = 8;
            this.adaugareAdmin_button.Text = "Adaugare admin";
            this.adaugareAdmin_button.UseVisualStyleBackColor = true;
            this.adaugareAdmin_button.Click += new System.EventHandler(this.adaugareAdmin_button_ClickC);
            // 
            // modify_button
            // 
            this.modify_button.Location = new System.Drawing.Point(35, 176);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(730, 23);
            this.modify_button.TabIndex = 9;
            this.modify_button.Text = "Modificare interval rezervari";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 484);
            this.Controls.Add(this.modify_button);
            this.Controls.Add(this.adaugareAdmin_button);
            this.Controls.Add(this.clientWinButton);
            this.Controls.Add(this.totWinButton);
            this.Controls.Add(this.clientRezHistButton);
            this.Controls.Add(this.TotRezHistButton);
            this.Controls.Add(this.remClientButton);
            this.Controls.Add(this.remFilmButton);
            this.Controls.Add(this.addFilmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addFilmButton;
        private System.Windows.Forms.Button remFilmButton;
        private System.Windows.Forms.Button remClientButton;
        private System.Windows.Forms.Button TotRezHistButton;
        private System.Windows.Forms.Button clientRezHistButton;
        private System.Windows.Forms.Button totWinButton;
        private System.Windows.Forms.Button clientWinButton;
        private System.Windows.Forms.Button adaugareAdmin_button;
        private System.Windows.Forms.Button modify_button;
    }
}