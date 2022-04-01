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
        int compteurProgramme=0;
       
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
            MessageBox.Show("Programme enregistré." + monCegep.ToString());

            
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

        }
    }
}
