using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Permet d'afficher les informations du programme dans la fonction ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
           return ("-  " + NumProgramme + ", " + NomProgramme + ", " + DateCreation + ", " + Description  + "\n\n");
        }
        /// <summary>
        /// Permet d'attitrer un code unique a un objet
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int x;
            x = NomProgramme.Length + Description.Length;
            return (x);
        }
        /// <summary>
        /// Permet de vérifier si deux objets sont identiques
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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
