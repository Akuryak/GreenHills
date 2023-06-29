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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void hide_Click(object sender, RoutedEventArgs e)
        {
            password_Box.Password = password_textBox.Text;
            password_Box.Visibility = Visibility.Visible;
            show.IsEnabled = true;
            hide.IsEnabled = false;
            password_textBox.Visibility = Visibility.Hidden;
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            password_textBox.Text = password_Box.Password;
            password_textBox.Visibility = Visibility.Visible;
            show.IsEnabled = false;
            hide.IsEnabled = true;
            password_Box.Visibility = Visibility.Hidden;
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Surname_textbox.Text) || string.IsNullOrWhiteSpace(Name_textbox.Text) || string.IsNullOrWhiteSpace(Patronymic_textbox.Text) || string.IsNullOrWhiteSpace(Requisites_textbox.Text) || string.IsNullOrWhiteSpace(Phone_textBox.Text) || string.IsNullOrWhiteSpace(password_Box.Password) && string.IsNullOrWhiteSpace(password_textBox.Text) || string.IsNullOrWhiteSpace(Email_textbox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }

            if (App.Context.Clients.ToList().FirstOrDefault(x=>x.PhoneClient == Phone_textBox.Text) != null)
            {
                MessageBox.Show("Пользователь с таким номером уже зарегистрирован", "Ошибка");
                return;
            }

            string phone = Phone_textBox.Text.Replace("-", "").Replace("_", "").Replace("(", "").Replace(")", "").Replace(" ", "");

            App.Context.Clients.Add(new Model.Client(App.Context.Clients.ToList().Max(x => x.IdClient) + 1, Surname_textbox.Text.Trim(), Name_textbox.Text.Trim(), Patronymic_textbox.Text.Trim(), phone, password_Box == null ? password_textBox.Text : password_Box.Password, Requisites_textbox.Text, Email_textbox.Text,/* Под сомнениями */ 4, null, null, null, null));
            App.Context.SaveChanges();

            MessageBox.Show("Вы успешно зарегистрировались", "Уведомление");

            PageManagerClass.MainFrame.Navigate(new MainPage());
        }

        private void noreg_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new ComePage());
        }
    }
}
