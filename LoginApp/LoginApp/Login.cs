using LoggingLib;

namespace LoginApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Logger.LogInfo("Application started at {Timestamp}", DateTime.Now);
        }

        public void OnLoginClicked(object? sender, EventArgs? e)
        {
            String uname = loginController1.Username;
            String pass = loginController1.Password;

            if(!String.IsNullOrEmpty(uname) && !String.IsNullOrEmpty(pass))
            {
                if (uname == "elliot" && pass == "P@ssw0rd")
                {
                    MessageBox.Show("Login Successful!");
                    Logger.LogInfo("Login success: {Username} at {Timestamp}", uname, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Username or password maybe incorrect");
                    Logger.LogLoginFailed(uname, "Incorrect Username or password!");
                }
            }
        }

        private void loginController1_Load(object sender, EventArgs e)
        {
            loginController1.LoginClicked += OnLoginClicked;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Logger.LogInfo("Application closed at {Timestamp}", DateTime.Now);
            base.OnFormClosed(e);
        }
    }
}
