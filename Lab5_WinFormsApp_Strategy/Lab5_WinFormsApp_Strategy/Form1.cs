using Lab5_ClassLibrary_Strategy;
namespace Lab5_WinFormsApp_Strategy
{
    public partial class Form1 : Form
    {
        private Phone? phone;

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonApplyStrategy_Click(object sender, EventArgs e)
        {
            try 
            {
                textBoxError.Text = ""; // Очистка ошибок

                var inputNumber = textBoxPhoneNumber.Text;

                var invalidChars = inputNumber.Where(c => !"+0123456789- ()".Contains(c)).ToArray();

                if (invalidChars.Any())
                {
                    textBoxError.Text = $"Недопустимые символы: {new string(invalidChars)}";
                    return;
                }

                // Создание телефона с выбранной стратегией
                IPhoneFormatStrategy strategy = radioButtonWithSeven.Checked
                    ? new WithSevenFormatStrategy()
                    : radioButtonWithEight.Checked
                    ? new WithEightFormatStrategy()
                    : new RawFormatStrategy();

                phone = new Phone(inputNumber, strategy);

                //textBoxFormattedNumber.Text = "";
                textBoxFormattedNumber.Text = $"{phone.GetFormattedNumber()}";
            }
            catch (ArgumentException ex)
            {
                textBoxFormattedNumber.Text = "";
                textBoxError.Text = $"{ex.Message}";
            }
        }
    }
}
