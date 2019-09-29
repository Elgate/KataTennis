namespace KataTennis
{
    partial class SetNameForm
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
            this.labelNamePlayer1 = new System.Windows.Forms.Label();
            this.labelNamePlayer2 = new System.Windows.Forms.Label();
            this.textBoxNamePlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxNamePlayer2 = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNamePlayer1
            // 
            this.labelNamePlayer1.AutoSize = true;
            this.labelNamePlayer1.Location = new System.Drawing.Point(12, 9);
            this.labelNamePlayer1.Name = "labelNamePlayer1";
            this.labelNamePlayer1.Size = new System.Drawing.Size(45, 13);
            this.labelNamePlayer1.TabIndex = 0;
            this.labelNamePlayer1.Text = "Player 1";
            // 
            // labelNamePlayer2
            // 
            this.labelNamePlayer2.AutoSize = true;
            this.labelNamePlayer2.Location = new System.Drawing.Point(12, 45);
            this.labelNamePlayer2.Name = "labelNamePlayer2";
            this.labelNamePlayer2.Size = new System.Drawing.Size(45, 13);
            this.labelNamePlayer2.TabIndex = 1;
            this.labelNamePlayer2.Text = "Player 2";
            // 
            // textBoxNamePlayer1
            // 
            this.textBoxNamePlayer1.Location = new System.Drawing.Point(63, 6);
            this.textBoxNamePlayer1.Name = "textBoxNamePlayer1";
            this.textBoxNamePlayer1.Size = new System.Drawing.Size(149, 20);
            this.textBoxNamePlayer1.TabIndex = 2;
            // 
            // textBoxNamePlayer2
            // 
            this.textBoxNamePlayer2.Location = new System.Drawing.Point(63, 42);
            this.textBoxNamePlayer2.Name = "textBoxNamePlayer2";
            this.textBoxNamePlayer2.Size = new System.Drawing.Size(149, 20);
            this.textBoxNamePlayer2.TabIndex = 3;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(15, 79);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(75, 23);
            this.buttonStartGame.TabIndex = 4;
            this.buttonStartGame.Text = "Begin game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 215);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.textBoxNamePlayer2);
            this.Controls.Add(this.textBoxNamePlayer1);
            this.Controls.Add(this.labelNamePlayer2);
            this.Controls.Add(this.labelNamePlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamePlayer1;
        private System.Windows.Forms.Label labelNamePlayer2;
        private System.Windows.Forms.TextBox textBoxNamePlayer1;
        private System.Windows.Forms.TextBox textBoxNamePlayer2;
        private System.Windows.Forms.Button buttonStartGame;
    }
}

