using System;
using System.IO;
using System.Windows.Forms;

namespace GameGuessNumber
{
    public partial class WriteNumberForm : Form
    {
        public WriteNumberForm()
        {
            InitializeComponent();
            Text = "";
            StartPosition = FormStartPosition.CenterParent;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchNumber.Text, out int saveValue))
            {
                Save(saveValue, "searchNumber.txt");
                MessageBox.Show($"Число {saveValue} успешно записано в файл searchNumber.txt", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else 
            {
                MessageBox.Show("Неверный формат ввода", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                searchNumber.Text = "";
            }
        }
        
        void Save(int saveValue, string path) 
        {
            File.WriteAllText(path, saveValue.ToString());
        }
    }
}
