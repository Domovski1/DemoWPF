using DemoWPF.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace DemoWPF.Classes
{
    public class BackgroundItemClass
    {

        public static void ChangeBackgroundStackPanel(StackPanel stackPanel, Product product)
        {
            if (product.Cost > 1800)
            {
                stackPanel.Background = new SolidColorBrush(Colors.Green);
            } 
        }
    }
}
