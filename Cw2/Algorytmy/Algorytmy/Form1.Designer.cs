namespace Algorytmy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.b6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(12, 12);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(75, 20);
            this.tb.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 47);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(118, 23);
            this.b1.TabIndex = 1;
            this.b1.Text = "Fib 1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(93, 15);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(37, 13);
            this.l.TabIndex = 2;
            this.l.Text = "Wynik";
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(12, 76);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(118, 23);
            this.b2.TabIndex = 3;
            this.b2.Text = "Fib 2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(12, 105);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(118, 23);
            this.b3.TabIndex = 4;
            this.b3.Text = "Fib 3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(144, 12);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 5;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(250, 12);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 20);
            this.tb3.TabIndex = 7;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(250, 46);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(37, 13);
            this.l2.TabIndex = 8;
            this.l2.Text = "Wynik";
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(144, 41);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(100, 23);
            this.b4.TabIndex = 9;
            this.b4.Text = "NWD";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(144, 104);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(100, 23);
            this.b5.TabIndex = 10;
            this.b5.Text = "MergeSort";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(144, 78);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 11;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(250, 81);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(34, 13);
            this.l3.TabIndex = 12;
            this.l3.Text = "wynik";
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(253, 104);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(97, 23);
            this.b6.TabIndex = 13;
            this.b6.Text = "SortB";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 147);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.l);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tb);
            this.Name = "Form1";
            this.Text = "Algorytmy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Button b6;
    }
}

