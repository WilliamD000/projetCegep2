using System;

namespace projetCegep2
{
    public class Etudiant : Personne
    {
        private int numeroDA;

        public int NumeroDA
        {
            get { return numeroDA; }
            set { numeroDA = value; }
        }
        private bool actif;

        public bool Actif
        {
            get { return actif; }
            set { actif = value; }
        }
        private DateTime dateInscription;

        public DateTime DateInscription
        {
            get { return dateInscription; }
            set { dateInscription = value; }
        }

        /// <summary>
        /// Constructeur non paramètré
        /// </summary>
        public Etudiant()
        {
            numeroDA = 0;
            dateInscription = DateTime.Now;
            actif = false;
        }
        /// <summary>
        /// Constructeur paramètré
        /// </summary>
        /// <param name="unNumeroDA"> Attribut pour l'objet "Numero d'admission"</param>
        /// <param name="uneDateInscription"> Attribut pour l'objet "Date d'inscription"</param>
        /// <param name="siActif"> Attribut pour l'objet "Actif"</param>
        public Etudiant(int unNumeroDA, DateTime uneDateInscription, bool siActif)
        {
            numeroDA = unNumeroDA;
            dateInscription = uneDateInscription;
            actif = siActif;
        }
        /// <summary>
        /// Permet de retourner les informations de l'étudiant dans la méthode .ToString()
        /// </summary>
        /// <returns>Les informations de l'étudiant</returns>
        public override string ToString()
        {
            return (NumeroDA + ", " + Prenom + ", " + Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel + ", Inscrit depuis:" + DateInscription + ", Actif:" + Actif);
        }
        /// <summary>
        /// Permet de donner un code unique à l'étudiant
        /// </summary>
        /// <returns>Hash Code</returns>
        public override int GetHashCode()
        {
            return NumeroDA;
        }
        /// <summary>
        /// Permet d'empêcher la création de copies
        /// </summary>
        /// <param name="obj">L'objet à comparer</param>
        /// <returns>Valeur booléene</returns>
        public override bool Equals(object obj)
        {
            return ((obj != null) && (obj is Etudiant) && NumeroDA.Equals((obj as Etudiant).NumeroDA));
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
