namespace Test_WFA
{
    partial class FormRemoveClient
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
            this.remClient_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remClient_label
            // 
            this.remClient_label.AutoSize = true;
            this.remClient_label.Location = new System.Drawing.Point(345, 30);
            this.remClient_label.Name = "remClient_label";
            this.remClient_label.Size = new System.Drawing.Size(93, 16);
            this.remClient_label.TabIndex = 0;
            this.remClient_label.Text = "Stergere client";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(667, 387);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(266, 186);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(356, 22);
            this.id_tb.TabIndex = 3;
            this.id_tb.TextChanged += new System.EventHandler(this.id_tb_TextChanged);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(166, 192);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(39, 16);
            this.id_label.TabIndex = 6;
            this.id_label.Text = "User ";
            // 
            // FormRemoveClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.remClient_label);
            this.Name = "FormRemoveClient";
            this.Text = "FormRemoveClient";
            this.Load += new System.EventHandler(this.FormRemoveClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label remClient_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label id_label;
    }
}