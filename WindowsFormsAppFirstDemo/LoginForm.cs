using System;
using System.Windows.Forms;

namespace WindowsFormsAppFirstDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var userName = "Aamir";
            var password = "mankind";
           
            var result = new CredentialValidator().Validate.Invoke(textBoxUserName.Text, textBoxPassword.Text);


            //if (!ValidateCredentials(userName, password))
            //if(!result)
            if (!CredentialValidator.ValidateCredentials(ValidateCredentials))
            {
                MessageBox.Show("You have entered wrong credentials.");
            }
            else
            {
                var form = new Form1();
                form.ShowDialog(); 
            }
        }
        private bool ValidateCredentials(string username, string password)
        {
            return textBoxUserName.Text.CompareTo(username) == 0 &&
                   textBoxPassword.Text.CompareTo(password) == 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class CredentialValidator
    {
        public delegate bool ValidateLoginCredentials(Func<string, string, bool> validateMethod);
        public string UserName { get; set; } = "Aamir";
        public string Password { get; set; } = "mankind";

        //A public field of type func delegate, named as Validate.
        public Func<string, string, bool> Validate = (x, y) =>
        {
            var cv = new CredentialValidator();
            return cv.UserName.CompareTo(x) == 0 && cv.Password.CompareTo(y) == 0;    
        };

        public static bool ValidateCredentials(Func<string, string, bool> credentials) 
        {
            var cv = new CredentialValidator();
            return credentials.Invoke(cv.UserName, cv.Password);
        }
    }
}
