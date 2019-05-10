namespace memory2
{
    partial class Holes
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
            this.ADD = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Best = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Worest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(122, 177);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(72, 32);
            this.ADD.TabIndex = 15;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Leave += new System.EventHandler(this.TextBox3_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Limit";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Leave += new System.EventHandler(this.TextBox2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Starting";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of hole";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(524, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 100);
            this.panel2.TabIndex = 0;
            this.panel2.UseWaitCursor = true;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Best
            // 
            this.Best.Location = new System.Drawing.Point(158, 109);
            this.Best.Name = "Best";
            this.Best.Size = new System.Drawing.Size(75, 23);
            this.Best.TabIndex = 17;
            this.Best.Text = "First";
            this.Best.UseVisualStyleBackColor = true;
            this.Best.Click += new System.EventHandler(this.Best_Click);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(289, 109);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(75, 23);
            this.first.TabIndex = 18;
            this.first.Text = "Best";
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.First_Click);
            // 
            // Home
            // 
            this.Home.Image = global::memory2.Properties.Resources.IMG_34691;
            this.Home.Location = new System.Drawing.Point(43, 401);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(50, 50);
            this.Home.TabIndex = 19;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Worest
            // 
            this.Worest.Location = new System.Drawing.Point(423, 109);
            this.Worest.Name = "Worest";
            this.Worest.Size = new System.Drawing.Size(75, 23);
            this.Worest.TabIndex = 20;
            this.Worest.Text = "Worst";
            this.Worest.UseVisualStyleBackColor = true;
            this.Worest.Click += new System.EventHandler(this.Worest_Click);
            // 
            // Holes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(774, 505);
            this.Controls.Add(this.Worest);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.first);
            this.Controls.Add(this.Best);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Holes";
            this.Text = "Hole2";
            this.Load += new System.EventHandler(this.Hole2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Best;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Worest;
    }
}