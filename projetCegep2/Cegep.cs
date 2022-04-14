/* Objet   : Cegep
 * Date    : 2022/03/22
 * Version : 1.0
 * Auteur  : William Desjardins
 * But: Objet qui représente le Cégep*/
using System.Collections.Generic;

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
        public List<Etudiant> listeEtudiant;
        /// <summary>
        /// Constructeur non paramètré
        /// </summary>
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
            listeEtudiant = new List<Etudiant>();
        }
        /// <summary>
        /// Constructeur paramètré
        /// </summary>
        /// <param name="unNom"> Attribut pour l'objet "Nom"</param>
        /// <param name="uneAdresse"> Attribut pour l'objet "Adresse"</param>
        /// <param name="unCodePostal"> Attribut pour l'objet "Code Postal"</param>
        /// <param name="unTelephone"> Attribut pour l'objet "Telephone"</param>
        /// <param name="uneVille"> Attribut pour l'objet "Ville"</param>
        /// <param name="uneProvince"> Attribut pour l'objet "Province"</param>
        /// <param name="unCourriel"> Attribut pour l'objet "Courriel"</param>
        /// <param name="uneAnneeDImplantation"> Attribut pour l'objet "Année d'Implantation"</param>
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
        /// <returns>Liste de programmes dans un tableau</returns>
        public Programme[] ObtenirListeProgramme()
        {
            return listeProgramme.ToArray();
        }
        /// <summary>
        /// Fonction qui retourne le programme désiré
        /// </summary>
        /// <param name="unProgramme">Programme souhaité</param>
        /// <returns>Le programme en question</returns>
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
        /// <param name="unProgramme">Programme à vérifier</param>
        /// <returns>Valeur booléene</returns>
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
        /// Fonction permettant d'ajouter un programme à la liste
        /// </summary>
        /// <param name="unProgramme">Programme à ajouter</param>
        /// <returns>Valeur booléene</returns>
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
        /// <param name="unProgramme">Programme à supprimer</param>
        /// <returns>Valeur booléene</returns>
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
        /// <returns>Nombre de programmes</returns>
        public int ObtenirNombreProgramme()
        {
            return (listeProgramme.Count);
        }
        /// <summary>
        /// Vérifie si la liste de programmes est vide
        /// </summary>
        /// <returns>Valeur booléene</returns>
        public bool SiAucunProgramme()
        {
            return (ObtenirNombreProgramme() == 0);
        }
        /// <summary>
        /// Fonction qui vide la liste de programmes
        /// </summary>
        /// <returns>Valeur booléene</returns>
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
        /// <returns>la liste d'enseignant dans un tableau</returns>
        public Enseignant[] ObtenirListeEnseignant()
        {
            return listeEnseignant.ToArray();
        }
        /// <summary>
        /// Fonction permettant d'obtenir un Enseignant spécifique
        /// </summary>
        /// <param name="unEnseignant">L'enseignant désiré</param>
        /// <returns>L'enseignant désiré</returns>
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
        /// <param name="unEnseignant">Enseignant à vérifier</param>
        /// <returns>Valeur booléene</returns>
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
        /// <param name="unEnseignant">Enseignant à ajouter</param>
        /// <returns>Valeur booléene</returns>
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
        /// <param name="unEnseignant">Enseignant à supprimer</param>
        /// <returns>Valeur booléene</returns>
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
        /// <returns>Le nombre d'enseignants</returns>
        public int ObtenirNombreEnseignant()
        {
            return (listeEnseignant.Count);
        }
        /// <summary>
        /// Vérifie si la liste d'enseignants est vide
        /// </summary>
        /// <returns>Valeur booléene</returns>
        public bool SiAucunEnseignant()
        {
            return (ObtenirNombreEnseignant() == 0);
        }
        /// <summary>
        /// Permet de vider la liste d'enseignants
        /// </summary>
        /// <returns>Valeur booléene</returns>
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
        /// Fonction qui retourne la liste d'étudiants en un tableau
        /// </summary>
        /// <returns>La liste d'étudiants en un tableau</returns>
        public Etudiant[] ObtenirListeEtudiant()
        {
            return listeEtudiant.ToArray();
        }
        /// <summary>
        /// Fonction qui retourne l'étudiant désiré
        /// </summary>
        /// <param name="unEtudiant">L'étudiant souhaité</param>
        /// <returns>L'étudiant désiré</returns>
        public Etudiant ObtenirEtudiant(Etudiant unEtudiant)
        {
            foreach (Etudiant Etudiant in listeEtudiant)
            {
                if (Etudiant.Equals(unEtudiant))
                {
                    return Etudiant;
                }
            }
            return null;
        }
        /// <summary>
        /// Fonction qui vérifie si l'étudiant existe
        /// </summary>
        /// <param name="unEtudiant">L'étudiant à vérifier</param>
        /// <returns>Valeur booléene</returns>
        public bool SiEtudiantPresent(Etudiant unEtudiant)
        {
            foreach (Etudiant etudiant in listeEtudiant)
            {
                if (etudiant.Equals(unEtudiant))
                {
                    return (true);
                }
            }
            return (false);
        }
        /// <summary>
        /// Fonction permettant d'ajouter un étudiant a la liste
        /// </summary>
        /// <param name="unEtudiant">L'étudiant à ajouter</param>
        /// <returns>Valeur booléene</returns>
        public bool AjouterEtudiant(Etudiant unEtudiant)
        {
            if (SiEtudiantPresent(unEtudiant))
            {
                return false;
            }
            listeEtudiant.Add(unEtudiant);
            return SiEtudiantPresent(unEtudiant);
        }
        /// <summary>
        /// Fonction qui supprime un étudiant
        /// </summary>
        /// <param name="unEtudiant">L'étudiant à supprimer</param>
        /// <returns>Valeur booléene</returns>
        public bool EnleverEtudiant(Etudiant unEtudiant)
        {
            if (!SiEtudiantPresent(unEtudiant))
            {
                return (false);
            }
            listeEtudiant.Remove(unEtudiant);
            return (!SiEtudiantPresent(unEtudiant));
        }
        /// <summary>
        /// Retourne le nombre d'étudiants
        /// </summary>
        /// <returns>Le nombre d'étudiants</returns>
        public int ObtenirNombreEtudiant()
        {
            return (listeEtudiant.Count);
        }
        /// <summary>
        /// Vérifie si la liste d'étudiants est vide
        /// </summary>
        /// <returns>Valeur booléene</returns>
        public bool SiAucunEtudiant()
        {
            return (ObtenirNombreEtudiant() == 0);
        }
        /// <summary>
        /// Fonction qui vide la liste d'étudiants
        /// </summary>
        /// <returns>Valeur booléene</returns>
        public bool ViderListeEtudiant()
        {
            if (ObtenirNombreEtudiant() == 0)
            {
                return false;
            }
            listeEtudiant.Clear();
            return SiAucunEtudiant();
        }


        /// <summary>
        /// Permet d'afficher les valeurs désirée dans la méthode .ToString()
        /// </summary>
        /// <returns>Les informations du Cégep</returns>
        public override string ToString()
        {
            return (Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel + ", " + AnneeDImplantation + ", " + "\n\n");
        }
        /// <summary>
        /// Créer un code unique pour un objet
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            int x;
            x = Nom.Length + Adresse.Length;
            return (x);
        }
        /// <summary>
        /// Permet de comparer deux objets pour ne pas avoir de copies
        /// </summary>
        /// <param name="obj">L'objet à comparer</param>
        /// <returns>Valeur booléene</returns>
        public override bool Equals(object obj)
        {
            return ((obj != null) && (obj is Cegep) && Adresse.Equals((obj as Cegep).Adresse));
        }


    
}
}
