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
    /// Logique d'interaction pour Bracket16.xaml
    /// </summary>
    public partial class Bracket16 : Page
    {
        public Bracket16(string Nom16, string category16)
        {
            InitializeComponent();
            afficheNom16.DataContext = new TextboxText() { textdata = Nom16 };
            afficheCategory16.DataContext = new TextboxText() { categorydata = category16 };
        }
    }
}
