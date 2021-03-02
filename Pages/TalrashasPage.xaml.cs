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
    /// Interaction logic for TalrashasPage.xaml
    /// </summary>
    public partial class TalrashasPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.TalRashasScore = Properties.Settings.Default.TalRashasScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.TalRashasScore = Properties.Settings.Default.TalRashasScore - pointsToRemove;
        }

        public void CheckTalrashaSet()
        {
            if (Properties.Settings.Default.Tal_Rasha_s_Lidless_Eye)
            {
                Tal_Rasha_s_Lidless_Eye.IsChecked = true;
            }
            if (Properties.Settings.Default.Tal_Rasha_s_Horadric_Crest)
            {
                Tal_Rasha_s_Horadric_Crest.IsChecked = true;
            }
            if (Properties.Settings.Default.Tal_Rasha_s_Guardianship)
            {
                Tal_Rasha_s_Guardianship.IsChecked = true;
            }
            if (Properties.Settings.Default.Tal_Rasha_s_Fine_Spun_Cloth)
            {
                Tal_Rasha_s_Fine_Spun_Cloth.IsChecked = true;
            }
            if (Properties.Settings.Default.Tal_Rasha_s_Adjudication)
            {
                Tal_Rasha_s_Adjudication.IsChecked = true;
            }
        }

        public TalrashasPage()
        {
            InitializeComponent();
            Properties.Settings.Default.TalRashasScore = 0;
            CheckTalrashaSet();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Tal_Rasha_s_Lidless_Eye_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(79);
            Properties.Settings.Default.Tal_Rasha_s_Lidless_Eye = true;
            Properties.Settings.Default.Save();
        }

        private void Tal_Rasha_s_Lidless_Eye_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(79);
            Properties.Settings.Default.Tal_Rasha_s_Lidless_Eye = false;
            Properties.Settings.Default.Save();
        }

        private void Tal_Rasha_s_Horadric_Crest_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(607);
            Properties.Settings.Default.Tal_Rasha_s_Horadric_Crest = true;
            Properties.Settings.Default.Save();
        }

        private void Tal_Rasha_s_Horadric_Crest_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(607);
            Properties.Settings.Default.Tal_Rasha_s_Horadric_Crest = false;
            Properties.Settings.Default.Save();
        }

        private void Tal_Rasha_s_Guardianship_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(807);
            Properties.Settings.Default.Tal_Rasha_s_Guardianship = true;
            Properties.Settings.Default.Save();
        }

        private void Tal_Rasha_s_Guardianship_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(807);
            Properties.Settings.Default.Tal_Rasha_s_Guardianship = false;
            Properties.Settings.Default.Save();
        }

        private void Tal_Rasha_s_Fine_Spun_Cloth_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(368);
            Properties.Settings.Default.Tal_Rasha_s_Fine_Spun_Cloth = true;
            Properties.Settings.Default.Save();
        }

        private void Tal_Rasha_s_Fine_Spun_Cloth_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(368);
            Properties.Settings.Default.Tal_Rasha_s_Fine_Spun_Cloth = false;
            Properties.Settings.Default.Save();
        }

        private void Tal_Rasha_s_Adjudication_Checked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(4353);
            Properties.Settings.Default.Tal_Rasha_s_Adjudication = true;
            Properties.Settings.Default.Save();
        }

        private void Tal_Rasha_s_Adjudication_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(4353);
            Properties.Settings.Default.Tal_Rasha_s_Adjudication = false;
            Properties.Settings.Default.Save();
        }
    }
}
