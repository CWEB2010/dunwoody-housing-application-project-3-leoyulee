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
using System.Windows.Shapes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }
        private void CreateButtonClicked(object sender, RoutedEventArgs e)
        {

        }
        private void QueryButtonClicked(object sender, RoutedEventArgs e)
        {

        }
        private void CloseButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
