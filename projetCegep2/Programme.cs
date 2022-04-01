using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCegep2
{
    public class Programme
    {
        Cegep monCegep;
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

        public override string ToString()
        {
            int x;
            //x = monCegep.listeProgramme.Count();
            return ("-  " + NumProgramme + ", " + NomProgramme + ", " + DateCreation + ", " + Description  + "\n\n");
        }
        public override int GetHashCode()
        {
            int x;
            x = NomProgramme.Length + Description.Length;
            return (x);
        }
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
