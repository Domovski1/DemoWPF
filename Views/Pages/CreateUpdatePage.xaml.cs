using DemoWPF.Base;
using Microsoft.Win32;
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

namespace DemoWPF.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateUpdatePage.xaml
    /// </summary>
    public partial class CreateUpdatePage : Page
    {
        public Product NativeProduct { get; set; }
        public CreateUpdatePage(Product GetProduct)
        {
            InitializeComponent();

            NativeProduct = GetProduct;
            this.DataContext = this;
            
        }

        private void BtnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "(*.png); (*jpg); | *.png; *.jpg";

            if (file.ShowDialog() == true)
            {
                ImgBox.Source = new BitmapImage(new Uri(file.FileName));
            } else
            {
                MessageBox.Show("Вы отменили выбор");
            }
        }

        private void BtnImageNull_Click(object sender, RoutedEventArgs e)
        {
            ImgBox.Source = null;
        }
    }
}
