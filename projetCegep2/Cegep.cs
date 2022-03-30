using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCegep2
{
    public class Cegep : Programme
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        private string codePostal;

        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        private string ville;

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        private string province;

        public string Province
        {
            get { return province; }
            set { province = value; }
        }
        private string courriel;

        public string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }
        private string anneeDImplentation;

        public string AnneeDImplantation
        {
            get { return anneeDImplentation; }
            set { anneeDImplentation = value; }
        }


        public override string ToString()
        {
            return ("-  " + Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel + ", " + AnneeDImplantation + NumProgramme + ", " + NomProgramme + ", " + DateCreation + ", " + Description + "\n\n");
        }
        public override int GetHashCode()
        {
            int x;
            x = Nom.Length + Adresse.Length;
            return (x);
        }
        public override bool Equals(object obj)
        {
            return ((obj != null) && (obj is Cegep) && Adresse.Equals((obj as Cegep).Adresse));
        }


    
}
}
