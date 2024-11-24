using System.Windows.Forms;

namespace Lab6_WinFormsApp_MVC
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
            textBoxNumber = new TextBox();
            textBoxBalance = new TextBox();
            textBoxProbability = new TextBox();
            labelPhoneInfo = new Label();
            textBoxPhoneInfo = new TextBox();
            buttonCreate = new Button();
            labelProbability = new Label();
            labelBalance = new Label();
            labelNumber = new Label();
            buttonCall = new Button();
            buttonEndCall = new Button();
            buttonAnswerCall = new Button();
            buttonRecharge = new Button();
            buttonCheckIncomingCall = new Button();
            buttonExit = new Button();
            textBoxRechargeAmount = new TextBox();
            SuspendLayout();
            // 
            // textBoxNumber
            // 
            textBoxNumber.BackColor = Color.Bisque;
            textBoxNumber.Location = new Point(33, 85);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(125, 27);
            textBoxNumber.TabIndex = 0;
            // 
            // textBoxBalance
            // 
            textBoxBalance.BackColor = Color.Bisque;
            textBoxBalance.Location = new Point(257, 85);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(125, 27);
            textBoxBalance.TabIndex = 1;
            // 
            // textBoxProbability
            // 
            textBoxProbability.BackColor = Color.Bisque;
            textBoxProbability.Location = new Point(487, 85);
            textBoxProbability.Name = "textBoxProbability";
            textBoxProbability.Size = new Size(125, 27);
            textBoxProbability.TabIndex = 2;
            // 
            // labelPhoneInfo
            // 
            labelPhoneInfo.AutoSize = true;
            labelPhoneInfo.Location = new Point(33, 138);
            labelPhoneInfo.Name = "labelPhoneInfo";
            labelPhoneInfo.Size = new Size(185, 20);
            labelPhoneInfo.TabIndex = 3;
            labelPhoneInfo.Text = "Информация о телефоне";
            // 
            // textBoxPhoneInfo
            // 
            textBoxPhoneInfo.BackColor = Color.FromArgb(192, 255, 255);
            textBoxPhoneInfo.Location = new Point(33, 171);
            textBoxPhoneInfo.Multiline = true;
            textBoxPhoneInfo.Name = "textBoxPhoneInfo";
            textBoxPhoneInfo.Size = new Size(172, 93);
            textBoxPhoneInfo.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.Yellow;
            buttonCreate.Location = new Point(667, 84);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += ButtonCreate_Click;
            // 
            // labelProbability
            // 
            labelProbability.AutoSize = true;
            labelProbability.Location = new Point(472, 51);
            labelProbability.Name = "labelProbability";
            labelProbability.Size = new Size(156, 20);
            labelProbability.TabIndex = 7;
            labelProbability.Text = "Введите вероятность";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Location = new Point(241, 51);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(200, 20);
            labelBalance.TabIndex = 8;
            labelBalance.Text = "Введите начальный баланс";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(20, 51);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(185, 20);
            labelNumber.TabIndex = 9;
            labelNumber.Text = "Введите номер телефона";
            // 
            // buttonCall
            // 
            buttonCall.BackColor = Color.GreenYellow;
            buttonCall.Location = new Point(303, 170);
            buttonCall.Name = "buttonCall";
            buttonCall.Size = new Size(198, 29);
            buttonCall.TabIndex = 10;
            buttonCall.Text = "Позвонить";
            buttonCall.UseVisualStyleBackColor = false;
            buttonCall.Click += ButtonCall_Click;
            // 
            // buttonEndCall
            // 
            buttonEndCall.BackColor = Color.GreenYellow;
            buttonEndCall.Location = new Point(303, 212);
            buttonEndCall.Name = "buttonEndCall";
            buttonEndCall.Size = new Size(198, 29);
            buttonEndCall.TabIndex = 11;
            buttonEndCall.Text = "Закончить разговор";
            buttonEndCall.UseVisualStyleBackColor = false;
            buttonEndCall.Click += ButtonEndCall_Click;
            // 
            // buttonAnswerCall
            // 
            buttonAnswerCall.BackColor = Color.GreenYellow;
            buttonAnswerCall.Location = new Point(303, 260);
            buttonAnswerCall.Name = "buttonAnswerCall";
            buttonAnswerCall.Size = new Size(198, 29);
            buttonAnswerCall.TabIndex = 12;
            buttonAnswerCall.Text = "Ответить на звонок";
            buttonAnswerCall.UseVisualStyleBackColor = false;
            buttonAnswerCall.Click += ButtonAnswerCall_Click;
            // 
            // buttonRecharge
            // 
            buttonRecharge.BackColor = Color.GreenYellow;
            buttonRecharge.Location = new Point(303, 357);
            buttonRecharge.Name = "buttonRecharge";
            buttonRecharge.Size = new Size(198, 29);
            buttonRecharge.TabIndex = 13;
            buttonRecharge.Text = "Пополнить баланс";
            buttonRecharge.UseVisualStyleBackColor = false;
            buttonRecharge.Click += ButtonRecharge_Click;
            // 
            // buttonCheckIncomingCall
            // 
            buttonCheckIncomingCall.BackColor = Color.GreenYellow;
            buttonCheckIncomingCall.Location = new Point(303, 309);
            buttonCheckIncomingCall.Name = "buttonCheckIncomingCall";
            buttonCheckIncomingCall.Size = new Size(198, 29);
            buttonCheckIncomingCall.TabIndex = 14;
            buttonCheckIncomingCall.Text = "Проверить вызов";
            buttonCheckIncomingCall.UseVisualStyleBackColor = false;
            buttonCheckIncomingCall.Click += ButtonCheckIncomingCall_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.GreenYellow;
            buttonExit.Location = new Point(303, 409);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(198, 29);
            buttonExit.TabIndex = 15;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += ButtonExit_Click;
            // 
            // textBoxRechargeAmount
            // 
            textBoxRechargeAmount.BackColor = Color.Bisque;
            textBoxRechargeAmount.Location = new Point(545, 357);
            textBoxRechargeAmount.Name = "textBoxRechargeAmount";
            textBoxRechargeAmount.Size = new Size(145, 27);
            textBoxRechargeAmount.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxRechargeAmount);
            Controls.Add(buttonExit);
            Controls.Add(buttonCheckIncomingCall);
            Controls.Add(buttonRecharge);
            Controls.Add(buttonAnswerCall);
            Controls.Add(buttonEndCall);
            Controls.Add(buttonCall);
            Controls.Add(labelNumber);
            Controls.Add(labelBalance);
            Controls.Add(labelProbability);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxPhoneInfo);
            Controls.Add(labelPhoneInfo);
            Controls.Add(textBoxProbability);
            Controls.Add(textBoxBalance);
            Controls.Add(textBoxNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumber;
        private TextBox textBoxBalance;
        private TextBox textBoxProbability;
        private Label labelPhoneInfo;
        private TextBox textBoxPhoneInfo;
        private Button buttonCreate;
        private Label labelProbability;
        private Label labelBalance;
        private Label labelNumber;
        private Button buttonCall;
        private Button buttonEndCall;
        private Button buttonAnswerCall;
        private Button buttonRecharge;
        private Button buttonCheckIncomingCall;
        private Button buttonExit;
        private TextBox textBoxRechargeAmount;
    }
}
