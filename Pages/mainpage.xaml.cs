using nedvijimost_.DataApp;
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

namespace nedvijimost_.Pages
{
    /// <summary>
    /// Логика взаимодействия для mainpage.xaml
    /// </summary>
    public partial class mainpage : Page
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void btnaddnedvijimost_Click(object sender, RoutedEventArgs e)
        {
            PageClass.frameMain.Navigate(new addrielty());
        }

        private void btnrieltors_Click(object sender, RoutedEventArgs e)
        {
            PageClass.frameMain.Navigate(new rieltors());
        }

        private void btnclients_Click(object sender, RoutedEventArgs e)
        {
            PageClass.frameMain.Navigate(new clients());
        }

        private void btnaddclient_Click(object sender, RoutedEventArgs e)
        {
            PageClass.frameMain.Navigate(new addclient());
        }

        private void btnaddrieltor_Click(object sender, RoutedEventArgs e)
        {
            PageClass.frameMain.Navigate(new addrieltor());
        }
    }
}
