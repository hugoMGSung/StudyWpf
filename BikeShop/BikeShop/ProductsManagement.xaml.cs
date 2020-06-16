using System.Windows.Controls;

namespace BikeShop
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProductsManagement : Page
    {
        public ProductsManagement()
        {
            InitializeComponent();
        }

        ProductsFactory factory = new ProductsFactory();

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DgrProducts.ItemsSource = factory.FindProducts(TxtSearch.Text);
        }
    }
}
