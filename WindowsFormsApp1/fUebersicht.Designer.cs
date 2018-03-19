namespace WindowsFormsApp1
{
    partial class fUebersicht
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
            this.bPasswort = new System.Windows.Forms.Button();
            this.bNotiz = new System.Windows.Forms.Button();
            this.bBild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPasswort
            // 
            this.bPasswort.Location = new System.Drawing.Point(13, 46);
            this.bPasswort.Name = "bPasswort";
            this.bPasswort.Size = new System.Drawing.Size(259, 52);
            this.bPasswort.TabIndex = 0;
            this.bPasswort.Text = "Passwörter";
            this.bPasswort.UseVisualStyleBackColor = true;
            this.bPasswort.Click += new System.EventHandler(this.button1_Click);
            // 
            // bNotiz
            // 
            this.bNotiz.Location = new System.Drawing.Point(13, 104);
            this.bNotiz.Name = "bNotiz";
            this.bNotiz.Size = new System.Drawing.Size(259, 52);
            this.bNotiz.TabIndex = 1;
            this.bNotiz.Text = "Notizen";
            this.bNotiz.UseVisualStyleBackColor = true;
            this.bNotiz.Click += new System.EventHandler(this.button2_Click);
            // 
            // bBild
            // 
            this.bBild.Location = new System.Drawing.Point(13, 162);
            this.bBild.Name = "bBild";
            this.bBild.Size = new System.Drawing.Size(259, 52);
            this.bBild.TabIndex = 2;
            this.bBild.Text = "Bilder";
            this.bBild.UseVisualStyleBackColor = true;
            this.bBild.Click += new System.EventHandler(this.button3_Click);
            // 
            // fUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bBild);
            this.Controls.Add(this.bNotiz);
            this.Controls.Add(this.bPasswort);
            this.Name = "fUebersicht";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPasswort;
        private System.Windows.Forms.Button bNotiz;
        private System.Windows.Forms.Button bBild;
    }
}