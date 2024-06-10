namespace assignment1
{
    partial class menu
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
            this.arcardModeBtn = new System.Windows.Forms.Button();
            this.FreeGameBtn = new System.Windows.Forms.Button();
            this.LoadSaveBtn = new System.Windows.Forms.Button();
            this.DisplayHighScoreBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arcardModeBtn
            // 
            this.arcardModeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.arcardModeBtn.Font = new System.Drawing.Font("Showcard Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arcardModeBtn.Location = new System.Drawing.Point(102, 89);
            this.arcardModeBtn.Name = "arcardModeBtn";
            this.arcardModeBtn.Size = new System.Drawing.Size(677, 79);
            this.arcardModeBtn.TabIndex = 0;
            this.arcardModeBtn.Text = "Arcade Game Mode";
            this.arcardModeBtn.UseVisualStyleBackColor = false;
            this.arcardModeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FreeGameBtn
            // 
            this.FreeGameBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FreeGameBtn.Font = new System.Drawing.Font("Showcard Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreeGameBtn.Location = new System.Drawing.Point(102, 197);
            this.FreeGameBtn.Name = "FreeGameBtn";
            this.FreeGameBtn.Size = new System.Drawing.Size(677, 79);
            this.FreeGameBtn.TabIndex = 1;
            this.FreeGameBtn.Text = "Free Game Mode";
            this.FreeGameBtn.UseVisualStyleBackColor = false;
            this.FreeGameBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoadSaveBtn
            // 
            this.LoadSaveBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoadSaveBtn.Font = new System.Drawing.Font("Showcard Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSaveBtn.Location = new System.Drawing.Point(102, 306);
            this.LoadSaveBtn.Name = "LoadSaveBtn";
            this.LoadSaveBtn.Size = new System.Drawing.Size(677, 79);
            this.LoadSaveBtn.TabIndex = 2;
            this.LoadSaveBtn.Text = "Load Save Game";
            this.LoadSaveBtn.UseVisualStyleBackColor = false;
            this.LoadSaveBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // DisplayHighScoreBtn
            // 
            this.DisplayHighScoreBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DisplayHighScoreBtn.Font = new System.Drawing.Font("Showcard Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayHighScoreBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DisplayHighScoreBtn.Location = new System.Drawing.Point(102, 416);
            this.DisplayHighScoreBtn.Name = "DisplayHighScoreBtn";
            this.DisplayHighScoreBtn.Size = new System.Drawing.Size(677, 79);
            this.DisplayHighScoreBtn.TabIndex = 3;
            this.DisplayHighScoreBtn.Text = "Display High Scores";
            this.DisplayHighScoreBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ExitBtn.Font = new System.Drawing.Font("Showcard Gothic", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(102, 516);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(677, 79);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit Game";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 652);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DisplayHighScoreBtn);
            this.Controls.Add(this.LoadSaveBtn);
            this.Controls.Add(this.FreeGameBtn);
            this.Controls.Add(this.arcardModeBtn);
            this.Name = "menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button arcardModeBtn;
        private System.Windows.Forms.Button FreeGameBtn;
        private System.Windows.Forms.Button LoadSaveBtn;
        private System.Windows.Forms.Button DisplayHighScoreBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

