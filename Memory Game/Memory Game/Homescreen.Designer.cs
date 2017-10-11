namespace Memory_Game
{
    partial class Homescreen
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
            this.Start = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.HighScores = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Themes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(84, 59);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(197, 226);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // HighScores
            // 
            this.HighScores.Location = new System.Drawing.Point(84, 130);
            this.HighScores.Name = "HighScores";
            this.HighScores.Size = new System.Drawing.Size(75, 23);
            this.HighScores.TabIndex = 2;
            this.HighScores.Text = "HighScores";
            this.HighScores.UseVisualStyleBackColor = true;
            this.HighScores.Click += new System.EventHandler(this.HighScores_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(84, 88);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(75, 23);
            this.Continue.TabIndex = 3;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            // 
            // Themes
            // 
            this.Themes.Location = new System.Drawing.Point(84, 171);
            this.Themes.Name = "Themes";
            this.Themes.Size = new System.Drawing.Size(75, 23);
            this.Themes.TabIndex = 4;
            this.Themes.Text = "Themes";
            this.Themes.UseVisualStyleBackColor = true;
            this.Themes.Click += new System.EventHandler(this.Themes_Click);
            // 
            // Homescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Themes);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.HighScores);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Start);
            this.Name = "Homescreen";
            this.Text = "Memory Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button HighScores;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Themes;
    }
}

