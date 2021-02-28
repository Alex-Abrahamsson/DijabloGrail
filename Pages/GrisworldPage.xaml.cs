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
    /// Interaction logic for GrisworldPage.xaml
    /// </summary>
    public partial class GrisworldPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.GrisworldScore = Properties.Settings.Default.GrisworldScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.GrisworldScore = Properties.Settings.Default.GrisworldScore - pointsToRemove;
        }

        public void CheckGrisSet()
        {
            if (Properties.Settings.Default.Griswold_s_Heart)
            {
                Griswold_s_Heart.IsChecked = true;
            }
            if (Properties.Settings.Default.Griswold_s_Valor)
            {
                Griswold_s_Valor.IsChecked = true;
            }
            if (Properties.Settings.Default.Griswold_s_Redemption)
            {
                Griswold_s_Redemption.IsChecked = true;
            }
            if (Properties.Settings.Default.Griswold_s_Honor)
            {
                Griswold_s_Honor.IsChecked = true;
            }
        }


        public GrisworldPage()
        {
            InitializeComponent();
            Properties.Settings.Default.GrisworldScore = 0;
            CheckGrisSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menu = new MenuPage();
            this.NavigationService.Navigate(menu);
        }

        private void Griswold_s_Heart_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(272);
            Properties.Settings.Default.Griswold_s_Heart = true;
            Properties.Settings.Default.Save();
        }

        private void Griswold_s_Heart_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(272);
            Properties.Settings.Default.Griswold_s_Heart = false;
            Properties.Settings.Default.Save();
        }

        private void Griswold_s_Valor_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(7121);
            Properties.Settings.Default.Griswold_s_Valor = true;
            Properties.Settings.Default.Save();
        }

        private void Griswold_s_Valor_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(7121);
            Properties.Settings.Default.Griswold_s_Valor = false;
            Properties.Settings.Default.Save();
        }

        private void Griswold_s_Redemption_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(17479);
            Properties.Settings.Default.Griswold_s_Redemption = true;
            Properties.Settings.Default.Save();
        }

        private void Griswold_s_Redemption_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(17479);
            Properties.Settings.Default.Griswold_s_Redemption = false;
            Properties.Settings.Default.Save();
        }

        private void Griswold_s_Honor_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(18026);
            Properties.Settings.Default.Griswold_s_Honor = true;
            Properties.Settings.Default.Save();
        }

        private void Griswold_s_Honor_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(18026);
            Properties.Settings.Default.Griswold_s_Honor = false;
            Properties.Settings.Default.Save();
        }
    }
}
