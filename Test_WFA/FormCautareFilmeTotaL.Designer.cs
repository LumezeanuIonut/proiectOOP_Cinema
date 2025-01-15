namespace Test_WFA
{
    partial class FormCautareFilme_total_
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxReservations;
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.labelReservations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(150, 50);
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
            this.listBoxReservations.Location = new System.Drawing.Point(150, 100);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(500, 200);
            this.listBoxReservations.TabIndex = 2;
            // 
            // labelReservations
            // 
            this.labelReservations.AutoSize = true;
            this.labelReservations.Location = new System.Drawing.Point(50, 100);
            this.labelReservations.Name = "labelReservations";
            this.labelReservations.Size = new System.Drawing.Size(89, 17);
            this.labelReservations.TabIndex = 4;
            this.labelReservations.Text = "Reservations";
            // 
            // FormCautareFilme_total_
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelReservations);
            this.Controls.Add(this.listBoxReservations);
            this.Controls.Add(this.buttonSearch);
            this.Name = "FormCautareFilme_total_";
            this.Text = "Search All Reservations";
            this.Load += new System.EventHandler(this.FormCautareFilme_total__Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}