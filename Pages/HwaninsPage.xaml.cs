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
    /// Interaction logic for HwaninsPage.xaml
    /// </summary>
    public partial class HwaninsPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.HwaninsScore = Properties.Settings.Default.HwaninsScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.HwaninsScore = Properties.Settings.Default.HwaninsScore - pointsToRemove;
        }

        public void CheckHwaninsSet()
        {
            if (Properties.Settings.Default.Hwanin_s_Splendor)
            {
                Hwanin_s_Splendor.IsChecked = true;
            }
            if (Properties.Settings.Default.Hwanin_s_Justice)
            {
                Hwanin_s_Justice.IsChecked = true;
            }
            if (Properties.Settings.Default.Hwanin_s_Refuge)
            {
                Hwanin_s_Refuge.IsChecked = true;
            }
            if (Properties.Settings.Default.Hwanin_s_Blessing)
            {
                Hwanin_s_Blessing.IsChecked = true;
            }
        }


        public HwaninsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.HwaninsScore = 0;
            CheckHwaninsSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Hwanin_s_Splendor_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(228);
            Properties.Settings.Default.Hwanin_s_Splendor = true;
            Properties.Settings.Default.Save();
        }

        private void Hwanin_s_Splendor_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(228);
            Properties.Settings.Default.Hwanin_s_Splendor = false;
            Properties.Settings.Default.Save();
        }

        private void Hwanin_s_Justice_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(211);
            Properties.Settings.Default.Hwanin_s_Justice = true;
            Properties.Settings.Default.Save();
        }

        private void Hwanin_s_Justice_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(211);
            Properties.Settings.Default.Hwanin_s_Justice = false;
            Properties.Settings.Default.Save();
        }

        private void Hwanin_s_Refuge_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(368);
            Properties.Settings.Default.Hwanin_s_Refuge = true;
            Properties.Settings.Default.Save();
        }

        private void Hwanin_s_Refuge_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(368);
            Properties.Settings.Default.Hwanin_s_Refuge = false;
            Properties.Settings.Default.Save();
        }

        private void Hwanin_s_Blessing_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(219);
            Properties.Settings.Default.Hwanin_s_Blessing = true;
            Properties.Settings.Default.Save();
        }

        private void Hwanin_s_Blessing_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(219);
            Properties.Settings.Default.Hwanin_s_Blessing = false;
            Properties.Settings.Default.Save();
        }
    }
}
