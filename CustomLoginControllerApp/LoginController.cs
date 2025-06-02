using System.ComponentModel;
using System.Text.RegularExpressions;


namespace CustomLoginControllerApp
{
    public partial class LoginController : UserControl
    {

        // Properties
        private event EventHandler? LoginClicked;

        public LoginController()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Clear all textboxes in the user control
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }
        }

        private bool ValidatePasswordString(string pass)
        {
            errProvider.Clear(); // Clear previous errors

            if (string.IsNullOrWhiteSpace(pass))
            {
                errProvider.SetError(txtPassword, "This field is required! The Password cannot be empty.");
                return false;
            }
            else if (pass.Length < 8)
            {
                errProvider.SetError(txtPassword, "Password must be at least 8 characters long.");
                return false;
            }

            if (!Regex.IsMatch(pass, @"[a-z]"))
            {
                errProvider.SetError(txtPassword, "Password must contain at least one lowercase letter.");
                return false;
            }

            if (!Regex.IsMatch(pass, @"[A-Z]"))
            {
                errProvider.SetError(txtPassword, "Password must contain at least one uppercase letter.");
                return false;
            }

            if (!Regex.IsMatch(pass, @"\d"))
            {
                errProvider.SetError(txtPassword, "Password must contain at least one digit.");
                return false;
            }

            // Password is valid
            return true;
        }


        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidatePasswordString(txtPassword.Text))
            {
                e.Cancel = true; // Prevent focus from leaving the control
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassword.Text))
            {
                errProvider.Clear();
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errProvider.SetError(txtUsername, "Username cannot be empty!");
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsername.Text))
            {
                errProvider.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
