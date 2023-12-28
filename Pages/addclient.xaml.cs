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
    /// Логика взаимодействия для addclient.xaml
    /// </summary>
    public partial class addclient : Page
    {
        public addclient()
        {
            InitializeComponent();
        }

        private void txbnumber_GotFocus(object sender, RoutedEventArgs e)
        {
            txbnumber.Text = string.Empty;
        }

        private void txbemail_GotFocus(object sender, RoutedEventArgs e)
        {
            txbemail.Text = string.Empty;
        }

        private void txbnumber_GotFocus_1(object sender, RoutedEventArgs e)
        {
            txbnumber.Text = string.Empty;
        }

        private void txbpatronomic_GotFocus(object sender, RoutedEventArgs e)
        {
            txbpatronomic.Text = string.Empty;
        }

        private void txbname_GotFocus(object sender, RoutedEventArgs e)
        {
            txbname.Text = string.Empty;
        }

        private void txbsurname_GotFocus(object sender, RoutedEventArgs e)
        {
            txbsurname.Text = string.Empty;
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            user_client client = new user_client();
            {
                client.surname = txbsurname.Text;
                client.name = txbname.Text;
                client.patronomic = txbpatronomic.Text;
                client.number = txbnumber.Text;
                client.client_email = txbemail.Text;
                client.client_status = "Свободен";
                client.user_role = 1;
            };
            PageClass.connectdb.user_client.Add(client);
            PageClass.connectdb.SaveChanges();
            MessageBox.Show("Добавлен!");
        }
    }
}
