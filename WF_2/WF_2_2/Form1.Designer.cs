namespace WF_2_2
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
            this.labelIntro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioYear = new System.Windows.Forms.RadioButton();
            this.radioMonth = new System.Windows.Forms.RadioButton();
            this.radioDay = new System.Windows.Forms.RadioButton();
            this.radioMinute = new System.Windows.Forms.RadioButton();
            this.radioSecond = new System.Windows.Forms.RadioButton();
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOut = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIntro
            // 
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntro.Location = new System.Drawing.Point(103, 9);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(200, 20);
            this.labelIntro.TabIndex = 0;
            this.labelIntro.Text = "Расчет времени до даты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSecond);
            this.groupBox1.Controls.Add(this.radioMinute);
            this.groupBox1.Controls.Add(this.radioDay);
            this.groupBox1.Controls.Add(this.radioMonth);
            this.groupBox1.Controls.Add(this.radioYear);
            this.groupBox1.Location = new System.Drawing.Point(23, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Остаток времени";
            // 
            // radioYear
            // 
            this.radioYear.AutoSize = true;
            this.radioYear.Location = new System.Drawing.Point(19, 30);
            this.radioYear.Name = "radioYear";
            this.radioYear.Size = new System.Drawing.Size(62, 17);
            this.radioYear.TabIndex = 0;
            this.radioYear.TabStop = true;
            this.radioYear.Text = "в годах";
            this.radioYear.UseVisualStyleBackColor = true;
            // 
            // radioMonth
            // 
            this.radioMonth.AutoSize = true;
            this.radioMonth.Location = new System.Drawing.Point(19, 54);
            this.radioMonth.Name = "radioMonth";
            this.radioMonth.Size = new System.Drawing.Size(77, 17);
            this.radioMonth.TabIndex = 1;
            this.radioMonth.TabStop = true;
            this.radioMonth.Text = "в месяцах";
            this.radioMonth.UseVisualStyleBackColor = true;
            // 
            // radioDay
            // 
            this.radioDay.AutoSize = true;
            this.radioDay.Location = new System.Drawing.Point(19, 78);
            this.radioDay.Name = "radioDay";
            this.radioDay.Size = new System.Drawing.Size(57, 17);
            this.radioDay.TabIndex = 2;
            this.radioDay.TabStop = true;
            this.radioDay.Text = "в днях";
            this.radioDay.UseVisualStyleBackColor = true;
            // 
            // radioMinute
            // 
            this.radioMinute.AutoSize = true;
            this.radioMinute.Location = new System.Drawing.Point(19, 102);
            this.radioMinute.Name = "radioMinute";
            this.radioMinute.Size = new System.Drawing.Size(75, 17);
            this.radioMinute.TabIndex = 3;
            this.radioMinute.TabStop = true;
            this.radioMinute.Text = "в минутах";
            this.radioMinute.UseVisualStyleBackColor = true;
            // 
            // radioSecond
            // 
            this.radioSecond.AutoSize = true;
            this.radioSecond.Location = new System.Drawing.Point(19, 126);
            this.radioSecond.Name = "radioSecond";
            this.radioSecond.Size = new System.Drawing.Size(80, 17);
            this.radioSecond.TabIndex = 4;
            this.radioSecond.TabStop = true;
            this.radioSecond.Text = "в секундах";
            this.radioSecond.UseVisualStyleBackColor = true;
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textInput.Location = new System.Drawing.Point(175, 76);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(204, 26);
            this.textInput.TabIndex = 2;
            // 
            // textOut
            // 
            this.textOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOut.Location = new System.Drawing.Point(175, 134);
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(204, 26);
            this.textOut.TabIndex = 3;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(175, 52);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(138, 13);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Введите дату для расчета";
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(178, 115);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(157, 13);
            this.labelOut.TabIndex = 5;
            this.labelOut.Text = "До введенной даты осталось";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(175, 178);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 34);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(304, 179);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 34);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 232);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelIntro);
            this.Name = "Form1";
            this.Text = "Расчет времени";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSecond;
        private System.Windows.Forms.RadioButton radioMinute;
        private System.Windows.Forms.RadioButton radioDay;
        private System.Windows.Forms.RadioButton radioMonth;
        private System.Windows.Forms.RadioButton radioYear;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonClear;
    }
}

