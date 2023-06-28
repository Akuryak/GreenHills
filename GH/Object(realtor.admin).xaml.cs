using GH.Model;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
    /// Логика взаимодействия для Object_realtor.xaml
    /// </summary>
    public partial class Object_realtor : Page
    {
        public static staff Staff { get; set; }
        public static Client Client { get; set; }
        public static List<Model.Object> Objects { get; set; }
        public Object_realtor(staff staff, Client client, List<Model.Object> objects)
        {
            InitializeComponent();

            Staff = staff;
            Objects = objects;
            Client = client;
        }

        public void Refresh()
        {
            ObjectsListBox.Items.Clear();

            if (!string.IsNullOrWhiteSpace(search_textbox.Text))
                Objects = Objects.Where(x => $"{x.CityObject} {x.DistrictObject} {x.AddressObject}".Contains(search_textbox.Text)).ToList();
            else
                Objects = App.Context.Objects.ToList();

            foreach (Model.Object @object in Objects)
            {
                if (Staff != null)
                    ObjectsListBox.Items.Add(new UserControls.ObjectInfoUserControl(@object));
                else if (Client != null)
                {
                    UserControls.ClientObjectUserControl clientObjectUserControl = new UserControls.ClientObjectUserControl(Client, @object);
                    clientObjectUserControl.ButtonClick += ClientObjectUserControl_ButtonClick;
                    ObjectsListBox.Items.Add(clientObjectUserControl);
                }
            }
        }
        private void ClientObjectUserControl_ButtonClick(object sender, RoutedEventArgs e)
        {
            if (ObjectsListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите объект, а затем нажмите кнопку \"Добавить в избранное\"", "Уведомление");
                return;
            }

            if ((Model.Object)((UserControls.ClientObjectUserControl)ObjectsListBox.SelectedItem).DataContext != null && Client != null)
            {
                if (App.Context.FavoriteClientObjects.ToList().FirstOrDefault(x => x.ClientNavigation.IdClient == Client.IdClient && x.ObjectNavigation.IdObject == ((Model.Object)((UserControls.ClientObjectUserControl)ObjectsListBox.SelectedItem).DataContext).IdObject) != null)
                {
                    MessageBox.Show("Вы уже добавили объект в избранное", "Уведомление");
                    return;
                }

                App.Context.FavoriteClientObjects.Add(new FavoriteClientObject(App.Context.FavoriteClientObjects.ToList().Count == 0 ? 1 : App.Context.FavoriteClientObjects.ToList().Max(x => x.Id) + 1, ((Model.Object)((UserControls.ClientObjectUserControl)ObjectsListBox.SelectedItem).DataContext).IdObject, Client.IdClient, null, null));
                App.Context.SaveChanges();

                MessageBox.Show("Вы успешно добавили объект в избранное", "Уведомление");
            }
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void filter_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new FilterObjectPage(Staff, Client));
        }

        private void addObject_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddObjectPage(Staff));
        }

        private void deliteObject_button_Click(object sender, RoutedEventArgs e)
        {
            if (ObjectsListBox.SelectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить объект?", "Предупреждение") == MessageBoxResult.Yes)
                {
                    App.Context.Objects.Remove((Model.Object)ObjectsListBox.SelectedItem);
                    App.Context.SaveChanges();

                    MessageBox.Show("Вы успешно удалили объект", "Уведомление");

                    PageManagerClass.MainFrame.Navigate(new Object_realtor(Staff, Client, App.Context.Objects.ToList()));
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nameuser.Content = Staff == null ? $"{Client.SurnameClient} {Client.NameClient}" : $"{Staff.SurnameStaff} {Staff.NameStaff}";

            if (Staff == null && Client != null)
            {
                addObject_button.Visibility = Visibility.Collapsed;
                deliteObject_button.Visibility = Visibility.Collapsed;
            }

            Refresh();
        }
    }
}
