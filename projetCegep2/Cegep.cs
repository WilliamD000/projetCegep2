using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
namespace projetCegep2
{
    public class Cegep : Programme
    {
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
        private string courriel;

        public string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }
        private string anneeDImplentation;

        public string AnneeDImplantation
        {
            get { return anneeDImplentation; }
            set { anneeDImplentation = value; }
        }

        public List<Programme> listeProgramme;
        public List<Enseignant> listeEnseignant;

        public Cegep()
        {
            nom = "";
            adresse = "";
            codePostal = "";
            telephone = "";
            ville = "";
            province = "";
            courriel = "";
            anneeDImplentation = "";
            listeProgramme = new List<Programme>();
            listeEnseignant = new List<Enseignant>();
        }
        public Cegep(string unNom, string uneAdresse, string unCodePostal, string unTelephone, string uneVille, string uneProvince, string unCourriel, string uneAnneeDImplantation)
        {
            nom = unNom;
            adresse = uneAdresse;
            codePostal = unCodePostal;
            telephone = unTelephone;
            ville = uneVille;
            province = uneProvince;
            courriel = unCourriel;
            anneeDImplentation = uneAnneeDImplantation;
            listeProgramme = new List<Programme>();
            listeEnseignant = new List<Enseignant>();
        }
        /// <summary>
        /// Fonction qui retourne la liste de programme en un tableau
        /// </summary>
        /// <returns></returns>
        public Programme[] ObtenirListeProgramme()
        {
            return listeProgramme.ToArray();
        }
        /// <summary>
        /// Fonction qui retourne le programme désiré
        /// </summary>
        /// <param name="unProgramme"></param>
        /// <returns></returns>
        public Programme ObtenirProgramme(Programme unProgramme)
        {
            foreach (Programme programme in listeProgramme)
            {
                if (programme.Equals(unProgramme))
                {
                    return programme;
                }
            }
            return null;
        }
        /// <summary>
        /// Fonction qui vérifie si le programme existe
        /// </summary>
        /// <param name="unProgramme"></param>
        /// <returns></returns>
        public bool SiProgrammePresent(Programme unProgramme)
        {
            foreach (Programme programme in listeProgramme)
            {
                if (programme.Equals(unProgramme))
                {
                    return (true);
                }
            }
            return (false);
        }
        /// <summary>
        /// FOnction permettant d'ajouter un programme a la liste
        /// </summary>
        /// <param name="unProgramme"></param>
        /// <returns></returns>
        public bool AjouterProgramme(Programme unProgramme)
        {
            if (SiProgrammePresent(unProgramme))
            {
                return false;
            }
            listeProgramme.Add(unProgramme);
            return SiProgrammePresent(unProgramme);
        }
        /// <summary>
        /// Fonction qui supprime un programme
        /// </summary>
        /// <param name="unProgramme"></param>
        /// <returns></returns>
        public bool EnleverProgramme(Programme unProgramme)
        {
            if (!SiProgrammePresent(unProgramme))
            {
                return (false);
            }
            listeProgramme.Remove(unProgramme);
            return (!SiProgrammePresent(unProgramme));
        }
        /// <summary>
        /// Retourne le nombre de programme
        /// </summary>
        /// <returns></returns>
        public int ObtenirNombreProgramme()
        {
            return (listeProgramme.Count);
        }
        /// <summary>
        /// Vérifie si la liste de programmes est vide
        /// </summary>
        /// <returns></returns>
        public bool SiAucunProgramme()
        {
            return (ObtenirNombreProgramme() == 0);
        }
        /// <summary>
        /// Fonction qui vide la liste de programmes
        /// </summary>
        /// <returns></returns>
        public bool ViderListeProgramme()
        {
            if (ObtenirNombreProgramme() == 0)
            {
                return false;
            }
            listeProgramme.Clear();
            return SiAucunProgramme();
        }
        /// <summary>
        /// Fonction qui transforme la liste d'enseignants en un tableau
        /// </summary>
        /// <returns></returns>
        public Enseignant[] ObtenirListeEnseignant()
        {
            return listeEnseignant.ToArray();
        }
        /// <summary>
        /// Fonction permettant d'obtenir un Enseignant spécifique
        /// </summary>
        /// <param name="unEnseignant"></param>
        /// <returns></returns>
        public Enseignant ObtenirEnseignant(Enseignant unEnseignant)
        {
            foreach (Enseignant enseignant in listeEnseignant)
            {
                if (enseignant.Equals(unEnseignant))
                {
                    return enseignant;
                }
            }
            return null;
        }
        /// <summary>
        /// Fonction qui vérifie si un enseignant existe
        /// </summary>
        /// <param name="unEnseignant"></param>
        /// <returns></returns>
        public bool SiEnseignantPresent(Enseignant unEnseignant)
        {
            foreach (Enseignant enseignant in listeEnseignant)
            {
                if (enseignant.Equals(unEnseignant))
                {
                    return (true);
                }
            }
            return (false);
        }
        /// <summary>
        /// Fonction qui crée un enseignant
        /// </summary>
        /// <param name="unEnseignant"></param>
        /// <returns></returns>
        public bool AjouterEnseignant(Enseignant unEnseignant)
        {
            if (SiEnseignantPresent(unEnseignant))
            {
                return false;
            }
            listeEnseignant.Add(unEnseignant);
            return SiEnseignantPresent(unEnseignant);
        }
        /// <summary>
        /// Fonction qui supprime un enseignant
        /// </summary>
        /// <param name="unEnseignant"></param>
        /// <returns></returns>
        public bool EnleverEnseignant(Enseignant unEnseignant)
        {
            if (!SiEnseignantPresent(unEnseignant))
            {
                return (false);
            }
            listeEnseignant.Remove(unEnseignant);
            return (!SiEnseignantPresent(unEnseignant));
        }
        /// <summary>
        /// Retourne le nombre d'enseignants
        /// </summary>
        /// <returns></returns>
        public int ObtenirNombreEnseignant()
        {
            return (listeEnseignant.Count);
        }
        /// <summary>
        /// VÉrifie si la liste d'enseignants est vide
        /// </summary>
        /// <returns></returns>
        public bool SiAucunEnseignant()
        {
            return (ObtenirNombreEnseignant() == 0);
        }
        /// <summary>
        /// Permet de vider la liste d'enseignants
        /// </summary>
        /// <returns></returns>
        public bool ViderListeEnseignant()
        {
            if (ObtenirNombreEnseignant() == 0)
            {
                return false;
            }
            listeEnseignant.Clear();
            return SiAucunEnseignant();
        }

        

        /// <summary>
        /// Permet d'afficher les valeurs désirée dans la méthode .ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel + ", " + AnneeDImplantation + ", " + "\n\n");
        }
        /// <summary>
        /// Créer un code unique pour un objet
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int x;
            x = Nom.Length + Adresse.Length;
            return (x);
        }
        /// <summary>
        /// Permet de comparer deux objets pour ne pas avoir de copies
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return ((obj != null) && (obj is Cegep) && Adresse.Equals((obj as Cegep).Adresse));
        }


    
}
}
