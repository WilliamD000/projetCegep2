﻿using System;
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
            monCegep.Nom = "Cégep de Rivière-du-Loup";
            monCegep.Adresse = "80 rue Frontenac";
            monCegep.Telephone = "(418) 862-6903";
            monCegep.CodePostal = "G5R 1R1";
            monCegep.Ville = "Rivière-du-Loup";
            monCegep.Province = "Québec";
            monCegep.AnneeDImplantation = "1969";
            monCegep.Courriel = "cegep@cegeprdl.ca";
            if (File.Exists("Cegep.xml"))
            {
                MessageBox.Show("Le fichier existe déja");
            }
            else
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
            monCegep.Nom = "Cégep de Rivière-du-Loup";
            monCegep.Adresse = "80 rue Frontenac";
            monCegep.Telephone = "(418) 862-6903";
            monCegep.CodePostal = "G5R 1R1";
            monCegep.Ville = "Rivière-du-Loup";
            monCegep.Province = "Québec";
            monCegep.AnneeDImplantation = "1969";
            monCegep.Courriel = "cegep@cegeprdl.ca";
            MessageBox.Show(monCegep.ToString());
        }
    }
}
