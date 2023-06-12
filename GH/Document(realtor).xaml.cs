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
    /// Логика взаимодействия для Document_realtor_.xaml
    /// </summary>
    public partial class Document_realtor_ : Page
    {
        public static staff Staff { get; set; }
        public Document_realtor_(staff staff)
        {
            InitializeComponent();

            Staff = staff;
        }

        public void Refresh()
        {
            List<Contract> contracts = App.Context.Contracts.ToList();

            if (!string.IsNullOrWhiteSpace(search_textbox.Text))
                contracts = contracts.Where(x => x.StaffFullName.Contains(search_textbox.Text) || x.BuyerFullName.Contains(search_textbox.Text)).ToList();

            if (Filter_combox.SelectedIndex != 0)
                contracts = contracts.Where(x => x.TypeContractNavigation.NameTypeContract.Contains(((ComboBoxItem)Filter_combox.SelectedItem).Content.ToString())).ToList();

            DocumentsListBox.Items.Clear();
            foreach (Contract contract in contracts)
            {
                DocumentsListBox.Items.Add(new UserControls.DocumentInfoUserControl(contract));
            }
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void addDoc_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddDocunent(Staff));
        }

        private void deliteDoc_button_Click(object sender, RoutedEventArgs e)
        {
            if (DocumentsListBox.SelectedItem != null)
            {
                App.Context.Contracts.Remove((Contract)((UserControls.DocumentInfoUserControl)DocumentsListBox.SelectedItem).DataContext);
                App.Context.SaveChanges();
                MessageBox.Show("Вы успешно удалили контракт", "Уведомление");
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nameuser.Content = Staff.FullName;

            Refresh();
        }
    }
}
