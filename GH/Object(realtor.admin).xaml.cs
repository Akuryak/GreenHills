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

namespace GH
{
    /// <summary>
    /// Логика взаимодействия для Object_realtor.xaml
    /// </summary>
    public partial class Object_realtor : Page
    {
        public Object_realtor()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void filter_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new FilterObjectPage());
        }

        private void addObject_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddObjectPage());
        }

        private void deliteObject_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
