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
            int bracket = Convert.ToInt32(comboBox1.SelectedItem);
            int category = Convert.ToInt32(comboBox.SelectedItem);
            ClassBracket value = new ClassBracket(nom,bracket,category);
            if (bracket == 2)
            this.NavigationService.Navigate(new Bracket2());
            else if (bracket == 4)
                this.NavigationService.Navigate(new Bracket4());
            else if (bracket == 8)
                this.NavigationService.Navigate(new Bracket8());
            else if (bracket == 16)
                this.NavigationService.Navigate(new Bracket16());
        }
    }
}
