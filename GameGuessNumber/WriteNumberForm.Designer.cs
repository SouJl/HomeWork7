
namespace GameGuessNumber
{
    partial class WriteNumberForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchNumber = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Впишите число, которое нужно будет отгадать";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchNumber
            // 
            this.searchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.searchNumber.ForeColor = System.Drawing.Color.Teal;
            this.searchNumber.Location = new System.Drawing.Point(12, 89);
            this.searchNumber.Name = "searchNumber";
            this.searchNumber.Size = new System.Drawing.Size(219, 39);
            this.searchNumber.TabIndex = 1;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Teal;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.acceptButton.ForeColor = System.Drawing.Color.White;
            this.acceptButton.Location = new System.Drawing.Point(12, 144);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(219, 39);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            this.acceptButton.MouseEnter += new System.EventHandler(this.acceptButton_MouseEnter);
            this.acceptButton.MouseLeave += new System.EventHandler(this.acceptButton_MouseLeave);
            // 
            // WriteNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 199);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.searchNumber);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(260, 238);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 238);
            this.Name = "WriteNumberForm";
            this.ShowIcon = false;
            this.Text = "WriteNumberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchNumber;
        private System.Windows.Forms.Button acceptButton;
    }
}