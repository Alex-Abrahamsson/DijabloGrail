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

        public double grailScore;
        public MainWindow()
        {  
            if(Properties.Settings.Default.userName == "null")
            {
                MessageBox.Show("Enter Username Here");
            }

            InitializeComponent();
            this.Title = "Diablo Holy Grail Game!";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
              
            mainPage.NavigationService.Navigate(menuPage);
        }

    }

}
