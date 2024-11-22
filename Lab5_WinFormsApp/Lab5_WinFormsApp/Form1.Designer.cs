namespace Lab5_WinFormsApp
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

        private Label labelNumber;
        private TextBox textBoxNumber;
        private TextBox textBoxBalance;
        private Label labelBalance;
        private TextBox textBoxState;
        private Label labelCurrentState;
        private Button buttonCall;
        private Button buttonAnswer;
        private Button buttonEndCall;
        private Button buttonRecharge;
        private TextBox textBoxAmount;
        private ListBox listBoxActions;
        private Button buttonCheckCall;
        private TextBox textBoxProbability;
        private Label labelProbability;
        private Button buttonCreatePhone;
        private Label labelHistory;
        private Label labelAmount;
        private TextBox textBoxCurrentBalance;
        private Label labelCurrentBalance;
    }
}
