namespace CustomLoginControllerApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loginController1.LoginClicked += OnLoginClicked;
        }

        public void OnLoginClicked(object sender, EventArgs e)
        {
            String uname = loginController1.Controls["txtUsername"].Text;
            String pass = loginController1.Controls["txtPassword"].Text;

            if (!String.IsNullOrEmpty(uname) && !String.IsNullOrEmpty(pass)) {
                if(uname == "elliot" && pass =="P@ssw0rd")
                {
                    MessageBox.Show("Login Successful!");
                }
                else
                {
                    MessageBox.Show("Username or password maybe incorrect");
                }
            }
        }
    }
}
