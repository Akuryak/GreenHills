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
    /// Логика взаимодействия для AddClient_realtor_.xaml
    /// </summary>
    public partial class AddClient_realtor_ : Page
    {
        public static string UserType { get; set; } = "Покупатель";
        public static staff Staff { get; set; }
        public AddClient_realtor_(staff staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        private void buyer_button_Click(object sender, RoutedEventArgs e)
        {
            UserType = "Покупатель";
        }

        private void sob_button_Click(object sender, RoutedEventArgs e)
        {
            UserType = "Собственник";
        }

        private void addclient_button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surname_textbox.Text) || string.IsNullOrWhiteSpace(name_textbox.Text) || string.IsNullOrWhiteSpace(patronymic_textbox.Text) || string.IsNullOrWhiteSpace(Phone_textBox.Text) || string.IsNullOrWhiteSpace(password_textbox.Text) || string.IsNullOrWhiteSpace(requisites_textbox.Text) || string.IsNullOrWhiteSpace(email_textbox.Text) || string.IsNullOrWhiteSpace(idObject_textbox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }

            if (!int.TryParse(idObject_textbox.Text, out int objectId) || !int.TryParse(Phone_textBox.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Replace("+", ""), out int phone) || !int.TryParse(requisites_textbox.Text, out int passSeriesAndNumber))
            {
                MessageBox.Show("Корректно заполните поля номера телефона, объекта, серию и номер паспорта", "Ошибка");
                return;
            }

            App.Context.Clients.Add(new Client(App.Context.Clients.ToList().Max(x=>x.IdClient) + 1, surname_textbox.Text, name_textbox.Text, patronymic_textbox.Text, phone.ToString(), password_textbox.Text, passSeriesAndNumber.ToString(), email_textbox.Text, UserType == "Покупатель" ? 4 : 3, null, null, null, null));
            App.Context.SaveChanges();

            MessageBox.Show("Вы успешно добавили клиента", "Уведомление");
            PageManagerClass.MainFrame.Navigate(new Client_realtor(Staff));

        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
           PageManagerClass.MainFrame.Navigate(new AddClient_realtor_(Staff));
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
