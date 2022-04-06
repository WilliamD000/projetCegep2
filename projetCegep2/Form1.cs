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

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monCegep.ToString() + "\n" + monProgramme.ToString());
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

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

        private void lbxListeProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = lbxListeProgramme.SelectedIndex;
              monCegep.ObtenirListeProgramme()[index].NomProgramme = edtNomProgramme.Text;
            monCegep.ObtenirListeProgramme()[index].NumProgramme = edtNumeroProgramme.Text;
            monCegep.ObtenirListeProgramme()[index].Description = edtDescriptionProgramme.Text;
            monCegep.ObtenirListeProgramme()[index].DateCreation = edtDateCreationProgramme.Text;

        }

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
