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
    /// Interaction logic for TrangOulsPage.xaml
    /// </summary>
    public partial class TrangOulsPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.TrangoulsScore = Properties.Settings.Default.TrangoulsScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.TrangoulsScore = Properties.Settings.Default.TrangoulsScore - pointsToRemove;
        }

        public void CheckTrangSet()
        {
            if (Properties.Settings.Default.Trang_Oul_s_Claws)
            {
                Trang_Oul_s_Claws.IsChecked = true;
            }
            if (Properties.Settings.Default.Trang_Oul_s_Girth)
            {
                Trang_Oul_s_Girth.IsChecked = true;
            }
            if (Properties.Settings.Default.Trang_Oul_s_Guise)
            {
                Trang_Oul_s_Guise.IsChecked = true;
            }
            if (Properties.Settings.Default.Trang_Oul_s_Scales)
            {
                Trang_Oul_s_Scales.IsChecked = true;
            }
            if (Properties.Settings.Default.Trang_Oul_s_Wing)
            {
                Trang_Oul_s_Wing.IsChecked = true;
            }
        }


        public TrangOulsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.TrangoulsScore = 0;
            CheckTrangSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Trang_Oul_s_Guise_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(812);
            Properties.Settings.Default.Trang_Oul_s_Guise = true;
            Properties.Settings.Default.Save();
        }

        private void Trang_Oul_s_Guise_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(812);
            Properties.Settings.Default.Trang_Oul_s_Guise = false;
            Properties.Settings.Default.Save();
        }

        private void Trang_Oul_s_Scales_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(410);
            Properties.Settings.Default.Trang_Oul_s_Scales = true;
            Properties.Settings.Default.Save();
        }

        private void Trang_Oul_s_Scales_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(410);
            Properties.Settings.Default.Trang_Oul_s_Scales = false;
            Properties.Settings.Default.Save();
        }

        private void Trang_Oul_s_Wing_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(79);
            Properties.Settings.Default.Trang_Oul_s_Wing = true;
            Properties.Settings.Default.Save();
        }

        private void Trang_Oul_s_Wing_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(79);
            Properties.Settings.Default.Trang_Oul_s_Wing = false;
            Properties.Settings.Default.Save();
        }

        private void Trang_Oul_s_Girth_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(807);
            Properties.Settings.Default.Trang_Oul_s_Girth = true;
            Properties.Settings.Default.Save();
        }

        private void Trang_Oul_s_Girth_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(807);
            Properties.Settings.Default.Trang_Oul_s_Girth = false;
            Properties.Settings.Default.Save();
        }

        private void Trang_Oul_s_Claws_Checked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(368);
            Properties.Settings.Default.Trang_Oul_s_Claws = true;
            Properties.Settings.Default.Save();
        }

        private void Trang_Oul_s_Claws_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(368);
            Properties.Settings.Default.Trang_Oul_s_Claws = false;
            Properties.Settings.Default.Save();
        }
    }
}
