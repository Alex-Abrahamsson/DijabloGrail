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
    /// Interaction logic for BeltsPage.xaml
    /// </summary>
    public partial class BeltsPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.BeltScore = Properties.Settings.Default.BeltScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.BeltScore = Properties.Settings.Default.BeltScore - pointsToRemove;
        }

        public void CheckBelts()
        {
            if (Properties.Settings.Default.Lenymo)
            {
                Lenymo.IsChecked = true;
            }
            if (Properties.Settings.Default.Snakecord)
            {
                Snakecord.IsChecked = true;
            }
            if (Properties.Settings.Default.Nightsmoke)
            {
                Nightsmoke.IsChecked = true;
            }
            if (Properties.Settings.Default.Goldwrap)
            {
                Goldwrap.IsChecked = true;
            }
            if (Properties.Settings.Default.Bladebuckle)
            {
                Bladebuckle.IsChecked = true;
            }
            if (Properties.Settings.Default.String_of_Ears)
            {
                String_of_Ears.IsChecked = true;
            }
            if (Properties.Settings.Default.Razortail)
            {
                Razortail.IsChecked = true;
            }
            if (Properties.Settings.Default.Glooms_Trap)
            {
                Glooms_Trap.IsChecked = true;
            }
            if (Properties.Settings.Default.Snowclash)
            {
                Snowclash.IsChecked = true;
            }
            if (Properties.Settings.Default.Thundergods_Vigor)
            {
                Thundergods_Vigor.IsChecked = true;
            }
            if (Properties.Settings.Default.Arachnid_Mesh)
            {
                Arachnid_Mesh.IsChecked = true;
            }
            if (Properties.Settings.Default.Nosferatus_Coil)
            {
                Nosferatu_Coil.IsChecked = true;
            }
            if (Properties.Settings.Default.Verdungos_Hearty_Cord)
            {
                Verdungos_Hearty_Cord.IsChecked = true;
            }
        }



        public BeltsPage()
        {
            InitializeComponent();
            Properties.Settings.Default.BeltScore = 0;
            CheckBelts();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Lenymo_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(820);
            Properties.Settings.Default.Lenymo = true;
            Properties.Settings.Default.Save();
        }

        private void Lenymo_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(820);
            Properties.Settings.Default.Lenymo = false;
            Properties.Settings.Default.Save();
        }

        private void Snakecord_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(237);
            Properties.Settings.Default.Snakecord = true;
            Properties.Settings.Default.Save();
        }

        private void Snakecord_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(237);
            Properties.Settings.Default.Snakecord = false;
            Properties.Settings.Default.Save();
        }

        private void Nightsmoke_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(274);
            Properties.Settings.Default.Nightsmoke = true;
            Properties.Settings.Default.Save();
        }

        private void Nightsmoke_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(274);
            Properties.Settings.Default.Nightsmoke = false;
            Properties.Settings.Default.Save();
        }

        private void Goldwrap_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(230);
            Properties.Settings.Default.Goldwrap = true;
            Properties.Settings.Default.Save();
        }

        private void Goldwrap_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(230);
            Properties.Settings.Default.Goldwrap = false;
            Properties.Settings.Default.Save();
        }

        private void Bladebuckle_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(168);
            Properties.Settings.Default.Bladebuckle = true;
            Properties.Settings.Default.Save();
        }

        private void Bladebuckle_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(168);
            Properties.Settings.Default.Bladebuckle = false;
            Properties.Settings.Default.Save();
        }

        private void String_of_Ears_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(416);
            Properties.Settings.Default.String_of_Ears = true;
            Properties.Settings.Default.Save();
        }

        private void String_of_Ears_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(416);
            Properties.Settings.Default.String_of_Ears = false;
            Properties.Settings.Default.Save();
        }

        private void Razortail_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(718);
            Properties.Settings.Default.Razortail = true;
            Properties.Settings.Default.Save();
        }

        private void Razortail_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(718);
            Properties.Settings.Default.Razortail = false;
            Properties.Settings.Default.Save();
        }

        private void Glooms_Trap_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(921);
            Properties.Settings.Default.Glooms_Trap = true;
            Properties.Settings.Default.Save();
        }

        private void Glooms_Trap_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(921);
            Properties.Settings.Default.Glooms_Trap = false;
            Properties.Settings.Default.Save();
        }

        private void Snowclash_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1300);
            Properties.Settings.Default.Snowclash = true;
            Properties.Settings.Default.Save();
        }

        private void Snowclash_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1300);
            Properties.Settings.Default.Snowclash = false;
            Properties.Settings.Default.Save();
        }

        private void Thundergods_Vigor_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(916);
            Properties.Settings.Default.Thundergods_Vigor = true;
            Properties.Settings.Default.Save();
        }

        private void Thundergods_Vigor_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(916);
            Properties.Settings.Default.Thundergods_Vigor = false;
            Properties.Settings.Default.Save();
        }

        private void Arachnid_Mesh_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1027);
            Properties.Settings.Default.Arachnid_Mesh = true;
            Properties.Settings.Default.Save();
        }

        private void Arachnid_Mesh_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1027);
            Properties.Settings.Default.Arachnid_Mesh = false;
            Properties.Settings.Default.Save();
        }

        private void Nosferatu_Coil_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1187);
            Properties.Settings.Default.Nosferatus_Coil = true;
            Properties.Settings.Default.Save();
        }

        private void Nosferatu_Coil_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1187);
            Properties.Settings.Default.Nosferatus_Coil = false;
            Properties.Settings.Default.Save();
        }

        private void Verdungos_Hearty_Cord_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(772);
            Properties.Settings.Default.Verdungos_Hearty_Cord = true;
            Properties.Settings.Default.Save();
        }

        private void Verdungos_Hearty_Cord_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(772);
            Properties.Settings.Default.Verdungos_Hearty_Cord = false;
            Properties.Settings.Default.Save();
        }
    }
}
