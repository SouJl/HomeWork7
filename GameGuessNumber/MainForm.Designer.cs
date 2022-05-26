
namespace GameGuessNumber
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inNumber = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.turnLeftCount = new System.Windows.Forms.Label();
            this.searchResult = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(399, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Угадай число!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inNumber
            // 
            this.inNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.inNumber.ForeColor = System.Drawing.Color.Teal;
            this.inNumber.Location = new System.Drawing.Point(17, 225);
            this.inNumber.Name = "inNumber";
            this.inNumber.ShortcutsEnabled = false;
            this.inNumber.Size = new System.Drawing.Size(165, 39);
            this.inNumber.TabIndex = 1;
            this.inNumber.Text = "0";
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.Teal;
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(195, 225);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(192, 41);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Проверить";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            this.AcceptButton.MouseEnter += new System.EventHandler(this.AcceptButton_MouseEnter);
            this.AcceptButton.MouseLeave += new System.EventHandler(this.AcceptButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Осталось попыток:";
            // 
            // turnLeftCount
            // 
            this.turnLeftCount.AutoSize = true;
            this.turnLeftCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.turnLeftCount.ForeColor = System.Drawing.Color.Teal;
            this.turnLeftCount.Location = new System.Drawing.Point(227, 176);
            this.turnLeftCount.Name = "turnLeftCount";
            this.turnLeftCount.Size = new System.Drawing.Size(23, 25);
            this.turnLeftCount.TabIndex = 4;
            this.turnLeftCount.Text = "0";
            // 
            // searchResult
            // 
            this.searchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.searchResult.Location = new System.Drawing.Point(0, 113);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(399, 29);
            this.searchResult.TabIndex = 5;
            this.searchResult.Text = "Загаданное число меньше ";
            this.searchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.Teal;
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.guessButton.ForeColor = System.Drawing.Color.White;
            this.guessButton.Location = new System.Drawing.Point(17, 286);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(370, 45);
            this.guessButton.TabIndex = 6;
            this.guessButton.Text = "Загадать число";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            this.guessButton.MouseEnter += new System.EventHandler(this.guessButton_MouseEnter);
            this.guessButton.MouseLeave += new System.EventHandler(this.guessButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 343);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.turnLeftCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.inNumber);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 382);
            this.MinimumSize = new System.Drawing.Size(415, 382);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inNumber;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label turnLeftCount;
        private System.Windows.Forms.Label searchResult;
        private System.Windows.Forms.Button guessButton;
    }
}

