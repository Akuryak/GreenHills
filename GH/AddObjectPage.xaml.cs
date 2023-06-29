using GH.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddObjectPage.xaml
    /// </summary>
    public partial class AddObjectPage : Page
    {
        public static staff Staff { get; set; }
        public static string ObjectType { get; set; } = "Квартира";
        public AddObjectPage(staff staff)
        {
            InitializeComponent();
            Staff = staff;
        }

        private void apartment_button_Click(object sender, RoutedEventArgs e)
        {
            square_textbox.IsEnabled = false;
            numRooms_textbox.IsEnabled = true;
            floor_textbox.IsEnabled = true;
            plotArea_textbox.IsEnabled = false;
            ObjectType = "Квартира";
        }

        private void room_button_Click(object sender, RoutedEventArgs e)
        {
            square_textbox.IsEnabled = false;
            numRooms_textbox.IsEnabled = false;
            floor_textbox.IsEnabled = true;
            plotArea_textbox.IsEnabled = false;
            ObjectType = "Комната";

        }

        private void home_button_Click(object sender, RoutedEventArgs e)
        {
            square_textbox.IsEnabled = true;
            numRooms_textbox.IsEnabled = true;
            floor_textbox.IsEnabled = true;
            plotArea_textbox.IsEnabled = true;
            ObjectType = "Дом";

        }

        private void plot_button_Click(object sender, RoutedEventArgs e)
        {
            square_textbox.IsEnabled = true;
            numRooms_textbox.IsEnabled = false;
            floor_textbox.IsEnabled = false;
            plotArea_textbox.IsEnabled = true;
            ObjectType = "Участок";

        }

        private void addObject_button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(city_textbox.Text) || string.IsNullOrWhiteSpace(district_textbox.Text) || string.IsNullOrWhiteSpace(address_textbox.Text))
            {
                MessageBox.Show("Заполните поля адреса объекта", "Ошибка");
                return;
            }

            if (!decimal.TryParse(price_textbox.Text, out decimal price))
            {
                MessageBox.Show("Корректно заполните поле цены", "Ошибка");
                return;
            }

            if (!int.TryParse(sob_textbox.Text, out int ownerID))
            {
                MessageBox.Show("Корректно заполните ID собственника", "Ошибка");
                return;
            }

            if (App.Context.Clients.ToList().Where(x=>x.IdClient == ownerID) == null)
            {
                MessageBox.Show("Собственника с таким ID не существует", "Ошибка");
                return;
            }

            if (!File.Exists($"Object/{foto_textbox.Text}"))
            {
                MessageBox.Show("Фото не найдено", "Ошибка");
                return;
            }

            switch (ObjectType)
            {
                case "Квартира":
                    if (string.IsNullOrWhiteSpace(price_textbox.Text) || string.IsNullOrWhiteSpace(sob_textbox.Text) || string.IsNullOrWhiteSpace(foto_textbox.Text) || string.IsNullOrWhiteSpace(square_textbox.Text) || string.IsNullOrWhiteSpace(floor_textbox.Text) || string.IsNullOrWhiteSpace(numRooms_textbox.Text))
                    {
                        MessageBox.Show("Заполните все поля", "Ошибка");
                        return;
                    }
                    if (!int.TryParse(square_textbox.Text, out int apartmentSquare) || !int.TryParse(floor_textbox.Text, out int apartmentFloor) || !int.TryParse(numRooms_textbox.Text, out int apartmentRoomsCount))
                    {
                        MessageBox.Show("Корректно заполните поля площади, этажа и колличества комнат", "Ошибка");
                        return;
                    }

                    App.Context.Objects.Add(new Model.Object(App.Context.Objects.ToList().Max(x => x.IdObject) + 1, 1, price, apartmentRoomsCount, apartmentSquare.ToString(), "", apartmentFloor, ownerID, city_textbox.Text, district_textbox.Text, address_textbox.Text, foto_textbox.Text, null, null, null, null));
                    break;

                case "Комната":
                    if (string.IsNullOrWhiteSpace(price_textbox.Text) || string.IsNullOrWhiteSpace(sob_textbox.Text) || string.IsNullOrWhiteSpace(foto_textbox.Text) || string.IsNullOrWhiteSpace(square_textbox.Text) || string.IsNullOrWhiteSpace(floor_textbox.Text))
                    {
                        MessageBox.Show("Заполните все поля", "Ошибка");
                        return;
                    }
                    if (!int.TryParse(square_textbox.Text, out int roomSquare) || !int.TryParse(floor_textbox.Text, out int roomFloor))
                    {
                        MessageBox.Show("Корректно заполните поля площади и этажа", "Ошибка");
                        return;
                    }

                    App.Context.Objects.Add(new Model.Object(App.Context.Objects.ToList().Max(x => x.IdObject) + 1, 1, price, 1, roomSquare.ToString(), "", roomFloor, ownerID, city_textbox.Text, district_textbox.Text, address_textbox.Text, foto_textbox.Text, null, null, null, null));
                    break;

                case "Дом":
                    if (string.IsNullOrWhiteSpace(price_textbox.Text) || string.IsNullOrWhiteSpace(sob_textbox.Text) || string.IsNullOrWhiteSpace(foto_textbox.Text) || string.IsNullOrWhiteSpace(square_textbox.Text) || string.IsNullOrWhiteSpace(floor_textbox.Text) || string.IsNullOrWhiteSpace(numRooms_textbox.Text))
                    {
                        MessageBox.Show("Заполните все поля", "Ошибка");
                        return;
                    }
                    if (!int.TryParse(square_textbox.Text, out int houseLivingSquare) || !int.TryParse(floor_textbox.Text, out int houseFloor) || !int.TryParse(numRooms_textbox.Text, out int houseRoomsCount) || !int.TryParse(plotArea_textbox.Text, out int housePlotArea))
                    {
                        MessageBox.Show("Корректно заполните поля площади, этажа и колличества комнат", "Ошибка");
                        return;
                    }

                    App.Context.Objects.Add(new Model.Object(App.Context.Objects.ToList().Max(x => x.IdObject) + 1, 1, price, houseRoomsCount, houseLivingSquare.ToString(), housePlotArea.ToString(), houseFloor, ownerID, city_textbox.Text, district_textbox.Text, address_textbox.Text, foto_textbox.Text, null, null, null, null));
                    break;

                case "Участок":
                    if (string.IsNullOrWhiteSpace(price_textbox.Text) || string.IsNullOrWhiteSpace(sob_textbox.Text) || string.IsNullOrWhiteSpace(foto_textbox.Text) || string.IsNullOrWhiteSpace(square_textbox.Text) || string.IsNullOrWhiteSpace(floor_textbox.Text) || string.IsNullOrWhiteSpace(numRooms_textbox.Text))
                    {
                        MessageBox.Show("Заполните все поля", "Ошибка");
                        return;
                    }
                    if (!int.TryParse(plotArea_textbox.Text, out int plotArea))
                    {
                        MessageBox.Show("Корректно заполните поля площади, этажа и колличества комнат", "Ошибка");
                        return;
                    }

                    App.Context.Objects.Add(new Model.Object(App.Context.Objects.ToList().Max(x => x.IdObject) + 1, 1, price, 0, "0", plotArea.ToString(), 0, ownerID, city_textbox.Text, district_textbox.Text, address_textbox.Text, foto_textbox.Text, null, null, null, null));
                    break;
            }
            App.Context.SaveChanges();

            MessageBox.Show("Вы успешно добавили объект", "Уведомление");

            PageManagerClass.MainFrame.Navigate(new Object_realtor(Staff, null, App.Context.Objects.ToList()));
        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new AddObjectPage(Staff));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nameuser.Content = $"{Staff.SurnameStaff} {Staff.NameStaff}";
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new Object_realtor(Staff, null, App.Context.Objects.ToList()));
        }
    }
}
