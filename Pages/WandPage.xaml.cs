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


    public partial class WandPage : Page
    {

        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.WandScore = Properties.Settings.Default.WandScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.WandScore = Properties.Settings.Default.WandScore - pointsToRemove;
        }

        public void CheckWands()
        {
            if (Properties.Settings.Default.Torch_of_Iro)
            {
                Torch_of_Iro.IsChecked = true;
            }
            if (Properties.Settings.Default.Maelstrom)
            {
                Maelstrom.IsChecked = true;
            }
            if (Properties.Settings.Default.Gravenspine)
            {
                Gravenspine.IsChecked = true;
            }
            if (Properties.Settings.Default.Ume_s_Lament)
            {
                Ume_s_Lament.IsChecked = true;
            }
            if (Properties.Settings.Default.Suicide_Branch)
            {
                Suicide_Branch.IsChecked = true;
            }
            if (Properties.Settings.Default.Carin_Shard)
            {
                Carin_Shard.IsChecked = true;
            }
            if (Properties.Settings.Default.Arm_of_King_Leoric)
            {
                Arm_of_King_Leoric.IsChecked = true;
            }
            if (Properties.Settings.Default.Blackhand_Key)
            {
                Blackhand_Key.IsChecked = true;
            }
            if (Properties.Settings.Default.Boneshade)
            {
                Boneshade.IsChecked = true;
            }
            if (Properties.Settings.Default.Death_s_Web)
            {
                Death_s_Web.IsChecked = true;
            }

        }
        public WandPage()
        {
            InitializeComponent();
            Properties.Settings.Default.WandScore = 0;
            CheckWands();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }

        private void Torch_of_Iro_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3157);
            Properties.Settings.Default.Torch_of_Iro = true;
            Properties.Settings.Default.Save();
        }

        private void Torch_of_Iro_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3157);
            Properties.Settings.Default.Torch_of_Iro = false;
            Properties.Settings.Default.Save();
        }

        private void Maelstrom_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(466);
            Properties.Settings.Default.Maelstrom = true;
            Properties.Settings.Default.Save();
        }

        private void Maelstrom_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(466);
            Properties.Settings.Default.Maelstrom = false;
            Properties.Settings.Default.Save();
        }

        private void Gravenspine_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(435);
            Properties.Settings.Default.Gravenspine = true;
            Properties.Settings.Default.Save();
        }

        private void Gravenspine_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(435);
            Properties.Settings.Default.Gravenspine = false;
            Properties.Settings.Default.Save();
        }

        private void Ume_s_Lament_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(586);
            Properties.Settings.Default.Ume_s_Lament = true;
            Properties.Settings.Default.Save();
        }

        private void Ume_s_Lament_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(586);
            Properties.Settings.Default.Ume_s_Lament = false;
            Properties.Settings.Default.Save();
        }

        private void Suicide_Branch_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1011);
            Properties.Settings.Default.Suicide_Branch = true;
            Properties.Settings.Default.Save();
        }

        private void Suicide_Branch_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1011);
            Properties.Settings.Default.Suicide_Branch = false;
            Properties.Settings.Default.Save();
        }

        private void Carin_Shard_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1589);
            Properties.Settings.Default.Carin_Shard = true;
            Properties.Settings.Default.Save();
        }

        private void Carin_Shard_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1589);
            Properties.Settings.Default.Carin_Shard = false;
            Properties.Settings.Default.Save();
        }

        private void Arm_of_King_Leoric_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1742);
            Properties.Settings.Default.Arm_of_King_Leoric = true;
            Properties.Settings.Default.Save();
        }

        private void Arm_of_King_Leoric_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1742);
            Properties.Settings.Default.Arm_of_King_Leoric = false;
            Properties.Settings.Default.Save();
        }

        private void Blackhand_Key_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1793);
            Properties.Settings.Default.Blackhand_Key = true;
            Properties.Settings.Default.Save();
        }

        private void Blackhand_Key_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1793);
            Properties.Settings.Default.Blackhand_Key = false;
            Properties.Settings.Default.Save();
        }

        private void Boneshade_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1407);
            Properties.Settings.Default.Boneshade = true;
            Properties.Settings.Default.Save();
        }

        private void Boneshade_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1407);
            Properties.Settings.Default.Boneshade = false;
            Properties.Settings.Default.Save();
        }

        private void Death_s_Web_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(43790);
            Properties.Settings.Default.Death_s_Web = true;
            Properties.Settings.Default.Save();
        }

        private void Death_s_Web_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(43790);
            Properties.Settings.Default.Death_s_Web = false;
            Properties.Settings.Default.Save();
        }
    }
}
