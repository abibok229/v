using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateWordListFile();
        }

        private void CreateWordListFile()
        {
            string filePath = "wordlist.txt";
            if (!File.Exists(filePath))
            {
                string[] defaultWords = { "АНАНАС", "АРБУЗ", "КЛУБНИКА", "БАНАН", "ВИНОГРАД" };
                File.WriteAllLines(filePath, defaultWords);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = !string.IsNullOrWhiteSpace(txtName.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 6)
            {
                MessageBox.Show("Имя должно содержать минимум 6 символов!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            GameForm gameForm = new GameForm(txtName.Text);
            gameForm.ShowDialog();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            WordForm wordForm = new WordForm();
            wordForm.ShowDialog();
        }
    }
}