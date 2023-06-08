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
    /// Логика взаимодействия для Document_realtor_.xaml
    /// </summary>
    public partial class Document_realtor_ : Page
    {
        public Document_realtor_()
        {
            InitializeComponent();
            //для всех договоров фото Doc(realtor).png
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addDoc_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddDocunent());
        }

        private void deliteDoc_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
