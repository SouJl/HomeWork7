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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            Text = "";
            StartPosition = FormStartPosition.CenterScreen;
        }

        #region ButtonClick

        private void playButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm frm = new MainForm();
            frm.ShowDialog();
            Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region MouseEnter/MouseLeave

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Teal;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Teal;
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            playButton.BackColor = Color.DarkSlateGray;
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.DarkSlateGray;
        }

        #endregion
    }
}
