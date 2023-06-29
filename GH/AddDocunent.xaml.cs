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
    /// Логика взаимодействия для AddDocunent.xaml
    /// </summary>
    public partial class AddDocunent : Page
    {
        public static staff Staff { get; set; }
        public static string ContractType { get; set; } = "Купли";
        public AddDocunent(staff staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        private void buyerDoc_button_Click(object sender, RoutedEventArgs e)
        {
            ContractType = "Купли";
            buyerDoc_button.IsEnabled = false;
            sobDoc_button.IsEnabled = true;
        }

        private void sobDoc_button_Click(object sender, RoutedEventArgs e)
        {
            ContractType = "Продажи";
            buyerDoc_button.IsEnabled = true;
            sobDoc_button.IsEnabled = false;
        }

        private void addDoc_button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Byer_textbox.Text, out int buyerId) || !int.TryParse(Sob_textbox.Text, out int ownerId) || !int.TryParse(Object_textbox.Text, out int objectId))
            {
                MessageBox.Show("Введите корректные ID покупателя и собственника", "Ошибка");
                return;
            }

            if (App.Context.Clients.ToList().FirstOrDefault(x=>x.IdClient == buyerId) == null || App.Context.Clients.ToList().FirstOrDefault(x => x.IdClient == ownerId) == null || App.Context.Objects.ToList().FirstOrDefault(x => x.IdObject == objectId) == null)
            {
                MessageBox.Show("Покупатель, собственник или объект с таким ID не найден", "Ошибка");
                return;
            }

            Contract contract = new Contract();
            try
            {
                contract = new Contract(App.Context.Contracts.ToList().Max(x => x.IdContract) + 1, App.Context.Clients.ToList().FirstOrDefault(x => x.IdClient == buyerId).IdClient, App.Context.Objects.ToList().FirstOrDefault(x => x.IdObject == objectId).IdObject, App.Context.Clients.ToList().FirstOrDefault(x => x.IdClient == ownerId).IdClient, (DateTime)dateConclusion_data.SelectedDate, (DateTime)validUntil_data.SelectedDate, ContractType == "Купли" ? 1 : 2, null, null, null, null);
                App.Context.Contracts.Add(contract);
                App.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при добавлении договора, проверьте правильность ID. Ошибка: {ex.Message}", "Ошибка");
            }

            if (ContractType == "Купли")
                PageManagerClass.MainFrame.Navigate(new BuyDocument(Staff, null, contract));
            else if (ContractType == "Продажи")
                PageManagerClass.MainFrame.Navigate(new SaleDocument(Staff, null, contract));
        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddDocunent(Staff));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nameuser.Content = $"{Staff.SurnameStaff} {Staff.NameStaff}";
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new Client_realtor(Staff));
        }
    }
}
