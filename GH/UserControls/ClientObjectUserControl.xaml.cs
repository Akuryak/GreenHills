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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GH.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ClientObjectUserControl.xaml
    /// </summary>
    public partial class ClientObjectUserControl : UserControl
    {
        public event RoutedEventHandler ButtonClick;

        public static Client Client { get; set; }
        public static Model.Object Object { get; set; }
        public ClientObjectUserControl(Client client, Model.Object @object)
        {
            InitializeComponent();
            Client = client;
            Object = @object;

            DataContext = @object;

            TypeTextBlock.Text = @object.TypeObjectNavigation.NameTypeObject;
            AddressTextBlock.Text = $"г. {@object.CityObject} р. {@object.DistrictObject}\nул. {@object.AddressObject}";
            FloorTextBlock.Text = @object.FloorObject.ToString() + " этаж";

            string area = "";
            if (!string.IsNullOrWhiteSpace(@object.PlotAreaObject))
                area = $"Площадь: {@object.PlotAreaObject} кв. м. \n";
            area += $"Жил. площадь: {@object.LivingAreaObject} кв. м.";

            AreaTextBlock.Text = area;
            RoomsCountTextBlock.Text = $"{@object.NumRoomsObject} комнат.";
            PriceTextBlock.Text = $"{@object.PriceObject / 1000000} млн. руб.";

            if (@object.ImagesObject != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.UriSource = new Uri($"../../../Object/{@object.ImagesObject}", UriKind.Relative);
                bitmapImage.EndInit();
                ObjectPhotoImage.Source = bitmapImage;
            }
        }

        private void LikeObjectButton_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }
    }
}
