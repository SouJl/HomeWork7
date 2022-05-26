using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameGuessNumber
{
    public partial class WriteNumberForm : Form
    {
        int _searchNumber = -1;
        public int SearchNumber
        {
            get =>_searchNumber; 
            set
            {
                _searchNumber = value;
            } 
        }

        public WriteNumberForm()
        {
            InitializeComponent();
            Text = "";
            StartPosition = FormStartPosition.CenterParent;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchNumber.Text, out int value))
            {
                _searchNumber = value;
                Close();
            }
        }

        private void acceptButton_MouseEnter(object sender, EventArgs e)
        {
            acceptButton.BackColor = Color.DarkSlateGray;
        }

        private void acceptButton_MouseLeave(object sender, EventArgs e)
        {
            acceptButton.BackColor = Color.Teal;
        }
    }
}
