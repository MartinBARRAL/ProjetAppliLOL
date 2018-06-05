using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ProjetAppliLOL
{
    /// <summary>
    /// Logique d'interaction pour Créer_Tournoi.xaml
    /// </summary>
    public partial class CreerTournoi : Page
    {
        public CreerTournoi()
        {
            InitializeComponent();
           
        }

        

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tournois_Click(object sender, RoutedEventArgs e)
        {
            string nom = nomTournois.Text;
            string bracket = Convert.ToString(comboBox1.SelectedValue);
             string category = Convert.ToString(comboBox.SelectedValue);
            ClassBracket value = new ClassBracket(nom,category);


            if (bracket == "System.Windows.Controls.ComboBoxItem: 2")
            {
                if (category == "System.Windows.Controls.ComboBoxItem: Bronze - Gold")
                {
                    category = "Bronze - Gold";
                    this.NavigationService.Navigate(new Bracket2(nom, category));
                }
                else if (category == "System.Windows.Controls.ComboBoxItem: Platine - Diamants")
                {
                    category = "Platine - Diamand";
                    this.NavigationService.Navigate(new Bracket2(nom, category));
                }
                else if (category == "System.Windows.Controls.ComboBoxItem: Master - Challenger")
                {
                    category = "Master - Challenger";
                    this.NavigationService.Navigate(new Bracket2(nom, category));
                }

                else if (category == "System.Windows.Controls.ComboBoxItem: All")
                {
                    category = "All";
                    this.NavigationService.Navigate(new Bracket2(nom, category));
                }
            }


            else if (bracket == "System.Windows.Controls.ComboBoxItem: 4")
            {
                if (category == "System.Windows.Controls.ComboBoxItem: Bronze - Gold")
                {
                    category = "Bronze - Gold";
                    this.NavigationService.Navigate(new Bracket4(nom, category));
                }
                else if (category == "System.Windows.Controls.ComboBoxItem: Platine - Diamants")
                {
                    category = "Platine - Diamand";
                    this.NavigationService.Navigate(new Bracket4(nom, category));
                }
                else if (category == "System.Windows.Controls.ComboBoxItem: Master - Challenger")
                {
                    category = "Master - Challenger";
                    this.NavigationService.Navigate(new Bracket4(nom, category));
                }
                else if (category == "System.Windows.Controls.ComboBoxItem: All")
                {
                    category = "All";
                    this.NavigationService.Navigate(new Bracket4(nom, category));
                }
            }



            else if (bracket == "System.Windows.Controls.ComboBoxItem: 8")
            {
                if (category == "System.Windows.Controls.ComboBoxItem: Bronze - Gold")
                {
                    category = "Bronze - Gold";
                    this.NavigationService.Navigate(new Bracket8(nom, category));
                }
                else if (category == "System.Windows.Controls.ComboBoxItem: Platine - Diamants")
                {
                    category = "Platine - Diamand";
                    this.NavigationService.Navigate(new Bracket8(nom, category));
                }
                else if (category == "System.Windows.Controls.ComboBoxItem: Master - Challenger")
                {
                    category = "Master - Challenger";
                    this.NavigationService.Navigate(new Bracket8(nom, category));
                }

                else if (category == "System.Windows.Controls.ComboBoxItem: All")
                {
                    category = "All";
                    this.NavigationService.Navigate(new Bracket8(nom, category));
                }
            }



            else if (bracket == "System.Windows.Controls.ComboBoxItem: 16")
            {
                if (category == "System.Windows.Controls.ComboBoxItem: Bronze - Gold")
                {
                    category = "Bronze - Gold";
                    this.NavigationService.Navigate(new Bracket16(nom, category));
                }
                else if (category == "System.Windows.Controls.ComboBoxItem: Platine - Diamants")
                {
                    category = "Platine - Diamand";
                    this.NavigationService.Navigate(new Bracket16(nom, category));
                }
                else if (category == "System.Windows.Controls.ComboBoxItem: Master - Challenger")
                {
                    category = "Master - Challenger";
                    this.NavigationService.Navigate(new Bracket16(nom, category));
                }

                else if (category == "System.Windows.Controls.ComboBoxItem: All")
                {
                    category = "All";
                    this.NavigationService.Navigate(new Bracket16(nom, category));
                }
            }
        }
    }
}
