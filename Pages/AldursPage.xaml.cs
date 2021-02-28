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
    /// Interaction logic for AldursPage.xaml
    /// </summary>
    public partial class AldursPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.AldursScore = Properties.Settings.Default.AldursScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.AldursScore = Properties.Settings.Default.AldursScore - pointsToRemove;
        }

        public void CheckAldursSet()
        {
            if (Properties.Settings.Default.Aldur_s_Stony_Gaze)
            {
                Aldur_s_Stony_Gaze.IsChecked = true;
            }
            if (Properties.Settings.Default.Aldur_s_Advance)
            {
                Aldur_s_Advance.IsChecked = true;
            }
            if (Properties.Settings.Default.Aldur_s_Deception)
            {
                Aldur_s_Deception.IsChecked = true;
            }
            if (Properties.Settings.Default.Aldur_s_Rhythm)
            {
                Aldur_s_Rhythm.IsChecked = true;
            }
        }



        public AldursPage()
        {
            InitializeComponent();
            Properties.Settings.Default.AldursScore = 0;
            CheckAldursSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menu = new MenuPage();
            this.NavigationService.Navigate(menu);
        }

        private void Aldur_s_Stony_Gaze_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(441);
            Properties.Settings.Default.Aldur_s_Stony_Gaze = true;
            Properties.Settings.Default.Save();
        }

        private void Aldur_s_Stony_Gaze_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(441);
            Properties.Settings.Default.Aldur_s_Stony_Gaze = false;
            Properties.Settings.Default.Save();
        }

        private void Aldur_s_Advance_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(519);
            Properties.Settings.Default.Aldur_s_Advance = true;
            Properties.Settings.Default.Save();
        }

        private void Aldur_s_Advance_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(519);
            Properties.Settings.Default.Aldur_s_Advance = false;
            Properties.Settings.Default.Save();
        }

        private void Aldur_s_Deception_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(807);
            Properties.Settings.Default.Aldur_s_Deception = true;
            Properties.Settings.Default.Save();
        }

        private void Aldur_s_Deception_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(807);
            Properties.Settings.Default.Aldur_s_Deception = false;
            Properties.Settings.Default.Save();
        }

        private void Aldur_s_Rhythm_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(212);
            Properties.Settings.Default.Aldur_s_Rhythm = true;
            Properties.Settings.Default.Save();
        }

        private void Aldur_s_Rhythm_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(212);
            Properties.Settings.Default.Aldur_s_Rhythm = false;
            Properties.Settings.Default.Save();
        }
    }
}
