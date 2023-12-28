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
    /// Логика взаимодействия для addrieltor.xaml
    /// </summary>
    public partial class addrieltor : Page
    {
        public addrieltor()
        {
            InitializeComponent();
        }


        private void txbsurname_GotFocus(object sender, RoutedEventArgs e)
        {
            txbsurname.Text = string.Empty;
        }

        private void txbname_GotFocus(object sender, RoutedEventArgs e)
        {
            txbname.Text = string.Empty;
        }

        private void txbpatronomic_GotFocus(object sender, RoutedEventArgs e)
        {
            txbpatronomic.Text = string.Empty;
        }

        private void txbcomission_GotFocus(object sender, RoutedEventArgs e)
        {
            txbcomission.Text = string.Empty;
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            user_rieltor rieltor = new user_rieltor();
            {
                rieltor.surname = txbsurname.Text;
                rieltor.name = txbname.Text;
                rieltor.patronomic = txbpatronomic.Text;
                rieltor.comission = txbcomission.Text;
                rieltor.user_role = 1;
                rieltor.user_status = "Свободен";
            };
            PageClass.connectdb.user_rieltor.Add(rieltor);
            PageClass.connectdb.SaveChanges();
            MessageBox.Show("Добавлен!");


        }
    }
}
