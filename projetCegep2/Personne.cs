

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
        /// <summary>
        /// Constructeur non paramètré
        /// </summary>
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
        /// <summary>
        /// Constructeur paramètré
        /// </summary>
        /// <param name="unPrenom">Attribut pour l'objet "Prénom"</param>
        /// <param name="unNom">Attribut pour l'objet "Nom"</param>
        /// <param name="uneAdresse">Attribut pour l'objet "Adresse"</param>
        /// <param name="uneVille">Attribut pour l'objet "Ville"</param>
        /// <param name="unCodePostal">Attribut pour l'objet "Code Postal"</param>
        /// <param name="uneProvince">Attribut pour l'objet "Province"</param>
        /// <param name="unTelephone">Attribut pour l'objet "Telephone"</param>
        /// <param name="unCourriel">Attribut pour l'objet "Courriel"</param>
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
        /// <summary>
        /// Permet d'afficher les informations de la personne dans la méthode ToString()
        /// </summary>
        /// <returns>Informations de la personne</returns>
        public override string ToString()
        {
            return (Prenom + ", " + Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel);
        }
        /// <summary>
        /// Permet de donner un code unique à l'enseignant
        /// </summary>
        /// <returns>Hash Code</returns>
        public override int GetHashCode()
        {
            return (Courriel.Length);
        }
        /// <summary>
        /// Permet d'empêcher la création de copies
        /// </summary>
        /// <param name="obj">L'objet à comparer</param>
        /// <returns>Valeur booléene</returns>
        public override bool Equals(object obj)
        {
            return (obj != null) && (obj is Personne) && Courriel.Equals((obj as Personne).Courriel);
        }
    }
}
