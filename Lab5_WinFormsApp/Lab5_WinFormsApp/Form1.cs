using Lab5_ClassLibrary2;

namespace Lab5_WinFormsApp
{

    public partial class Form1 : Form
    {
        private Phone? phone;  // Экземпляр телефона
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            labelNumber = new Label();
            textBoxNumber = new TextBox();
            textBoxBalance = new TextBox();
            labelBalance = new Label();
            textBoxState = new TextBox();
            labelCurrentState = new Label();
            buttonCall = new Button();
            buttonAnswer = new Button();
            buttonEndCall = new Button();
            buttonRecharge = new Button();
            textBoxAmount = new TextBox();
            listBoxActions = new ListBox();
            buttonCheckCall = new Button();
            textBoxProbability = new TextBox();
            labelProbability = new Label();
            buttonCreatePhone = new Button();
            labelHistory = new Label();
            labelAmount = new Label();
            textBoxCurrentBalance = new TextBox();
            labelCurrentBalance = new Label();
            SuspendLayout();
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(12, 9);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(192, 20);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "Введите номер телефона: ";
            // 
            // textBoxNumber
            // 
            textBoxNumber.BackColor = Color.Bisque;
            textBoxNumber.Location = new Point(12, 32);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(200, 27);
            textBoxNumber.TabIndex = 1;
            // 
            // textBoxBalance
            // 
            textBoxBalance.BackColor = Color.Bisque;
            textBoxBalance.Location = new Point(296, 32);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(100, 27);
            textBoxBalance.TabIndex = 3;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Location = new Point(250, 9);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(207, 20);
            labelBalance.TabIndex = 2;
            labelBalance.Text = "Введите начальный баланс: ";
            // 
            // textBoxState
            // 
            textBoxState.BackColor = Color.FromArgb(192, 255, 255);
            textBoxState.Location = new Point(442, 139);
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(125, 27);
            textBoxState.TabIndex = 5;
            // 
            // labelCurrentState
            // 
            labelCurrentState.AutoSize = true;
            labelCurrentState.Location = new Point(442, 105);
            labelCurrentState.Name = "labelCurrentState";
            labelCurrentState.Size = new Size(143, 20);
            labelCurrentState.TabIndex = 4;
            labelCurrentState.Text = "Текущее состояние";
            // 
            // buttonCall
            // 
            buttonCall.BackColor = Color.GreenYellow;
            buttonCall.Location = new Point(226, 101);
            buttonCall.Name = "buttonCall";
            buttonCall.Size = new Size(94, 29);
            buttonCall.TabIndex = 6;
            buttonCall.Text = "Позвонить";
            buttonCall.UseVisualStyleBackColor = false;
            buttonCall.Click += buttonCall_Click;
            // 
            // buttonAnswer
            // 
            buttonAnswer.BackColor = Color.GreenYellow;
            buttonAnswer.Location = new Point(226, 164);
            buttonAnswer.Name = "buttonAnswer";
            buttonAnswer.Size = new Size(163, 29);
            buttonAnswer.TabIndex = 7;
            buttonAnswer.Text = "Ответить на звонок";
            buttonAnswer.UseVisualStyleBackColor = false;
            buttonAnswer.Click += buttonAnswer_Click;
            // 
            // buttonEndCall
            // 
            buttonEndCall.BackColor = Color.GreenYellow;
            buttonEndCall.Location = new Point(226, 234);
            buttonEndCall.Name = "buttonEndCall";
            buttonEndCall.Size = new Size(170, 29);
            buttonEndCall.TabIndex = 8;
            buttonEndCall.Text = "Завершить разговор";
            buttonEndCall.UseVisualStyleBackColor = false;
            buttonEndCall.Click += buttonEndCall_Click;
            // 
            // buttonRecharge
            // 
            buttonRecharge.BackColor = Color.GreenYellow;
            buttonRecharge.Location = new Point(226, 316);
            buttonRecharge.Name = "buttonRecharge";
            buttonRecharge.Size = new Size(184, 29);
            buttonRecharge.TabIndex = 9;
            buttonRecharge.Text = "Пополнить баланс";
            buttonRecharge.UseVisualStyleBackColor = false;
            buttonRecharge.Click += buttonRecharge_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BackColor = Color.Bisque;
            textBoxAmount.Location = new Point(460, 316);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(125, 27);
            textBoxAmount.TabIndex = 10;
            // 
            // listBoxActions
            // 
            listBoxActions.BackColor = Color.FromArgb(192, 255, 255);
            listBoxActions.FormattingEnabled = true;
            listBoxActions.Location = new Point(23, 118);
            listBoxActions.Name = "listBoxActions";
            listBoxActions.Size = new Size(150, 184);
            listBoxActions.TabIndex = 11;
            // 
            // buttonCheckCall
            // 
            buttonCheckCall.BackColor = Color.Yellow;
            buttonCheckCall.Location = new Point(534, 220);
            buttonCheckCall.Name = "buttonCheckCall";
            buttonCheckCall.Size = new Size(165, 29);
            buttonCheckCall.TabIndex = 12;
            buttonCheckCall.Text = "Проверить вызов";
            buttonCheckCall.UseVisualStyleBackColor = false;
            buttonCheckCall.Click += buttonCheckCall_Click;
            // 
            // textBoxProbability
            // 
            textBoxProbability.BackColor = Color.Bisque;
            textBoxProbability.Location = new Point(518, 32);
            textBoxProbability.Name = "textBoxProbability";
            textBoxProbability.Size = new Size(100, 27);
            textBoxProbability.TabIndex = 14;
            // 
            // labelProbability
            // 
            labelProbability.AutoSize = true;
            labelProbability.Location = new Point(478, 9);
            labelProbability.Name = "labelProbability";
            labelProbability.Size = new Size(199, 20);
            labelProbability.TabIndex = 13;
            labelProbability.Text = "Введите вероятность (0-1): ";
            // 
            // buttonCreatePhone
            // 
            buttonCreatePhone.BackColor = Color.Yellow;
            buttonCreatePhone.Location = new Point(714, 26);
            buttonCreatePhone.Name = "buttonCreatePhone";
            buttonCreatePhone.Size = new Size(120, 33);
            buttonCreatePhone.TabIndex = 15;
            buttonCreatePhone.Text = "Создать телефон";
            buttonCreatePhone.UseVisualStyleBackColor = false;
            buttonCreatePhone.Click += buttonCreatePhone_Click;
            // 
            // labelHistory
            // 
            labelHistory.AutoSize = true;
            labelHistory.Location = new Point(23, 83);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(142, 20);
            labelHistory.TabIndex = 16;
            labelHistory.Text = "История операций";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(460, 293);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(206, 20);
            labelAmount.TabIndex = 17;
            labelAmount.Text = "Введите сумму пополнения:";
            // 
            // textBoxCurrentBalance
            // 
            textBoxCurrentBalance.BackColor = Color.FromArgb(192, 255, 255);
            textBoxCurrentBalance.Location = new Point(638, 139);
            textBoxCurrentBalance.Name = "textBoxCurrentBalance";
            textBoxCurrentBalance.Size = new Size(100, 27);
            textBoxCurrentBalance.TabIndex = 18;
            // 
            // labelCurrentBalance
            // 
            labelCurrentBalance.AutoSize = true;
            labelCurrentBalance.Location = new Point(628, 105);
            labelCurrentBalance.Name = "labelCurrentBalance";
            labelCurrentBalance.Size = new Size(122, 20);
            labelCurrentBalance.TabIndex = 19;
            labelCurrentBalance.Text = "Текущий баланс";
            // 
            // Form1
            // 
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(867, 416);
            Controls.Add(labelCurrentBalance);
            Controls.Add(textBoxCurrentBalance);
            Controls.Add(labelAmount);
            Controls.Add(labelHistory);
            Controls.Add(buttonCreatePhone);
            Controls.Add(textBoxProbability);
            Controls.Add(labelProbability);
            Controls.Add(buttonCheckCall);
            Controls.Add(listBoxActions);
            Controls.Add(textBoxAmount);
            Controls.Add(buttonRecharge);
            Controls.Add(buttonEndCall);
            Controls.Add(buttonAnswer);
            Controls.Add(buttonCall);
            Controls.Add(textBoxState);
            Controls.Add(labelCurrentState);
            Controls.Add(textBoxBalance);
            Controls.Add(labelBalance);
            Controls.Add(textBoxNumber);
            Controls.Add(labelNumber);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        // Обработчик для создания телефона
        private void buttonCreatePhone_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxBalance.Text, out double balance) ||
                !double.TryParse(textBoxProbability.Text, out double probability) ||
                string.IsNullOrWhiteSpace(textBoxNumber.Text) ||
                probability < 0 || probability > 1)
            {
                MessageBox.Show("Введите корректные данные!");
                return;
            }

            phone = new Phone(textBoxNumber.Text, balance, probability);
            UpdatePhoneState();
            listBoxActions.Items.Add("Телефон создан.");
        }

        // Обработчик для совершения звонка
        private void buttonCall_Click(object sender, EventArgs e)
        {
            if (phone == null) return;

            try
            {
                phone.Call();
                listBoxActions.Items.Add("Совершен звонок.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdatePhoneState();
        }

        // Обработчик для ответа на вызов
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (phone == null) return;

            try
            {
                phone.AnswerCall();
                listBoxActions.Items.Add("Ответ на звонок.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdatePhoneState();
        }

        // Обработчик для завершения разговора
        private void buttonEndCall_Click(object sender, EventArgs e)
        {
            if (phone == null) return;

            try
            {
                phone.EndCall();
                listBoxActions.Items.Add("Разговор завершен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdatePhoneState();
        }

        // Обработчик для пополнения баланса
        private void buttonRecharge_Click(object sender, EventArgs e)
        {
            if (phone == null || !double.TryParse(textBoxAmount.Text, out double amount))
            {
                MessageBox.Show("Введите корректную сумму.");
                return;
            }

            try
            {
                phone.RechargeBalance(amount);
                listBoxActions.Items.Add($"Баланс пополнен на {amount}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdatePhoneState();
        }

        // Обработчик для проверки входящего вызова
        private void buttonCheckCall_Click(object sender, EventArgs e)
        {
            if (phone == null) return;

            try
            {
                phone.CheckIncomingCall();
                listBoxActions.Items.Add("Поступил входящий вызов.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdatePhoneState();
        }

        // Обновление отображения данных о телефоне
        private void UpdatePhoneState()
        {
            if (phone == null) return;

            textBoxCurrentBalance.Text = phone.Balance.ToString("F2");
            textBoxState.Text = phone.CurrentState.GetType().Name;
        }

    }
}
