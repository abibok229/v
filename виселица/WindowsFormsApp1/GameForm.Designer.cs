namespace WindowsFormsApp1
{
    partial class GameForm
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
            this.lblMaskedWord = new System.Windows.Forms.Label();
            this.lblGuessedLetters = new System.Windows.Forms.Label();
            this.picHangman = new System.Windows.Forms.PictureBox();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaskedWord
            // 
            this.lblMaskedWord.AutoSize = true;
            this.lblMaskedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMaskedWord.Location = new System.Drawing.Point(62, 40);
            this.lblMaskedWord.Name = "lblMaskedWord";
            this.lblMaskedWord.Size = new System.Drawing.Size(81, 29);
            this.lblMaskedWord.TabIndex = 0;
            this.lblMaskedWord.Text = "label1";
            // 
            // lblGuessedLetters
            // 
            this.lblGuessedLetters.AutoSize = true;
            this.lblGuessedLetters.Location = new System.Drawing.Point(182, 126);
            this.lblGuessedLetters.Name = "lblGuessedLetters";
            this.lblGuessedLetters.Size = new System.Drawing.Size(44, 16);
            this.lblGuessedLetters.TabIndex = 1;
            this.lblGuessedLetters.Text = "label2";
            // 
            // picHangman
            // 
            this.picHangman.Location = new System.Drawing.Point(809, 50);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(306, 317);
            this.picHangman.TabIndex = 3;
            this.picHangman.TabStop = false;
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(499, 86);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(100, 22);
            this.txtLetter.TabIndex = 4;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(499, 137);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(97, 45);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Ввести";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.picHangman);
            this.Controls.Add(this.lblGuessedLetters);
            this.Controls.Add(this.lblMaskedWord);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaskedWord;
        private System.Windows.Forms.Label lblGuessedLetters;
        private System.Windows.Forms.PictureBox picHangman;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnGuess;
    }
}