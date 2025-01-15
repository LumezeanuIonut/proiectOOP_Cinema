namespace Test_WFA
{
    partial class FormAdaugareFilm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxFilmName;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAddFilm;
        private System.Windows.Forms.Label labelFilmName;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPrice;

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
            this.textBoxFilmName = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAddFilm = new System.Windows.Forms.Button();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFilmName
            // 
            this.textBoxFilmName.Location = new System.Drawing.Point(150, 30);
            this.textBoxFilmName.Name = "textBoxFilmName";
            this.textBoxFilmName.Size = new System.Drawing.Size(200, 22);
            this.textBoxFilmName.TabIndex = 0;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(150, 70);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(200, 22);
            this.textBoxDirector.TabIndex = 1;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(150, 110);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(200, 22);
            this.textBoxGenre.TabIndex = 2;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(150, 150);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(200, 22);
            this.textBoxYear.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(150, 190);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 22);
            this.textBoxPrice.TabIndex = 4;
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Location = new System.Drawing.Point(150, 230);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(100, 30);
            this.buttonAddFilm.TabIndex = 5;
            this.buttonAddFilm.Text = "Add Film";
            this.buttonAddFilm.UseVisualStyleBackColor = true;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // labelFilmName
            // 
            this.labelFilmName.AutoSize = true;
            this.labelFilmName.Location = new System.Drawing.Point(50, 30);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(74, 17);
            this.labelFilmName.TabIndex = 6;
            this.labelFilmName.Text = "Film Name";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(50, 70);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(58, 17);
            this.labelDirector.TabIndex = 7;
            this.labelDirector.Text = "Director";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(50, 110);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(48, 17);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(50, 150);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(38, 17);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Year";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(50, 190);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Price";
            // 
            // FormAdaugareFilm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelFilmName);
            this.Controls.Add(this.buttonAddFilm);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxFilmName);
            this.Name = "FormAdaugareFilm";
            this.Text = "Add Film";
            this.Load += new System.EventHandler(this.FormAdaugareFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}