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

        public List<Programme> listeProgramme;

        public Cegep()
        {
            nom = "";
            adresse = "";
            codePostal = "";
            telephone = "";
            ville = "";
            province = "";
            courriel = "";
            anneeDImplentation = "";
            listeProgramme = new List<Programme>();
        }
        public Cegep(string unNom, string uneAdresse, string unCodePostal, string unTelephone, string uneVille, string uneProvince, string unCourriel, string uneAnneeDImplantation)
        {
            nom = unNom;
            adresse = uneAdresse;
            codePostal = unCodePostal;
            telephone = unTelephone;
            ville = uneVille;
            province = uneProvince;
            courriel = unCourriel;
            anneeDImplentation = uneAnneeDImplantation;
            listeProgramme = new List<Programme>();
        }
        public Programme[] ObtenirListeProgramme()
        {
            return listeProgramme.ToArray();
        }
        public Programme ObtenirProgramme(Programme unProgramme)
        {
            foreach (Programme programme in listeProgramme)
            {
                if (programme.Equals(unProgramme))
                {
                    return programme;
                }
            }
            return null;
        }
        public bool SiProgrammePresent(Programme unProgramme)
        {
            foreach (Programme programme in listeProgramme)
            {
                if (programme.Equals(unProgramme))
                {
                    return (true);
                }
            }
            return (false);
        }
        public bool AjouterProgramme(Programme unProgramme)
        {
            if (SiProgrammePresent(unProgramme))
            {
                return false;
            }
            listeProgramme.Add(unProgramme);
            return SiProgrammePresent(unProgramme);
        }
        public bool EnleverProgramme(Programme unProgramme)
        {
            if (!SiProgrammePresent(unProgramme))
            {
                return (false);
            }
            listeProgramme.Remove(unProgramme);
            return (!SiProgrammePresent(unProgramme));
        }
        public int ObtenirNombreProgramme()
        {
            return (listeProgramme.Count);
        }
        public bool SiAucunProgramme()
        {
            return (ObtenirNombreProgramme() == 0);
        }
        public bool ViderListeProgramme()
        {
            if (ObtenirNombreProgramme() == 0)
            {
                return false;
            }
            listeProgramme.Clear();
            return SiAucunProgramme();
        }


        public override string ToString()
        {
            return (Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel + ", " + AnneeDImplantation + ", " + "\n\n");
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
