namespace EcGr2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.camp_a = new System.Windows.Forms.TextBox();
            this.camp_b = new System.Windows.Forms.TextBox();
            this.camp_c = new System.Windows.Forms.TextBox();
            this.Rezolva = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // camp_a
            // 
            this.camp_a.Location = new System.Drawing.Point(193, 83);
            this.camp_a.Name = "camp_a";
            this.camp_a.Size = new System.Drawing.Size(125, 27);
            this.camp_a.TabIndex = 0;
            // 
            // camp_b
            // 
            this.camp_b.Location = new System.Drawing.Point(193, 155);
            this.camp_b.Name = "camp_b";
            this.camp_b.Size = new System.Drawing.Size(125, 27);
            this.camp_b.TabIndex = 1;
            // 
            // camp_c
            // 
            this.camp_c.Location = new System.Drawing.Point(193, 237);
            this.camp_c.Name = "camp_c";
            this.camp_c.Size = new System.Drawing.Size(125, 27);
            this.camp_c.TabIndex = 2;
            // 
            // Rezolva
            // 
            this.Rezolva.Location = new System.Drawing.Point(694, 279);
            this.Rezolva.Name = "Rezolva";
            this.Rezolva.Size = new System.Drawing.Size(94, 29);
            this.Rezolva.TabIndex = 4;
            this.Rezolva.Text = "button1";
            this.Rezolva.UseVisualStyleBackColor = true;
            this.Rezolva.Click += new System.EventHandler(this.Rezolva_Click);
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(703, 136);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(661, 27);
            this.rez.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 573);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.Rezolva);
            this.Controls.Add(this.camp_c);
            this.Controls.Add(this.camp_b);
            this.Controls.Add(this.camp_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox camp_a;
        private TextBox camp_b;
        private TextBox camp_c;
        private Button Rezolva;
        private TextBox rez;
    }
}