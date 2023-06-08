using GH.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для Report_admin_.xaml
    /// </summary>
    public partial class Report_admin_ : Page
    {
        public Report_admin_()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            List<Contract> contracts = App.Context.Contracts.ToList();

            if (Realtor_combobox.SelectedIndex != 0)
                contracts = contracts.Where(x=>x.StaffFullName.Contains(((ComboBoxItem)Realtor_combobox.SelectedItem).Content.ToString())).ToList();

            if (StartDatePicker.SelectedDate != null)
                contracts = contracts.Where(x => x.DateConclusionContract.CompareTo((DateTime)StartDatePicker.SelectedDate) > 0).ToList();

            if (EndDatePicker.SelectedDate != null)
                contracts = contracts.Where(x => x.ValidUntilContract.CompareTo((DateTime)EndDatePicker.SelectedDate) < 0).ToList();

            if (ContractListBox != null)
                ContractListBox.Items.Clear();

            foreach (Contract contract in contracts)
            {
                ContractListBox.Items.Add(new UserControls.ContractInfoUserControl(contract));
            }
        }

        private void StartDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void EndDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void Realtor_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Realtor_combobox.SelectedIndex != 0)
                Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (staff staff in App.Context.staff.ToList().Where(x=>x.RoleStaff == 2))
            {
                ComboBoxItem item = new ComboBoxItem() { Content = $"{staff.SurnameStaff} {staff.NameStaff} {staff.PatronymicStaff}" };
                Realtor_combobox.Items.Add(item);
            }

            Refresh();
        }
    }
}
