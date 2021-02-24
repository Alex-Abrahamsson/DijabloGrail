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

        public double[] allScore = new double[50];
        public double grailScore;
        public SoundPlayer sp = new SoundPlayer();
        public bool firstStart = true;

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
                ScoreBox.Text = "   Dijablo <3  ";
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
            SetAllScoreVariables();

            CalculateScore();
            SetScore();

            if (firstStart)
            {
                PlaySong();
                firstStart = false;
            }

            //--------------------------------MAIN CODE END--------------------------
        }

        //========================================== MUTE CHECKBOX ====================================
        private void MuteCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.IsMuted = true;
        }

        private void MuteCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.IsMuted = false;
        }
        //=============================================================================================

        private void SetAllScoreVariables()
        {
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
            allScore[17] = Properties.Settings.Default.ArcannasScore;
            allScore[18] = Properties.Settings.Default.BerserkersScore;
            allScore[19] = Properties.Settings.Default.CatansScore;
            allScore[20] = Properties.Settings.Default.CiverbScore;
            allScore[21] = Properties.Settings.Default.CleglawScore;
            allScore[22] = Properties.Settings.Default.DeathsScore;
            allScore[23] = Properties.Settings.Default.HsarusScore;
            allScore[24] = Properties.Settings.Default.InfernalsScore;
            allScore[25] = Properties.Settings.Default.IrathasScore;
            allScore[26] = Properties.Settings.Default.IsenheartScore;
            allScore[27] = Properties.Settings.Default.MilabregasScore;
            allScore[28] = Properties.Settings.Default.SigonsScore;
            allScore[29] = Properties.Settings.Default.TancredsScore;
            allScore[30] = Properties.Settings.Default.VidalasScore;
            allScore[31] = Properties.Settings.Default.AldursScore;
            allScore[32] = Properties.Settings.Default.BulKatosScore;
            allScore[33] = Properties.Settings.Default.CowKingsScore;
            allScore[34] = Properties.Settings.Default.TheDiscipleScore;
            allScore[35] = Properties.Settings.Default.GrisworldScore;
            allScore[36] = Properties.Settings.Default.HeavensScore;
            allScore[37] = Properties.Settings.Default.HwaninsScore;
            allScore[38] = Properties.Settings.Default.ImmortalsScore;
            allScore[39] = Properties.Settings.Default.MavinasScore;
            allScore[40] = Properties.Settings.Default.NatalyasScore;
            allScore[41] = Properties.Settings.Default.NajsScore;
            allScore[42] = Properties.Settings.Default.OrphansScore;
            allScore[43] = Properties.Settings.Default.SandersScore;
            allScore[44] = Properties.Settings.Default.SazabisScore;
            allScore[45] = Properties.Settings.Default.TalRashasScore;
            allScore[46] = Properties.Settings.Default.TrangoulsScore;
            allScore[47] = Properties.Settings.Default.ArticScore;
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



        private void Angelic_RaimentBtn_Click(object sender, RoutedEventArgs e)
        {
            AngelicRaimentPage angelicRaimentPage = new AngelicRaimentPage();
            this.NavigationService.Navigate(angelicRaimentPage);
        }

        private void Arcannas_Btn_Click(object sender, RoutedEventArgs e)
        {
            ArcannasTrickPage1 arcannasTrickPage1 = new ArcannasTrickPage1();
            this.NavigationService.Navigate(arcannasTrickPage1);
        }

        private void BerserkBtn_Click(object sender, RoutedEventArgs e)
        {
            BerserkersPage berserkersPage = new BerserkersPage();
            this.NavigationService.Navigate(berserkersPage);
        }

        private void CathansBtn_Click(object sender, RoutedEventArgs e)
        {
            CathansPage cathansPage = new CathansPage();
            this.NavigationService.Navigate(cathansPage);
        }

        private void CleglawsBtn_Click(object sender, RoutedEventArgs e)
        {
            CleglawPage cleglawPage = new CleglawPage();
            this.NavigationService.Navigate(cleglawPage);
        }

        private void CiverbsBtn_Click(object sender, RoutedEventArgs e)
        {
            Civerbs_Page civerbs_Page = new Civerbs_Page();
            this.NavigationService.Navigate(civerbs_Page);
        }

        private void DeathsBtn_Click(object sender, RoutedEventArgs e)
        {
            DeathsPage deathsPage = new DeathsPage();
            this.NavigationService.Navigate(deathsPage);
        }

        private void HsarusBtn_Click(object sender, RoutedEventArgs e)
        {
            Hsarus_Page hsarus_Page = new Hsarus_Page();
            this.NavigationService.Navigate(hsarus_Page);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InfernalPage infernalPage = new InfernalPage();
            this.NavigationService.Navigate(infernalPage);
        }

        private void IrathasBtn_Click(object sender, RoutedEventArgs e)
        {
            Iratha_s_Page iratha_S_Page = new Iratha_s_Page();
            this.NavigationService.Navigate(iratha_S_Page);
        }

        private void IsenhartBtn_Click(object sender, RoutedEventArgs e)
        {
            IsenhartPage isenhartPage = new IsenhartPage();
            this.NavigationService.Navigate(isenhartPage);
        }

        private void MilabregasBtn_Click(object sender, RoutedEventArgs e)
        {
            MilabregasPage milabregasPage = new MilabregasPage();
            this.NavigationService.Navigate(milabregasPage);
        }

        private void SigonsBtn_Click(object sender, RoutedEventArgs e)
        {
            SigonsPage sigonsPage = new SigonsPage();
            this.NavigationService.Navigate(sigonsPage);
        }
    }
}
