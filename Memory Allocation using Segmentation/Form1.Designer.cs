namespace memory2
{
    partial class Form1
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
            this.Hole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hole
            // 
            this.Hole.Location = new System.Drawing.Point(253, 147);
            this.Hole.Name = "Hole";
            this.Hole.Size = new System.Drawing.Size(100, 20);
            this.Hole.TabIndex = 10;
            this.Hole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hole.Leave += new System.EventHandler(this.Hole_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Holes";
            // 
            // Mem
            // 
            this.Mem.Location = new System.Drawing.Point(254, 78);
            this.Mem.Name = "Mem";
            this.Mem.Size = new System.Drawing.Size(100, 20);
            this.Mem.TabIndex = 12;
            this.Mem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mem.TextChanged += new System.EventHandler(this.Mem_TextChanged);
            this.Mem.Leave += new System.EventHandler(this.Mem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Memory_Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Next
            // 
            this.Next.Image = global::memory2.Properties.Resources.IMG_3473;
            this.Next.Location = new System.Drawing.Point(280, 230);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(50, 50);
            this.Next.TabIndex = 11;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Exit
            // 
            this.Exit.Image = global::memory2.Properties.Resources.IMG_3472;
            this.Exit.Location = new System.Drawing.Point(171, 230);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.TabIndex = 6;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 336);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Hole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox Hole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
    }
}

