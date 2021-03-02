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
    /// Interaction logic for ArcannasTrickPage.xaml
    /// </summary>
    public partial class ArcannasTrickPage1 : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.ArcannasScore = Properties.Settings.Default.ArcannasScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.ArcannasScore = Properties.Settings.Default.ArcannasScore - pointsToRemove;
        }

        public void CheckArcannasSet()
        {
            if (Properties.Settings.Default.Arcanna_s_Deathwand)
            {
                Arcanna_s_Deathwand.IsChecked = true;
            }
            if (Properties.Settings.Default.Arcanna_s_flesh)
            {
                Arcanna_s_flesh.IsChecked = true;
            }
            if (Properties.Settings.Default.Arcanna_s_head)
            {
                Arcanna_s_head.IsChecked = true;
            }
            if (Properties.Settings.Default.Arcanna_s_Sign)
            {
                Arcanna_s_Sign.IsChecked = true;
            }
        }


        public ArcannasTrickPage1()
        {
            InitializeComponent();
            Properties.Settings.Default.ArcannasScore = 0;
            CheckArcannasSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }






        private void Arcanna_s_head_Checked(object sender, RoutedEventArgs e)
        {
            Arcannas_Head_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(218);
            Properties.Settings.Default.Arcanna_s_head = true;
            Properties.Settings.Default.Save();
        }

        private void Arcanna_s_head_Unchecked(object sender, RoutedEventArgs e)
        {
            Arcannas_Head_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(218);
            Properties.Settings.Default.Arcanna_s_head = false;
            Properties.Settings.Default.Save();
        }

        private void Arcanna_s_flesh_Checked(object sender, RoutedEventArgs e)
        {
            Arcannas_Flesh_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(166);
            Properties.Settings.Default.Arcanna_s_flesh = true;
            Properties.Settings.Default.Save();
        }

        private void Arcanna_s_flesh_Unchecked(object sender, RoutedEventArgs e)
        {
            Arcannas_Flesh_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(166);
            Properties.Settings.Default.Arcanna_s_flesh = false;
            Properties.Settings.Default.Save();
        }

        private void Arcanna_s_Deathwand_Checked(object sender, RoutedEventArgs e)
        {
            Arcannas_Staff_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(207);
            Properties.Settings.Default.Arcanna_s_Deathwand = true;
            Properties.Settings.Default.Save();
        }

        private void Arcanna_s_Deathwand_Unchecked(object sender, RoutedEventArgs e)
        {
            Arcannas_Staff_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(207);
            Properties.Settings.Default.Arcanna_s_Deathwand = false;
            Properties.Settings.Default.Save();
        }

        private void Arcanna_s_Sign_Checked(object sender, RoutedEventArgs e)
        {
            Arcannas_Amulett_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(4060);
            Properties.Settings.Default.Arcanna_s_Sign = true;
            Properties.Settings.Default.Save();
        }

        private void Arcanna_s_Sign_Unchecked(object sender, RoutedEventArgs e)
        {
            Arcannas_Amulett_Pic.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(4060);
            Properties.Settings.Default.Arcanna_s_Sign = false;
            Properties.Settings.Default.Save();
        }
    }
}
