using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDoubler
{
    public partial class MainForm : Form
    {
        int comCount = 0;
        int currentNumber = 1;
        Stack<int> valueBuff;
        Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
            Start();
        }

        #region ButtonClick

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            valueBuff.Push(currentNumber++);
            comCount++;
            UpdateUI();
            CheckGameState();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            valueBuff.Push(currentNumber);
            currentNumber *= 2;
            comCount++;
            UpdateUI();
            CheckGameState();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (valueBuff.Any())
            {
                currentNumber = valueBuff.Pop();
                comCount--;
                UpdateUI();
            }
        }

        #endregion

        #region MouseEnter/MouseLeave

        private void btnCommand1_MouseEnter(object sender, EventArgs e)
        {
            btnCommand1.BackColor = Color.DarkSlateGray;
        }

        private void btnCommand1_MouseLeave(object sender, EventArgs e)
        {
            btnCommand1.BackColor = Color.Teal;
        }

        private void btnCommand2_MouseEnter(object sender, EventArgs e)
        {
            btnCommand2.BackColor = Color.DarkSlateGray;
        }

        private void btnCommand2_MouseLeave(object sender, EventArgs e)
        {
            btnCommand2.BackColor = Color.Teal;
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.DarkSlateGray;
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.Teal;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.DarkSlateGray;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.Teal;
        }

        #endregion

        #region Вспомогательные методы

        void Start()
        {
            reqValue.Text = rnd.Next(256).ToString();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            Text = "";
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
            valueBuff = new Stack<int>();
            UpdateUI();
        }

        private void Reset()
        {
            valueBuff.Clear();
            currentNumber = 1;
            comCount = 0;
            reqValue.Text = rnd.Next(256).ToString();
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblNumber.Text = currentNumber.ToString();
            commandCount.Text = comCount.ToString();
            minReqCommand.Text = FindMinCommandCount(int.Parse(reqValue.Text)).ToString();
        }

        private void CheckGameState()
        {
            if (currentNumber == int.Parse(reqValue.Text))
            {
                MessageBox.Show($"Вы выиграли!\nИспользовано комманд: {comCount}", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Начать новую игру?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Reset();
                }
                else 
                {
                    Close();
                }
            }
        }

        private int FindMinCommandCount(int searchValue)
        {
            int count = 0;
            while (searchValue != 1)
            {
                if (searchValue % 2 == 0)
                {
                    searchValue /= 2;
                    count++;
                }
                else
                {
                    searchValue -= 1;
                    count++;
                }
            }
            return count;
        }

        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm.ResetVisible();
        }
    }
}
