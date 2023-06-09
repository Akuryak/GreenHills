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
    /// Логика взаимодействия для Admin_cabinet_.xaml
    /// </summary>
    public partial class Admin_cabinet_ : Page
    {
        public static staff Staff { get; set;}
        public Admin_cabinet_(staff staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        private void realtor_button_Click(object sender, RoutedEventArgs e)
        {
            Admin.Navigate(new ListRealtor(Staff));
        }

        private void report_button_Click(object sender, RoutedEventArgs e)
        {
            Admin.Navigate(new Report_admin_(Staff));
        }

        private void power_button_Click(object sender, RoutedEventArgs e)
        {
            Admin.Navigate(new MainPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Admin.Navigate(new ListRealtor(Staff));
        }
    }
}
