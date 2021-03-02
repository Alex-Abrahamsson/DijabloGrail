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
    /// Interaction logic for ImmortalKingPage.xaml
    /// </summary>
    public partial class ImmortalKingPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.ImmortalsScore = Properties.Settings.Default.ImmortalsScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.ImmortalsScore = Properties.Settings.Default.ImmortalsScore - pointsToRemove;
        }

        public void CheckImmortalSet()
        {
            if (Properties.Settings.Default.Immortal_King_s_Will)
            {
                Immortal_King_s_Will.IsChecked = true;
            }
            if (Properties.Settings.Default.Immortal_King_s_Stone_Crusher)
            {
                Immortal_King_s_Stone_Crusher.IsChecked = true;
            }
            if (Properties.Settings.Default.Immortal_King_s_Soul_Cage)
            {
                Immortal_King_s_Soul_Cage.IsChecked = true;
            }
            if (Properties.Settings.Default.Immortal_King_s_Detail)
            {
                Immortal_King_s_Detail.IsChecked = true;
            }
            if (Properties.Settings.Default.Immortal_King_s_Forge)
            {
                Immortal_King_s_Forge.IsChecked = true;
            }
            if (Properties.Settings.Default.Immortal_King_s_Pillar)
            {
                Immortal_King_s_Pillar.IsChecked = true;
            }
        }


        public ImmortalKingPage()
        {
            InitializeComponent();
            Properties.Settings.Default.ImmortalsScore = 0;
            CheckImmortalSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menu = new MenuPage();
            this.NavigationService.Navigate(menu);
        }

        private void Immortal_King_s_Will_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(277);
            Properties.Settings.Default.Immortal_King_s_Will = true;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Will_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(277);
            Properties.Settings.Default.Immortal_King_s_Will = false;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Stone_Crusher_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(179);
            Properties.Settings.Default.Immortal_King_s_Stone_Crusher = true;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Stone_Crusher_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(179);
            Properties.Settings.Default.Immortal_King_s_Stone_Crusher = false;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Soul_Cage_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(7121);
            Properties.Settings.Default.Immortal_King_s_Soul_Cage = true;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Soul_Cage_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(7121);
            Properties.Settings.Default.Immortal_King_s_Soul_Cage = false;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Detail_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(367);
            Properties.Settings.Default.Immortal_King_s_Detail = true;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Detail_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(367);
            Properties.Settings.Default.Immortal_King_s_Detail = false;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Forge_Checked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(367);
            Properties.Settings.Default.Immortal_King_s_Forge = true;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Forge_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(367);
            Properties.Settings.Default.Immortal_King_s_Forge = false;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Pillar_Checked(object sender, RoutedEventArgs e)
        {
            Pic6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(367);
            Properties.Settings.Default.Immortal_King_s_Pillar = true;
            Properties.Settings.Default.Save();
        }

        private void Immortal_King_s_Pillar_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(367);
            Properties.Settings.Default.Immortal_King_s_Pillar = false;
            Properties.Settings.Default.Save();
        }
    }
}
