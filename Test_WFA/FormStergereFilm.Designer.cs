namespace Test_WFA
{
    partial class FormStergereFilm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxFilm;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Label labelFilm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxFilm = new System.Windows.Forms.TextBox();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.labelFilm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFilm
            // 
            this.textBoxFilm.Location = new System.Drawing.Point(150, 50);
            this.textBoxFilm.Name = "textBoxFilm";
            this.textBoxFilm.Size = new System.Drawing.Size(200, 22);
            this.textBoxFilm.TabIndex = 0;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(150, 100);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(100, 30);
            this.buttonSterge.TabIndex = 1;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Location = new System.Drawing.Point(50, 50);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(34, 17);
            this.labelFilm.TabIndex = 2;
            this.labelFilm.Text = "Film";
            // 
            // FormStergereFilm
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.textBoxFilm);
            this.Name = "FormStergereFilm";
            this.Text = "Stergere Film";
            this.Load += new System.EventHandler(this.FormStergereFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}