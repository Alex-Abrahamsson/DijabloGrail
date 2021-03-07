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
    /// Interaction logic for StavePage.xaml
    /// </summary>
    public partial class StavePage : Page
    {
        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.StaveScore = Properties.Settings.Default.StaveScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.StaveScore = Properties.Settings.Default.StaveScore - pointsToRemove;
        }

        public void CheckStaves()
        {
            if (Properties.Settings.Default.Bane_Ash)
            {
                Bane_Ash.IsChecked = true;
            }
            if (Properties.Settings.Default.Serpent_Lord)
            {
                Serpent_Lord.IsChecked = true;
            }
            if (Properties.Settings.Default.Spire_of_Lazarus)
            {
                Spire_of_Lazarus.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Salamander)
            {
                The_Salamander.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Iron_Jang_Bong)
            {
                The_Iron_Jang_Bong.IsChecked = true;
            }
            if (Properties.Settings.Default.Razorswitch)
            {
                Razorswitch.IsChecked = true;
            }
            if (Properties.Settings.Default.Ribcracker)
            {
                Ribcracker.IsChecked = true;
            }
            if (Properties.Settings.Default.Chromatic_Ire)
            {
                Chromatic_Ire.IsChecked = true;
            }
            if (Properties.Settings.Default.Warpspear)
            {
                Warpspear.IsChecked = true;
            }
            if (Properties.Settings.Default.Skull_Collector)
            {
                Skull_Collector.IsChecked = true;
            }
            if (Properties.Settings.Default.Ondal_s_Wisdom)
            {
                Ondal_s_Wisdom.IsChecked = true;
            }
            if (Properties.Settings.Default.Mang_Song_s_Lesson)
            {
                Mang_Song_s_Lesson.IsChecked = true;
            }

        }


        public StavePage()
        {
            InitializeComponent();
            Properties.Settings.Default.StaveScore = 0;
            CheckStaves();
        }



        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }




        private void Bane_Ash_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3149);
            Properties.Settings.Default.Bane_Ash = true;
            Properties.Settings.Default.Save();
        }

        private void Bane_Ash_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3149);
            Properties.Settings.Default.Bane_Ash = false;
            Properties.Settings.Default.Save();
        }

        private void Serpent_Lord_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(331);
            Properties.Settings.Default.Serpent_Lord = true;
            Properties.Settings.Default.Save();
        }

        private void Serpent_Lord_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(331);
            Properties.Settings.Default.Serpent_Lord = false;
            Properties.Settings.Default.Save();
        }

        private void Spire_of_Lazarus_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(466);
            Properties.Settings.Default.Spire_of_Lazarus = true;
            Properties.Settings.Default.Save();
        }

        private void Spire_of_Lazarus_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(466);
            Properties.Settings.Default.Spire_of_Lazarus = false;
            Properties.Settings.Default.Save();
        }

        private void The_Salamander_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(433);
            Properties.Settings.Default.The_Salamander = true;
            Properties.Settings.Default.Save();
        }

        private void The_Salamander_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(433);
            Properties.Settings.Default.The_Salamander = false;
            Properties.Settings.Default.Save();
        }

        private void The_Iron_Jang_Bong_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(563);
            Properties.Settings.Default.The_Iron_Jang_Bong = true;
            Properties.Settings.Default.Save();
        }

        private void The_Iron_Jang_Bong_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(563);
            Properties.Settings.Default.The_Iron_Jang_Bong = false;
            Properties.Settings.Default.Save();
        }

        private void Razorswitch_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(713);
            Properties.Settings.Default.Razorswitch = true;
            Properties.Settings.Default.Save();
        }

        private void Razorswitch_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(713);
            Properties.Settings.Default.Razorswitch = false;
            Properties.Settings.Default.Save();
        }

        private void Ribcracker_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1077);
            Properties.Settings.Default.Ribcracker = true;
            Properties.Settings.Default.Save();
        }

        private void Ribcracker_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1077);
            Properties.Settings.Default.Ribcracker = false;
            Properties.Settings.Default.Save();
        }

        private void Chromatic_Ire_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1589);
            Properties.Settings.Default.Chromatic_Ire = true;
            Properties.Settings.Default.Save();
        }

        private void Chromatic_Ire_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1589);
            Properties.Settings.Default.Chromatic_Ire = false;
            Properties.Settings.Default.Save();
        }

        private void Warpspear_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2051);
            Properties.Settings.Default.Warpspear = true;
            Properties.Settings.Default.Save();
        }

        private void Warpspear_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2051);
            Properties.Settings.Default.Warpspear = false;
            Properties.Settings.Default.Save();
        }

        private void Skull_Collector_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1790);
            Properties.Settings.Default.Skull_Collector = true;
            Properties.Settings.Default.Save();
        }

        private void Skull_Collector_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1790);
            Properties.Settings.Default.Skull_Collector = false;
            Properties.Settings.Default.Save();
        }

        private void Ondal_s_Wisdom_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1402);
            Properties.Settings.Default.Ondal_s_Wisdom = true;
            Properties.Settings.Default.Save();
        }

        private void Ondal_s_Wisdom_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1402);
            Properties.Settings.Default.Ondal_s_Wisdom = false;
            Properties.Settings.Default.Save();
        }

        private void Mang_Song_s_Lesson_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(43696);
            Properties.Settings.Default.Mang_Song_s_Lesson = true;
            Properties.Settings.Default.Save();
        }

        private void Mang_Song_s_Lesson_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(43696);
            Properties.Settings.Default.Mang_Song_s_Lesson = false;
            Properties.Settings.Default.Save();
        }
    }
}
