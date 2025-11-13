using ClassExampleController;

namespace ClassExamples
{
    /// <summary>
    /// Login View.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginView : Form
    {
        private readonly LoginController loginController;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginView" /> class.
        /// </summary>
        /// <param name="loginController">The login controller.</param>
        public LoginView(LoginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
        }

        private bool ValidateArgs(string userName, string password)
        {
            if (!userName.IsValidadString())
            {
                MessageBox.Show("The UserName cannot be empty");
                this.txt_Password.Clear();
            }
            else if (!password.IsValidadString())
            {
                MessageBox.Show("The Password cannot be empty");
                this.txt_Password.Clear();
            }
            return true;
        }

        private bool Login(string userName, string password)
        {
            var loginValidation = this.loginController.Login(userName, password);

            if (loginValidation)
            {
                MessageBox.Show($"Login Successful! Welcome {userName}!");
                var formMainView = new CalculatorFrm(new OperationsHandler(), this.loginController.UserHandler);
                formMainView.Show();
                return true;
            }
            
            return loginValidation;
        }

        private void BtnLoginClick(object sender, EventArgs e)
        {
            var userName = txt_UserName.Text;
            var password =  txt_Password.Text;
            var isUserValid = ValidateArgs(userName, password);

            if (isUserValid)
            {
                var loginSuccess = Login(userName, password);
                if (!loginSuccess)
                {
                    MessageBox.Show("UserName or Password incorrect");
                    this.txt_Password.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid values.");
            }
        }
    }
}
