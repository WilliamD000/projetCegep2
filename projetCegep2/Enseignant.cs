using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCegep2
{
    public class Enseignant
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
        private DateTime dateEmbauche;

        public DateTime DateEmbauche
        {
            get { return dateEmbauche; }
            set { dateEmbauche = value; }
        }
        private DateTime dateArret;

        public DateTime DateArret
        {
            get { return dateArret; }
            set { dateArret = value; }
        }
        private string numeroEmploye;

        public string NumeroEmploye
        {
            get { return numeroEmploye; }
            set { numeroEmploye = value; }
        }
       
        public Enseignant()
        {
            prenom = "";
            nom = "";
            adresse = "";
            ville = "";
            province = "";
            codePostal = "";
            telephone = "";
            courriel = "";
            dateEmbauche = DateTime.Now;
            dateArret = DateTime.Now;
            numeroEmploye = "";
        }
        public Enseignant(string unPrenom, string unNom, string uneAdresse, string uneVille, string unCodePostal, string uneProvince, string unTelephone, string unCourriel, DateTime uneDateEmbauche, DateTime uneDateArret, string unNumeroEmploye)
        {
            prenom = unPrenom;
            nom = unNom;
            adresse = uneAdresse;
            ville = uneVille;
            province = uneProvince;
            codePostal = unCodePostal;
            telephone = unTelephone;
            courriel = unCourriel;
            dateEmbauche = uneDateEmbauche;
            dateArret = uneDateArret;
            numeroEmploye = unNumeroEmploye;
        }
        

        /// <summary>
        /// Permet d'Afficher les informations de l'enseignant dans la méthode ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (NumeroEmploye + ", " + Prenom + ", " + Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel + ", " + "\n\n");
        }
        /// <summary>
        /// Permet de donner un code unique à l'enseignant
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int x;
            x = Nom.Length + Adresse.Length;
            return (x);
        }
        /// <summary>
        /// Permet d'empêcher la création de copies
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return ((obj != null) && (obj is Enseignant) && NumeroEmploye.Equals((obj as Enseignant).NumeroEmploye));
        }

        public Cegep Cegep
        {
            get => default;
            set
            {
            }
        }
    }
}
