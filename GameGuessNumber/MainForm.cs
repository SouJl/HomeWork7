using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGuessNumber
{
    public partial class MainForm : Form
    {
        public static bool isFileMode;

        Random rnd = new Random();
        int searchNumber = 0;
        int attemptCount = 0;
        string searchResultStr;
        string searchNumberFilePath = "searchNumber.txt";

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Start();
        }

        void Start() 
        {
            if (File.Exists(searchNumberFilePath))
            {
                if(MessageBox.Show("Использовать число из файла?","Угадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    searchNumber = int.Parse(File.ReadAllText(searchNumberFilePath));
                else
                    searchNumber = rnd.Next(1, 100);
            }
            else 
            {
                searchNumber = rnd.Next(1, 100);
            }         
            attemptCount = 10;
            inNumber.Text = "";
            searchResultStr = "Ожидание ввода числа...";
            UpdateUI();
        }

        void UpdateUI() 
        {
            turnLeftCount.Text = attemptCount.ToString();
            searchResult.Text = searchResultStr;
        }

        void GameEnd(bool isWin) 
        {
            if (isWin)
            {
                MessageBox.Show($"Вы нашли нужное число - {searchNumber}!", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show($"Вы проиграли! Закончилось число попыток\nЗагаданное число - {searchNumber}", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (MessageBox.Show("Начать новую игру?", "Угадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Start();
            }
            else
            {
                Close();
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inNumber.Text, out int inValue))
            {
                if (inValue == searchNumber)
                {
                    GameEnd(true);
                    return;
                }

                if (--attemptCount == 0)
                {
                    GameEnd(false);
                    return;
                }

                if (searchNumber > inValue) searchResultStr = "Загаданное число больше!";
                else searchResultStr = "Загаданное число меньше!";

                UpdateUI();
            }
            else inNumber.Text = "";
        }


        private void guessButton_Click(object sender, EventArgs e)
        {
            WriteNumberForm form = new WriteNumberForm();
            form.ShowDialog();
            Start();
        }

        private void AcceptButton_MouseLeave(object sender, EventArgs e)
        {
            AcceptButton.BackColor = Color.Teal;
        }

        private void AcceptButton_MouseEnter(object sender, EventArgs e)
        {
            AcceptButton.BackColor = Color.DarkSlateGray;
        }

        private void guessButton_MouseEnter(object sender, EventArgs e)
        {
            guessButton.BackColor = Color.DarkSlateGray;
        }

        private void guessButton_MouseLeave(object sender, EventArgs e)
        {
            guessButton.BackColor = Color.Teal;
        }
    }
}
