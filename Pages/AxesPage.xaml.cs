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
    /// Interaction logic for AxesPage.xaml
    /// </summary>
    public partial class AxesPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.AxeScore = Properties.Settings.Default.AxeScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.AxeScore = Properties.Settings.Default.AxeScore - pointsToRemove;
        }

        public void CheckAxes()
        {
            if (Properties.Settings.Default.The_Gnasher)
            {
                The_Gnasher.IsChecked = true;
            }
            if (Properties.Settings.Default.Deathspade)
            {
                Deathspade.IsChecked = true;
            }
            if (Properties.Settings.Default.Bladebone)
            {
                Bladebone.IsChecked = true;
            }
            if (Properties.Settings.Default.Skull_Splitter)
            {
                Skull_Splitter.IsChecked = true;
            }
            if (Properties.Settings.Default.Rakescar)
            {
                Rakescare.IsChecked = true;
            }
            if (Properties.Settings.Default.Axe_of_Fechmar)
            {
                Axe_of_Fechmar.IsChecked = true;
            }
            if (Properties.Settings.Default.Goreshovel)
            {
                Goreshovel.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Chieftain)
            {
                The_Chieftain.IsChecked = true;
            }
            if (Properties.Settings.Default.Brainhew)
            {
                Brainhew.IsChecked = true;
            }
            if (Properties.Settings.Default.Humongous)
            {
                Humongous.IsChecked = true;
            }
            if (Properties.Settings.Default.Coldkill)
            {
                Coldkill.IsChecked = true;
            }
            if (Properties.Settings.Default.Butchers_Pupil)
            {
                Butchers_Pupil.IsChecked = true;
            }
            if (Properties.Settings.Default.Islestrike)
            {
                Islestrike.IsChecked = true;
            }
            //-------
            if (Properties.Settings.Default.Pompeiis_Wrath)
            {
                Pompeiis_wrath.IsChecked = true;
            }
            if (Properties.Settings.Default.Guardian_Naga)
            {
                Guardian_Naga.IsChecked = true;
            }
            if (Properties.Settings.Default.Warlords_Trust)
            {
                Warlords_Trust.IsChecked = true;
            }
            if (Properties.Settings.Default.Spellsteel)
            {
                Spellsteel.IsChecked = true;
            }
            if (Properties.Settings.Default.Stormrider)
            {
                Stormrider.IsChecked = true;
            }
            if (Properties.Settings.Default.Boneslayer_Blade)
            {
                Boneslayer_Blade.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Minotaur)
            {
                The_Minotaur.IsChecked = true;
            }
            if (Properties.Settings.Default.Razors_Edge)
            {
                Razors_Edge.IsChecked = true;
            }
            if (Properties.Settings.Default.Rune_Master)
            {
                Rune_Master.IsChecked = true;
            }
            if (Properties.Settings.Default.Cranebeak)
            {
                Cranebeak.IsChecked = true;
            }
            if (Properties.Settings.Default.Death_Cleaver)
            {
                Death_Cleaver.IsChecked = true;
            }
            if (Properties.Settings.Default.Ethereal_Edge)
            {
                Ethereal_Edge.IsChecked = true;
            }
            if (Properties.Settings.Default.Hellslayer)
            {
                Hellslayer.IsChecked = true;
            }
            if (Properties.Settings.Default.Messerschmidts_Reaver)
            {
                Messerschmidts__Reaver.IsChecked = true;
            }
            if (Properties.Settings.Default.Executioners_Justice)
            {
                Executioners_Justice.IsChecked = true;
            }
        }
        public AxesPage()
        {
            InitializeComponent();
            Properties.Settings.Default.AxeScore = 0;
            CheckAxes();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void The_Gnasher_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1030);
            Properties.Settings.Default.The_Gnasher = true;
            Properties.Settings.Default.Save();
        }

        private void The_Gnasher_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1030);
            Properties.Settings.Default.The_Gnasher = false;
            Properties.Settings.Default.Save();
        }

        private void Deathspade_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(110);
            Properties.Settings.Default.Deathspade = true;
            Properties.Settings.Default.Save();
        }

        private void Deathspade_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(110);
            Properties.Settings.Default.Deathspade = false;
            Properties.Settings.Default.Save();
        }

        private void Bladebone_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(126);
            Properties.Settings.Default.Bladebone = true;
            Properties.Settings.Default.Save();
        }

        private void Bladebone_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(126);
            Properties.Settings.Default.Bladebone = false;
            Properties.Settings.Default.Save();
        }

        private void Skull_Splitter_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(141);
            Properties.Settings.Default.Skull_Splitter = true;
            Properties.Settings.Default.Save();
        }

        private void Skull_Splitter_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(141);
            Properties.Settings.Default.Skull_Splitter = false;
            Properties.Settings.Default.Save();
        }

        private void Rakescare_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(195);
            Properties.Settings.Default.Rakescar = true;
            Properties.Settings.Default.Save();
        }

        private void Rakescare_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(195);
            Properties.Settings.Default.Rakescar = false;
            Properties.Settings.Default.Save();
        }

        private void Axe_of_Fechmar_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(237);
            Properties.Settings.Default.Axe_of_Fechmar = true;
            Properties.Settings.Default.Save();
        }

        private void Axe_of_Fechmar_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(237);
            Properties.Settings.Default.Axe_of_Fechmar = false;
            Properties.Settings.Default.Save();
        }

        private void Goreshovel_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(155);
            Properties.Settings.Default.Goreshovel = true;
            Properties.Settings.Default.Save();
        }

        private void Goreshovel_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(155);
            Properties.Settings.Default.Goreshovel = false;
            Properties.Settings.Default.Save();
        }

        private void The_Chieftain_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(132);
            Properties.Settings.Default.The_Chieftain = true;
            Properties.Settings.Default.Save();
        }

        private void The_Chieftain_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(132);
            Properties.Settings.Default.The_Chieftain = false;
            Properties.Settings.Default.Save();
        }

        private void Brainhew_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(187);
            Properties.Settings.Default.Brainhew = true;
            Properties.Settings.Default.Save();
        }

        private void Brainhew_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(187);
            Properties.Settings.Default.Brainhew = false;
            Properties.Settings.Default.Save();
        }

        private void Humongous_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(196);
            Properties.Settings.Default.Humongous = true;
            Properties.Settings.Default.Save();
        }

        private void Humongous_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(196);
            Properties.Settings.Default.Humongous = false;
            Properties.Settings.Default.Save();
        }

        private void Coldkill_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(337);
            Properties.Settings.Default.Coldkill = true;
            Properties.Settings.Default.Save();
        }

        private void Coldkill_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(337);
            Properties.Settings.Default.Coldkill = false;
            Properties.Settings.Default.Save();
        }

        private void Butchers_Pupil_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(358);
            Properties.Settings.Default.Butchers_Pupil = true;
            Properties.Settings.Default.Save();
        }

        private void Butchers_Pupil_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(358);
            Properties.Settings.Default.Butchers_Pupil = false;
            Properties.Settings.Default.Save();
        }

        private void Islestrike_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(531);
            Properties.Settings.Default.Islestrike = true;
            Properties.Settings.Default.Save();
        }

        private void Islestrike_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(531);
            Properties.Settings.Default.Islestrike = false;
            Properties.Settings.Default.Save();
        }

        private void Pompeiis_wrath_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(581);
            Properties.Settings.Default.Pompeiis_Wrath = true;
            Properties.Settings.Default.Save();
        }

        private void Pompeiis_wrath_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(581);
            Properties.Settings.Default.Pompeiis_Wrath = false;
            Properties.Settings.Default.Save();
        }

        private void Guardian_Naga_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(606);
            Properties.Settings.Default.Guardian_Naga = true;
            Properties.Settings.Default.Save();
        }

        private void Guardian_Naga_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(606);
            Properties.Settings.Default.Guardian_Naga = false;
            Properties.Settings.Default.Save();
        }

        private void Warlords_Trust_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(358);
            Properties.Settings.Default.Warlords_Trust = true;
            Properties.Settings.Default.Save();
        }

        private void Warlords_Trust_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(358);
            Properties.Settings.Default.Warlords_Trust = false;
            Properties.Settings.Default.Save();
        }

        private void Spellsteel_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(530);
            Properties.Settings.Default.Spellsteel = true;
            Properties.Settings.Default.Save();
        }

        private void Spellsteel_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(530);
            Properties.Settings.Default.Spellsteel = false;
            Properties.Settings.Default.Save();
        }

        private void Stormrider_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(683);
            Properties.Settings.Default.Stormrider = true;
            Properties.Settings.Default.Save();
        }

        private void Stormrider_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(683);
            Properties.Settings.Default.Stormrider = false;
            Properties.Settings.Default.Save();
        }

        private void Boneslayer_Blade_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(595);
            Properties.Settings.Default.Boneslayer_Blade = true;
            Properties.Settings.Default.Save();
        }

        private void Boneslayer_Blade_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(595);
            Properties.Settings.Default.Boneslayer_Blade = false;
            Properties.Settings.Default.Save();
        }

        private void The_Minotaur_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(601);
            Properties.Settings.Default.The_Minotaur = true;
            Properties.Settings.Default.Save();
        }

        private void The_Minotaur_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(601);
            Properties.Settings.Default.The_Minotaur = false;
            Properties.Settings.Default.Save();
        }

        private void Razors_Edge_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(549);
            Properties.Settings.Default.Razors_Edge = true;
            Properties.Settings.Default.Save();
        }

        private void Razors_Edge_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(549);
            Properties.Settings.Default.Razors_Edge = false;
            Properties.Settings.Default.Save();
        }

        private void Rune_Master_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(581);
            Properties.Settings.Default.Rune_Master = true;
            Properties.Settings.Default.Save();
        }

        private void Rune_Master_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(581);
            Properties.Settings.Default.Rune_Master = false;
            Properties.Settings.Default.Save();
        }

        private void Cranebeak_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(850);
            Properties.Settings.Default.Cranebeak = true;
            Properties.Settings.Default.Save();
        }

        private void Cranebeak_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(850);
            Properties.Settings.Default.Cranebeak = false;
            Properties.Settings.Default.Save();
        }

        private void Death_Cleaver_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(14565);
            Properties.Settings.Default.Death_Cleaver = true;
            Properties.Settings.Default.Save();
        }

        private void Death_Cleaver_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(14565);
            Properties.Settings.Default.Death_Cleaver = false;
            Properties.Settings.Default.Save();
        }

        private void Ethereal_Edge_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(538);
            Properties.Settings.Default.Ethereal_Edge = true;
            Properties.Settings.Default.Save();
        }

        private void Ethereal_Edge_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(538);
            Properties.Settings.Default.Ethereal_Edge = false;
            Properties.Settings.Default.Save();
        }

        private void Hellslayer_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(466);
            Properties.Settings.Default.Hellslayer = true;
            Properties.Settings.Default.Save();
        }

        private void Hellslayer_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(466);
            Properties.Settings.Default.Hellslayer = false;
            Properties.Settings.Default.Save();
        }

        private void Messerschmidts__Reaver_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1158);
            Properties.Settings.Default.Messerschmidts_Reaver = true;
            Properties.Settings.Default.Save();
        }

        private void Messerschmidts__Reaver_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1158);
            Properties.Settings.Default.Messerschmidts_Reaver = false;
            Properties.Settings.Default.Save();
        }

        private void Executioners_Justice_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(14565);
            Properties.Settings.Default.Executioners_Justice = true;
            Properties.Settings.Default.Save();
        }

        private void Executioners_Justice_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(14565);
            Properties.Settings.Default.Executioners_Justice = false;
            Properties.Settings.Default.Save();
        }
    }
}
