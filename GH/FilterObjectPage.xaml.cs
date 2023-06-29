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
    /// Логика взаимодействия для FilterObjectPage.xaml
    /// </summary>
    public partial class FilterObjectPage : Page
    {
        public static staff Staff { get; set; }
        public static Client Client { get; set; }
        public FilterObjectPage(staff staff, Client client)
        {
            InitializeComponent();
            Staff = staff;
            Client = client;
        }

        private void apartment_button_Click(object sender, RoutedEventArgs e)
        {
            plotAreaFrom_textbox.IsEnabled = false;
            plotAreaBefore_textbox.IsEnabled = false;

            plotAreaFrom_textbox.Text = string.Empty;
            plotAreaBefore_textbox.Text = string.Empty;

            numRoomsFrom_textbox.IsEnabled = true;
            numRoomsBefore_textbox.IsEnabled = true;

            floorFrom_textbox.IsEnabled = true;
            floorBefore_textbox.IsEnabled = true;
        }

        private void room_button_Click(object sender, RoutedEventArgs e)
        {
            numRoomsFrom_textbox.IsEnabled = false;
            numRoomsBefore_textbox.IsEnabled = false;

            numRoomsFrom_textbox.Text = string.Empty;
            numRoomsBefore_textbox.Text = string.Empty;

            plotAreaFrom_textbox.IsEnabled = false;
            plotAreaBefore_textbox.IsEnabled = false;

            plotAreaFrom_textbox.Text = string.Empty;
            plotAreaBefore_textbox.Text = string.Empty;

            floorFrom_textbox.IsEnabled = true;
            floorBefore_textbox.IsEnabled = true;
        }

        private void home_button_Click(object sender, RoutedEventArgs e)
        {
            plotAreaFrom_textbox.IsEnabled = true;
            plotAreaBefore_textbox.IsEnabled = true;

            numRoomsFrom_textbox.IsEnabled = true;
            numRoomsBefore_textbox.IsEnabled = true;

            floorFrom_textbox.IsEnabled = true;
            floorBefore_textbox.IsEnabled = true;
        }

        private void plot_button_Click(object sender, RoutedEventArgs e)
        {
            numRoomsFrom_textbox.IsEnabled = false;
            numRoomsBefore_textbox.IsEnabled = false;

            squareFrom_textbox.IsEnabled = false;
            squareBefore_textbox.IsEnabled = false;

            floorFrom_textbox.IsEnabled = false;
            floorBefore_textbox.IsEnabled = false;

            plotAreaFrom_textbox.IsEnabled = true;
            plotAreaBefore_textbox.IsEnabled = true;
        }

        private void filter_button_Click(object sender, RoutedEventArgs e)
        {
            List<Model.Object> objects = App.Context.Objects.ToList();

            if (!string.IsNullOrWhiteSpace(priceFrom_textbox.Text) && !string.IsNullOrWhiteSpace(priceBefore_textbox.Text))
                if (decimal.TryParse(priceFrom_textbox.Text, out decimal priceFrom) && decimal.TryParse(priceBefore_textbox.Text, out decimal priceBefore))
                {
                    objects = objects.Where(x => x.PriceObject > priceFrom && x.PriceObject < priceBefore).ToList();
                }
                else
                {
                    MessageBox.Show("Корректно заполните поля цены", "Ошибка");
                    return;
                }

            if (!string.IsNullOrWhiteSpace(plotAreaFrom_textbox.Text) && !string.IsNullOrWhiteSpace(plotAreaBefore_textbox.Text))
                if (int.TryParse(plotAreaFrom_textbox.Text, out int plotAreaFrom) && int.TryParse(plotAreaBefore_textbox.Text, out int plotAreaBefore))
                {
                    objects = objects.Where(x => int.Parse(x.PlotAreaObject) > plotAreaFrom && int.Parse(x.PlotAreaObject) < plotAreaBefore).ToList();
                }
                else
                {
                    MessageBox.Show("Корректно заполните поля площади", "Ошибка");
                    return;
                }

            if (!string.IsNullOrWhiteSpace(squareFrom_textbox.Text) && !string.IsNullOrWhiteSpace(squareBefore_textbox.Text))
                if (int.TryParse(squareFrom_textbox.Text, out int squareFrom) && int.TryParse(squareBefore_textbox.Text, out int squareBefore))
                {
                    objects = objects.Where(x => int.Parse(x.LivingAreaObject) > squareFrom && int.Parse(x.LivingAreaObject) < squareBefore).ToList();
                }
                else
                {
                    MessageBox.Show("Корректно заполните поля площади", "Ошибка");
                    return;
                }

            if (!string.IsNullOrWhiteSpace(floorFrom_textbox.Text) && !string.IsNullOrWhiteSpace(floorBefore_textbox.Text))
                if (int.TryParse(floorFrom_textbox.Text, out int floorFrom) && int.TryParse(floorBefore_textbox.Text, out int floorBefore))
                {
                    objects = objects.Where(x => x.FloorObject > floorFrom && x.FloorObject < floorBefore).ToList();
                }
                else
                {
                    MessageBox.Show("Корректно заполните поля этажа", "Ошибка");
                    return;
                }

            if (!string.IsNullOrWhiteSpace(numRoomsFrom_textbox.Text) && !string.IsNullOrWhiteSpace(numRoomsBefore_textbox.Text))
                if (int.TryParse(numRoomsFrom_textbox.Text, out int numberRoomFrom) && int.TryParse(numRoomsBefore_textbox.Text, out int numberRoomBefore))
                {
                    objects = objects.Where(x => x.NumRoomsObject > numberRoomFrom && x.NumRoomsObject < numberRoomBefore).ToList();
                }
                else
                {
                    MessageBox.Show("Корректно заполните поля количества комнат", "Ошибка");
                    return;
                }

            if (!string.IsNullOrWhiteSpace(city_textbox.Text))
                objects = objects.Where(x => x.CityObject.Contains(city_textbox.Text)).ToList();

            if (!string.IsNullOrWhiteSpace(district_textbox.Text))
                objects = objects.Where(x => x.DistrictObject.Contains(district_textbox.Text)).ToList();

            if (!string.IsNullOrWhiteSpace(address_textbox.Text))
                objects = objects.Where(x => x.AddressObject.Contains(address_textbox.Text)).ToList();

            PageManagerClass.MainFrame.Navigate(new Object_realtor(Staff, Client, objects));
        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new Object_realtor(Staff, Client, App.Context.Objects.ToList()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            nameuser.Content = Staff == null ? $"{Client.SurnameClient} {Client.NameClient}" : $"{Staff.SurnameStaff} {Staff.NameStaff}";
        }
    }
}
