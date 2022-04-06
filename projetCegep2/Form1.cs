using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
       
        XmlSerializer serializer = new XmlSerializer(typeof(Cegep));
        public Form1()
        {
            InitializeComponent();
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
            //serializer.Serialize("Cegep.xml", monCegep);
            //fichierLogique.Close();
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
            using (StreamReader reader = new StreamReader("Cegep.xml"))
            {
                monCegep = (Cegep)serializer.Deserialize(reader);
            }
            MessageBox.Show("Programme ouvert.");
            lbxListeProgramme.Items.Clear();
            compteurProgramme = 0;
            foreach (Programme unProgramme in monCegep.listeProgramme)
            {
                compteurProgramme++;
                lbxListeProgramme.Items.Add(compteurProgramme.ToString() + unProgramme.ToString());
            }
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
        }
        /// <summary>
        /// BOuton permettant de créer un programme et de l'ajouter à la liste
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
        /// BOuton pour vider la liste de programmes
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
                compteurProgramme = 0;
                monCegep.ViderListeProgramme();
                lbxListeProgramme.Items.Clear();
                foreach (Programme unProgramme in monCegep.listeProgramme)
                {
                    compteurProgramme++;
                    lbxListeProgramme.Items.Add(compteurProgramme.ToString() + unProgramme.ToString());
                }
            }
        }

        private void btnArrangerListe_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// BOuton pour retirer un programme précis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetirerProgramme_Click(object sender, EventArgs e)
        {
            int nombreARetirer;
            nombreARetirer = int.Parse(edtRetirerProgramme.Text);
            monCegep.listeProgramme.RemoveAt(nombreARetirer-1);
            lbxListeProgramme.Items.Clear();
            compteurProgramme = 0;
            foreach (Programme unProgramme in monCegep.listeProgramme)
            {
                compteurProgramme++;
                lbxListeProgramme.Items.Add(compteurProgramme.ToString() + unProgramme.ToString());
            }
        }
        /// <summary>
        /// Action se déroulant quand l'utilisateur change l'Index du listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxListeProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = lbxListeProgramme.SelectedIndex;
            edtNomProgramme.Text = monCegep.ObtenirListeProgramme()[index].NomProgramme;
            edtNumeroProgramme.Text = monCegep.ObtenirListeProgramme()[index].NumProgramme;
            edtDescriptionProgramme.Text = monCegep.ObtenirListeProgramme()[index].Description;
            edtDateCreationProgramme.Text = monCegep.ObtenirListeProgramme()[index].DateCreation;

        }
        /// <summary>
        /// Bouton pour vider la liste d'enseignants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViderListeEnseignant_Click(object sender, EventArgs e)
        {
            if (unEnseignant.ViderListeEnseignant() == false)
            {
                MessageBox.Show("Il n'y a aucun enseignant a retirer.");
            }
            else
            {
                compteurEnseignant = 0;
                unEnseignant.ViderListeEnseignant();
                lbxListeEnseignant.Items.Clear();
                foreach (Enseignant unEnseignant in unEnseignant.listeEnseignant)
                {
                    compteurEnseignant++;
                    lbxListeEnseignant.Items.Add(compteurEnseignant.ToString() + unEnseignant.ToString());
                }
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
            unEnseignant.listeEnseignant.RemoveAt(nombreARetirer - 1);
            lbxListeEnseignant.Items.Clear();
            compteurEnseignant = 0;
            foreach (Enseignant unEnseignant in unEnseignant.listeEnseignant)
            {
                compteurEnseignant++;
                lbxListeEnseignant.Items.Add(compteurEnseignant.ToString() + unEnseignant.ToString());
            }
        }
        /// <summary>
        /// Action déclanchée par l'utilisateur au changement de l'Index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxListeEnseignant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = lbxListeProgramme.SelectedIndex;
            edtPrenomEmploye.Text = unEnseignant.ObtenirListeEnseignant()[index].Prenom;
            edtNomEmploye.Text = unEnseignant.ObtenirListeEnseignant()[index].Nom;
            edtAdresseEnseignant.Text = unEnseignant.ObtenirListeEnseignant()[index].Adresse;
            edtCodePostalEnseignant.Text = unEnseignant.ObtenirListeEnseignant()[index].CodePostal;
            edtTelephoneEnseignant.Text = unEnseignant.ObtenirListeEnseignant()[index].Telephone;
            edtVilleEnseignant.Text = unEnseignant.ObtenirListeEnseignant()[index].Ville;
            edtProvinceEnseignant.Text = unEnseignant.ObtenirListeEnseignant()[index].Province;
            edtCourrielEnseignant.Text = unEnseignant.ObtenirListeEnseignant()[index].Courriel;
            edtNumeroEmploye.Text = unEnseignant.ObtenirListeEnseignant()[index].NumeroEmploye;
            dtpDateEmbauche.Value = unEnseignant.ObtenirListeEnseignant()[index].DateEmbauche;
            dtpDateArret.Value = unEnseignant.ObtenirListeEnseignant()[index].DateArret;

        }
        /// <summary>
        /// BOuton permettant à la création d'un nouvel enseignant
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
            if (unEnseignant.AjouterEnseignant(unEnseignant) == false)
            {
                MessageBox.Show("Cet enseignant existe déjà");
            }
            else
            {
                compteurEnseignant++;
                unEnseignant.AjouterEnseignant(unEnseignant);
                lbxListeEnseignant.Items.Add(compteurEnseignant.ToString() + unEnseignant.ToString());
            }
        }
    }
}
