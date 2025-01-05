namespace Test_WFA
{
    partial class Form1
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
            this.PrenumeText = new System.Windows.Forms.TextBox();
            this.NumeText = new System.Windows.Forms.TextBox();
            this.BiletHorror = new System.Windows.Forms.RadioButton();
            this.BiletThriller = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.gb_TipBilet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_TipBilet.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrenumeText
            // 
            this.PrenumeText.Location = new System.Drawing.Point(520, 92);
            this.PrenumeText.Name = "PrenumeText";
            this.PrenumeText.Size = new System.Drawing.Size(188, 22);
            this.PrenumeText.TabIndex = 4;
            // 
            // NumeText
            // 
            this.NumeText.Location = new System.Drawing.Point(178, 94);
            this.NumeText.Name = "NumeText";
            this.NumeText.Size = new System.Drawing.Size(175, 22);
            this.NumeText.TabIndex = 2;
            this.NumeText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BiletHorror
            // 
            this.BiletHorror.AutoSize = true;
            this.BiletHorror.Location = new System.Drawing.Point(18, 40);
            this.BiletHorror.Name = "BiletHorror";
            this.BiletHorror.Size = new System.Drawing.Size(66, 20);
            this.BiletHorror.TabIndex = 6;
            this.BiletHorror.TabStop = true;
            this.BiletHorror.Text = "Horror";
            this.BiletHorror.UseVisualStyleBackColor = true;
            this.BiletHorror.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BiletThriller
            // 
            this.BiletThriller.AutoSize = true;
            this.BiletThriller.Location = new System.Drawing.Point(217, 40);
            this.BiletThriller.Name = "BiletThriller";
            this.BiletThriller.Size = new System.Drawing.Size(69, 20);
            this.BiletThriller.TabIndex = 7;
            this.BiletThriller.TabStop = true;
            this.BiletThriller.Text = "Thriller";
            this.BiletThriller.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(583, 343);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(92, 35);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // gb_TipBilet
            // 
            this.gb_TipBilet.Controls.Add(this.BiletHorror);
            this.gb_TipBilet.Controls.Add(this.BiletThriller);
            this.gb_TipBilet.Location = new System.Drawing.Point(178, 236);
            this.gb_TipBilet.Name = "gb_TipBilet";
            this.gb_TipBilet.Size = new System.Drawing.Size(369, 100);
            this.gb_TipBilet.TabIndex = 5;
            this.gb_TipBilet.TabStop = false;
            this.gb_TipBilet.Text = "Tip Bilet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_TipBilet);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NumeText);
            this.Controls.Add(this.PrenumeText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_TipBilet.ResumeLayout(false);
            this.gb_TipBilet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrenumeText;
        private System.Windows.Forms.TextBox NumeText;
        private System.Windows.Forms.RadioButton BiletHorror;
        private System.Windows.Forms.RadioButton BiletThriller;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox gb_TipBilet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

