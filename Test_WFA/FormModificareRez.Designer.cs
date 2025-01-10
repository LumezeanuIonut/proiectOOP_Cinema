namespace Test_WFA
{
    partial class FormModificareRez
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
            this.ModifyRezTitle = new System.Windows.Forms.Label();
            this.modRez_tb = new System.Windows.Forms.TextBox();
            this.modRezLabel = new System.Windows.Forms.Label();
            this.gb_DataRez = new System.Windows.Forms.GroupBox();
            this.dataFinalizariiLabel = new System.Windows.Forms.Label();
            this.dataInceputLabel = new System.Windows.Forms.Label();
            this.modrez_dtp2 = new System.Windows.Forms.DateTimePicker();
            this.modrez_dtp1 = new System.Windows.Forms.DateTimePicker();
            this.OKButton = new System.Windows.Forms.Button();
            this.modify_label = new System.Windows.Forms.Label();
            this.modif_tb = new System.Windows.Forms.TextBox();
            this.gb_DataRez.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyRezTitle
            // 
            this.ModifyRezTitle.AutoSize = true;
            this.ModifyRezTitle.Location = new System.Drawing.Point(317, 41);
            this.ModifyRezTitle.Name = "ModifyRezTitle";
            this.ModifyRezTitle.Size = new System.Drawing.Size(130, 16);
            this.ModifyRezTitle.TabIndex = 0;
            this.ModifyRezTitle.Text = "Modificare rezervare";
            // 
            // modRez_tb
            // 
            this.modRez_tb.Location = new System.Drawing.Point(216, 99);
            this.modRez_tb.Name = "modRez_tb";
            this.modRez_tb.Size = new System.Drawing.Size(332, 22);
            this.modRez_tb.TabIndex = 1;
            this.modRez_tb.TextChanged += new System.EventHandler(this.modRez_tb_TextChanged);
            // 
            // modRezLabel
            // 
            this.modRezLabel.AutoSize = true;
            this.modRezLabel.Location = new System.Drawing.Point(66, 102);
            this.modRezLabel.Name = "modRezLabel";
            this.modRezLabel.Size = new System.Drawing.Size(115, 16);
            this.modRezLabel.TabIndex = 2;
            this.modRezLabel.Text = "Alegere rezervare";
            this.modRezLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb_DataRez
            // 
            this.gb_DataRez.Controls.Add(this.dataFinalizariiLabel);
            this.gb_DataRez.Controls.Add(this.dataInceputLabel);
            this.gb_DataRez.Controls.Add(this.modrez_dtp2);
            this.gb_DataRez.Controls.Add(this.modrez_dtp1);
            this.gb_DataRez.Location = new System.Drawing.Point(69, 279);
            this.gb_DataRez.Name = "gb_DataRez";
            this.gb_DataRez.Size = new System.Drawing.Size(549, 97);
            this.gb_DataRez.TabIndex = 14;
            this.gb_DataRez.TabStop = false;
            this.gb_DataRez.Text = "Data rezervare";
            // 
            // dataFinalizariiLabel
            // 
            this.dataFinalizariiLabel.AutoSize = true;
            this.dataFinalizariiLabel.Location = new System.Drawing.Point(15, 69);
            this.dataFinalizariiLabel.Name = "dataFinalizariiLabel";
            this.dataFinalizariiLabel.Size = new System.Drawing.Size(90, 16);
            this.dataFinalizariiLabel.TabIndex = 3;
            this.dataFinalizariiLabel.Text = "Data finalizarii";
            // 
            // dataInceputLabel
            // 
            this.dataInceputLabel.AutoSize = true;
            this.dataInceputLabel.Location = new System.Drawing.Point(15, 33);
            this.dataInceputLabel.Name = "dataInceputLabel";
            this.dataInceputLabel.Size = new System.Drawing.Size(90, 16);
            this.dataInceputLabel.TabIndex = 2;
            this.dataInceputLabel.Text = "Data inceperii";
            // 
            // modrez_dtp2
            // 
            this.modrez_dtp2.Location = new System.Drawing.Point(134, 64);
            this.modrez_dtp2.Name = "modrez_dtp2";
            this.modrez_dtp2.Size = new System.Drawing.Size(388, 22);
            this.modrez_dtp2.TabIndex = 1;
            // 
            // modrez_dtp1
            // 
            this.modrez_dtp1.Location = new System.Drawing.Point(134, 27);
            this.modrez_dtp1.Name = "modrez_dtp1";
            this.modrez_dtp1.Size = new System.Drawing.Size(388, 22);
            this.modrez_dtp1.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(660, 392);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(92, 35);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // modify_label
            // 
            this.modify_label.AutoSize = true;
            this.modify_label.Location = new System.Drawing.Point(66, 224);
            this.modify_label.Name = "modify_label";
            this.modify_label.Size = new System.Drawing.Size(100, 16);
            this.modify_label.TabIndex = 16;
            this.modify_label.Text = "Noua rezervare";
            // 
            // modif_tb
            // 
            this.modif_tb.Location = new System.Drawing.Point(216, 221);
            this.modif_tb.Name = "modif_tb";
            this.modif_tb.Size = new System.Drawing.Size(332, 22);
            this.modif_tb.TabIndex = 15;
            // 
            // FormModificareRez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modify_label);
            this.Controls.Add(this.modif_tb);
            this.Controls.Add(this.gb_DataRez);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.modRezLabel);
            this.Controls.Add(this.modRez_tb);
            this.Controls.Add(this.ModifyRezTitle);
            this.Name = "FormModificareRez";
            this.Text = "FormModificareRez";
            this.Load += new System.EventHandler(this.FormModificareRez_Load);
            this.gb_DataRez.ResumeLayout(false);
            this.gb_DataRez.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyRezTitle;
        private System.Windows.Forms.TextBox modRez_tb;
        private System.Windows.Forms.Label modRezLabel;
        private System.Windows.Forms.GroupBox gb_DataRez;
        private System.Windows.Forms.Label dataFinalizariiLabel;
        private System.Windows.Forms.Label dataInceputLabel;
        private System.Windows.Forms.DateTimePicker modrez_dtp2;
        private System.Windows.Forms.DateTimePicker modrez_dtp1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label modify_label;
        private System.Windows.Forms.TextBox modif_tb;
    }
}