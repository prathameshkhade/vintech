using Microsoft.Extensions.Logging;

namespace LoginApp
{
    public partial class Login : Form
    {
        // Serilog - Logger
        private static readonly Serilog.ILogger _logger = Serilog.Log.ForContext<Login>();

        public Login()
        {
            InitializeComponent();
        }

        public void OnLoginClicked(object? sender, EventArgs? e)
        {
            String uname = loginController1.Username;
            String pass = loginController1.Password;

            _logger.LogInformation("Login attempt for username: {Username} at {Timestamp}",
                string.IsNullOrEmpty(uname) ? "Empty" : uname, DateTime.Now);

            if (!String.IsNullOrEmpty(uname) && !String.IsNullOrEmpty(pass))
            {
                if (uname == "elliot" && pass == "P@ssw0rd")
                {
                    MessageBox.Show("Login Successful!");
                }
                else
                {
                    MessageBox.Show("Username or password maybe incorrect");
                }
            }
        }

        private void loginController1_Load(object sender, EventArgs e)
        {
            loginController1.LoginClicked += OnLoginClicked;
        }
    }
}
