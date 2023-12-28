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
    /// Логика взаимодействия для clients.xaml
    /// </summary>
    public partial class clients : Page
    {
        public clients()
        {
            InitializeComponent();
        }

        private void txbsearch_GotFocus(object sender, RoutedEventArgs e)
        {
            txbsearch.Text = string.Empty;
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            gridviewclients.ItemsSource = FindAll(x => x.Contains(txbsearch.Text));
        }
    }
}
