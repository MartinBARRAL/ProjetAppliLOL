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
       
        public string Classement;

        public ClassBracket() { }

        public ClassBracket(string nomtournois, string classement)
        {
            this.nomTournoi = nomtournois;
          
            this.Classement = classement;
        }

        public string NomTournois()
        {
            
            return this.nomTournoi;
        }

        public string Categorie()
        {

            return this.Classement;
        }
    }

    
}
