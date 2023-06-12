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
    /// Логика взаимодействия для ComePage.xaml
    /// </summary>
    public partial class ComePage : Page
    {
        public ComePage()
        {
            InitializeComponent();
        }

        private void Registration_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new RegistrationPage());
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            password_textBox.Text = password_Box.Password;
            password_textBox.Visibility = Visibility.Visible;
            show.IsEnabled = false;
            hide.IsEnabled = true;
            password_Box.Visibility = Visibility.Hidden;
        }

        private void hide_Click(object sender, RoutedEventArgs e)
        {
            password_Box.Password = password_textBox.Text;
            password_Box.Visibility = Visibility.Visible;
            show.IsEnabled = true;
            hide.IsEnabled = false;
            password_textBox.Visibility = Visibility.Hidden;
        }

        private void ComeButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phone_textBox.Text) || string.IsNullOrWhiteSpace(password_Box.Password) && string.IsNullOrWhiteSpace(password_textBox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }
            string phone = phone_textBox.Text.Replace("-", "").Replace("_", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            if (!decimal.TryParse(phone, out decimal phoneNumber))
            {
                MessageBox.Show("Введите корректный номер телефона", "Ошибка");
                return;
            }

            staff staff = new staff();
            Client client = new Client();
            try
            {
                staff = App.Context.staff.ToList().FirstOrDefault(x => x.PhoneStaff == phoneNumber && x.PasswordStaf == password_Box.Password.Trim() || x.PasswordStaf == password_textBox.Text.Trim());
                client = App.Context.Clients.ToList().FirstOrDefault(x => x.PhoneClient == phone && x.PasswordClient == password_Box.Password.Trim() || x.PasswordClient == password_textBox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При получении данных с БД произошла ошибка.\n {ex.Message}", "Ошибка");
                return;
            };

            if (staff != null && client == null)
            {
                switch (staff.RoleStaff)
                {
                    case 1:
                        PageManagerClass.MainFrame.Navigate(new Admin_cabinet_(staff));
                        break;

                    case 2:
                        PageManagerClass.MainFrame.Navigate(new Realtor_cabinet_(staff));
                        break;

                    default:
                        MessageBox.Show("Такой роли нет", "Ошибка");
                        break;
                }
            }

            else if (staff == null && client != null)
            {
                switch (client.Role)
                {
                    case 3:
                        PageManagerClass.MainFrame.Navigate(new Client_cabinet_(staff));
                        break;

                    case 4:
                        PageManagerClass.MainFrame.Navigate(new Client_cabinet_(staff));
                        break;

                    default:
                        MessageBox.Show("Такой роли нет", "Ошибка");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Уведомление");
            }
        }
    }
}
