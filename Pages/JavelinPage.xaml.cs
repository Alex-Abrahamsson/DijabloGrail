using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DijabloGrail.Pages
{

    /// <summary>
    /// Interaction logic for JavelinPage.xaml
    /// </summary>
    public partial class JavelinPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.JavelinScore = Properties.Settings.Default.JavelinScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.JavelinScore = Properties.Settings.Default.JavelinScore - pointsToRemove;
        }

        public void CheckJavelins()
        {
            if (Properties.Settings.Default.Demon_s_Arch)
            {
                Demon_s_Arch.IsChecked = true;
            }
            if (Properties.Settings.Default.Wraith_Flight)
            {
                Wraith_Flight.IsChecked = true;
            }
            if (Properties.Settings.Default.Gargoyle_s_Bite)
            {
                Gargoyle_s_Bite.IsChecked = true;
            }
        }


        public JavelinPage()
        {
            InitializeComponent();
            Properties.Settings.Default.JavelinScore = 0;
            CheckJavelins();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Demon_s_Arch_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(582);
            Properties.Settings.Default.Demon_s_Arch = true;
            Properties.Settings.Default.Save();
        }

        private void Demon_s_Arch_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(582);
            Properties.Settings.Default.Demon_s_Arch = false;
            Properties.Settings.Default.Save();
        }

        private void Wraith_Flight_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(850);
            Properties.Settings.Default.Wraith_Flight = true;
            Properties.Settings.Default.Save();
        }

        private void Wraith_Flight_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(850);
            Properties.Settings.Default.Wraith_Flight = false;
            Properties.Settings.Default.Save();
        }

        private void Gargoyle_s_Bite_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(14565);
            Properties.Settings.Default.Gargoyle_s_Bite = true;
            Properties.Settings.Default.Save();
        }

        private void Gargoyle_s_Bite_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(14565);
            Properties.Settings.Default.Gargoyle_s_Bite = false;
            Properties.Settings.Default.Save();
        }
    }
}
