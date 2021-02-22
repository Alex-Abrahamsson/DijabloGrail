using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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

    public partial class MainWindow : Window
    {
        MenuPage menuPage = new MenuPage();


        public double grailScore;
        public MainWindow()
        {

            InitializeComponent();
            this.Title = "Diablo Holy Grail Game!";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            

            
            mainPage.NavigationService.Navigate(menuPage);

            CheckIfMusicIsMuted(menuPage);
        }

        private void CheckIfMusicIsMuted(MenuPage mPage)
        {
            switch (Properties.Settings.Default.IsMuted)
            {
                case false:
                    menuPage.sp.Play();
                    menuPage.PlaySong();
                    break;
                case true:
                    menuPage.sp.Stop();
                    break;
            }
        }


        //public void PlaySong()
        //{
        //    Random numberGenerator = new Random();
        //    int randomNumber = numberGenerator.Next(1, 5);

        //    switch (randomNumber)
        //    {
        //        case 1:
        //            sp.SoundLocation = @".\Act 1 - Town1.wav";
        //            sp.Play();
        //            break;
        //        case 2:
        //            sp.SoundLocation = @".\Act 1 - Tristram.wav";
        //            sp.Play();
        //            break;
        //        case 3:
        //            sp.SoundLocation = @".\Act 2 - Town2.wav";
        //            sp.Play();
        //            break;
        //        case 4:
        //            sp.SoundLocation = @".\Act 5 - Xtown.wav";
        //            sp.Play();
        //            break;
        //    }
        //}
    }
}
