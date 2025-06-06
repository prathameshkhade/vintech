using LoggingLib;
using LoginApp.Models;
using LoginApp.Controller;

namespace LoginApp
{
    public partial class Login : Form
    {
        private readonly UserController _userController;
        public Login()
        {
            InitializeComponent();
            _userController = new UserController();
            Logger.LogInfo("Application started at {Timestamp}", DateTime.Now);
        }

        public void OnLoginClicked(object? sender, EventArgs? e)
        {
            User user = new User
            {
                Username = loginController1.Username,
                Password = loginController1.Password
            };

            if (_userController.Authenticate(user))
            {
                MessageBox.Show("Login Successful");
                Logger.LogLoginSuccess(user.Username);
            }
            else
            {
                MessageBox.Show("Incorrect Username or password!");
                Logger.LogLoginFailed(user.Username, "Incorrect username or password");
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
