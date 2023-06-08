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
    /// Логика взаимодействия для AddDocunent.xaml
    /// </summary>
    public partial class AddDocunent : Page
    {
        public AddDocunent()
        {
            InitializeComponent();
        }

        private void buyerDoc_button_Click(object sender, RoutedEventArgs e)
        {
            //выбор типа документа можно реализовать в combobox 
        }

        private void sobDoc_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addDoc_button_Click(object sender, RoutedEventArgs e)
        {
            //в зависимости от типа разные договоры
            //переход на страничку либо на договор купли либо на договор продажи
           // PageManagerClass.MainFrame.Navigate(new BuyDocument());

        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
