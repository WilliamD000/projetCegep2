/* Nom     : ProjetCégep
 * Date    : 2022/03/15
 * Version : 1.0
 * Auteur  : William Desjardins
 * But: Simuler la gestion d'un cégep et de ses fonctions.*/
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace projetCegep2
{
    public partial class Form1 : Form
    {
        //FileStream fichierLogique;
        Cegep monCegep;
        Programme monProgramme;
        Enseignant unEnseignant;
        Etudiant monEtudiant;
        int compteurProgramme = 0, compteurEnseignant = 0, compteurEtudiant = 0;

        int index = 0;

        XmlSerializer serializer = new XmlSerializer(typeof(Cegep));

        public Form1()
        {
            InitializeComponent();
            OuvrirFichier(compteurProgramme, compteurEnseignant, compteurEtudiant);
        }

        /// <summary>
        /// Bouton permettant de fermer l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Bouton permettant d'enregistrer le fichier xml à la racine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File.WriteAllText("Cegep.xml", "");
            //fichierLogique = File.OpenRead("Cegep.xml");
            //fichierLogique = "Cegep.xml";
            //fichierLogique.Close();
            //serializer.Serialize("Cegep.xml", monCegep);

            using (var writer = new StreamWriter("Cegep.xml"))
            {
                serializer.Serialize(writer, monCegep);
            }
            MessageBox.Show("Programme enregistré.");


        }

        /// <summary>
        /// Bouton permettant d'ouvrir le fichier XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFichier(compteurProgramme, compteurEnseignant, compteurEtudiant);
        }

        /// <summary>
        /// Bouton affichant des informations sur le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monCegep.ToString() + "\n" + monProgramme.ToString() + "/n" + unEnseignant.ToString());
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton permettant à créer le cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerCegep_Click(object sender, EventArgs e)
        {
            monCegep = new Cegep();
            monCegep.Nom = edtNomCegep.Text;
            monCegep.Adresse = edtAdresse.Text;
            monCegep.Telephone = edtTelephone.Text;
            monCegep.CodePostal = edtCodePostal.Text;
            monCegep.Ville = edtVille.Text;
            monCegep.Province = edtProvince.Text;
            monCegep.AnneeDImplantation = edtAnneeDImplantation.Text;
            monCegep.Courriel = edtCourriel.Text;
            btnCreerCegep.Enabled = false;
            compteurProgramme = InitialiserListeProgramme(compteurProgramme);
            compteurEnseignant = InitialiserListeEnseignants(compteurEnseignant);

        }

        /// <summary>
        /// Bouton permettant de créer un programme et de l'ajouter à la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerProgramme_Click(object sender, EventArgs e)
        {
            monProgramme = new Programme();
            monProgramme.NomProgramme = edtNomProgramme.Text;
            monProgramme.NumProgramme = edtNumeroProgramme.Text;
            monProgramme.DateCreation = edtDateCreationProgramme.Text;
            monProgramme.Description = edtDescriptionProgramme.Text;
            if (monCegep.AjouterProgramme(monProgramme) == false)
            {
                MessageBox.Show("Ce programme existe déjà");
            }
            else
            {
                compteurProgramme++;
                monCegep.AjouterProgramme(monProgramme);
                lbxListeProgramme.Items.Add(compteurProgramme.ToString() + monProgramme.ToString());
            }

        }

        /// <summary>
        /// Bouton pour vider la liste de programmes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViderListe_Click(object sender, EventArgs e)
        {
            if (monCegep.ViderListeProgramme() == false)
            {
                MessageBox.Show("Il n'y a aucun programme dans la liste.");
            }
            else
            {
                monCegep.ViderListeProgramme();
                InitialiserListeProgramme(compteurProgramme);
            }
        }

        private void btnArrangerListe_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton pour retirer un programme précis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetirerProgramme_Click(object sender, EventArgs e)
        {
            int nombreARetirer;
            nombreARetirer = int.Parse(edtRetirerProgramme.Text);
            monCegep.EnleverEtudiant(monCegep.ObtenirListeEtudiant()[nombreARetirer - 1]);
            InitialiserListeProgramme(compteurProgramme);
        }

        /// <summary>
        /// Action se déroulant quand l'utilisateur change l'Index du listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxListeProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Programme[] tableauProgramme;
                index = lbxListeProgramme.SelectedIndex;
                tableauProgramme = monCegep.ObtenirListeProgramme();
                edtNomProgramme.Text = tableauProgramme[index].NomProgramme;
                edtNumeroProgramme.Text = tableauProgramme[index].NumProgramme;
                edtDescriptionProgramme.Text = tableauProgramme[index].Description;
                edtDateCreationProgramme.Text = tableauProgramme[index].DateCreation;
                edtRetirerProgramme.Text = (lbxListeProgramme.SelectedIndex + 1).ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Erreur de sélection");
            }

        }

        /// <summary>
        /// Bouton pour vider la liste d'enseignants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViderListeEnseignant_Click(object sender, EventArgs e)
        {
            if (monCegep.ViderListeEnseignant() == false)
            {
                MessageBox.Show("Il n'y a aucun enseignant a retirer.");
            }
            else
            {
                monCegep.ViderListeEnseignant();
                InitialiserListeEnseignants(compteurEnseignant);
            }
        }

        /// <summary>
        /// Bouton permetant de retirer un enseignant précis de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetirerEnseignant_Click(object sender, EventArgs e)
        {
            int nombreARetirer;
            nombreARetirer = int.Parse(edtEnseignantARetirer.Text);
            monCegep.EnleverEtudiant(monCegep.ObtenirListeEtudiant()[nombreARetirer - 1]);
            InitialiserListeEnseignants(compteurEnseignant);
        }

        /// <summary>
        /// Action déclenchée par l'utilisateur au changement de l'Index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxListeEnseignant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                index = lbxListeEnseignant.SelectedIndex;
                edtPrenomEmploye.Text = monCegep.ObtenirListeEnseignant()[index].Prenom;
                edtNomEmploye.Text = monCegep.ObtenirListeEnseignant()[index].Nom;
                edtAdresseEnseignant.Text = monCegep.ObtenirListeEnseignant()[index].Adresse;
                edtCodePostalEnseignant.Text = monCegep.ObtenirListeEnseignant()[index].CodePostal;
                edtTelephoneEnseignant.Text = monCegep.ObtenirListeEnseignant()[index].Telephone;
                edtVilleEnseignant.Text = monCegep.ObtenirListeEnseignant()[index].Ville;
                edtProvinceEnseignant.Text = monCegep.ObtenirListeEnseignant()[index].Province;
                edtCourrielEnseignant.Text = monCegep.ObtenirListeEnseignant()[index].Courriel;
                edtNumeroEmploye.Text = monCegep.ObtenirListeEnseignant()[index].NumeroEmploye;
                dtpDateEmbauche.Value = monCegep.ObtenirListeEnseignant()[index].DateEmbauche;
                dtpDateArret.Value = monCegep.ObtenirListeEnseignant()[index].DateArret;
                edtEnseignantARetirer.Text = (lbxListeEnseignant.SelectedIndex + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de sélection");
            }
        }

        /// <summary>
        /// BOuton permettant d'afficher le premier enseignant de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPremierEnseignant_Click(object sender, EventArgs e)
        {
            lbxListeEnseignant.SelectedIndex = 0;
        }

        /// <summary>
        /// Bouton permettant d'afficher l'enseignant précédent de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrécédentEnseignant_Click(object sender, EventArgs e)
        {
            if (lbxListeEnseignant.SelectedIndex == 0)
            {
                lbxListeEnseignant.SelectedIndex = monCegep.ObtenirNombreEnseignant() - 1;
            }
            else
            {
                index = lbxListeEnseignant.SelectedIndex - 1;
                lbxListeEnseignant.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Bouton permettant d'afficher l'enseignant suivant de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuivantEnseignant_Click(object sender, EventArgs e)
        {
            if (lbxListeEnseignant.SelectedIndex == monCegep.ObtenirNombreEnseignant() - 1)
            {
                lbxListeEnseignant.SelectedIndex = 0;
            }
            else
            {
                int index;
                index = lbxListeEnseignant.SelectedIndex + 1;
                lbxListeEnseignant.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Bouton permettant d'afficher le dernier enseignant de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDernierEnseignant_Click(object sender, EventArgs e)
        {
            lbxListeEnseignant.SelectedIndex = monCegep.ObtenirNombreEnseignant() - 1;
        }

        /// <summary>
        /// Bouton permettant d'afficher le premier programme de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPremierProgramme_Click(object sender, EventArgs e)
        {
            lbxListeProgramme.SelectedIndex = 0;
        }

        /// <summary>
        /// Bouton permettant d'afficher le programme précédent de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrécédentProgramme_Click(object sender, EventArgs e)
        {
            if (lbxListeProgramme.SelectedIndex == 0)
            {
                lbxListeProgramme.SelectedIndex = monCegep.ObtenirNombreProgramme() - 1;
            }
            else
            {
                int index;
                index = lbxListeProgramme.SelectedIndex - 1;
                lbxListeProgramme.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Bouton permettant d'afficher le programme suivant de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuivantProgramme_Click(object sender, EventArgs e)
        {
            if (lbxListeProgramme.SelectedIndex == monCegep.ObtenirNombreProgramme() - 1)
            {
                lbxListeProgramme.SelectedIndex = 0;
            }
            else
            {
                index = lbxListeProgramme.SelectedIndex + 1;
                lbxListeProgramme.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Bouton permettant d'afficher le dernier programme de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDernierProgramme_Click(object sender, EventArgs e)
        {
            lbxListeProgramme.SelectedIndex = monCegep.ObtenirNombreProgramme() - 1;
        }

        /// <summary>
        /// Bouton permettant de modifier l'enseignant sélectionné dans le listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierEnseignant_Click(object sender, EventArgs e)
        {
            index = lbxListeEnseignant.SelectedIndex + 1;
            monCegep.ObtenirListeEnseignant()[index].Prenom = edtPrenomEmploye.Text;
            monCegep.ObtenirListeEnseignant()[index].Nom = edtNomEmploye.Text;
            monCegep.ObtenirListeEnseignant()[index].Adresse = edtAdresseEnseignant.Text;
            monCegep.ObtenirListeEnseignant()[index].CodePostal = edtCodePostalEnseignant.Text;
            monCegep.ObtenirListeEnseignant()[index].Telephone = edtTelephoneEnseignant.Text;
            monCegep.ObtenirListeEnseignant()[index].Ville = edtVilleEnseignant.Text;
            monCegep.ObtenirListeEnseignant()[index].Province = edtProvinceEnseignant.Text;
            monCegep.ObtenirListeEnseignant()[index].Courriel = edtCourrielEnseignant.Text;
            monCegep.ObtenirListeEnseignant()[index].NumeroEmploye = edtNumeroEmploye.Text;
            monCegep.ObtenirListeEnseignant()[index].DateEmbauche = dtpDateEmbauche.Value;
            monCegep.ObtenirListeEnseignant()[index].DateArret = dtpDateArret.Value;
            foreach (Enseignant unEnseignant in monCegep.listeEnseignant)
            {
                compteurEnseignant++;
                lbxListeEnseignant.Items.Add(compteurEnseignant.ToString() + unEnseignant.ToString());
            }
            InitialiserListeEnseignants(compteurEnseignant);
        }

        /// <summary>
        /// Bouton permettant de modifier le programme sélectionné dans le listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierProgramme_Click(object sender, EventArgs e)
        {

            index = lbxListeProgramme.SelectedIndex;
            monCegep.ObtenirListeProgramme()[index].NomProgramme = edtNomProgramme.Text;
            monCegep.ObtenirListeProgramme()[index].NumProgramme = edtNumeroProgramme.Text;
            monCegep.ObtenirListeProgramme()[index].Description = edtDescriptionProgramme.Text;
            monCegep.ObtenirListeProgramme()[index].DateCreation = edtDateCreationProgramme.Text;
            InitialiserListeProgramme(compteurProgramme);
        }

        /// <summary>
        /// Bouton permettant à la création d'un nouvel enseignant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerEnseignant_Click(object sender, EventArgs e)
        {
            unEnseignant = new Enseignant();
            unEnseignant.Prenom = edtPrenomEmploye.Text;
            unEnseignant.Nom = edtNomEmploye.Text;
            unEnseignant.Adresse = edtAdresse.Text;
            unEnseignant.CodePostal = edtCodePostalEnseignant.Text;
            unEnseignant.Telephone = edtTelephoneEnseignant.Text;
            unEnseignant.Ville = edtVilleEnseignant.Text;
            unEnseignant.Province = edtProvinceEnseignant.Text;
            unEnseignant.Courriel = edtCourrielEnseignant.Text;
            unEnseignant.NumeroEmploye = edtNumeroEmploye.Text;
            unEnseignant.DateEmbauche = dtpDateEmbauche.Value;
            unEnseignant.DateArret = dtpDateArret.Value;
            if (monCegep.AjouterEnseignant(unEnseignant) == false)
            {
                MessageBox.Show("Cet enseignant existe déjà");
            }
            else
            {
                compteurEnseignant++;
                monCegep.AjouterEnseignant(unEnseignant);
                lbxListeEnseignant.Items.Add(compteurEnseignant.ToString() + "- " + unEnseignant.ToString());
            }
        }
        /// <summary>
        /// Fonction qui réaffiche la liste de programmes dans le listbox
        /// </summary>
        /// <param name="compteurProgramme">Compteur du nombre de programmes du Cégep</param>
        /// <returns></returns>
        public int InitialiserListeProgramme(int compteurProgramme)
        {

            lbxListeProgramme.Items.Clear();
            compteurProgramme = 0;
            Programme[] tableauProgramme = monCegep.ObtenirListeProgramme();
            foreach (Programme unProgramme in tableauProgramme)
            {
                compteurProgramme++;
                lbxListeProgramme.Items.Add(compteurProgramme.ToString() + "- " + unProgramme.ToString());
            }
            return (compteurProgramme);
        }
        /// <summary>
        /// Fonction qui réaffiche les Enseignants dans le listbox
        /// </summary>
        /// <param name="compteurEnseignant">Compteur du nombre d'enseignants du Cégep</param>
        /// <returns></returns>
        public int InitialiserListeEnseignants(int compteurEnseignant)
        {
            compteurEnseignant = 0;
            lbxListeEnseignant.Items.Clear();
            foreach (Enseignant unEnseignant in monCegep.listeEnseignant)
            {
                compteurEnseignant++;
                lbxListeEnseignant.Items.Add(compteurEnseignant.ToString() + "- " + unEnseignant.ToString());
            }
            return (compteurEnseignant);
        }
        /// <summary>
        /// Fonction qui rempli le listbox avec la liste d'étudiants actuels
        /// </summary>
        /// <param name="compteurEtudiant">Compteur du nombre d'étudiants du Cégep</param>
        /// <returns></returns>
        public int InitialiserListeEtudiant(int compteurEtudiant)
        {
            compteurEtudiant = 0;
            lbxListeEtudiant.Items.Clear();
            foreach (Etudiant unEtudiant in monCegep.listeEtudiant)
            {
                //unEtudiant = new Etudiant();
                compteurEtudiant++;
                lbxListeEtudiant.Items.Add(compteurEtudiant.ToString() + "- " + unEtudiant.ToString());
            }
            return (compteurEtudiant);
        }
        /// <summary>
        /// Bouton permettant de créer un nouvel étudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerEtudiant_Click(object sender, EventArgs e)
        {
            monEtudiant = new Etudiant();

            monEtudiant.Prenom = edtPrenomEtudiant.Text;
            monEtudiant.Nom = edtNomEtudiant.Text;
            monEtudiant.Adresse = edtAdresse.Text;
            monEtudiant.Ville = edtVilleEtudiant.Text;
            monEtudiant.Province = edtProvinceEtudiant.Text;
            monEtudiant.CodePostal = edtCodePostalEtudiant.Text;
            monEtudiant.Telephone = edtTelephoneEtudiant.Text;
            monEtudiant.Courriel = edtCourrielEtudiant.Text;
            monEtudiant.NumeroDA = int.Parse(edtNumeroDA.Text);
            monEtudiant.DateInscription = dtpDateInscription.Value;
            monEtudiant.Actif = cbxActif.Checked;

            if (monCegep.AjouterEtudiant(monEtudiant) == false)
            {
                MessageBox.Show("Cet étudiant existe déja");
            }
            else
            {
                compteurEtudiant++;
                monCegep.AjouterEtudiant(monEtudiant);
                lbxListeEtudiant.Items.Add(compteurEtudiant.ToString() + "- " + monEtudiant.ToString());
            }
        }
        /// <summary>
        /// Bouton permettant de vider la liste d'étudiants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViderListeEtudiant_Click(object sender, EventArgs e)
        {
            if (monCegep.ObtenirNombreEtudiant() == 0)
            {
                MessageBox.Show("La liste est déja vide");
            }
            else
            {
                compteurEtudiant = 0;
                monCegep.ViderListeEtudiant();
            }
        }
        /// <summary>
        /// Bouton permettant de retirer l'étudiant souhaité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetirerEtudiant_Click(object sender, EventArgs e)
        {
            int nombreARetirer;
            nombreARetirer = int.Parse(edtEtudiantARetirer.Text);
            monCegep.EnleverEtudiant(monCegep.ObtenirListeEtudiant()[nombreARetirer - 1]);
            InitialiserListeEtudiant(compteurEtudiant);
        }
        /// <summary>
        /// Bouton permettant de modifier un étudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierEtudiant_Click(object sender, EventArgs e)
        {
            index = lbxListeEtudiant.SelectedIndex + 1;
            monCegep.ObtenirListeEtudiant()[index].Prenom = edtPrenomEtudiant.Text;
            monCegep.ObtenirListeEtudiant()[index].Nom = edtNomEtudiant.Text;
            monCegep.ObtenirListeEtudiant()[index].Adresse = edtAdresseEtudiant.Text;
            monCegep.ObtenirListeEtudiant()[index].CodePostal = edtCodePostalEtudiant.Text;
            monCegep.ObtenirListeEtudiant()[index].Telephone = edtTelephoneEtudiant.Text;
            monCegep.ObtenirListeEtudiant()[index].Ville = edtVilleEtudiant.Text;
            monCegep.ObtenirListeEtudiant()[index].Province = edtProvinceEtudiant.Text;
            monCegep.ObtenirListeEtudiant()[index].Courriel = edtCourrielEtudiant.Text;
            monCegep.ObtenirListeEtudiant()[index].NumeroDA = int.Parse(edtNumeroDA.Text);
            monCegep.ObtenirListeEtudiant()[index].DateInscription = dtpDateInscription.Value;
            monCegep.ObtenirListeEtudiant()[index].Actif = cbxActif.Checked;
            foreach (Etudiant unEtudiant in monCegep.listeEtudiant)
            {
                compteurEtudiant++;
                lbxListeEtudiant.Items.Add(compteurEtudiant.ToString() + unEtudiant.ToString());
            }
            InitialiserListeEtudiant(compteurEtudiant);
        }
        /// <summary>
        /// Bouton qui renvoie l'index au premier étudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPremierEtudiant_Click(object sender, EventArgs e)
        {
            lbxListeEtudiant.SelectedIndex = 0;
        }
        /// <summary>
        /// Bouton qui renvoie l'index à l'étudiant précédent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrecedentEtudiant_Click(object sender, EventArgs e)
        {
            if (lbxListeEtudiant.SelectedIndex == 0)
            {
                lbxListeEtudiant.SelectedIndex = monCegep.ObtenirNombreEnseignant() - 1;
            }
            else
            {
                index = lbxListeEtudiant.SelectedIndex - 1;
                lbxListeEtudiant.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Bouton qui renvoie l'index au prochain étudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuivantEtudiant_Click(object sender, EventArgs e)
        {
            if (lbxListeEtudiant.SelectedIndex == monCegep.ObtenirNombreEtudiant() - 1)
            {
                lbxListeEtudiant.SelectedIndex = 0;
            }
            else
            {
                int index;
                index = lbxListeEtudiant.SelectedIndex + 1;
                lbxListeEtudiant.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Bouton qui renvoie l'index au dernier étudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDernierEtudiant_Click(object sender, EventArgs e)
        {
            lbxListeEtudiant.SelectedIndex = monCegep.ObtenirNombreEtudiant() - 1;
        }
        /// <summary>
        /// Permet de changer les champs d'édition selon l'index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxListeEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                index = lbxListeEtudiant.SelectedIndex;
                edtPrenomEtudiant.Text = monCegep.ObtenirListeEtudiant()[index].Prenom;
                edtNomEtudiant.Text = monCegep.ObtenirListeEtudiant()[index].Nom;
                edtAdresseEtudiant.Text = monCegep.ObtenirListeEtudiant()[index].Adresse;
                edtCodePostalEtudiant.Text = monCegep.ObtenirListeEtudiant()[index].CodePostal;
                edtTelephoneEtudiant.Text = monCegep.ObtenirListeEtudiant()[index].Telephone;
                edtVilleEtudiant.Text = monCegep.ObtenirListeEtudiant()[index].Ville;
                edtProvinceEtudiant.Text = monCegep.ObtenirListeEtudiant()[index].Province;
                edtCourrielEtudiant.Text = monCegep.ObtenirListeEtudiant()[index].Courriel;
                edtNumeroDA.Text = monCegep.ObtenirListeEtudiant()[index].NumeroDA.ToString();
                dtpDateInscription.Value = monCegep.ObtenirListeEtudiant()[index].DateInscription;
                cbxActif.Checked = monCegep.ObtenirListeEtudiant()[index].Actif;
                edtEnseignantARetirer.Text = (lbxListeEnseignant.SelectedIndex + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de sélection");
            }
        }

        /// <summary>
        /// Fonction qui permet d'ouvrir le fichier XML et d'en extraire l'objet Cégep 
        /// </summary>
        /// <param name="compteurProgramme">Compteur du nombre de programmes du Cégep</param>
        /// <param name="compteurEnseignant">Compteur du nombre d'enseignants du Cégep</param>
        /// <param name="compteurEtudiant">Compteur du nombre d'étudiants du Cégep</param>
        public void OuvrirFichier(int compteurProgramme, int compteurEnseignant, int compteurEtudiant)
        {
            monCegep = new Cegep();
            try
            {


                if (File.Exists("Cegep.xml"))
                {
                    serializer = new XmlSerializer(typeof(Cegep));
                    using (StreamReader reader = new StreamReader("Cegep.xml"))
                    {
                        monCegep = (Cegep)serializer.Deserialize(reader);
                    }
                    MessageBox.Show("Programme ouvert.");
                    btnCreerCegep.Enabled = false;
                    InitialiserListeProgramme(compteurProgramme);
                    InitialiserListeEnseignants(compteurEnseignant);
                    InitialiserListeEtudiant(compteurEtudiant);
                }
                else
                {



                }
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }
    }
}
