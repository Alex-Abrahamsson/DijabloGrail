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
    /// Interaction logic for CleglawPage.xaml
    /// </summary>
    public partial class CleglawPage : Page
    {


        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.CleglawScore = Properties.Settings.Default.CleglawScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.CleglawScore = Properties.Settings.Default.CleglawScore - pointsToRemove;
        }

        public void CheckCleglawSet()
        {
            if (Properties.Settings.Default.Cleglaws_Tooth)
            {
                Cleglaws_Tooth.IsChecked = true;
            }
            if (Properties.Settings.Default.Cleglaws_Claw)
            {
                Cleglaws_Claw.IsChecked = true;
            }
            if (Properties.Settings.Default.Cleglaws_Pinchers)
            {
                Cleglaws_Pinchers.IsChecked = true;
            }
        }




        public CleglawPage()
        {
            InitializeComponent();
            Properties.Settings.Default.CleglawScore = 0;
            CheckCleglawSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Cleglaws_Tooth_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(52);
            Properties.Settings.Default.Cleglaws_Tooth = true;
            Properties.Settings.Default.Save();
        }

        private void Cleglaws_Tooth_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(52);
            Properties.Settings.Default.Cleglaws_Tooth = false;
            Properties.Settings.Default.Save();
        }

        private void Cleglaws_Pinchers_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(76);
            Properties.Settings.Default.Cleglaws_Pinchers = true;
            Properties.Settings.Default.Save();
        }

        private void Cleglaws_Pinchers_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(76);
            Properties.Settings.Default.Cleglaws_Pinchers = false;
            Properties.Settings.Default.Save();
        }

        private void Cleglaws_Claw_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(103);
            Properties.Settings.Default.Cleglaws_Claw = true;
            Properties.Settings.Default.Save();
        }

        private void Cleglaws_Claw_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(103);
            Properties.Settings.Default.Cleglaws_Claw = false;
            Properties.Settings.Default.Save();
        }
    }
}
