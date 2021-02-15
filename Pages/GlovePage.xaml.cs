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
    /// Interaction logic for GlovePage.xaml
    /// </summary>
    public partial class GlovePage : Page
    {


        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.GloveScore = Properties.Settings.Default.GloveScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.GloveScore = Properties.Settings.Default.GloveScore - pointsToRemove;
        }

        public void CheckGloves()
        {
            if (Properties.Settings.Default.The_Hand_of_Broc)
            {
                The_Hand_of_Broc.IsChecked = true;
            }
            if (Properties.Settings.Default.Bloodfist)
            {
                Bloodfist.IsChecked = true;
            }
            if (Properties.Settings.Default.Chance_Guards)
            {
                Chance_Guards.IsChecked = true;
            }
            if (Properties.Settings.Default.Magefist)
            {
                Magefist.IsChecked = true;
            }
            if (Properties.Settings.Default.Frostburn)
            {
                Frostburn.IsChecked = true;
            }
            if (Properties.Settings.Default.Venom_Grip)
            {
                Venom_Grip.IsChecked = true;
            }
            if (Properties.Settings.Default.Gravepalm)
            {
                Gravepalm.IsChecked = true;
            }
            if (Properties.Settings.Default.Ghoulhide)
            {
                Ghoulhide.IsChecked = true;
            }
            if (Properties.Settings.Default.Lava_Gout)
            {
                Lava_Gout.IsChecked = true;
            }
            if (Properties.Settings.Default.Hellmouth)
            {
                Hellmouth.IsChecked = true;
            }
            if (Properties.Settings.Default.Draculs_Grasp)
            {
                Dracul_s_Grasp.IsChecked = true;
            }
            if (Properties.Settings.Default.Soul_Drainer)
            {
                Soul_Drainer.IsChecked = true;
            }
            if (Properties.Settings.Default.Steelrend)
            {
                Steelrend.IsChecked = true;
            }
        }

        public GlovePage()
        {
            InitializeComponent();
            Properties.Settings.Default.GloveScore = 0;
            CheckGloves();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void The_Hand_of_Broc_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(820);
            Properties.Settings.Default.The_Hand_of_Broc = true;
            Properties.Settings.Default.Save();
        }

        private void The_Hand_of_Broc_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(820);
            Properties.Settings.Default.The_Hand_of_Broc = false;
            Properties.Settings.Default.Save();
        }

        private void Bloodfist_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(237);
            Properties.Settings.Default.Bloodfist = true;
            Properties.Settings.Default.Save();
        }

        private void Bloodfist_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(237);
            Properties.Settings.Default.Bloodfist = false;
            Properties.Settings.Default.Save();
        }

        private void Chance_Guards_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(251);
            Properties.Settings.Default.Chance_Guards = true;
            Properties.Settings.Default.Save();
        }

        private void Chance_Guards_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(251);
            Properties.Settings.Default.Chance_Guards = false;
            Properties.Settings.Default.Save();
        }

        private void Magefist_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(230);
            Properties.Settings.Default.Magefist = true;
            Properties.Settings.Default.Save();
        }

        private void Magefist_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(230);
            Properties.Settings.Default.Magefist = false;
            Properties.Settings.Default.Save();
        }

        private void Frostburn_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(168);
            Properties.Settings.Default.Frostburn = true;
            Properties.Settings.Default.Save();
        }

        private void Frostburn_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(168);
            Properties.Settings.Default.Frostburn = false;
            Properties.Settings.Default.Save();
        }

        private void Venom_Grip_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(246);
            Properties.Settings.Default.Venom_Grip = true;
            Properties.Settings.Default.Save();
        }

        private void Venom_Grip_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(246);
            Properties.Settings.Default.Venom_Grip = false;
            Properties.Settings.Default.Save();
        }

        private void Gravepalm_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(718);
            Properties.Settings.Default.Gravepalm = true;
            Properties.Settings.Default.Save();
        }

        private void Gravepalm_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(718);
            Properties.Settings.Default.Gravepalm = false;
            Properties.Settings.Default.Save();
        }

        private void Ghoulhide_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(921);
            Properties.Settings.Default.Ghoulhide = true;
            Properties.Settings.Default.Save();
        }

        private void Ghoulhide_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(921);
            Properties.Settings.Default.Ghoulhide = false;
            Properties.Settings.Default.Save();
        }

        private void Lava_Gout_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1300);
            Properties.Settings.Default.Lava_Gout = true;
            Properties.Settings.Default.Save();
        }

        private void Lava_Gout_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1300);
            Properties.Settings.Default.Lava_Gout = false;
            Properties.Settings.Default.Save();
        }

        private void Hellmouth_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(916);
            Properties.Settings.Default.Hellmouth = true;
            Properties.Settings.Default.Save();
        }

        private void Hellmouth_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(916);
            Properties.Settings.Default.Hellmouth = false;
            Properties.Settings.Default.Save();
        }

        private void Dracul_s_Grasp_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1033);
            Properties.Settings.Default.Draculs_Grasp = true;
            Properties.Settings.Default.Save();
        }

        private void Dracul_s_Grasp_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1033);
            Properties.Settings.Default.Draculs_Grasp = false;
            Properties.Settings.Default.Save();
        }

        private void Soul_Drainer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1189);
            Properties.Settings.Default.Soul_Drainer = true;
            Properties.Settings.Default.Save();
        }

        private void Soul_Drainer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1189);
            Properties.Settings.Default.Soul_Drainer = false;
            Properties.Settings.Default.Save();
        }

        private void Steelrend_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(17802);
            Properties.Settings.Default.Steelrend = true;
            Properties.Settings.Default.Save();
        }

        private void Steelrend_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(17802);
            Properties.Settings.Default.Steelrend = false;
            Properties.Settings.Default.Save();
        }


    }
}
