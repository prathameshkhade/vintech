using Microsoft.Extensions.Logging;

namespace LoginApp
{
    public partial class Login : Form
    {
        private readonly ILogger<Login> _logger;

        public Login(ILogger<Login> logger)
        {
            InitializeComponent();
            _logger = logger;
            _logger.LogInformation("Application started at {Timestamp}", DateTime.Now);
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
                    _logger.LogInformation("LOGIN SUCCESS: {Username} logged in at {Timestamp}", uname, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Username or password maybe incorrect");
                    _logger.LogWarning("LOGIN FAILED: Invalid credentials for {Username} at {Timestamp}", uname, DateTime.Now);
                }
            }
        }

        private void loginController1_Load(object sender, EventArgs e)
        {
            loginController1.LoginClicked += OnLoginClicked;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _logger.LogInformation("Application closed at {Timestamp}", DateTime.Now);
            base.OnFormClosed(e);
        }
    }
}
