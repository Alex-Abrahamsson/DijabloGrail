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

namespace DijabloGrail
{
    /// <summary>
    /// Interaction logic for BootsPage.xaml
    /// </summary>
    public partial class BootsPage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.BootScore = Properties.Settings.Default.BootScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.BootScore = Properties.Settings.Default.BootScore - pointsToRemove;
        }

        public void CheckBoots()
        {
            if (Properties.Settings.Default.Hotspur)
            {
                Hotspur.IsChecked = true;
            }
            if (Properties.Settings.Default.Gorefoot)
            {
                Gorefoot.IsChecked = true;
            }
            if (Properties.Settings.Default.Treads_of_Cthon)
            {
                Treads_of_Cthon.IsChecked = true;
            }
            if (Properties.Settings.Default.Goblin_Toe)
            {
                Goblin_Toe.IsChecked = true;
            }
            if (Properties.Settings.Default.Tearhaunch)
            {
                Tearhaunch.IsChecked = true;
            }
            if (Properties.Settings.Default.Infernostride)
            {
                Infernostride.IsChecked = true;
            }
            if (Properties.Settings.Default.Waterwalk)
            {
                Waterwalk.IsChecked = true;
            }
            if (Properties.Settings.Default.Silkweave)
            {
                Silkweave.IsChecked = true;
            }
            if (Properties.Settings.Default.War_Traveler)
            {
                War_Traveler.IsChecked = true;
            }
            if (Properties.Settings.Default.Gore_Rider)
            {
                Gore_Rider.IsChecked = true;
            }
            if (Properties.Settings.Default.Sandstorm_Trek)
            {
                Sandstorm_Trek.IsChecked = true;
            }
            if (Properties.Settings.Default.Marrowwalk)
            {
                Marrowwalk.IsChecked = true;
            }
            if (Properties.Settings.Default.Shadow_Dancer)
            {
                Shadow_Dancer.IsChecked = true;
            }
        }



        public BootsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.BootScore = 0;
            CheckBoots();
        }



        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Hotspur_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(820);
            Properties.Settings.Default.Hotspur = true;
            Properties.Settings.Default.Save();
        }

        private void Hotspur_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(820);
            Properties.Settings.Default.Hotspur = false;
            Properties.Settings.Default.Save();
        }

        private void Gorefoot_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(237);
            Properties.Settings.Default.Gorefoot = true;
            Properties.Settings.Default.Save();
        }

        private void Gorefoot_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(237);
            Properties.Settings.Default.Gorefoot = false;
            Properties.Settings.Default.Save();
        }

        private void Treads_of_Cthon_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(251);
            Properties.Settings.Default.Treads_of_Cthon = true;
            Properties.Settings.Default.Save();
        }

        private void Treads_of_Cthon_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(251);
            Properties.Settings.Default.Treads_of_Cthon = false;
            Properties.Settings.Default.Save();
        }

        private void Goblin_Toe_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(230);
            Properties.Settings.Default.Goblin_Toe = true;
            Properties.Settings.Default.Save();
        }

        private void Goblin_Toe_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(230);
            Properties.Settings.Default.Goblin_Toe = false;
            Properties.Settings.Default.Save();
        }

        private void Tearhaunch_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(168);
            Properties.Settings.Default.Tearhaunch = true;
            Properties.Settings.Default.Save();
        }

        private void Tearhaunch_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(168);
            Properties.Settings.Default.Tearhaunch = false;
            Properties.Settings.Default.Save();
        }

        private void Infernostride_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(416);
            Properties.Settings.Default.Infernostride = true;
            Properties.Settings.Default.Save();
        }

        private void Infernostride_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(416);
            Properties.Settings.Default.Infernostride = false;
            Properties.Settings.Default.Save();
        }

        private void Waterwalk_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(718);
            Properties.Settings.Default.Waterwalk = true;
            Properties.Settings.Default.Save();
        }

        private void Waterwalk_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(718);
            Properties.Settings.Default.Waterwalk = false;
            Properties.Settings.Default.Save();
        }

        private void Silkweave_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(921);
            Properties.Settings.Default.Silkweave = true;
            Properties.Settings.Default.Save();
        }

        private void Silkweave_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(921);
            Properties.Settings.Default.Silkweave = false;
            Properties.Settings.Default.Save();
        }

        private void War_Traveler_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1300);
            Properties.Settings.Default.War_Traveler = true;
            Properties.Settings.Default.Save();
        }

        private void War_Traveler_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1300);
            Properties.Settings.Default.War_Traveler = false;
            Properties.Settings.Default.Save();
        }

        private void Gore_Rider_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(916);
            Properties.Settings.Default.Gore_Rider = true;
            Properties.Settings.Default.Save();
        }

        private void Gore_Rider_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(916);
            Properties.Settings.Default.Gore_Rider = false;
            Properties.Settings.Default.Save();
        }

        private void Sandstorm_Trek_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(683);
            Properties.Settings.Default.Sandstorm_Trek = true;
            Properties.Settings.Default.Save();
        }

        private void Sandstorm_Trek_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(683);
            Properties.Settings.Default.Sandstorm_Trek = false;
            Properties.Settings.Default.Save();
        }

        private void Marrowwalk_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(890);
            Properties.Settings.Default.Marrowwalk = true;
            Properties.Settings.Default.Save();
        }

        private void Marrowwalk_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(890);
            Properties.Settings.Default.Marrowwalk = false;
            Properties.Settings.Default.Save();
        }

        private void Shadow_Dancer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(17802);
            Properties.Settings.Default.Shadow_Dancer = true;
            Properties.Settings.Default.Save();
        }

        private void Shadow_Dancer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(17802);
            Properties.Settings.Default.Shadow_Dancer = false;
            Properties.Settings.Default.Save();
        }
    }
}
