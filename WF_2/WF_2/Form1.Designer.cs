namespace WF_2
{
    partial class Form1
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
            this.DataInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Okbutton = new System.Windows.Forms.Button();
            this.DataOut = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.labelOut = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataInput
            // 
            this.DataInput.BackColor = System.Drawing.SystemColors.Window;
            this.DataInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataInput.Location = new System.Drawing.Point(32, 44);
            this.DataInput.Margin = new System.Windows.Forms.Padding(4);
            this.DataInput.Name = "DataInput";
            this.DataInput.Size = new System.Drawing.Size(228, 26);
            this.DataInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите дату";
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(280, 44);
            this.Okbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(144, 48);
            this.Okbutton.TabIndex = 2;
            this.Okbutton.Text = "OK";
            this.Okbutton.UseVisualStyleBackColor = true;
            // 
            // DataOut
            // 
            this.DataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataOut.Location = new System.Drawing.Point(32, 145);
            this.DataOut.Margin = new System.Windows.Forms.Padding(4);
            this.DataOut.Name = "DataOut";
            this.DataOut.Size = new System.Drawing.Size(228, 26);
            this.DataOut.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(280, 129);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(144, 48);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(29, 114);
            this.labelOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(76, 17);
            this.labelOut.TabIndex = 6;
            this.labelOut.Text = "Результат";
            this.labelOut.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(53, 75);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(187, 17);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "Вы неверно ввели дату!";
            this.labelError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 198);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.DataInput);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DataOut);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Дата в день недели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.TextBox DataOut;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Label labelError;
    }
}

