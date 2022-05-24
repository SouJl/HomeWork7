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
        public static MenuForm S;

        public static void ResetVisible()
        {
            if (S != null)
                S.Show();
        }

        public MenuForm()
        {
            InitializeComponent();
            Text = "";
            StartPosition = FormStartPosition.CenterScreen;
            S = this;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            S.Hide();
            MainForm frm = new MainForm();
            frm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            playButton.BackColor = Color.DarkSlateGray;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Teal;
        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.DarkSlateGray;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Teal;
        }
    }
}
