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
    /// Interaction logic for SigonsPage.xaml
    /// </summary>
    public partial class SigonsPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.SigonsScore = Properties.Settings.Default.SigonsScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.SigonsScore = Properties.Settings.Default.SigonsScore - pointsToRemove;
        }

        public void CheckSigonsSet()
        {
            if (Properties.Settings.Default.Sigon_s_Visor)
            {
                Sigon_s_Visor.IsChecked = true;
            }
            if (Properties.Settings.Default.Sigon_s_Shelter)
            {
                Sigon_s_Shelter.IsChecked = true;
            }
            if (Properties.Settings.Default.Sigon_s_Guard)
            {
                Sigon_s_Guard.IsChecked = true;
            }
            if (Properties.Settings.Default.Sigon_s_Wrap)
            {
                Sigon_s_Wrap.IsChecked = true;
            }
            if (Properties.Settings.Default.Sigon_s_Gage)
            {
                Sigon_s_Gage.IsChecked = true;
            }
            if (Properties.Settings.Default.Sigon_s_Sabot)
            {
                Sigon_s_Sabot.IsChecked = true;
            }
        }


        public SigonsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.SigonsScore = 0;
            CheckSigonsSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Sigon_s_Visor_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(101);
            Properties.Settings.Default.Sigon_s_Visor = true;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Visor_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(101);
            Properties.Settings.Default.Sigon_s_Visor = false;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Shelter_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(98);
            Properties.Settings.Default.Sigon_s_Shelter = true;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Shelter_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(98);
            Properties.Settings.Default.Sigon_s_Shelter = false;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Sabot_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(67);
            Properties.Settings.Default.Sigon_s_Sabot = true;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Sabot_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(67);
            Properties.Settings.Default.Sigon_s_Sabot = false;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Guard_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(100);
            Properties.Settings.Default.Sigon_s_Guard = true;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Guard_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(100);
            Properties.Settings.Default.Sigon_s_Guard = false;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Wrap_Checked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(67);
            Properties.Settings.Default.Sigon_s_Wrap = true;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Wrap_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(67);
            Properties.Settings.Default.Sigon_s_Wrap = false;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Gage_Checked(object sender, RoutedEventArgs e)
        {
            Pic6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(67);
            Properties.Settings.Default.Sigon_s_Gage = true;
            Properties.Settings.Default.Save();
        }

        private void Sigon_s_Gage_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(67);
            Properties.Settings.Default.Sigon_s_Gage = false;
            Properties.Settings.Default.Save();
        }
    }
}
