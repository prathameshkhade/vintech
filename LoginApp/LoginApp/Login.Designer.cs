namespace LoginApp
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginController1 = new CustomControls.LoginController();
            SuspendLayout();
            // 
            // loginController1
            // 
            loginController1.Location = new Point(91, 62);
            loginController1.Name = "loginController1";
            loginController1.Size = new Size(314, 152);
            loginController1.TabIndex = 0;
            loginController1.Load += loginController1_Load;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 279);
            Controls.Add(loginController1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.LoginController loginController1;
    }
}
