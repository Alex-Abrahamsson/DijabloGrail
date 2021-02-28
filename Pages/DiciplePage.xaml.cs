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
    /// Interaction logic for DiciplePage.xaml
    /// </summary>
    public partial class DiciplePage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.TheDiscipleScore = Properties.Settings.Default.TheDiscipleScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.TheDiscipleScore = Properties.Settings.Default.TheDiscipleScore - pointsToRemove;
        }

        public void CheckDiciplesSet()
        {
            if (Properties.Settings.Default.Telling_of_Beads)
            {
                Telling_of_Beads.IsChecked = true;
            }
            if (Properties.Settings.Default.Laying_of_Hands)
            {
                Laying_of_Hands.IsChecked = true;
            }
            if (Properties.Settings.Default.Dark_Adherent)
            {
                Dark_Adherent.IsChecked = true;
            }
            if (Properties.Settings.Default.Rite_of_Passage)
            {
                Rite_of_Passage.IsChecked = true;
            }
            if (Properties.Settings.Default.Credendum)
            {
                Credendum.IsChecked = true;
            }
        }


            public DiciplePage()
        {
            InitializeComponent();
            Properties.Settings.Default.TheDiscipleScore = 0;
            CheckDiciplesSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Telling_of_Beads_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(4353);
            Properties.Settings.Default.Telling_of_Beads = true;
            Properties.Settings.Default.Save();
        }

        private void Telling_of_Beads_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(4353);
            Properties.Settings.Default.Telling_of_Beads = false;
            Properties.Settings.Default.Save();
        }

        private void Laying_of_Hands_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(229);
            Properties.Settings.Default.Laying_of_Hands = true;
            Properties.Settings.Default.Save();
        }

        private void Laying_of_Hands_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(229);
            Properties.Settings.Default.Laying_of_Hands = false;
            Properties.Settings.Default.Save();
        }

        private void Dark_Adherent_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(272);
            Properties.Settings.Default.Dark_Adherent = true;
            Properties.Settings.Default.Save();
        }

        private void Dark_Adherent_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(272);
            Properties.Settings.Default.Dark_Adherent = false;
            Properties.Settings.Default.Save();
        }

        private void Rite_of_Passage_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(166);
            Properties.Settings.Default.Rite_of_Passage = true;
            Properties.Settings.Default.Save();
        }

        private void Rite_of_Passage_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(166);
            Properties.Settings.Default.Rite_of_Passage = false;
            Properties.Settings.Default.Save();
        }

        private void Credendum_Checked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(310);
            Properties.Settings.Default.Credendum = true;
            Properties.Settings.Default.Save();
        }

        private void Credendum_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(310);
            Properties.Settings.Default.Credendum = false;
            Properties.Settings.Default.Save();
        }
    }
}
