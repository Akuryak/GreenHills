using GH.Model;
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
        public static staff Staff { get; set; }
        public Realtor_cabinet_(staff staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Cabinet_realtor_(Staff));
        }

        private void cabinet_button_Click(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Cabinet_realtor_(Staff));
        }

        private void object_button_Click(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Object_realtor(Staff, null, App.Context.Objects.ToList()));
        }

        private void client_button_Click(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Client_realtor(Staff));
        }

        private void documents_button_Click(object sender, RoutedEventArgs e)
        {
            Realtor.Navigate(new Document_realtor_(Staff));
        }

        private void power_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new MainPage());
        }
    }
}
