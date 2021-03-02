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
    /// Interaction logic for MilabregasPage.xaml
    /// </summary>
    public partial class MilabregasPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.MilabregasScore = Properties.Settings.Default.MilabregasScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.MilabregasScore = Properties.Settings.Default.MilabregasScore - pointsToRemove;
        }

        public void CheckMilaBregasSet()
        {
            if (Properties.Settings.Default.Milabrega_s_Diadem)
            {
                Milabrega_s_Diadem.IsChecked = true;
            }
            if (Properties.Settings.Default.Milabrega_s_Orb)
            {
                Milabrega_s_Orb.IsChecked = true;
            }
            if (Properties.Settings.Default.Milabrega_s_Robe)
            {
                Milabrega_s_Robe.IsChecked = true;
            }
            if (Properties.Settings.Default.Milabrega_s_Rod)
            {
                Milabrega_s_Rod.IsChecked = true;
            }
        }


        public MilabregasPage()
        {
            InitializeComponent();
            Properties.Settings.Default.MilabregasScore = 0;
            CheckMilaBregasSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Milabrega_s_Diadem_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(179);
            Properties.Settings.Default.Milabrega_s_Diadem = true;
            Properties.Settings.Default.Save();
        }

        private void Milabrega_s_Diadem_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(179);
            Properties.Settings.Default.Milabrega_s_Diadem = false;
            Properties.Settings.Default.Save();
        }

        private void Milabrega_s_Robe_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(341);
            Properties.Settings.Default.Milabrega_s_Robe = true;
            Properties.Settings.Default.Save();
        }

        private void Milabrega_s_Robe_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(341);
            Properties.Settings.Default.Milabrega_s_Robe = false;
            Properties.Settings.Default.Save();
        }

        private void Milabrega_s_Orb_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(51);
            Properties.Settings.Default.Milabrega_s_Orb = true;
            Properties.Settings.Default.Save();
        }

        private void Milabrega_s_Orb_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(51);
            Properties.Settings.Default.Milabrega_s_Orb = false;
            Properties.Settings.Default.Save();
        }

        private void Milabrega_s_Rod_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(156);
            Properties.Settings.Default.Milabrega_s_Rod = true;
            Properties.Settings.Default.Save();
        }

        private void Milabrega_s_Rod_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(156);
            Properties.Settings.Default.Milabrega_s_Rod = false;
            Properties.Settings.Default.Save();
        }
    }
}
