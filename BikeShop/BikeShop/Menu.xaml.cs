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

namespace BikeShop
{
    /// <summary>
    /// Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnEmailSupport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TestDB.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnLiveSupport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/Discussion.xaml", UriKind.RelativeOrAbsolute)
                );
        }

        private void BtnProducts_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/ProductsManagement.xaml", UriKind.RelativeOrAbsolute)
                );
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/Test.xaml", UriKind.RelativeOrAbsolute)
                );
        }
    }
}
