namespace Cw5
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.b1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l41 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(56, 41);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(203, 166);
            this.treeView1.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(265, 98);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(95, 23);
            this.b1.TabIndex = 1;
            this.b1.Text = "Create Tree BST";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(366, 98);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 2;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(265, 124);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(49, 13);
            this.l1.TabIndex = 3;
            this.l1.Text = "PreOrder";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(265, 137);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(42, 13);
            this.l2.TabIndex = 4;
            this.l2.Text = "InOrder";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(265, 150);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(54, 13);
            this.l3.TabIndex = 5;
            this.l3.Text = "PostOrder";
            // 
            // l41
            // 
            this.l41.AutoSize = true;
            this.l41.Location = new System.Drawing.Point(267, 163);
            this.l41.Name = "l41";
            this.l41.Size = new System.Drawing.Size(52, 13);
            this.l41.TabIndex = 6;
            this.l41.Text = "HeapSort";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Stwórz Kopiec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l41);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l41;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

