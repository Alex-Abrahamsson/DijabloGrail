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
    /// Interaction logic for RunePage.xaml
    /// </summary>
    public partial class RunePage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = Math.Round(points / 10);
            Properties.Settings.Default.RuneScore = Properties.Settings.Default.RuneScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = Math.Round(points / 10);
            Properties.Settings.Default.RuneScore = Properties.Settings.Default.RuneScore - pointsToRemove;
        }

        public void CheckRunes()
        {
            if (Properties.Settings.Default.El)
            {
                El.IsChecked = true;
            }
            if (Properties.Settings.Default.Eld)
            {
                Eld.IsChecked = true;
            }
            if (Properties.Settings.Default.Tir)
            {
                Tir.IsChecked = true;
            }
            if (Properties.Settings.Default.Nef)
            {
                Nef.IsChecked = true;
            }
            if (Properties.Settings.Default.Eth)
            {
                Eth.IsChecked = true;
            }
            if (Properties.Settings.Default.Ith)
            {
                Ith.IsChecked = true;
            }
            if (Properties.Settings.Default.Tal)
            {
                Tal.IsChecked = true;
            }
            if (Properties.Settings.Default.Ral)
            {
                Ral.IsChecked = true;
            }
            if (Properties.Settings.Default.Ort)
            {
                Ort.IsChecked = true;
            }
            if (Properties.Settings.Default.Thul)
            {
                Thul.IsChecked = true;
            }
            if (Properties.Settings.Default.Amn)
            {
                Amn.IsChecked = true;
            }
            if (Properties.Settings.Default.Sol)
            {
                Sol.IsChecked = true;
            }
            if (Properties.Settings.Default.Sheal)
            {
                Sheal.IsChecked = true;
            }
            if (Properties.Settings.Default.Dol)
            {
                Dol.IsChecked = true;
            }
            if (Properties.Settings.Default.Hel)
            {
                Hel.IsChecked = true;
            }
            if (Properties.Settings.Default.Io)
            {
                Io.IsChecked = true;
            }
            if (Properties.Settings.Default.Lum)
            {
                Lum.IsChecked = true;
            }
            if (Properties.Settings.Default.Ko)
            {
                Ko.IsChecked = true;
            }
            if (Properties.Settings.Default.Fal)
            {
                Fal.IsChecked = true;
            }
            if (Properties.Settings.Default.Lem)
            {
                Lem.IsChecked = true;
            }
            if (Properties.Settings.Default.Pul)
            {
                Pul.IsChecked = true;
            }
            if (Properties.Settings.Default.Um)
            {
                Um.IsChecked = true;
            }
            if (Properties.Settings.Default.Mal)
            {
                Mal.IsChecked = true;
            }
            if (Properties.Settings.Default.Ist)
            {
                Ist.IsChecked = true;
            }
            if (Properties.Settings.Default.Gul)
            {
                Gul.IsChecked = true;
            }
            if (Properties.Settings.Default.Vex)
            {
                Vex.IsChecked = true;
            }
            if (Properties.Settings.Default.Ohm)
            {
                Ohm.IsChecked = true;
            }
            if (Properties.Settings.Default.Lo)
            {
                Lo.IsChecked = true;
            }
            if (Properties.Settings.Default.Sur)
            {
                Sur.IsChecked = true;
            }
            if (Properties.Settings.Default.Ber)
            {
                Ber.IsChecked = true;
            }
            if (Properties.Settings.Default.Jah)
            {
                Jah.IsChecked = true;
            }
            if (Properties.Settings.Default.Cham)
            {
                Cham.IsChecked = true;
            }
            if (Properties.Settings.Default.Zod)
            {
                Zod.IsChecked = true;
            }
        }


        public RunePage()
        {
            InitializeComponent();
            Properties.Settings.Default.RuneScore = 0;
            CheckRunes();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }



        private void El_Checked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(3);
            Properties.Settings.Default.El = true;
            Properties.Settings.Default.Save();
        }

        private void El_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(3);
            Properties.Settings.Default.El = false;
            Properties.Settings.Default.Save();
        }

        private void Eld_Checked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(5);
            Properties.Settings.Default.Eld = true;
            Properties.Settings.Default.Save();
        }

        private void Eld_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(5);
            Properties.Settings.Default.Eld = false;
            Properties.Settings.Default.Save();
        }

        private void Tir_Checked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(6);
            Properties.Settings.Default.Tir = true;
            Properties.Settings.Default.Save();
        }

        private void Tir_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(6);
            Properties.Settings.Default.Tir = false;
            Properties.Settings.Default.Save();
        }

        private void Nef_Checked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(9);
            Properties.Settings.Default.Nef = true;
            Properties.Settings.Default.Save();
        }

        private void Nef_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(9);
            Properties.Settings.Default.Nef = false;
            Properties.Settings.Default.Save();
        }

        private void Eth_Checked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(9);
            Properties.Settings.Default.Eth = true;
            Properties.Settings.Default.Save();
        }

        private void Eth_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(9);
            Properties.Settings.Default.Eth = false;
            Properties.Settings.Default.Save();
        }

        private void Ith_Checked(object sender, RoutedEventArgs e)
        {
            Pic6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(14);
            Properties.Settings.Default.Ith = true;
            Properties.Settings.Default.Save();
        }

        private void Ith_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(14);
            Properties.Settings.Default.Ith = false;
            Properties.Settings.Default.Save();
        }

        private void Tal_Checked(object sender, RoutedEventArgs e)
        {
            Pic7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(11);
            Properties.Settings.Default.Tal = true;
            Properties.Settings.Default.Save();
        }

        private void Tal_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(11);
            Properties.Settings.Default.Tal = false;
            Properties.Settings.Default.Save();
        }

        private void Ral_Checked(object sender, RoutedEventArgs e)
        {
            Pic8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(17);
            Properties.Settings.Default.Ral = true;
            Properties.Settings.Default.Save();
        }

        private void Ral_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(17);
            Properties.Settings.Default.Ral = false;
            Properties.Settings.Default.Save();
        }

        private void Ort_Checked(object sender, RoutedEventArgs e)
        {
            Pic9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(19);
            Properties.Settings.Default.Ort = true;
            Properties.Settings.Default.Save();
        }

        private void Ort_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(19);
            Properties.Settings.Default.Ort = false;
            Properties.Settings.Default.Save();
        }

        private void Thul_Checked(object sender, RoutedEventArgs e)
        {
            Pic10.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(29);
            Properties.Settings.Default.Thul = true;
            Properties.Settings.Default.Save();
        }

        private void Thul_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic10.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(29);
            Properties.Settings.Default.Thul = false;
            Properties.Settings.Default.Save();
        }

        private void Amn_Checked(object sender, RoutedEventArgs e)
        {
            Pic11.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(31);
            Properties.Settings.Default.Amn = true;
            Properties.Settings.Default.Save();
        }

        private void Amn_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic11.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(31);
            Properties.Settings.Default.Amn = false;
            Properties.Settings.Default.Save();
        }

        private void Sol_Checked(object sender, RoutedEventArgs e)
        {
            Pic12.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(47);
            Properties.Settings.Default.Sol = true;
            Properties.Settings.Default.Save();
        }

        private void Sol_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic12.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(47);
            Properties.Settings.Default.Sol = false;
            Properties.Settings.Default.Save();
        }

        private void Sheal_Checked(object sender, RoutedEventArgs e)
        {
            Pic13.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(60);
            Properties.Settings.Default.Sheal = true;
            Properties.Settings.Default.Save();
        }

        private void Sheal_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic13.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(60);
            Properties.Settings.Default.Sheal = false;
            Properties.Settings.Default.Save();
        }

        private void Dol_Checked(object sender, RoutedEventArgs e)
        {
            Pic14.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(90);
            Properties.Settings.Default.Dol = true;
            Properties.Settings.Default.Save();
        }

        private void Dol_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic14.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(90);
            Properties.Settings.Default.Dol = false;
            Properties.Settings.Default.Save();
        }

        private void Hel_Checked(object sender, RoutedEventArgs e)
        {
            Pic15.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(117);
            Properties.Settings.Default.Hel = true;
            Properties.Settings.Default.Save();
        }

        private void Hel_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic15.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(117);
            Properties.Settings.Default.Hel = false;
            Properties.Settings.Default.Save();
        }

        private void Io_Checked(object sender, RoutedEventArgs e)
        {
            Pic16.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(176);
            Properties.Settings.Default.Io = true;
            Properties.Settings.Default.Save();
        }

        private void Io_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic16.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(176);
            Properties.Settings.Default.Io = false;
            Properties.Settings.Default.Save();
        }

        private void Lum_Checked(object sender, RoutedEventArgs e)
        {
            Pic17.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(235);
            Properties.Settings.Default.Lum = true;
            Properties.Settings.Default.Save();
        }

        private void Lum_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic17.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(235);
            Properties.Settings.Default.Lum = false;
            Properties.Settings.Default.Save();
        }

        private void Ko_Checked(object sender, RoutedEventArgs e)
        {
            Pic18.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(353);
            Properties.Settings.Default.Ko = true;
            Properties.Settings.Default.Save();
        }

        private void Ko_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic18.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(353);
            Properties.Settings.Default.Ko = false;
            Properties.Settings.Default.Save();
        }

        private void Fal_Checked(object sender, RoutedEventArgs e)
        {
            Pic19.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(467);
            Properties.Settings.Default.Fal = true;
            Properties.Settings.Default.Save();
        }

        private void Fal_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic19.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(467);
            Properties.Settings.Default.Fal = false;
            Properties.Settings.Default.Save();
        }

        private void Lem_Checked(object sender, RoutedEventArgs e)
        {
            Pic20.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(701);
            Properties.Settings.Default.Lem = true;
            Properties.Settings.Default.Save();
        }

        private void Lem_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic20.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(701);
            Properties.Settings.Default.Lem = false;
            Properties.Settings.Default.Save();
        }

        private void Pul_Checked(object sender, RoutedEventArgs e)
        {
            Pic21.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(932);
            Properties.Settings.Default.Pul = true;
            Properties.Settings.Default.Save();
        }

        private void Pul_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic21.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(932);
            Properties.Settings.Default.Pul = false;
            Properties.Settings.Default.Save();
        }

        private void Um_Checked(object sender, RoutedEventArgs e)
        {
            Pic22.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(1398);
            Properties.Settings.Default.Um = true;
            Properties.Settings.Default.Save();
        }

        private void Um_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic22.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(1398);
            Properties.Settings.Default.Um = false;
            Properties.Settings.Default.Save();
        }

        private void Mal_Checked(object sender, RoutedEventArgs e)
        {
            Pic23.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(1378);
            Properties.Settings.Default.Mal = true;
            Properties.Settings.Default.Save();
        }

        private void Mal_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic23.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(1378);
            Properties.Settings.Default.Mal = false;
            Properties.Settings.Default.Save();
        }

        private void Ist_Checked(object sender, RoutedEventArgs e)
        {
            Pic24.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(2067);
            Properties.Settings.Default.Ist = true;
            Properties.Settings.Default.Save();
        }

        private void Ist_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic24.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(2067);
            Properties.Settings.Default.Ist = false;
            Properties.Settings.Default.Save();
        }

        private void Gul_Checked(object sender, RoutedEventArgs e)
        {
            Pic25.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(51517);
            Properties.Settings.Default.Gul = true;
            Properties.Settings.Default.Save();
        }

        private void Gul_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic25.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(51517);
            Properties.Settings.Default.Gul = false;
            Properties.Settings.Default.Save();
        }

        private void Vex_Checked(object sender, RoutedEventArgs e)
        {
            Pic26.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(77276);
            Properties.Settings.Default.Vex = true;
            Properties.Settings.Default.Save();
        }

        private void Vex_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic26.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(77276);
            Properties.Settings.Default.Vex = false;
            Properties.Settings.Default.Save();
        }

        private void Ohm_Checked(object sender, RoutedEventArgs e)
        {
            Pic27.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(73553);
            Properties.Settings.Default.Ohm = true;
            Properties.Settings.Default.Save();
        }

        private void Ohm_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic27.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(73553);
            Properties.Settings.Default.Ohm = false;
            Properties.Settings.Default.Save();
        }

        private void Lo_Checked(object sender, RoutedEventArgs e)
        {
            Pic28.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(110329);
            Properties.Settings.Default.Lo = true;
            Properties.Settings.Default.Save();
        }

        private void Lo_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic28.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(110329);
            Properties.Settings.Default.Lo = false;
            Properties.Settings.Default.Save();
        }

        private void Sur_Checked(object sender, RoutedEventArgs e)
        {
            Pic29.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(99622);
            Properties.Settings.Default.Sur = true;
            Properties.Settings.Default.Save();
        }

        private void Sur_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic29.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(99622);
            Properties.Settings.Default.Sur = false;
            Properties.Settings.Default.Save();
        }

        private void Ber_Checked(object sender, RoutedEventArgs e)
        {
            Pic30.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(149434);
            Properties.Settings.Default.Ber = true;
            Properties.Settings.Default.Save();
        }

        private void Ber_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic30.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(149434);
            Properties.Settings.Default.Ber = false;
            Properties.Settings.Default.Save();
        }

        private void Jah_Checked(object sender, RoutedEventArgs e)
        {
            Pic31.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(134576);
            Properties.Settings.Default.Jah = true;
            Properties.Settings.Default.Save();
        }

        private void Jah_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic31.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(134576);
            Properties.Settings.Default.Jah = false;
            Properties.Settings.Default.Save();
        }

        private void Cham_Checked(object sender, RoutedEventArgs e)
        {
            Pic32.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(201864);
            Properties.Settings.Default.Cham = true;
            Properties.Settings.Default.Save();
        }

        private void Cham_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic32.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(201864);
            Properties.Settings.Default.Cham = false;
            Properties.Settings.Default.Save();
        }

        private void Zod_Checked(object sender, RoutedEventArgs e)
        {
            Pic33.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
            AddPoints(524929);
            Properties.Settings.Default.Zod = true;
            Properties.Settings.Default.Save();
        }

        private void Zod_Unchecked(object sender, RoutedEventArgs e)
        {
            Pic33.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#99000000"));
            RemovePoints(524929);
            Properties.Settings.Default.Zod = false;
            Properties.Settings.Default.Save();
        }
    }
}
