namespace Test_WFA
{
    partial class FormCautareFilmeClient
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxReservations;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelReservations;

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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelReservations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(150, 50);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 22);
            this.textBoxUsername.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(150, 100);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 30);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.ItemHeight = 16;
            this.listBoxReservations.Location = new System.Drawing.Point(150, 150);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(500, 200);
            this.listBoxReservations.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(50, 50);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 17);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // labelReservations
            // 
            this.labelReservations.AutoSize = true;
            this.labelReservations.Location = new System.Drawing.Point(50, 150);
            this.labelReservations.Name = "labelReservations";
            this.labelReservations.Size = new System.Drawing.Size(89, 17);
            this.labelReservations.TabIndex = 4;
            this.labelReservations.Text = "Reservations";
            // 
            // FormCautareFilmeClient
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelReservations);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.listBoxReservations);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "FormCautareFilmeClient";
            this.Text = "Search Reservations";
            this.Load += new System.EventHandler(this.FormCautareFilmeClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}