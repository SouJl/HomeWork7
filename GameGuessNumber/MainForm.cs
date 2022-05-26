using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameGuessNumber
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        int searchNumber = 0;
        int attemptCount = 0;
        string searchResultStr;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Start();
        }

        /// <summary>
        /// Ввод начальных значение
        /// </summary>
        /// <param name="value"></param>
        void Start(int value = -1) 
        {
            if (value == -1)
            {
                searchNumber = rnd.Next(1, 100);
            }
            else 
            {
                searchNumber = value;
            }
            attemptCount = 10;
            inNumber.Text = "";
            searchResultStr = "Ожидание ввода числа...";
            UpdateUI();
        }

        /// <summary>
        /// Обновление интерфейса игры
        /// </summary>
        void UpdateUI() 
        {
            turnLeftCount.Text = attemptCount.ToString();
            searchResult.Text = searchResultStr;
        }

        /// <summary>
        /// Обработка завершения игры
        /// </summary>
        /// <param name="isWin"></param>
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

        #region ButtonsActions

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
            Start(form.SearchNumber);
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

        #endregion
    }
}
