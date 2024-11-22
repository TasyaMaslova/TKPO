namespace Lab5_WinFormsApp_Strategy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            groupBoxStrategies = new GroupBox();
            buttonApplyStrategy = new Button();
            radioButtonRaw = new RadioButton();
            radioButtonWithEight = new RadioButton();
            radioButtonWithSeven = new RadioButton();
            textBoxFormattedNumber = new TextBox();
            labelFormattedNumber = new Label();
            textBoxError = new TextBox();
            labelError = new Label();
            groupBoxStrategies.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.Bisque;
            textBoxPhoneNumber.Location = new Point(32, 72);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(168, 27);
            textBoxPhoneNumber.TabIndex = 0;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(32, 39);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(185, 20);
            labelPhoneNumber.TabIndex = 1;
            labelPhoneNumber.Text = "Введите номер телефона";
            // 
            // groupBoxStrategies
            // 
            groupBoxStrategies.BackColor = Color.FromArgb(250, 218, 221);
            groupBoxStrategies.Controls.Add(buttonApplyStrategy);
            groupBoxStrategies.Controls.Add(radioButtonRaw);
            groupBoxStrategies.Controls.Add(radioButtonWithEight);
            groupBoxStrategies.Controls.Add(radioButtonWithSeven);
            groupBoxStrategies.Location = new Point(261, 40);
            groupBoxStrategies.Name = "groupBoxStrategies";
            groupBoxStrategies.Size = new Size(293, 170);
            groupBoxStrategies.TabIndex = 2;
            groupBoxStrategies.TabStop = false;
            groupBoxStrategies.Text = "Выберите стратегию";
            // 
            // buttonApplyStrategy
            // 
            buttonApplyStrategy.BackColor = Color.DarkViolet;
            buttonApplyStrategy.ForeColor = SystemColors.ButtonHighlight;
            buttonApplyStrategy.Location = new Point(6, 135);
            buttonApplyStrategy.Name = "buttonApplyStrategy";
            buttonApplyStrategy.Size = new Size(94, 29);
            buttonApplyStrategy.TabIndex = 3;
            buttonApplyStrategy.Text = "Выбрать";
            buttonApplyStrategy.UseVisualStyleBackColor = false;
            buttonApplyStrategy.Click += buttonApplyStrategy_Click;
            // 
            // radioButtonRaw
            // 
            radioButtonRaw.AutoSize = true;
            radioButtonRaw.BackColor = Color.Fuchsia;
            radioButtonRaw.Location = new Point(6, 99);
            radioButtonRaw.Name = "radioButtonRaw";
            radioButtonRaw.Size = new Size(134, 24);
            radioButtonRaw.TabIndex = 2;
            radioButtonRaw.TabStop = true;
            radioButtonRaw.Text = "Без префиксов";
            radioButtonRaw.UseVisualStyleBackColor = false;
            // 
            // radioButtonWithEight
            // 
            radioButtonWithEight.AutoSize = true;
            radioButtonWithEight.BackColor = Color.Violet;
            radioButtonWithEight.Location = new Point(6, 69);
            radioButtonWithEight.Name = "radioButtonWithEight";
            radioButtonWithEight.Size = new Size(176, 24);
            radioButtonWithEight.TabIndex = 1;
            radioButtonWithEight.TabStop = true;
            radioButtonWithEight.Text = "Форматирование с 8";
            radioButtonWithEight.UseVisualStyleBackColor = false;
            // 
            // radioButtonWithSeven
            // 
            radioButtonWithSeven.AutoSize = true;
            radioButtonWithSeven.BackColor = Color.Thistle;
            radioButtonWithSeven.Location = new Point(6, 39);
            radioButtonWithSeven.Name = "radioButtonWithSeven";
            radioButtonWithSeven.Size = new Size(186, 24);
            radioButtonWithSeven.TabIndex = 0;
            radioButtonWithSeven.TabStop = true;
            radioButtonWithSeven.Text = "Форматирование с +7";
            radioButtonWithSeven.UseVisualStyleBackColor = false;
            // 
            // textBoxFormattedNumber
            // 
            textBoxFormattedNumber.BackColor = Color.FromArgb(192, 255, 255);
            textBoxFormattedNumber.Location = new Point(32, 287);
            textBoxFormattedNumber.Name = "textBoxFormattedNumber";
            textBoxFormattedNumber.Size = new Size(168, 27);
            textBoxFormattedNumber.TabIndex = 3;
            // 
            // labelFormattedNumber
            // 
            labelFormattedNumber.AutoSize = true;
            labelFormattedNumber.Location = new Point(32, 236);
            labelFormattedNumber.Name = "labelFormattedNumber";
            labelFormattedNumber.Size = new Size(210, 20);
            labelFormattedNumber.TabIndex = 4;
            labelFormattedNumber.Text = "Отформатированный номер";
            // 
            // textBoxError
            // 
            textBoxError.BackColor = Color.FromArgb(192, 255, 255);
            textBoxError.Location = new Point(321, 259);
            textBoxError.Multiline = true;
            textBoxError.Name = "textBoxError";
            textBoxError.Size = new Size(418, 110);
            textBoxError.TabIndex = 5;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(321, 236);
            labelError.Name = "labelError";
            labelError.Size = new Size(113, 20);
            labelError.TabIndex = 6;
            labelError.Text = "Вывод ошибок";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(labelError);
            Controls.Add(textBoxError);
            Controls.Add(labelFormattedNumber);
            Controls.Add(textBoxFormattedNumber);
            Controls.Add(groupBoxStrategies);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxPhoneNumber);
            Name = "Form1";
            Text = "Form1";
            groupBoxStrategies.ResumeLayout(false);
            groupBoxStrategies.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNumber;
        private GroupBox groupBoxStrategies;
        private RadioButton radioButtonRaw;
        private RadioButton radioButtonWithEight;
        private RadioButton radioButtonWithSeven;
        private Button buttonApplyStrategy;
        private TextBox textBoxFormattedNumber;
        private Label labelFormattedNumber;
        private TextBox textBoxError;
        private Label labelError;
    }
}
