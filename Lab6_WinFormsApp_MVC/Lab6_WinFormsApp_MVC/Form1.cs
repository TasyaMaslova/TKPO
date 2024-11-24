
using Lab6_ClassLibrary_Controller_View;
namespace Lab6_WinFormsApp_MVC
{
    public partial class Form1 : Form, IPhoneView
    {
        private PhoneController controller;

        // �������, ������� ����� ������� ��� ������� ������ �� �����
        public event EventHandler CallRequested;
        public event EventHandler EndCallRequested;
        public event EventHandler AnswerCallRequested;
        public event EventHandler ExitRequested;
        public event EventHandler CheckIncomingCallRequested;
        public event EventHandler<double> RechargeRequested;
        public event EventHandler<object[]> CreatePhoneRequested;

        public Form1()
        {
            InitializeComponent();
            EnableInteractionButtons(false);

            controller = new PhoneController(this);
        }
        // ����������� ������� �� �������
        private void ButtonCall_Click(object sender, EventArgs e) => CallRequested?.Invoke(this, EventArgs.Empty);
        private void ButtonEndCall_Click(object sender, EventArgs e) => EndCallRequested?.Invoke(this, EventArgs.Empty);
        private void ButtonAnswerCall_Click(object sender, EventArgs e) => AnswerCallRequested?.Invoke(this, EventArgs.Empty);
        private void ButtonExit_Click(object sender, EventArgs e) => ExitRequested?.Invoke(this, EventArgs.Empty);
        private void ButtonCheckIncomingCall_Click(object sender, EventArgs e) => CheckIncomingCallRequested?.Invoke(this, EventArgs.Empty);
        private void ButtonRecharge_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxRechargeAmount.Text, out double amount))
                RechargeRequested?.Invoke(this, amount);
            else
                ShowMessage("������� ���������� �����.");
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
    {
            if (!double.TryParse(textBoxBalance.Text, out double balance) ||
            !double.TryParse(textBoxProbability.Text, out double probability) ||
            string.IsNullOrWhiteSpace(textBoxNumber.Text) ||
            probability < 0 || probability > 1)
            {
                ShowMessage("������� ���������� ������!");
                return;
            }
            var args = new object[] { textBoxNumber.Text, balance, probability };
            CreatePhoneRequested?.Invoke(this, args);
        }
       
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ��������� ������ ��������������
        public void EnableInteractionButtons(bool enable)
        {
            buttonCall.Enabled = enable;
            buttonEndCall.Enabled = enable;
            buttonAnswerCall.Enabled = enable;
            buttonRecharge.Enabled = enable;
            buttonCheckIncomingCall.Enabled = enable;
            buttonExit.Enabled = enable;
            textBoxRechargeAmount.Enabled = enable;
        }

        // ����� ��� ���������� ���������� �� �����
        public void UpdatePhoneInfo(string number, double balance, string state)
        {
            textBoxPhoneInfo.Text = $"�����: {number}\n������: {balance:F2}\n���������: {state}";
        }
        public void CloseApp()
        {
            Close();
        }

    }
}
