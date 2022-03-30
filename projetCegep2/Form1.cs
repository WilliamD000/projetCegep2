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
        Cegep monCegep = new Cegep();
        Programme monProgramme = new Programme();
        List<Programme> listeProgramme;
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
            File.WriteAllText("Cegep.xml", "");
            //fichierLogique = File.OpenRead("Cegep.xml");
            //fichierLogique = "Cegep.xml";
            //serializer.Serialize("Cegep.xml", monCegep);
            using (var writer = new StreamWriter("Cegep.xml"))
            {
                serializer.Serialize(writer, monCegep);
            }
            
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("Cegep.xml"))
            {
                monCegep = (Cegep)serializer.Deserialize(reader);
            }
            MessageBox.Show(monCegep.ToString());
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
            listeProgramme = new List<Programme>();
            monProgramme.NomProgramme = edtNomProgramme.Text;
            monProgramme.NumProgramme = edtNumeroProgramme.Text;
            monProgramme.DateCreation = edtDateCreationProgramme.Text;
            monProgramme.Description = edtDescriptionProgramme.Text;
            listeProgramme.Add(monProgramme);
        }
    }
}
