using DijabloGrail.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace DijabloGrail
{

    public partial class MainWindow : Window
    {
        MenuPage menuPage = new MenuPage();
        UserNameInputPage uniPage = new UserNameInputPage();

        public double grailScore;
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Diablo Holy Grail Game!";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            if(Properties.Settings.Default.userName == "null")
            {
                mainPage.NavigationService.Navigate(uniPage);
            }
            else if(Properties.Settings.Default.userName != "null")
            {
                mainPage.NavigationService.Navigate(menuPage);
            }

            
        }

    }

}
