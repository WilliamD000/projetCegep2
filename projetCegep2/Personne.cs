using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCegep2
{
    public class Personne
    {
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

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
        private string courriel;

        public string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }
        public Personne()
        {
            prenom = "";
            nom = "";
            adresse = "";
            ville = "";
            province = "";
            codePostal = "";
            telephone = "";
            courriel = "";
        }
        public Personne(string unPrenom, string unNom, string uneAdresse, string uneVille, string unCodePostal, string uneProvince, string unTelephone, string unCourriel)
        {
            prenom = unPrenom;
            nom = unNom;
            adresse = uneAdresse;
            ville = uneVille;
            province = uneProvince;
            codePostal = unCodePostal;
            telephone = unTelephone;
            courriel = unCourriel;
        }
        public override string ToString()
        {
            return (Prenom + ", " + Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel);
        }
        public override int GetHashCode()
        {
            return (Courriel.Length);
        }
        public override bool Equals(object obj)
        {
            return (obj != null) && (obj is Personne) && Courriel.Equals((obj as Personne).Courriel);
        }
    }
}
