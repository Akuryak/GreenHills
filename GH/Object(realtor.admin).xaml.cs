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
        public static List<Model.Object> Objects { get; set; }
        public Object_realtor(staff staff, List<Model.Object> objects)
        {
            InitializeComponent();

            Staff = staff;
            Objects = objects;
        }

        public void Refresh()
        {
            ObjectsListBox.Items.Clear();

            if (!string.IsNullOrWhiteSpace(search_textbox.Text))
                Objects = Objects.Where(x => $"{x.CityObject} {x.DistrictObject} {x.AddressObject}".Contains(search_textbox.Text)).ToList();

            foreach (Model.Object @object in Objects)
            {
                ObjectsListBox.Items.Add(new UserControls.ObjectInfoUserControl(@object));
            }
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void filter_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new FilterObjectPage(Staff));
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

                    PageManagerClass.MainFrame.Navigate(new Object_realtor(Staff, App.Context.Objects.ToList()));
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nameuser.Content = Staff.FullName;

            Refresh();
        }
    }
}
