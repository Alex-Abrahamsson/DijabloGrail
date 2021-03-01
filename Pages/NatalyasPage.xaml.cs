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
    /// Interaction logic for NatalyasPage.xaml
    /// </summary>
    public partial class NatalyasPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.NatalyasScore = Properties.Settings.Default.NatalyasScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.NatalyasScore = Properties.Settings.Default.NatalyasScore - pointsToRemove;
        }

        public void CheckNatalyaSet()
        {
            if (Properties.Settings.Default.Natalya_s_Totem)
            {
                Natalya_s_Totem.IsChecked = true;
            }
            if (Properties.Settings.Default.Natalya_s_Mark)
            {
                Natalya_s_Mark.IsChecked = true;
            }
            if (Properties.Settings.Default.Natalya_s_Shadow)
            {
                Natalya_s_Shadow.IsChecked = true;
            }
            if (Properties.Settings.Default.Natalya_s_Soul)
            {
                Natalya_s_Soul.IsChecked = true;
            }
        }


        public NatalyasPage()
        {
            InitializeComponent();
            Properties.Settings.Default.NatalyasScore = 0;
            CheckNatalyaSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Natalya_s_Totem_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(79);
            Properties.Settings.Default.Natalya_s_Totem = true;
            Properties.Settings.Default.Save();
        }

        private void Natalya_s_Totem_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(79);
            Properties.Settings.Default.Natalya_s_Totem = false;
            Properties.Settings.Default.Save();
        }

        private void Natalya_s_Mark_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(7374);
            Properties.Settings.Default.Natalya_s_Mark = true;
            Properties.Settings.Default.Save();
        }

        private void Natalya_s_Mark_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(7374);
            Properties.Settings.Default.Natalya_s_Mark = false;
            Properties.Settings.Default.Save();
        }

        private void Natalya_s_Shadow_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(308);
            Properties.Settings.Default.Natalya_s_Shadow = true;
            Properties.Settings.Default.Save();
        }

        private void Natalya_s_Shadow_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(308);
            Properties.Settings.Default.Natalya_s_Shadow = false;
            Properties.Settings.Default.Save();
        }

        private void Natalya_s_Soul_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(79);
            Properties.Settings.Default.Natalya_s_Soul = true;
            Properties.Settings.Default.Save();
        }

        private void Natalya_s_Soul_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(79);
            Properties.Settings.Default.Natalya_s_Soul = false;
            Properties.Settings.Default.Save();
        }
    }
}
