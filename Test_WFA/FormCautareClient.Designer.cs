namespace Test_WFA
{
    partial class FormCautareClient
    {
        private System.ComponentModel.IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCautare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCautare
            // 
            this.buttonCautare.Location = new System.Drawing.Point(150, 100);
            this.buttonCautare.Name = "buttonCautare";
            this.buttonCautare.Size = new System.Drawing.Size(100, 30);
            this.buttonCautare.TabIndex = 1;
            this.buttonCautare.Text = "Cautare";
            this.buttonCautare.UseVisualStyleBackColor = true;
            this.buttonCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // FormCautareClient
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCautare);
            this.Controls.Add(this.textBox1);
            this.Name = "FormCautareClient";
            this.Text = "Cautare Client";
            this.Load += new System.EventHandler(this.FormCautareClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCautare;
        private System.Windows.Forms.Label label1;
    }
}