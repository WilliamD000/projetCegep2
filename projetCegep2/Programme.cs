/* Objet   : Programme
 * Date    : 2022/03/27
 * Version : 1.0
 * Auteur  : William Desjardins
 * But: Objet qui représente le programme*/
namespace projetCegep2
{
    public class Programme
    {
        private string numProgramme;

        public string NumProgramme
        {
            get { return numProgramme; }
            set { numProgramme = value; }
        }
        private string nomProgramme;

        public string NomProgramme
        {
            get { return nomProgramme; }
            set { nomProgramme = value; }
        }
        private string dateCreation;

        public string DateCreation
        {
            get { return dateCreation; }
            set { dateCreation = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// Constructeur non paramètré
        /// </summary>
        public Programme()
        {
            numProgramme = "";
            nomProgramme = "";
            dateCreation = "";
            description = "";
        }
        /// <summary>
        /// Constructeur paramètré
        /// </summary>
        /// <param name="unNumProgramme"> Attribut pour l'objet "Numero Programme"</param>
        /// <param name="unNomProgramme"> Attribut pour l'objet "Nom Programme"</param>
        /// <param name="uneDateCreation"> Attribut pour l'objet "Date creation"</param>
        /// <param name="uneDescription"> Attribut pour l'objet "Description"</param>
        public Programme(string unNumProgramme, string unNomProgramme, string uneDateCreation, string uneDescription)
        {
            numProgramme = unNumProgramme;
            nomProgramme = unNomProgramme;
            dateCreation = uneDateCreation;
            description = uneDescription;
        }
        /// <summary>
        /// Permet d'afficher les informations du programme dans la fonction ToString()
        /// </summary>
        /// <returns>Les informations du programme</returns>
        public override string ToString()
        {
           return (NumProgramme + ", " + NomProgramme + ", " + DateCreation + ", " + Description  + "\n\n");
        }
        /// <summary>
        /// Permet d'attitrer un code unique a un objet
        /// </summary>
        /// <returns>Hash Code</returns>
        public override int GetHashCode()
        {
            int x;
            x = NomProgramme.Length + Description.Length;
            return (x);
        }
        /// <summary>
        /// Permet de vérifier si deux objets sont identiques
        /// </summary>
        /// <param name="obj">Valeur à comparer</param>
        /// <returns>Valeur booléene</returns>
        public override bool Equals(object obj)
        {
            return ((obj != null) && (obj is Programme) && NomProgramme.Equals((obj as Programme).NomProgramme));
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
