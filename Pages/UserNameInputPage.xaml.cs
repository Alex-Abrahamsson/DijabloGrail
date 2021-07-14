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
    /// Interaction logic for UserNameInputPage.xaml
    /// </summary>
    public partial class UserNameInputPage : Page
    {
        
        public UserNameInputPage()
        {
            InitializeComponent();
        }

        private void UserInputTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Properties.Settings.Default.userName = UserInputTxt.Text;
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.userName = UserInputTxt.Text;
            Properties.Settings.Default.Save();
            MenuPage menuPage = new MenuPage();
            this.NavigationService.Navigate(menuPage);
        }
    }
}
