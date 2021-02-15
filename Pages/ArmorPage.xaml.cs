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
using System.IO;

namespace DijabloGrail
{
    public partial class ArmorPage : Page
    {


        public void AddPoints(double points)
        {
            double pointsToAdd = points / 10;
            Properties.Settings.Default.ArmorScore = Properties.Settings.Default.ArmorScore + pointsToAdd;
        }

        public void RemovePoints(double points)
        {
            double pointsToRemove = points / 10;
            Properties.Settings.Default.ArmorScore = Properties.Settings.Default.ArmorScore - pointsToRemove;
        }


        public void CheckArmors()
        {
            if (Properties.Settings.Default.Greyform)
            {
                Greyform.IsChecked = true;
            }
            if (Properties.Settings.Default.Blinkbats_Form)
            {
                Blinkbat_s_Form.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Centurion)
            {
                The_Centurion.IsChecked = true;
            }
            if (Properties.Settings.Default.Twitchthroe)
            {
                Twitchthroe.IsChecked = true;
            }
            if (Properties.Settings.Default.Darkglow)
            {
                Darkglow.IsChecked = true;
            }
            if (Properties.Settings.Default.Hawkmail)
            {
                Hawkmail.IsChecked = true;
            }
            if (Properties.Settings.Default.Venom_Ward)
            {
                Venom_Ward.IsChecked = true;
            }
            if (Properties.Settings.Default.Iceblink)
            {
                Iceblink.IsChecked = true;
            }
            if (Properties.Settings.Default.Heavenly_Garb)
            {
                Heavenly_Garb.IsChecked = true;
            }
            if (Properties.Settings.Default.Rockfleece)
            {
                Rockfleece.IsChecked = true;
            }
            if (Properties.Settings.Default.Boneflesh)
            {
                Boneflesh.IsChecked = true;
            }
            if (Properties.Settings.Default.Rattlecage)
            {
                Rattlecage.IsChecked = true;
            }
            if (Properties.Settings.Default.Goldskin)
            {
                Goldskin.IsChecked = true;
            }
            if (Properties.Settings.Default.Silks_of_the_Victor)
            {
                Silks_of_the_Victor.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Spirit_Shroud)
            {
                The_Spirit_Shroud.IsChecked = true;
            }
            if (Properties.Settings.Default.Vipermagi)
            {
                Skin_of_the_Vipermagi.IsChecked = true;
            }
            if (Properties.Settings.Default.Skin_of_the_Flayed_One)
            {
                Skin_of_the_Flayed_One.IsChecked = true;
            }
            if (Properties.Settings.Default.Iron_Pelt)
            {
                Iron_Pelt.IsChecked = true;
            }
            if (Properties.Settings.Default.Crow_Caw)
            {
                Crow_Caw.IsChecked = true;
            }
            if (Properties.Settings.Default.Spirit_Forge)
            {
                Spirit_Forge.IsChecked = true;
            }
            if (Properties.Settings.Default.Duriels_Shell)
            {
                Duriel_s_Shell.IsChecked = true;
            }
            if (Properties.Settings.Default.Shaftstop)
            {
                Shaftstop.IsChecked = true;
            }
            if (Properties.Settings.Default.Skullders_Ire)
            {
                Skullder_s_Ire.IsChecked = true;
            }
            if (Properties.Settings.Default.Que_Hegans_Wisdom)
            {
                Que_Hegan_s_Wisdom.IsChecked = true;
            }
            if (Properties.Settings.Default.Toothrow)
            {
                Toothrow.IsChecked = true;
            }
            if (Properties.Settings.Default.Guardian_Angel)
            {
                Guardian_Angel.IsChecked = true;
            }
            if (Properties.Settings.Default.Atmas_Wail)
            {
                Atma_s_Wail.IsChecked = true;
            }
            if (Properties.Settings.Default.Black_Hades)
            {
                Black_Hades.IsChecked = true;
            }
            if (Properties.Settings.Default.Corpsemourn)
            {
                Corpsemourn.IsChecked = true;
            }
            if (Properties.Settings.Default.Ormus_Robes)
            {
                Ormus__Robes.IsChecked = true;
            }
            if (Properties.Settings.Default.The_Gladiators_Bane)
            {
                The_Gladiator_s_Bane.IsChecked = true;
            }
            if (Properties.Settings.Default.Arkaines_Valor)
            {
                Arkaine_s_Valor.IsChecked = true;
            }
            if (Properties.Settings.Default.Leviathan)
            {
                Leviathan.IsChecked = true;
            }
            if (Properties.Settings.Default.Steel_Carapace)
            {
                Steel_Carapace.IsChecked = true;
            }
            if (Properties.Settings.Default.Templars_Might)
            {
                Templar_s_Might.IsChecked = true;
            }
            if (Properties.Settings.Default.Tyraels_Might)
            {
                Tyrael_s_Might.IsChecked = true;
            }
            if (Properties.Settings.Default.Sparking_Mail)
            {
                Sparkling_Mail.IsChecked = true;
            }
        }

        public ArmorPage()
        {
            InitializeComponent();
            Properties.Settings.Default.ArmorScore = 0;
            CheckArmors();
        }


        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }


        //-------------------------------------------------------------------Armor Clicks Start-------------------------------
        private void Greyform_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(816);
            Properties.Settings.Default.Greyform = true;
            Properties.Settings.Default.Save();
        }

        private void Greyform_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(816);
            Properties.Settings.Default.Greyform = false;
            Properties.Settings.Default.Save();
        }

        private void Blinkbat_s_Form_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(3664);
            Properties.Settings.Default.Blinkbats_Form = true;
            Properties.Settings.Default.Save();
        }

        private void Blinkbat_s_Form_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(3664);
            Properties.Settings.Default.Blinkbats_Form = false;
            Properties.Settings.Default.Save();
        }

        private void The_Centurion_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(543);
            Properties.Settings.Default.The_Centurion = true;
            Properties.Settings.Default.Save();
        }

        private void The_Centurion_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(543);
            Properties.Settings.Default.The_Centurion = false;
            Properties.Settings.Default.Save();
        }

        private void Twitchthroe_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(237);
            Properties.Settings.Default.Twitchthroe = true;
            Properties.Settings.Default.Save();
        }

        private void Twitchthroe_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(237);
            Properties.Settings.Default.Twitchthroe = false;
            Properties.Settings.Default.Save();
        }

        private void Darkglow_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(250);
            Properties.Settings.Default.Darkglow = true;
            Properties.Settings.Default.Save();
        }

        private void Darkglow_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(250);
            Properties.Settings.Default.Darkglow = false;
            Properties.Settings.Default.Save();
        }

        private void Hawkmail_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(126);
            Properties.Settings.Default.Hawkmail = true;
            Properties.Settings.Default.Save();
        }

        private void Hawkmail_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(126);
            Properties.Settings.Default.Hawkmail = false;
            Properties.Settings.Default.Save();
        }

        private void Venom_Ward_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(72);
            Properties.Settings.Default.Venom_Ward = true;
            Properties.Settings.Default.Save();
        }

        private void Venom_Ward_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(72);
            Properties.Settings.Default.Venom_Ward = false;
            Properties.Settings.Default.Save();
        }

        private void Iceblink_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(230);
            Properties.Settings.Default.Iceblink = true;
            Properties.Settings.Default.Save();
        }

        private void Iceblink_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(230);
            Properties.Settings.Default.Iceblink = false;
            Properties.Settings.Default.Save();
        }

        private void Heavenly_Garb_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(414);
            Properties.Settings.Default.Heavenly_Garb = true;
            Properties.Settings.Default.Save();
        }

        private void Heavenly_Garb_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(414);
            Properties.Settings.Default.Heavenly_Garb = false;
            Properties.Settings.Default.Save();
        }

        private void Rockfleece_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(223);
            Properties.Settings.Default.Rockfleece = true;
            Properties.Settings.Default.Save();
        }

        private void Rockfleece_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(223);
            Properties.Settings.Default.Rockfleece = false;
            Properties.Settings.Default.Save();
        }

        private void Boneflesh_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(274);
            Properties.Settings.Default.Boneflesh = true;
            Properties.Settings.Default.Save();
        }

        private void Boneflesh_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(274);
            Properties.Settings.Default.Boneflesh = false;
            Properties.Settings.Default.Save();
        }

        private void Rattlecage_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(246);
            Properties.Settings.Default.Rattlecage = true;
            Properties.Settings.Default.Save();
        }

        private void Rattlecage_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(246);
            Properties.Settings.Default.Rattlecage = false;
            Properties.Settings.Default.Save();
        }

        private void Goldskin_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(715);
            Properties.Settings.Default.Goldskin = true;
            Properties.Settings.Default.Save();
        }

        private void Goldskin_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(715);
            Properties.Settings.Default.Goldskin = false;
            Properties.Settings.Default.Save();
        }

        private void Silks_of_the_Victor_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(850);
            Properties.Settings.Default.Silks_of_the_Victor = true;
            Properties.Settings.Default.Save();
        }

        private void Silks_of_the_Victor_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(850);
            Properties.Settings.Default.Silks_of_the_Victor = false;
            Properties.Settings.Default.Save();
        }

        private void The_Spirit_Shroud_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(413);
            Properties.Settings.Default.The_Spirit_Shroud = true;
            Properties.Settings.Default.Save();
        }

        private void The_Spirit_Shroud_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(413);
            Properties.Settings.Default.The_Spirit_Shroud = false;
            Properties.Settings.Default.Save();
        }

        private void Skin_of_the_Vipermagi_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(416);
            Properties.Settings.Default.Vipermagi = true;
            Properties.Settings.Default.Save();
        }

        private void Skin_of_the_Vipermagi_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(416);
            Properties.Settings.Default.Vipermagi = false;
            Properties.Settings.Default.Save();
        }

        private void Skin_of_the_Flayed_One_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(715);
            Properties.Settings.Default.Skin_of_the_Flayed_One = true;
            Properties.Settings.Default.Save();
        }

        private void Skin_of_the_Flayed_One_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(715);
            Properties.Settings.Default.Skin_of_the_Flayed_One = false;
            Properties.Settings.Default.Save();
        }

        private void Iron_Pelt_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(850);
            Properties.Settings.Default.Iron_Pelt = true;
            Properties.Settings.Default.Save();
        }

        private void Iron_Pelt_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(850);
            Properties.Settings.Default.Iron_Pelt = false;
            Properties.Settings.Default.Save();
        }

        private void Crow_Caw_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(921);
            Properties.Settings.Default.Crow_Caw = true;
            Properties.Settings.Default.Save();
        }

        private void Crow_Caw_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(921);
            Properties.Settings.Default.Crow_Caw = false;
            Properties.Settings.Default.Save();
        }

        private void Spirit_Forge_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(854);
            Properties.Settings.Default.Spirit_Forge = true;
            Properties.Settings.Default.Save();
        }

        private void Spirit_Forge_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(854);
            Properties.Settings.Default.Spirit_Forge = false;
            Properties.Settings.Default.Save();
        }

        private void Duriel_s_Shell_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(437);
            Properties.Settings.Default.Duriels_Shell = true;
            Properties.Settings.Default.Save();
        }

        private void Duriel_s_Shell_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(437);
            Properties.Settings.Default.Duriels_Shell = false;
            Properties.Settings.Default.Save();
        }

        private void Shaftstop_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(926);
            Properties.Settings.Default.Shaftstop = true;
            Properties.Settings.Default.Save();
        }

        private void Shaftstop_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(926);
            Properties.Settings.Default.Shaftstop = false;
            Properties.Settings.Default.Save();
        }

        private void Skullder_s_Ire_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1300);
            Properties.Settings.Default.Skullders_Ire = true;
            Properties.Settings.Default.Save();
        }

        private void Skullder_s_Ire_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1300);
            Properties.Settings.Default.Skullders_Ire = false;
            Properties.Settings.Default.Save();
        }

        private void Que_Hegan_s_Wisdom_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(715);
            Properties.Settings.Default.Que_Hegans_Wisdom = true;
            Properties.Settings.Default.Save();
        }

        private void Que_Hegan_s_Wisdom_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(715);
            Properties.Settings.Default.Que_Hegans_Wisdom = false;
            Properties.Settings.Default.Save();
        }

        private void Toothrow_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(569);
            Properties.Settings.Default.Toothrow = true;
            Properties.Settings.Default.Save();
        }

        private void Toothrow_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(569);
            Properties.Settings.Default.Toothrow = false;
            Properties.Settings.Default.Save();
        }

        private void Guardian_Angel_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(911);
            Properties.Settings.Default.Guardian_Angel = true;
            Properties.Settings.Default.Save();
        }

        private void Guardian_Angel_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(911);
            Properties.Settings.Default.Guardian_Angel = false;
            Properties.Settings.Default.Save();
        }

        private void Atma_s_Wail_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(711);
            Properties.Settings.Default.Atmas_Wail = true;
            Properties.Settings.Default.Save();
        }

        private void Atma_s_Wail_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(711);
            Properties.Settings.Default.Atmas_Wail = false;
            Properties.Settings.Default.Save();
        }

        private void Black_Hades_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1027);
            Properties.Settings.Default.Black_Hades = true;
            Properties.Settings.Default.Save();
        }

        private void Black_Hades_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1027);
            Properties.Settings.Default.Black_Hades = false;
            Properties.Settings.Default.Save();
        }

        private void Corpsemourn_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(679);
            Properties.Settings.Default.Corpsemourn = true;
            Properties.Settings.Default.Save();
        }

        private void Corpsemourn_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(679);
            Properties.Settings.Default.Corpsemourn = false;
            Properties.Settings.Default.Save();
        }

        private void Ormus__Robes_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(681);
            Properties.Settings.Default.Ormus_Robes = true;
            Properties.Settings.Default.Save();
        }

        private void Ormus__Robes_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(681);
            Properties.Settings.Default.Ormus_Robes = false;
            Properties.Settings.Default.Save();
        }

        private void The_Gladiator_s_Bane_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(885);
            Properties.Settings.Default.The_Gladiators_Bane = true;
            Properties.Settings.Default.Save();
        }

        private void The_Gladiator_s_Bane_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(885);
            Properties.Settings.Default.The_Gladiators_Bane = false;
            Properties.Settings.Default.Save();
        }

        private void Arkaine_s_Valor_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1404);
            Properties.Settings.Default.Arkaines_Valor = true;
            Properties.Settings.Default.Save();
        }

        private void Arkaine_s_Valor_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1404);
            Properties.Settings.Default.Arkaines_Valor = false;
            Properties.Settings.Default.Save();
        }

        private void Leviathan_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(1139);
            Properties.Settings.Default.Leviathan = true;
            Properties.Settings.Default.Save();
        }

        private void Leviathan_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(1139);
            Properties.Settings.Default.Leviathan = false;
            Properties.Settings.Default.Save();
        }

        private void Steel_Carapace_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(2018);
            Properties.Settings.Default.Steel_Carapace = true;
            Properties.Settings.Default.Save();
        }

        private void Steel_Carapace_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(2018);
            Properties.Settings.Default.Steel_Carapace = false;
            Properties.Settings.Default.Save();
        }

        private void Templar_s_Might_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(20027);
            Properties.Settings.Default.Templars_Might = true;
            Properties.Settings.Default.Save();
        }

        private void Templar_s_Might_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(20027);
            Properties.Settings.Default.Templars_Might = false;
            Properties.Settings.Default.Save();
        }

        private void Tyrael_s_Might_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(160220);
            Properties.Settings.Default.Tyraels_Might = true;
            Properties.Settings.Default.Save();
        }

        private void Tyrael_s_Might_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(160220);
            Properties.Settings.Default.Tyraels_Might = false;
            Properties.Settings.Default.Save();
        }

        private void Sparkling_Mail_Checked(object sender, RoutedEventArgs e)
        {
            AddPoints(127);
            Properties.Settings.Default.Sparking_Mail = true;
            Properties.Settings.Default.Save();
        }

        private void Sparkling_Mail_Unchecked(object sender, RoutedEventArgs e)
        {
            RemovePoints(127);
            Properties.Settings.Default.Sparking_Mail = false;
            Properties.Settings.Default.Save();
        }



        //-----------------------------------------------------ARMOR click END---------------------------------------------
    }
}
