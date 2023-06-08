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
    /// Логика взаимодействия для Client_realtor.xaml
    /// </summary>
    public partial class Client_realtor : Page
    {
        public Client_realtor()
        {
            InitializeComponent();
            //combox фильтр по двум значениям 1)покупатель 2)собственник
            //у всех клиентов фото user.jpg
        }

        private void addClient_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddClient_realtor_());
        }

        private void deliteClient_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
