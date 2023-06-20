using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GH
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Model.greenhillsContext Context { get; private set; } = new Model.greenhillsContext();
        //Scaffold-DbContext "Server=localhost;Database=greenhills;User=root;Password=12345" "Pomelo.EntityFrameworkCore.MySql" -outputdir Model -context greenhillsContext -f
    }
}
