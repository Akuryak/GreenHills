using GH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для ListRealtor.xaml
    /// </summary>
    public partial class ListRealtor : Page
    {
        public static staff Staff { get; set; }
        public ListRealtor(staff staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (Staff.RoleStaff != 1)
            {
                addrealtor_button.Visibility = Visibility.Collapsed;
                deliterealtor_button.Visibility = Visibility.Collapsed;
            }

            nameuser.Content = Staff.FullName;

            Refresh();
        }

        public void Refresh()
        {
            RealtorsListListBox.Items.Clear();

            List<staff> staffs = App.Context.staff.ToList().Where(x => x.RoleStaff == 2).ToList();

            if (!string.IsNullOrWhiteSpace(search_textbox.Text))
                staffs = staffs.Where(x=> $"{x.SurnameStaff} {x.NameStaff} {x.PatronymicStaff}".Contains(search_textbox.Text)).ToList();

            foreach (staff staff in staffs)
            {
                RealtorsListListBox.Items.Add(new UserControls.RealtorsInfoUserControl(staff));
            }
        }

        private void addrealtor_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddRealtor_admin_(Staff));

            //при выводе у всех риэлторов фото Resourses/realtor(2).png
            //клиент просмотр и поиск
            //реализовать рейтинг для риэлторов при выводе, создать класс patrial, рейтинг считается в зависимости от того сколько риэлтор заключил договоров 
            //5.0 рейтинг если 3 договора
            //4.0 рейтинг если 2 договора 
            //3.0 рейтинг если 1 договора
            //1.5 рейтинг если 0 договоров
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void deliterealtor_button_Click(object sender, RoutedEventArgs e)
        {
            if (RealtorsListListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите риелтора для удаления", "Уведомление");
                return;
            }

            if (MessageBox.Show("Вы уверены что хотите удалить риелтора?", "Предупреждение", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                return;

            App.Context.staff.Remove((staff)((UserControls.RealtorsInfoUserControl)RealtorsListListBox.SelectedItem).DataContext);
            App.Context.SaveChanges();

            MessageBox.Show("Вы успешно удалили риелтора", "Уведомление");
            Refresh();
        }
    }
}
