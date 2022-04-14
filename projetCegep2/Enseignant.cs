using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCegep2
{
    public class Enseignant : Personne
    {
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
        /// <summary>
        /// Constructeur non paramètré
        /// </summary>
        public Enseignant()
        {
            dateEmbauche = DateTime.Now;
            dateArret = DateTime.Now;
            numeroEmploye = "";
        }
        /// <summary>
        /// Constructeur paramètré
        /// </summary>
        /// <param name="unPrenom"></param>
        /// <param name="unNom"></param>
        /// <param name="uneAdresse"></param>
        /// <param name="uneVille"></param>
        /// <param name="unCodePostal"></param>
        /// <param name="uneProvince"></param>
        /// <param name="unTelephone"></param>
        /// <param name="unCourriel"></param>
        /// <param name="uneDateEmbauche"></param>
        /// <param name="uneDateArret"></param>
        /// <param name="unNumeroEmploye"></param>
        public Enseignant(DateTime uneDateEmbauche, DateTime uneDateArret, string unNumeroEmploye)
        {
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

        internal Personne Personne
        {
            get => default;
            set
            {
            }
        }
    }
}
