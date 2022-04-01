
namespace projetCegep2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreerCegep = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.edtAnneeDImplantation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtCourriel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtProvince = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtVille = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtCodePostal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNomCegep = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.memoListeProgramme = new System.Windows.Forms.RichTextBox();
            this.btnCreerProgramme = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.edtDescriptionProgramme = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edtDateCreationProgramme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.edtNomProgramme = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.edtNumeroProgramme = new System.Windows.Forms.TextBox();
            this.edtRetirerProgramme = new System.Windows.Forms.TextBox();
            this.btnRetirerProgramme = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnViderListe = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.àProposToolStripMenuItem.Text = "À propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(33, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 371);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCreerCegep);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.edtAnneeDImplantation);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.edtCourriel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.edtProvince);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.edtVille);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.edtTelephone);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.edtCodePostal);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.edtAdresse);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.edtNomCegep);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cégep";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnCreerCegep
            // 
            this.btnCreerCegep.Location = new System.Drawing.Point(259, 248);
            this.btnCreerCegep.Name = "btnCreerCegep";
            this.btnCreerCegep.Size = new System.Drawing.Size(86, 39);
            this.btnCreerCegep.TabIndex = 16;
            this.btnCreerCegep.Text = "Créer";
            this.btnCreerCegep.UseVisualStyleBackColor = true;
            this.btnCreerCegep.Click += new System.EventHandler(this.btnCreerCegep_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Année d\'implantation:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // edtAnneeDImplantation
            // 
            this.edtAnneeDImplantation.Location = new System.Drawing.Point(120, 286);
            this.edtAnneeDImplantation.Name = "edtAnneeDImplantation";
            this.edtAnneeDImplantation.Size = new System.Drawing.Size(100, 20);
            this.edtAnneeDImplantation.TabIndex = 14;
            this.edtAnneeDImplantation.Text = "1969";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Courriel:";
            // 
            // edtCourriel
            // 
            this.edtCourriel.Location = new System.Drawing.Point(109, 245);
            this.edtCourriel.Name = "edtCourriel";
            this.edtCourriel.Size = new System.Drawing.Size(111, 20);
            this.edtCourriel.TabIndex = 12;
            this.edtCourriel.Text = "cegep@cegeprdl.ca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Province";
            // 
            // edtProvince
            // 
            this.edtProvince.Location = new System.Drawing.Point(109, 206);
            this.edtProvince.Name = "edtProvince";
            this.edtProvince.Size = new System.Drawing.Size(100, 20);
            this.edtProvince.TabIndex = 10;
            this.edtProvince.Text = "Québec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ville";
            // 
            // edtVille
            // 
            this.edtVille.Location = new System.Drawing.Point(109, 169);
            this.edtVille.Name = "edtVille";
            this.edtVille.Size = new System.Drawing.Size(100, 20);
            this.edtVille.TabIndex = 8;
            this.edtVille.Text = "Rivière-du-Loup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone:";
            // 
            // edtTelephone
            // 
            this.edtTelephone.Location = new System.Drawing.Point(109, 130);
            this.edtTelephone.Name = "edtTelephone";
            this.edtTelephone.Size = new System.Drawing.Size(100, 20);
            this.edtTelephone.TabIndex = 6;
            this.edtTelephone.Text = "(418) 862-6903";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code Postal:";
            // 
            // edtCodePostal
            // 
            this.edtCodePostal.Location = new System.Drawing.Point(109, 92);
            this.edtCodePostal.Name = "edtCodePostal";
            this.edtCodePostal.Size = new System.Drawing.Size(100, 20);
            this.edtCodePostal.TabIndex = 4;
            this.edtCodePostal.Text = "G5R 1R1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresse:";
            // 
            // edtAdresse
            // 
            this.edtAdresse.Location = new System.Drawing.Point(109, 57);
            this.edtAdresse.Name = "edtAdresse";
            this.edtAdresse.Size = new System.Drawing.Size(100, 20);
            this.edtAdresse.TabIndex = 2;
            this.edtAdresse.Text = "80 rue Frontenac";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom:";
            // 
            // edtNomCegep
            // 
            this.edtNomCegep.Location = new System.Drawing.Point(109, 21);
            this.edtNomCegep.Name = "edtNomCegep";
            this.edtNomCegep.Size = new System.Drawing.Size(142, 20);
            this.edtNomCegep.TabIndex = 0;
            this.edtNomCegep.Text = "Cégep de Rivière-du-Loup";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnViderListe);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnRetirerProgramme);
            this.tabPage2.Controls.Add(this.edtRetirerProgramme);
            this.tabPage2.Controls.Add(this.memoListeProgramme);
            this.tabPage2.Controls.Add(this.btnCreerProgramme);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.edtDescriptionProgramme);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.edtDateCreationProgramme);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.edtNomProgramme);
            this.tabPage2.Controls.Add(this.label);
            this.tabPage2.Controls.Add(this.edtNumeroProgramme);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Programme";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // memoListeProgramme
            // 
            this.memoListeProgramme.Location = new System.Drawing.Point(458, 22);
            this.memoListeProgramme.Name = "memoListeProgramme";
            this.memoListeProgramme.Size = new System.Drawing.Size(219, 274);
            this.memoListeProgramme.TabIndex = 9;
            this.memoListeProgramme.Text = "";
            // 
            // btnCreerProgramme
            // 
            this.btnCreerProgramme.Location = new System.Drawing.Point(46, 199);
            this.btnCreerProgramme.Name = "btnCreerProgramme";
            this.btnCreerProgramme.Size = new System.Drawing.Size(85, 35);
            this.btnCreerProgramme.TabIndex = 8;
            this.btnCreerProgramme.Text = "Créer";
            this.btnCreerProgramme.UseVisualStyleBackColor = true;
            this.btnCreerProgramme.Click += new System.EventHandler(this.btnCreerProgramme_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Description:";
            // 
            // edtDescriptionProgramme
            // 
            this.edtDescriptionProgramme.Location = new System.Drawing.Point(137, 147);
            this.edtDescriptionProgramme.Name = "edtDescriptionProgramme";
            this.edtDescriptionProgramme.Size = new System.Drawing.Size(100, 20);
            this.edtDescriptionProgramme.TabIndex = 6;
            this.edtDescriptionProgramme.Text = "Informatique";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Date de création du programme:";
            // 
            // edtDateCreationProgramme
            // 
            this.edtDateCreationProgramme.Location = new System.Drawing.Point(208, 111);
            this.edtDateCreationProgramme.Name = "edtDateCreationProgramme";
            this.edtDateCreationProgramme.Size = new System.Drawing.Size(100, 20);
            this.edtDateCreationProgramme.TabIndex = 4;
            this.edtDateCreationProgramme.Text = "1980";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nom de Programme:";
            // 
            // edtNomProgramme
            // 
            this.edtNomProgramme.Location = new System.Drawing.Point(152, 74);
            this.edtNomProgramme.Name = "edtNomProgramme";
            this.edtNomProgramme.Size = new System.Drawing.Size(156, 20);
            this.edtNomProgramme.TabIndex = 2;
            this.edtNomProgramme.Text = "Techniques de l\'informatique";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(43, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Numéro de Programme:";
            // 
            // edtNumeroProgramme
            // 
            this.edtNumeroProgramme.Location = new System.Drawing.Point(167, 39);
            this.edtNumeroProgramme.Name = "edtNumeroProgramme";
            this.edtNumeroProgramme.Size = new System.Drawing.Size(100, 20);
            this.edtNumeroProgramme.TabIndex = 0;
            this.edtNumeroProgramme.Text = "420.B0";
            // 
            // edtRetirerProgramme
            // 
            this.edtRetirerProgramme.Location = new System.Drawing.Point(228, 247);
            this.edtRetirerProgramme.Name = "edtRetirerProgramme";
            this.edtRetirerProgramme.Size = new System.Drawing.Size(100, 20);
            this.edtRetirerProgramme.TabIndex = 10;
            this.edtRetirerProgramme.Text = "1";
            // 
            // btnRetirerProgramme
            // 
            this.btnRetirerProgramme.Location = new System.Drawing.Point(228, 274);
            this.btnRetirerProgramme.Name = "btnRetirerProgramme";
            this.btnRetirerProgramme.Size = new System.Drawing.Size(75, 23);
            this.btnRetirerProgramme.TabIndex = 11;
            this.btnRetirerProgramme.Text = "Retirer";
            this.btnRetirerProgramme.UseVisualStyleBackColor = true;
            this.btnRetirerProgramme.Click += new System.EventHandler(this.btnRetirerProgramme_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Chiffre du programme à retirer:";
            // 
            // btnViderListe
            // 
            this.btnViderListe.Location = new System.Drawing.Point(46, 272);
            this.btnViderListe.Name = "btnViderListe";
            this.btnViderListe.Size = new System.Drawing.Size(75, 23);
            this.btnViderListe.TabIndex = 13;
            this.btnViderListe.Text = "Vider la liste";
            this.btnViderListe.UseVisualStyleBackColor = true;
            this.btnViderListe.Click += new System.EventHandler(this.btnViderListe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtTelephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtCodePostal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtAdresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNomCegep;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreerCegep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtAnneeDImplantation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtCourriel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtProvince;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtVille;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox edtDescriptionProgramme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edtDateCreationProgramme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtNomProgramme;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox edtNumeroProgramme;
        private System.Windows.Forms.Button btnCreerProgramme;
        private System.Windows.Forms.RichTextBox memoListeProgramme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRetirerProgramme;
        private System.Windows.Forms.TextBox edtRetirerProgramme;
        private System.Windows.Forms.Button btnViderListe;
    }
}

