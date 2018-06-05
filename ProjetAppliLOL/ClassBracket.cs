using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAppliLOL
{
    class ClassBracket
    {
        public string nomTournoi;
        public int nbEquipes;
        public int Classement;

        public ClassBracket() { }

        public ClassBracket(string nomtournois, int nbequipes, int classement)
        {
            this.nomTournoi = nomtournois;
            this.nbEquipes = nbequipes;
            this.Classement = classement;
        }

        public string NomTournois()
        {
            
            return this.nomTournoi;
        }

        public int NbEquipes()
        {

            return this.nbEquipes;
        }

        public int Categorie()
        {

            return this.Classement;
        }
    }

    
}
