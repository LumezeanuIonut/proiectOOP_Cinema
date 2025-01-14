namespace Test_WFA
{
    partial class FormCreareUtilizator
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
            this.crUser_label = new System.Windows.Forms.Label();
            this.np_label = new System.Windows.Forms.Label();
            this.parola_label = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.parola_tb = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crUser_label
            // 
            this.crUser_label.AutoSize = true;
            this.crUser_label.Location = new System.Drawing.Point(369, 28);
            this.crUser_label.Name = "crUser_label";
            this.crUser_label.Size = new System.Drawing.Size(80, 16);
            this.crUser_label.TabIndex = 0;
            this.crUser_label.Text = "Creare User";
            // 
            // np_label
            // 
            this.np_label.AutoSize = true;
            this.np_label.Location = new System.Drawing.Point(88, 160);
            this.np_label.Name = "np_label";
            this.np_label.Size = new System.Drawing.Size(112, 16);
            this.np_label.TabIndex = 1;
            this.np_label.Text = "Nume si prenume";
            // 
            // parola_label
            // 
            this.parola_label.AutoSize = true;
            this.parola_label.Location = new System.Drawing.Point(147, 209);
            this.parola_label.Name = "parola_label";
            this.parola_label.Size = new System.Drawing.Size(47, 16);
            this.parola_label.TabIndex = 2;
            this.parola_label.Text = "Parola";
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(218, 157);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(389, 22);
            this.username_tb.TabIndex = 3;
            this.username_tb.TextChanged += new System.EventHandler(this.username_tb_TextChanged);
            // 
            // parola_tb
            // 
            this.parola_tb.Location = new System.Drawing.Point(218, 209);
            this.parola_tb.Name = "parola_tb";
            this.parola_tb.Size = new System.Drawing.Size(389, 22);
            this.parola_tb.TabIndex = 4;
            this.parola_tb.TextChanged += new System.EventHandler(this.parola_tb_TextChanged);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(669, 394);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 5;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // FormCreareUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.parola_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.parola_label);
            this.Controls.Add(this.np_label);
            this.Controls.Add(this.crUser_label);
            this.Name = "FormCreareUtilizator";
            this.Text = "FormCreareUtilizator";
            this.Load += new System.EventHandler(this.FormCreareUtilizator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label crUser_label;
        private System.Windows.Forms.Label np_label;
        private System.Windows.Forms.Label parola_label;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox parola_tb;
        private System.Windows.Forms.Button ok_button;
    }
}