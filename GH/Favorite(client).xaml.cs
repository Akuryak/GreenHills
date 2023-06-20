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
    /// Логика взаимодействия для Favorite_client_.xaml
    /// </summary>
    public partial class Favorite_client_ : Page
    {
        public static Client Client { get; set; }
        public Favorite_client_(Client client)
        {
            InitializeComponent();
            Client = client;
        }

        private void trash_button_Click(object sender, RoutedEventArgs e)
        {
            if (ObjectsListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите объект для удаления", "Ошибка");
                return;
            }

            if (App.Context.FavoriteClientObjects.ToList().FirstOrDefault(x => x.ClientNavigation.IdClient == Client.IdClient && x.ObjectNavigation.IdObject == ((Model.Object)((UserControls.ObjectInfoUserControl)ObjectsListBox.SelectedItem).DataContext).IdObject) == null)
            {
                MessageBox.Show("Не удается найти объект", "Ошибка");
                return;
            }
            App.Context.FavoriteClientObjects.Remove(App.Context.FavoriteClientObjects.ToList().FirstOrDefault(x => x.ClientNavigation.IdClient == Client.IdClient && x.ObjectNavigation.IdObject == ((Model.Object)((UserControls.ObjectInfoUserControl)ObjectsListBox.SelectedItem).DataContext).IdObject));
            App.Context.SaveChanges();

            ObjectsListBox.Items.Remove(ObjectsListBox.SelectedItem);
            MessageBox.Show("Вы успешно удалили избранный объект", "Уведомление");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UsernameLable.Content = $"{Client.SurnameClient} {Client.NameClient} {Client.PatronymicClient}";

            if (App.Context.FavoriteClientObjects.ToList().Where(x => x.ClientNavigation.IdClient == Client.IdClient).Count() <= 0)
            {
                ObjectsListBox.Items.Add(new ListViewItem() { Content = "Нет избранных объектов" });
                return;
            }

            foreach (FavoriteClientObject clientObject in App.Context.FavoriteClientObjects.ToList().Where(x=>x.ClientNavigation.IdClient == Client.IdClient))
            {
                ObjectsListBox.Items.Add(new UserControls.ObjectInfoUserControl(clientObject.ObjectNavigation));
            }
        }
    }
}
