using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LandingWindow : Window
    {
        Admin admin = new Admin { Username = "home", Password = "1234" };
        public LandingWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(String.Equals(UsernameBox.Text, admin.Username) && String.Equals(PasswordBox.Text, admin.Password))
            {
                try
                {
                    HomeWindow homePageWindow = new HomeWindow();
                    homePageWindow.Show();
                    string message = "Success!";
                    MessageBox.Show(message);
                    this.Close();
                }
                catch(Exception ex)
                {
                    string message = "An error has occured whilst trying to sign you in! Here's the exception: " + ex.Message;
                    MessageBox.Show(message);
                }
                
                
            }
            else
            {
                string message = "Your username password combination is wrong. Here's the combination: " + admin.Username + " and " + admin.Password;
                MessageBox.Show(message);
            }
            
        }
        private void CloseButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    class Admin
    {
        private string usernameValue;
        public string Username
        {
            get { return usernameValue; }
            set { usernameValue = value; }
        }
        private string passwordValue;
        public string Password
        {
            get { return passwordValue; }
            set { passwordValue = value; }
        }
    }
}
