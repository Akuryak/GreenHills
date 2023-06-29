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
    /// Логика взаимодействия для AddRealtor_admin_.xaml
    /// </summary>
    public partial class AddRealtor_admin_ : Page
    {
        public static staff Staff { get; set; }
        public AddRealtor_admin_(staff staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        private void addrealtor_button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surname_textbox.Text) || string.IsNullOrWhiteSpace(name_textbox.Text) || string.IsNullOrWhiteSpace(patronymic_textbox.Text) || string.IsNullOrWhiteSpace(Phone_textBox.Text) || string.IsNullOrWhiteSpace(password_textbox.Text) || string.IsNullOrWhiteSpace(requisites_textbox.Text) || string.IsNullOrWhiteSpace(email_textbox.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }

            if (!decimal.TryParse(Phone_textBox.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Replace("_", ""), out decimal phone))
            {
                MessageBox.Show("Корректно заполните номер телефона", "Ошибка");
                return;
            }

            App.Context.staff.Add(new staff(App.Context.staff.ToList().Max(x => x.IdStaff) + 1, surname_textbox.Text, name_textbox.Text, patronymic_textbox.Text, phone, password_textbox.Text, requisites_textbox.Text, email_textbox.Text, 2, null, null));
            App.Context.SaveChanges();

            MessageBox.Show("Вы успешно добавили риелтора", "Уведомление");
            PageManagerClass.MainFrame.Navigate(new Admin_cabinet_(Staff));
        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddRealtor_admin_(Staff));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nameuser.Content = $"{Staff.SurnameStaff} {Staff.NameStaff}";
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new Admin_cabinet_(Staff));
        }
    }
}
