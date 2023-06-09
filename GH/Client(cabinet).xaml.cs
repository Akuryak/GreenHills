﻿using GH.Model;
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
    /// Логика взаимодействия для Client_cabinet_.xaml
    /// </summary>
    public partial class Client_cabinet_ : Page
    {
        public static staff Staff { get; set; }
        public static Client Client { get; set; }
        public Client_cabinet_(staff staff, Client client)
        {
            InitializeComponent();
            Staff = staff;
            Client = client;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClientFrame.Navigate(new Favorite_client_(Client));
        }

        private void favorite_button_Click(object sender, RoutedEventArgs e)
        {
            ClientFrame.Navigate(new Favorite_client_(Client));
        }

        private void object_button_Click(object sender, RoutedEventArgs e)
        {
            ClientFrame.Navigate(new Object_realtor(Staff, Client, App.Context.Objects.ToList()));
        }

        private void realtor_button_Click(object sender, RoutedEventArgs e)
        {
            ClientFrame.Navigate(new ListRealtor(Staff, Client));
        }

        private void personalDoc_button_Click(object sender, RoutedEventArgs e)
        {
            ClientFrame.Navigate(new PersonalDoc(Client));
        }

        private void power_button_Click(object sender, RoutedEventArgs e)
        {
            PageManagerClass.MainFrame.Navigate(new ComePage());
        }
    }
}
