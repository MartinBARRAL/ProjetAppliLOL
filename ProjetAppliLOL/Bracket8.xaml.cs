﻿using System;
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
    /// Logique d'interaction pour Bracket8.xaml
    /// </summary>
    public partial class Bracket8 : Page
    {
        public Bracket8(string Nom8, string category8)
        {
            InitializeComponent();

            afficheNom8.DataContext = new TextboxText() { textdata = Nom8};
            afficheCategory8.DataContext = new TextboxText() { categorydata = category8 };
        }

      
    }
}
