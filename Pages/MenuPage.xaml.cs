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
using System.Media;
using DijabloGrail.Pages;

namespace DijabloGrail
{

    public partial class MenuPage : Page
    {
        public double[] allScore = new double[40];
        public double grailScore;
        public SoundPlayer sp = new SoundPlayer();

        public void PlaySong()
        {
            Random numberGenerator = new Random();
            int randomNumber = numberGenerator.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    sp.SoundLocation = @".\Music\Act 1 - Town1.wav";
                    sp.Play();
                    break;
                case 2:
                    sp.SoundLocation = @".\Music\Act 1 - Tristram.wav";
                    sp.Play();
                    break;
                case 3:
                    sp.SoundLocation = @".\Music\Act 2 - Town2.wav";
                    sp.Play();
                    break;
                case 4:
                    sp.SoundLocation = @".\Music\Act 5 - Xtown.wav";
                    sp.Play();
                    break;
            }
        }

        public void SetScore()
        {
            if (grailScore < 1)
            {
                ScoreBox.Text = "   Hej Pigge <3  ";
            }
            else ScoreBox.Text = "  Score: " + grailScore;
        }

        public void UpdateScore()
        {
            ScoreBox.Text = "  Score: " + grailScore;
        }

        public void CalculateScore()
        {
            foreach (var item in allScore)
            {
                grailScore = grailScore + item;
            }
        }

        public MenuPage()
        {
            //---------------------------------MAIN CODE-----------------------------
            InitializeComponent();

            allScore[0] = Properties.Settings.Default.ArmorScore;
            allScore[1] = Properties.Settings.Default.HelmScore;
            allScore[2] = Properties.Settings.Default.GloveScore;
            allScore[3] = Properties.Settings.Default.BootScore;
            allScore[4] = Properties.Settings.Default.BeltScore;
            allScore[5] = Properties.Settings.Default.JewleryScore;
            allScore[6] = Properties.Settings.Default.SheildScore;
            allScore[7] = Properties.Settings.Default.AxeScore;
            allScore[8] = Properties.Settings.Default.SwordScore;
            allScore[9] = Properties.Settings.Default.BowScore;
            allScore[10] = Properties.Settings.Default.DaggerScore;
            allScore[11] = Properties.Settings.Default.CrossbowScore;
            allScore[12] = Properties.Settings.Default.WandScore;
            allScore[13] = Properties.Settings.Default.MaceScore;
            allScore[14] = Properties.Settings.Default.ScepterScore;
            allScore[15] = Properties.Settings.Default.JavelinScore;

            allScore[16] = Properties.Settings.Default.AngelicScore;




            CalculateScore();
            SetScore();
            
            //--------------------------------MAIN CODE END--------------------------
        }
        private void HelmsBtn_Click(object sender, RoutedEventArgs e)
        {
            HelmsPage helmsPage = new HelmsPage();
            this.NavigationService.Navigate(helmsPage);
        }

        private void BootsBtn_Click(object sender, RoutedEventArgs e)
        {
            BootsPage bootsPage = new BootsPage();
            this.NavigationService.Navigate(bootsPage);
        }

        private void BeltsBtn_Click(object sender, RoutedEventArgs e)
        {
            BeltsPage beltsPage = new BeltsPage();
            this.NavigationService.Navigate(beltsPage);
        }

        private void ArmorBtn_Click(object sender, RoutedEventArgs e)
        {
            ArmorPage armorPage = new ArmorPage();
            this.NavigationService.Navigate(armorPage);
        }

        private void GlovesBtn_Click(object sender, RoutedEventArgs e)
        {
            GlovePage glovePage = new GlovePage();
            this.NavigationService.Navigate(glovePage);
        }

        private void RingsBtn_Click(object sender, RoutedEventArgs e)
        {
            JewleryPage jewleryPage = new JewleryPage();
            this.NavigationService.Navigate(jewleryPage);
        }

        private void SheildsBtn_Click(object sender, RoutedEventArgs e)
        {
            SheildPage sheildPage = new SheildPage();
            this.NavigationService.Navigate(sheildPage);
        }

        private void AxesBtn_Click(object sender, RoutedEventArgs e)
        {
            AxesPage axesPage = new AxesPage();
            this.NavigationService.Navigate(axesPage);
        }

        //---------------------------------INFO BUTTON-------------------------------------------------------------
        private void InfoBtn_Click(object sender, RoutedEventArgs e)
        {
            string info = "-----------------------------INFO-----------------------------\n" +
                " Hover over item to show best place to find it. \n" +
                " \n" +
                " The numbers are based on Players-8 and 200 MF\n " +
                "\n" +
                " Points is calculated as follows -Dropchance / 10-\n" +
                " --------------------------------------------------------------";
            MessageBox.Show(info, "Information", MessageBoxButton.OK);
        }
        //---------------------------------INFO BUTTON-------------------------------------------------------------


        private void BowsBtn_Click(object sender, RoutedEventArgs e)
        {
            BowPage bowPage = new BowPage();
            this.NavigationService.Navigate(bowPage);
        }

        private void DaggerBtn_Click(object sender, RoutedEventArgs e)
        {
            DaggerPage daggerPage = new DaggerPage();
            this.NavigationService.Navigate(daggerPage);
        }

        private void CrossbowsBtn_Click(object sender, RoutedEventArgs e)
        {
            CrossbowPage crossbowPage = new CrossbowPage();
            this.NavigationService.Navigate(crossbowPage);
        }

        private void WandsBtn_Click(object sender, RoutedEventArgs e)
        {
            WandPage wandPage = new WandPage();
            this.NavigationService.Navigate(wandPage);
        }

        private void _1HandMaceBtn_Click(object sender, RoutedEventArgs e)
        {
            MacePage macePage = new MacePage();
            this.NavigationService.Navigate(macePage);
        }

        private void _1HandSwordBtn_Click(object sender, RoutedEventArgs e)
        {
            SwordPage swordPage = new SwordPage();
            this.NavigationService.Navigate(swordPage);
        }

        private void SceptersBtn_Click(object sender, RoutedEventArgs e)
        {
            ScepterPage scepterPage = new ScepterPage();
            this.NavigationService.Navigate(scepterPage);
        }

        private void MuteCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.IsMuted = true;
        }

        private void MuteCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.IsMuted = false;
        }

        private void Angelic_RaimentBtn_Click(object sender, RoutedEventArgs e)
        {
            AngelicRaimentPage angelicRaimentPage = new AngelicRaimentPage();
            this.NavigationService.Navigate(angelicRaimentPage);
        }

        private void Arcannas_Btn_Click(object sender, RoutedEventArgs e)
        {
            ArcannasTrickPage arcannasTrickPage = new ArcannasTrickPage();
            this.NavigationService.Navigate(arcannasTrickPage);
        }
    }
}
