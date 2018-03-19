namespace WindowsFormsApp1
{
    partial class fNotizen
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitelNotiz = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbTitelNotiz
            // 
            this.tbTitelNotiz.Location = new System.Drawing.Point(128, 20);
            this.tbTitelNotiz.Name = "tbTitelNotiz";
            this.tbTitelNotiz.Size = new System.Drawing.Size(100, 20);
            this.tbTitelNotiz.TabIndex = 2;
            this.tbTitelNotiz.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 196);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // fNotizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 261);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbTitelNotiz);
            this.Controls.Add(this.label1);
            this.Name = "fNotizen";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitelNotiz;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}