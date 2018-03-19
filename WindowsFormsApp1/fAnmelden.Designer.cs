namespace WindowsFormsApp1
{
    partial class fAnmelden
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNutzername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.bNeuesKonto = new System.Windows.Forms.Button();
            this.bAnmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNutzername
            // 
            this.tbNutzername.Location = new System.Drawing.Point(144, 29);
            this.tbNutzername.Name = "tbNutzername";
            this.tbNutzername.Size = new System.Drawing.Size(100, 20);
            this.tbNutzername.TabIndex = 0;
            this.tbNutzername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nutzername";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbPasswort
            // 
            this.tbPasswort.Location = new System.Drawing.Point(144, 81);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(100, 20);
            this.tbPasswort.TabIndex = 2;
            this.tbPasswort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bNeuesKonto
            // 
            this.bNeuesKonto.Location = new System.Drawing.Point(32, 156);
            this.bNeuesKonto.Name = "bNeuesKonto";
            this.bNeuesKonto.Size = new System.Drawing.Size(75, 23);
            this.bNeuesKonto.TabIndex = 3;
            this.bNeuesKonto.Text = "neues Konto";
            this.bNeuesKonto.UseVisualStyleBackColor = true;
            this.bNeuesKonto.Click += new System.EventHandler(this.button1_Click);
            // 
            // bAnmelden
            // 
            this.bAnmelden.Location = new System.Drawing.Point(169, 156);
            this.bAnmelden.Name = "bAnmelden";
            this.bAnmelden.Size = new System.Drawing.Size(75, 23);
            this.bAnmelden.TabIndex = 4;
            this.bAnmelden.Text = "anmelden";
            this.bAnmelden.UseVisualStyleBackColor = true;
            this.bAnmelden.Click += new System.EventHandler(this.button2_Click);
            // 
            // fAnmelden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bAnmelden);
            this.Controls.Add(this.bNeuesKonto);
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNutzername);
            this.Name = "fAnmelden";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNutzername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.Button bNeuesKonto;
        private System.Windows.Forms.Button bAnmelden;
    }
}

