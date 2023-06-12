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
    /// Логика взаимодействия для Client_realtor.xaml
    /// </summary>
    public partial class Client_realtor : Page
    {
        public static staff Staff { get; set; }
        public Client_realtor(staff staff)
        {
            InitializeComponent();

            Staff = staff;
            //combox фильтр по двум значениям 1)покупатель 2)собственник
            //у всех клиентов фото user.jpg
        }

        public void Refresh()
        {
            List<Client> clients = App.Context.Clients.ToList();

            if (!string.IsNullOrWhiteSpace(search_textbox.Text))
                clients = clients.Where(x => $"{x.SurnameClient} {x.NameClient} {x.PatronymicClient}".Contains(search_textbox.Text)).ToList();

            if (Filter_combox.SelectedIndex != 0)
                clients = clients.Where(x=>x.RoleNavigation.NameRole.Contains(((ComboBoxItem)Filter_combox.SelectedItem).Content.ToString())).ToList();

            ClientListBox.Items.Clear();
            foreach (Client client in clients)
            {
                ClientListBox.Items.Add(new UserControls.ClientInfoUserControl(client));
            }
        }

        private void addClient_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddClient_realtor_(Staff));
        }

        private void deliteClient_button_Click(object sender, RoutedEventArgs e)
        {
            if (ClientListBox.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить клиента", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    App.Context.Clients.Remove((Client)ClientListBox.SelectedItem);
                    App.Context.SaveChanges();

                    MessageBox.Show("Вы успешно удалили клиента", "Уведомление");
                    PageManagerClass.MainFrame.Navigate(new Client_realtor(Staff));
                }
            }
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nameuser.Content = Staff.FullName;

            Refresh();
        }
    }
}
