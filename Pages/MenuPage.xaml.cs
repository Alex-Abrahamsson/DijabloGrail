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
using Newtonsoft.Json;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace DijabloGrail
{

    public partial class MenuPage : Page
    {
        

        public double[] allScore = new double[54];
        public double grailScore;
        public void SetScore()
        {
            if (grailScore < 1)
            {
                ScoreBox.Text = "      Dijablo <3  ";
            }
            else ScoreBox.Text = "      Score: " + grailScore;
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
            UsernameDisplayTxt.Text = "Welcome " + Properties.Settings.Default.userName;

            //--------------------------------MAIN CODE END--------------------------
        }

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
            allScore[16] = Properties.Settings.Default.ThrowingScore;
            allScore[17] = Properties.Settings.Default.PolearmScore;
            allScore[18] = Properties.Settings.Default.SpearScore;
            allScore[19] = Properties.Settings.Default.StaveScore;

            allScore[20] = Properties.Settings.Default.AngelicScore;
            allScore[21] = Properties.Settings.Default.ArcannasScore;
            allScore[22] = Properties.Settings.Default.BerserkersScore;
            allScore[23] = Properties.Settings.Default.CatansScore;
            allScore[24] = Properties.Settings.Default.CiverbScore;
            allScore[25] = Properties.Settings.Default.CleglawScore;
            allScore[26] = Properties.Settings.Default.DeathsScore;
            allScore[27] = Properties.Settings.Default.HsarusScore;
            allScore[28] = Properties.Settings.Default.InfernalsScore;
            allScore[29] = Properties.Settings.Default.IrathasScore;
            allScore[30] = Properties.Settings.Default.IsenheartScore;
            allScore[31] = Properties.Settings.Default.MilabregasScore;
            allScore[32] = Properties.Settings.Default.SigonsScore;
            allScore[33] = Properties.Settings.Default.TancredsScore;
            allScore[34] = Properties.Settings.Default.VidalasScore;
            allScore[35] = Properties.Settings.Default.AldursScore;
            allScore[36] = Properties.Settings.Default.BulKatosScore;
            allScore[37] = Properties.Settings.Default.CowKingsScore;
            allScore[38] = Properties.Settings.Default.TheDiscipleScore;
            allScore[39] = Properties.Settings.Default.GrisworldScore;
            allScore[40] = Properties.Settings.Default.HeavensScore;
            allScore[41] = Properties.Settings.Default.HwaninsScore;
            allScore[42] = Properties.Settings.Default.ImmortalsScore;
            allScore[43] = Properties.Settings.Default.MavinasScore;
            allScore[44] = Properties.Settings.Default.NatalyasScore;
            allScore[45] = Properties.Settings.Default.NajsScore;
            allScore[46] = Properties.Settings.Default.OrphansScore;
            allScore[47] = Properties.Settings.Default.SandersScore;
            allScore[48] = Properties.Settings.Default.SazabisScore;
            allScore[49] = Properties.Settings.Default.TalRashasScore;
            allScore[50] = Properties.Settings.Default.TrangoulsScore;
            allScore[51] = Properties.Settings.Default.ArticScore;
            allScore[52] = Properties.Settings.Default.ClassItemScore;
            allScore[53] = Properties.Settings.Default.RuneScore;
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

        private void TancredsBtn_Click(object sender, RoutedEventArgs e)
        {
            TancredsPage tancredsPage = new TancredsPage();
            this.NavigationService.Navigate(tancredsPage);
        }

        private void VidalasBtn_Click(object sender, RoutedEventArgs e)
        {
            VidalasPage vidalasPage = new VidalasPage();
            this.NavigationService.Navigate(vidalasPage);
        }

        private void DicipleBtn_Click(object sender, RoutedEventArgs e)
        {
            DiciplePage diciplePage = new DiciplePage();
            this.NavigationService.Navigate(diciplePage);
        }

        private void HeavensBtn_Click(object sender, RoutedEventArgs e)
        {
            HeavensPage heavensPage = new HeavensPage();
            this.NavigationService.Navigate(heavensPage);
        }

        private void HwaninsBtn_Click(object sender, RoutedEventArgs e)
        {
            HwaninsPage hwaninsPage = new HwaninsPage();
            this.NavigationService.Navigate(hwaninsPage);
        }

        private void NajsBtn_Click(object sender, RoutedEventArgs e)
        {
            NajsPage najsPage = new NajsPage();
            this.NavigationService.Navigate(najsPage);
        }

        private void OrphansBtn_Click(object sender, RoutedEventArgs e)
        {
            OrphansPage orphansPage = new OrphansPage();
            this.NavigationService.Navigate(orphansPage);
        }

        private void SanderBtn_Click(object sender, RoutedEventArgs e)
        {
            SandersPage sandersPage = new SandersPage();
            this.NavigationService.Navigate(sandersPage);
        }

        private void SazabisBtn_Click(object sender, RoutedEventArgs e)
        {
            SazabisPage sazabisPage = new SazabisPage();
            this.NavigationService.Navigate(sazabisPage);
        }

        private void CowkingsBtn_Click(object sender, RoutedEventArgs e)
        {
            CowkingsPage cowkingsPage = new CowkingsPage();
            this.NavigationService.Navigate(cowkingsPage);
        }

        private void AldursBtn_Click(object sender, RoutedEventArgs e)
        {
            AldursPage aldursPage = new AldursPage();
            this.NavigationService.Navigate(aldursPage);
        }

        private void BulkathosBtn_Click(object sender, RoutedEventArgs e)
        {
            BulKatosPage bulKatosPage = new BulKatosPage();
            this.NavigationService.Navigate(bulKatosPage);
        }

        private void GriswoldsBtn_Click(object sender, RoutedEventArgs e)
        {
            GrisworldPage grisworld = new GrisworldPage();
            this.NavigationService.Navigate(grisworld);
        }

        private void ImmortalBtn_Click(object sender, RoutedEventArgs e)
        {
            ImmortalKingPage immortalKing = new ImmortalKingPage();
            this.NavigationService.Navigate(immortalKing);
        }

        private void MavinasBtn_Click(object sender, RoutedEventArgs e)
        {
            MavinasPage mavinasPage = new MavinasPage();
            this.NavigationService.Navigate(mavinasPage);
        }

        private void NatalyasBtn_Click(object sender, RoutedEventArgs e)
        {
            NatalyasPage natalyasPage = new NatalyasPage();
            this.NavigationService.Navigate(natalyasPage);
        }

        private void TalrashasBtn_Click(object sender, RoutedEventArgs e)
        {
            TalrashasPage talrashasPage = new TalrashasPage();
            this.NavigationService.Navigate(talrashasPage);
        }

        private void TranoulsBtn_Click(object sender, RoutedEventArgs e)
        {
            TrangOulsPage trangOulsPage = new TrangOulsPage();
            this.NavigationService.Navigate(trangOulsPage);
        }

        private void ArcticBtn_Click(object sender, RoutedEventArgs e)
        {
            Artic_Gear_Page1 artic_Gear_Page = new Artic_Gear_Page1();
            this.NavigationService.Navigate(artic_Gear_Page);
        }

        private void ThrowWeaponBtn_Click(object sender, RoutedEventArgs e)
        {
            ThrowingPage throwingPage = new ThrowingPage();
            this.NavigationService.Navigate(throwingPage);
        }

        private void JavelinBtn_Click(object sender, RoutedEventArgs e)
        {
            JavelinPage javelinPage = new JavelinPage();
            this.NavigationService.Navigate(javelinPage);
        }

        private void PolearmBtn_Click(object sender, RoutedEventArgs e)
        {
            PolearmPage polearmPage = new PolearmPage();
            this.NavigationService.Navigate(polearmPage);
        }

        private void SpearsBtn_Click(object sender, RoutedEventArgs e)
        {
            SpearPage spearPage = new SpearPage();
            this.NavigationService.Navigate(spearPage);
        }

        private void StaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StavePage stavePage = new StavePage();
            this.NavigationService.Navigate(stavePage);
        }

        private void ClassBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassitemPage classitemPage = new ClassitemPage();
            this.NavigationService.Navigate(classitemPage);
        }

        private void RunesBtn_Click(object sender, RoutedEventArgs e)
        {
            RunePage runePage = new RunePage();
            this.NavigationService.Navigate(runePage);
        }


        //Reset button should ask if you are sure, then open a window that prompts for username input, then  sends mail with totalscore and username
        //Highscore button opens highscore page
        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("This will reset all of your score!", "Are you sure?", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                string emailInfo = "----------------------------------------------------------------------\n" +
                                    "Your season score has been sent to the app creator! \n" +
                                    " \n" +
                                    "Your score will be inserted into the highscore list. \n" +
                                    "-----------------------------------------------------------------------";

                double seasonScore = 0;
                foreach (var item in allScore)
                {
                    seasonScore += item;
                }
                string seasonScorestring = $" {Convert.ToString(seasonScore)}";

                MessageBox.Show(emailInfo);


                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("Alex.Abrahamsson@gmail.com");
                    mail.To.Add("Alex.Abrahamsson@Gmail.com");
                    mail.Subject = "Season Score";
                    mail.Body = "<h1>Hello from User: " + Properties.Settings.Default.userName + " </h1><p>Here is my season score: " + seasonScorestring + "</p>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("DijabloGrail@gmail.com", "KungDiablo");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                string tempUserName = Properties.Settings.Default.userName; //Save the username before reset
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.userName = tempUserName;//Restore username after reset

                MessageBox.Show("-----------Mail sent successfully!----------- \n \n     The application will shutdown.");
                Application.Current.Shutdown();

            }
        }

        //Highscore button opens highscore page
        //================================================= Highscore Button =========================================================================
        #region
        private void HighscoreBtn_Click(object sender, RoutedEventArgs e)
        {
            HighscorePage highScorePage = new HighscorePage();
            this.NavigationService.Navigate(highScorePage);
        }
        #endregion
        //============================================================================================================================================

    }
}
