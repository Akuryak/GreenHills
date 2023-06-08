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
    /// Логика взаимодействия для Realtor_cabinet_.xaml
    /// </summary>
    public partial class Realtor_cabinet_ : Page
    {
        public Realtor_cabinet_()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Cabinet_realtor_());
        }

        private void cabinet_button_Click(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Cabinet_realtor_());
        }

        private void object_button_Click(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Object_realtor());
        }

        private void client_button_Click(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Client_realtor());
        }

        private void documents_button_Click(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Document_realtor_());
        }

        private void power_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new MainPage());
        }
    }
}
