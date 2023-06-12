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
    /// Логика взаимодействия для Client_cabinet_.xaml
    /// </summary>
    public partial class Client_cabinet_ : Page
    {
        public static staff Staff { get; set; }
        public Client_cabinet_(staff staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame = Client;
            Client.Navigate(new Favorite_client_());
        }

        private void favorite_button_Click(object sender, RoutedEventArgs e)
        {
            Client.Navigate(new Favorite_client_());
        }

        private void object_button_Click(object sender, RoutedEventArgs e)
        {
            Client.Navigate(new Object_realtor(Staff, App.Context.Objects.ToList()));
        }

        private void realtor_button_Click(object sender, RoutedEventArgs e)
        {
            Client.Navigate(new ListRealtor(Staff));
        }

        private void personalDoc_button_Click(object sender, RoutedEventArgs e)
        {
            Client.Navigate(new PersonalDoc());
        }

        private void power_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
