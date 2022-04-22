/* Objet   : Enseignant
 * Date    : 2022/03/27
 * Version : 1.0
 * Auteur  : William Desjardins
 * But: Objet qui représente un Enseignant*/
using System;

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
        /// <param name="uneDateEmbauche"> Attribut pour l'objet "Date d'embauche"</param>
        /// <param name="uneDateArret"> Attribut pour l'objet "Date d'arret"</param>
        /// <param name="unNumeroEmploye"> Attribut pour l'objet "Numero d'employe"</param>
        public Enseignant(DateTime uneDateEmbauche, DateTime uneDateArret, string unNumeroEmploye)
        {
            dateEmbauche = uneDateEmbauche;
            dateArret = uneDateArret;
            numeroEmploye = unNumeroEmploye;
        }


        /// <summary>
        /// Permet d'afficher les informations de l'enseignant dans la méthode ToString()
        /// </summary>
        /// <returns>Informations de l'enseignant</returns>
        public override string ToString()
        {
            return (NumeroEmploye + ", " + Prenom + ", " + Nom + ", " + Adresse + ", \n" + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel + ", " + "\n\n");
        }
        /// <summary>
        /// Permet de donner un code unique à l'enseignant
        /// </summary>
        /// <returns>Hash Code</returns>
        public override int GetHashCode()
        {
            int x;
            x = Nom.Length + Adresse.Length;
            return (x);
        }
        /// <summary>
        /// Permet d'empêcher la création de copies
        /// </summary>
        /// <param name="obj">L'objet à comparer</param>
        /// <returns>Valeur booléene</returns>
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
