namespace Memory_Game_Startmenu
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(217, 94);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(116, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Start New Game ";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(217, 181);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(116, 23);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Highscores";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(217, 220);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(116, 23);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "Quit";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Continue";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Homescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 329);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "Homescreen";
            this.Text = "Memory ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button button4;
    }
}

