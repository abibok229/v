using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameForm : Form
    {
        private string playerName;
        private string targetWord;
        private string[] displayWord;
        private int attempts = 8;
        private List<char> guessedLetters = new List<char>();
        private string[] words;

        public GameForm(string name)
        {
            InitializeComponent();
            playerName = name;
            txtLetter.MaxLength = 1;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void StartNewGame()
        {
            if (!File.Exists("wordlist.txt")) return;

            words = File.ReadAllLines("wordlist.txt");
            if (words.Length == 0) return;

            Random rnd = new Random();
            targetWord = words[rnd.Next(words.Length)].Trim().ToUpper();

            displayWord = new string[targetWord.Length];
            for (int i = 0; i < displayWord.Length; i++)
            {
                displayWord[i] = "🐧";
            }

            attempts = 8;
            guessedLetters.Clear();
            UpdateUI();

            picHangman.Image = null;
            txtLetter.Focus();
        }

        private void UpdateUI()
        {
            lblMaskedWord.Text = string.Join(" ", displayWord);
            lblGuessedLetters.Text = "Введенные буквы: " + string.Join(", ", guessedLetters);
        }

        private void UpdatePicture()
        {
            int mistakeCount = 8 - attempts;

            switch (mistakeCount)
            {
                case 1:
                    picHangman.Image = Properties.Resources.pic1;
                    break;
                case 2:
                    picHangman.Image = Properties.Resources.pic2;
                    break;
                case 3:
                    picHangman.Image = Properties.Resources.pic3;
                    break;
                case 4:
                    picHangman.Image = Properties.Resources.pic4;
                    break;
                case 5:
                    picHangman.Image = Properties.Resources.pic5;
                    break;
                case 6:
                    picHangman.Image = Properties.Resources.pic6;
                    break;
                case 7:
                    picHangman.Image = Properties.Resources.pic7;
                    break;
                case 8:
                    picHangman.Image = Properties.Resources.pic8;
                    break;
                default:
                    picHangman.Image = null;
                    break;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            ProcessGuess();
        }

        private void txtLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcessGuess();
                e.Handled = true;
            }
        }

        private void ProcessGuess()
        {
            string input = txtLetter.Text.ToUpper().Trim();
            txtLetter.Clear();
            txtLetter.Focus();

            if (input.Length != 1 || !char.IsLetter(input[0])) return;

            char guess = input[0];

            if (guessedLetters.Contains(guess)) return;

            guessedLetters.Add(guess);
            bool isCorrect = false;

            for (int i = 0; i < targetWord.Length; i++)
            {
                if (targetWord[i] == guess)
                {
                    displayWord[i] = guess.ToString();
                    isCorrect = true;
                }
            }

            if (!isCorrect)
            {
                attempts--;
                UpdatePicture();
            }

            UpdateUI();
            CheckGameOver();
        }

        private void CheckGameOver()
        {
            if (!displayWord.Contains("🐧"))
            {
                MessageBox.Show($"Поздравляем, {playerName}! Вы угадали слово: {targetWord}", "Победа!");
                SaveStats("Победа");
                this.Close();
            }
            else if (attempts <= 0)
            {
                MessageBox.Show($"Вы проиграли! Загаданное слово было: {targetWord}", "Игра окончена");
                SaveStats("Поражение");
                this.Close();
            }
        }

        private void SaveStats(string result)
        {
            string record = $"{result} {playerName} {targetWord.Length}";
            File.AppendAllText("stats.txt", record + Environment.NewLine);
        }
    }
}