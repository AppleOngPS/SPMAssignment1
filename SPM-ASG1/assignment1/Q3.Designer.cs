namespace assignment1
{
    partial class Q3
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
            this.top = new System.Windows.Forms.Button();
            this.bot = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(49, 163);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(75, 23);
            this.top.TabIndex = 1;
            this.top.Text = "Top";
            this.top.UseVisualStyleBackColor = true;
            this.top.Click += new System.EventHandler(this.button1_Click);
            // 
            // bot
            // 
            this.bot.Location = new System.Drawing.Point(170, 163);
            this.bot.Name = "bot";
            this.bot.Size = new System.Drawing.Size(75, 23);
            this.bot.TabIndex = 2;
            this.bot.Text = "Bottom";
            this.bot.UseVisualStyleBackColor = true;
            this.bot.Click += new System.EventHandler(this.bot_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(49, 227);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 23);
            this.left.TabIndex = 3;
            this.left.Text = "Left";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(170, 227);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 23);
            this.right.TabIndex = 4;
            this.right.Text = "Right";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // Q3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 278);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.bot);
            this.Controls.Add(this.top);
            this.Controls.Add(this.label1);
            this.Name = "Q3";
            this.Text = "Q3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button top;
        private System.Windows.Forms.Button bot;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
    }
}