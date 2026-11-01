using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WordForm : Form
    {
        public WordForm()
        {
            InitializeComponent();
        }

        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            string newWord = txtNewWord.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(newWord))
            {
                MessageBox.Show("Введите слово!");
                return;
            }

            File.AppendAllText("wordlist.txt", Environment.NewLine + newWord);
            MessageBox.Show("Слово добавлено!");
            this.Close();
        }
    }
}