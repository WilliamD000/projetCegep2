using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public Etudiant()
        {
            numeroDA = 0;
            dateInscription = DateTime.Now;
            actif = false;
        }

        public Etudiant(int unNumeroDA, DateTime uneDateInscription, bool siActif)
        {
            numeroDA = unNumeroDA;
            dateInscription = uneDateInscription;
            actif = siActif;
        }

        public override string ToString()
        {
            return (NumeroDA + ", Inscrit depuis:" + DateInscription + ", Actif:" + Actif);
        }

        public override int GetHashCode()
        {
            return NumeroDA;
        }
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
