/* Nom     : ProjetCégep
 * Date    : 2022/03/15
 * Version : 1.0
 * Auteur  : William Desjardins
 * But: Simuler la gestion d'un cégep et de ses fonctions.*/
using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace projetCegep2
{
    public partial class Form1 : Form
    {
        //FileStream fichierLogique;
        Cegep monCegep;
        Programme monProgramme;
        int compteurProgramme=0, compteurEnseignant=0;
        Enseignant unEnseignant;
        int index=0;

        XmlSerializer serializer = new XmlSerializer(typeof(Cegep));

        public Form1()
        {
            InitializeComponent();
            OuvrirFichier(compteurProgramme, compteurEnseignant);
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
            OuvrirFichier(compteurProgramme, compteurEnseignant);
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
            InitialiserListeProgramme(compteurProgramme);
            InitialiserListeEnseignants(compteurEnseignant);
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
            monCegep.listeProgramme.RemoveAt(nombreARetirer-1);
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
            monCegep.listeEnseignant.RemoveAt(nombreARetirer - 1);
            lbxListeEnseignant.Items.RemoveAt(nombreARetirer);
            compteurEnseignant--;
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
            if (lbxListeEnseignant.SelectedIndex==0)
            {
                lbxListeEnseignant.SelectedIndex = monCegep.ObtenirNombreEnseignant() + 1;
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
            if (lbxListeEnseignant.SelectedIndex == monCegep.ObtenirNombreEnseignant()+1)
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
            lbxListeEnseignant.SelectedIndex = monCegep.ObtenirNombreEnseignant() + 1;
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
                lbxListeProgramme.SelectedIndex = monCegep.ObtenirNombreProgramme() + 1;
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
            if (lbxListeProgramme.SelectedIndex == monCegep.ObtenirNombreProgramme() + 1)
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
            lbxListeProgramme.SelectedIndex = monCegep.ObtenirNombreProgramme() + 1;
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
            monCegep.ObtenirListeEnseignant()[index].Nom = edtNomEmploye.Text ;
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
        public int InitialiserListeProgramme(int compteurProgramme)
        {
            lbxListeProgramme.Items.Clear();
            compteurProgramme = 0;
            Programme[] tableauProgramme = monCegep.ObtenirListeProgramme();
            foreach (Programme unProgramme in tableauProgramme)
            {
                compteurProgramme++;
                lbxListeProgramme.Items.Add(compteurProgramme.ToString() + unProgramme.ToString());
            }
            return (compteurProgramme);
        }
        public int InitialiserListeEnseignants(int compteurEnseignant)
        {
            compteurEnseignant = 0;
            lbxListeEnseignant.Items.Clear();
            foreach (Enseignant unEnseignant in monCegep.listeEnseignant)
            {
                compteurEnseignant++;
                lbxListeEnseignant.Items.Add(compteurEnseignant.ToString() + unEnseignant.ToString());
            }
            return (compteurEnseignant);
        }

        public void OuvrirFichier(int compteurProgramme, int compteurEnseignant)
        {
            serializer = new XmlSerializer(typeof(Cegep));
            using (StreamReader reader = new StreamReader("Cegep.xml"))
            {
                monCegep = (Cegep)serializer.Deserialize(reader);
            }
            MessageBox.Show("Programme ouvert.");
            lbxListeProgramme.Items.Clear();
            compteurProgramme = 0;
            Programme[] tableauProgramme = monCegep.ObtenirListeProgramme();
            foreach (Programme unProgramme in tableauProgramme)
            {
                compteurProgramme++;
                lbxListeProgramme.Items.Add(compteurProgramme.ToString() + unProgramme.ToString());
            }
            compteurEnseignant = 0;
            lbxListeEnseignant.Items.Clear();
            foreach (Enseignant unEnseignant in monCegep.listeEnseignant)
            {
                compteurEnseignant++;
                lbxListeEnseignant.Items.Add(compteurEnseignant.ToString() + unEnseignant.ToString());
            }
        }
    }
}
