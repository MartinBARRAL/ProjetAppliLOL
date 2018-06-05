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
    /// Logique d'interaction pour Bracket2.xaml
    /// </summary>
    public partial class Bracket2 : Page
    {
        public Bracket2(string Nom2, string category2)
        {
            InitializeComponent();
            afficheNom2.DataContext = new TextboxText() { textdata = Nom2 };
            afficheCategory2.DataContext = new TextboxText() { categorydata = category2 };
        }
    }
}
