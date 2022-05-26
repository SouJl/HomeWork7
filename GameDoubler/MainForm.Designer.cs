
namespace GameDoubler
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commandCount = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reqValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minReqCommand = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.BackColor = System.Drawing.Color.Teal;
            this.btnCommand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.btnCommand1.ForeColor = System.Drawing.Color.White;
            this.btnCommand1.Location = new System.Drawing.Point(216, 138);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(125, 40);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Tag = "";
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = false;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            this.btnCommand1.MouseEnter += new System.EventHandler(this.btnCommand1_MouseEnter);
            this.btnCommand1.MouseLeave += new System.EventHandler(this.btnCommand1_MouseLeave);
            // 
            // btnCommand2
            // 
            this.btnCommand2.BackColor = System.Drawing.Color.Teal;
            this.btnCommand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.btnCommand2.ForeColor = System.Drawing.Color.White;
            this.btnCommand2.Location = new System.Drawing.Point(216, 197);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(125, 40);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Tag = "";
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = false;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            this.btnCommand2.MouseEnter += new System.EventHandler(this.btnCommand2_MouseEnter);
            this.btnCommand2.MouseLeave += new System.EventHandler(this.btnCommand2_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Teal;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(195, 287);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 50);
            this.btnReset.TabIndex = 2;
            this.btnReset.Tag = "";
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.lblNumber.ForeColor = System.Drawing.Color.Teal;
            this.lblNumber.Location = new System.Drawing.Point(10, 159);
            this.lblNumber.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(54, 58);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Использовано комманд:";
            // 
            // commandCount
            // 
            this.commandCount.AutoSize = true;
            this.commandCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.commandCount.ForeColor = System.Drawing.Color.White;
            this.commandCount.Location = new System.Drawing.Point(284, 76);
            this.commandCount.Name = "commandCount";
            this.commandCount.Size = new System.Drawing.Size(20, 22);
            this.commandCount.TabIndex = 5;
            this.commandCount.Text = "0";
            this.commandCount.UseMnemonic = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Teal;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(12, 287);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(146, 50);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Tag = "";
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.MouseEnter += new System.EventHandler(this.cancelButton_MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Получите число: ";
            // 
            // reqValue
            // 
            this.reqValue.AutoSize = true;
            this.reqValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.reqValue.ForeColor = System.Drawing.Color.White;
            this.reqValue.Location = new System.Drawing.Point(284, 11);
            this.reqValue.Name = "reqValue";
            this.reqValue.Size = new System.Drawing.Size(20, 22);
            this.reqValue.TabIndex = 8;
            this.reqValue.Text = "0";
            this.reqValue.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Минимальное число комманд: ";
            // 
            // minReqCommand
            // 
            this.minReqCommand.AutoSize = true;
            this.minReqCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.minReqCommand.ForeColor = System.Drawing.Color.White;
            this.minReqCommand.Location = new System.Drawing.Point(284, 44);
            this.minReqCommand.Name = "minReqCommand";
            this.minReqCommand.Size = new System.Drawing.Size(20, 22);
            this.minReqCommand.TabIndex = 10;
            this.minReqCommand.Text = "0";
            this.minReqCommand.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reqValue);
            this.panel1.Controls.Add(this.minReqCommand);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.commandCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 111);
            this.panel1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(353, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label commandCount;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reqValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minReqCommand;
        private System.Windows.Forms.Panel panel1;
    }
}

