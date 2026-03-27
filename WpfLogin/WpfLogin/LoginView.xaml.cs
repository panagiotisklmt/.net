using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLogin
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void OnLoginButtonClick(object sender, RoutedEventArgs e)
        {
            var passwordEntered = PasswordBox.Password;
            string? environmentPassword = Environment.GetEnvironmentVariable("InvoiceManagement");
            if (environmentPassword != null)
            {
                if (passwordEntered == environmentPassword)
                {
                    MessageBox.Show("Entered correct password!");
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }
            }
            else
            {
                MessageBox.Show("Environment variable not found");
            }

        }

        public void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
