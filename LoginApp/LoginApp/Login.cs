namespace LoginApp
{
    public partial class Login : Form
    {
        // Serilog - Logger
        private static readonly Serilog.ILogger _logger = Serilog.Log.ForContext<Login>();

        public Login()
        {
            InitializeComponent();
            _logger.Information("Application started at {Timestamp}", DateTime.Now);
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
                    _logger.Information("Login success: {Username} at {Timestamp}", uname, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Username or password maybe incorrect");
                    _logger.Warning("Login failed: {Username} at {Timestamp}", uname, DateTime.Now);
                }
            }
        }

        private void loginController1_Load(object sender, EventArgs e)
        {
            loginController1.LoginClicked += OnLoginClicked;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _logger.Information("Application closed at {Timestamp}", DateTime.Now);
            base.OnFormClosed(e);
        }
    }
}
