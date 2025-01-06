namespace Test_WFA
{
    partial class FormUserLog
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
            this.userTB = new System.Windows.Forms.TextBox();
            this.parolaTB = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.parolaLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(273, 144);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(249, 22);
            this.userTB.TabIndex = 2;
            this.userTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // parolaTB
            // 
            this.parolaTB.Location = new System.Drawing.Point(273, 235);
            this.parolaTB.Name = "parolaTB";
            this.parolaTB.Size = new System.Drawing.Size(249, 22);
            this.parolaTB.TabIndex = 4;
            this.parolaTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(270, 116);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(36, 16);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User";
            // 
            // parolaLabel
            // 
            this.parolaLabel.AutoSize = true;
            this.parolaLabel.Location = new System.Drawing.Point(270, 206);
            this.parolaLabel.Name = "parolaLabel";
            this.parolaLabel.Size = new System.Drawing.Size(47, 16);
            this.parolaLabel.TabIndex = 3;
            this.parolaLabel.Text = "Parola";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(658, 358);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // FormUserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.parolaLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.parolaTB);
            this.Controls.Add(this.userTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUserLog";
            this.Text = "UserLogForm";
            this.Load += new System.EventHandler(this.FormUserLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.TextBox parolaTB;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label parolaLabel;
        private System.Windows.Forms.Button OkButton;
    }
}