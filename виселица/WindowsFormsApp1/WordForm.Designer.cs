namespace WindowsFormsApp1
{
    partial class WordForm
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
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.btnSaveWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewWord
            // 
            this.txtNewWord.Location = new System.Drawing.Point(86, 64);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(100, 22);
            this.txtNewWord.TabIndex = 0;
            // 
            // btnSaveWord
            // 
            this.btnSaveWord.Location = new System.Drawing.Point(97, 132);
            this.btnSaveWord.Name = "btnSaveWord";
            this.btnSaveWord.Size = new System.Drawing.Size(89, 23);
            this.btnSaveWord.TabIndex = 1;
            this.btnSaveWord.Text = "Добавить";
            this.btnSaveWord.UseVisualStyleBackColor = true;
            this.btnSaveWord.Click += new System.EventHandler(this.btnSaveWord_Click);
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 275);
            this.Controls.Add(this.btnSaveWord);
            this.Controls.Add(this.txtNewWord);
            this.Name = "WordForm";
            this.Text = "WordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.Button btnSaveWord;
    }
}