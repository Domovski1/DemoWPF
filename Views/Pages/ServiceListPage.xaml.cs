using DemoWPF.Base;
using DemoWPF.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DemoWPF.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {
        public ObservableCollection<Product> products { get; set; }
        public ServiceListPage()
        {
            InitializeComponent();

            products = new ObservableCollection<Product>(BaseClass.db.Product.ToList());
            this.DataContext = this;
        }

        private void BtnActive_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new CreateUpdatePage((Product)ProductListView.SelectedItem));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
