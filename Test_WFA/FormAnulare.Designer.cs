namespace Test_WFA
{
    partial class FormAnulare
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
            this.Anulare_label = new System.Windows.Forms.Label();
            this.Rezervari_label = new System.Windows.Forms.Label();
            this.anulari_tb = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Anulare_label
            // 
            this.Anulare_label.AutoSize = true;
            this.Anulare_label.Location = new System.Drawing.Point(351, 19);
            this.Anulare_label.Name = "Anulare_label";
            this.Anulare_label.Size = new System.Drawing.Size(113, 16);
            this.Anulare_label.TabIndex = 0;
            this.Anulare_label.Text = "Anulare rezervare";
            // 
            // Rezervari_label
            // 
            this.Rezervari_label.AutoSize = true;
            this.Rezervari_label.Location = new System.Drawing.Point(63, 177);
            this.Rezervari_label.Name = "Rezervari_label";
            this.Rezervari_label.Size = new System.Drawing.Size(65, 16);
            this.Rezervari_label.TabIndex = 1;
            this.Rezervari_label.Text = "Rezervari";
            // 
            // anulari_tb
            // 
            this.anulari_tb.Location = new System.Drawing.Point(159, 174);
            this.anulari_tb.Name = "anulari_tb";
            this.anulari_tb.Size = new System.Drawing.Size(456, 22);
            this.anulari_tb.TabIndex = 2;
            this.anulari_tb.TextChanged += new System.EventHandler(this.anulari_tb_TextChanged);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(652, 382);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // FormAnulare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.anulari_tb);
            this.Controls.Add(this.Rezervari_label);
            this.Controls.Add(this.Anulare_label);
            this.Name = "FormAnulare";
            this.Text = "FormAnulare";
            this.Load += new System.EventHandler(this.FormAnulare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Anulare_label;
        private System.Windows.Forms.Label Rezervari_label;
        private System.Windows.Forms.TextBox anulari_tb;
        private System.Windows.Forms.Button ok_button;
    }
}