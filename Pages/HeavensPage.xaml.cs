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
    /// Interaction logic for HeavensPage.xaml
    /// </summary>
    public partial class HeavensPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.HeavensScore = Properties.Settings.Default.HeavensScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.HeavensScore = Properties.Settings.Default.HeavensScore - pointsToRemove;
        }

        public void CheckHeavensSet()
        {
            if (Properties.Settings.Default.Haemosu_s_Adamant)
            {
                Haemosu_s_Adamant.IsChecked = true;
            }
            if (Properties.Settings.Default.Dangoon_s_Teaching)
            {
                Dangoon_s_Teaching.IsChecked = true;
            }
            if (Properties.Settings.Default.Taebaek_s_Glory)
            {
                Taebaek_s_Glory.IsChecked = true;
            }
            if (Properties.Settings.Default.Ondal_s_Almighty)
            {
                Ondal_s_Almighty.IsChecked = true;
            }
        }


        public HeavensPage()
        {
            InitializeComponent();
            Properties.Settings.Default.HeavensScore = 0;
            CheckHeavensSet();
        }

        private void Haemosu_s_Adamant_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(175);
            Properties.Settings.Default.Haemosu_s_Adamant = true;
            Properties.Settings.Default.Save();
        }

        private void Haemosu_s_Adamant_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(175);
            Properties.Settings.Default.Haemosu_s_Adamant = false;
            Properties.Settings.Default.Save();
        }

        private void Dangoon_s_Teaching_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(227);
            Properties.Settings.Default.Dangoon_s_Teaching = true;
            Properties.Settings.Default.Save();
        }

        private void Dangoon_s_Teaching_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(227);
            Properties.Settings.Default.Dangoon_s_Teaching = false;
            Properties.Settings.Default.Save();
        }

        private void Taebaek_s_Glory_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(812);
            Properties.Settings.Default.Taebaek_s_Glory = true;
            Properties.Settings.Default.Save();
        }

        private void Taebaek_s_Glory_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(812);
            Properties.Settings.Default.Taebaek_s_Glory = false;
            Properties.Settings.Default.Save();
        }

        private void Ondal_s_Almighty_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(453);
            Properties.Settings.Default.Ondal_s_Almighty = true;
            Properties.Settings.Default.Save();
        }

        private void Ondal_s_Almighty_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(453);
            Properties.Settings.Default.Ondal_s_Almighty = false;
            Properties.Settings.Default.Save();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }
    }
}
