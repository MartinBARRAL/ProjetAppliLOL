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
    /// Logique d'interaction pour Selectionner_tournoi.xaml
    /// </summary>
    public partial class Bracket4 : Page
    {
        public Bracket4(string Nom4, string category4)
        {
            InitializeComponent();
            afficheNom4.DataContext = new TextboxText() { textdata = Nom4 };
            afficheCategory4.DataContext = new TextboxText() { categorydata = category4 };
        }
    }
}
