﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCegep2
{
    class Programme
    {
        private string numProgramme;

        public string NumProgramme
        {
            get { return numProgramme; }
            set { numProgramme = value; }
        }
        private string nomProgramme;

        public string NomProgramme
        {
            get { return nomProgramme; }
            set { nomProgramme = value; }
        }
        private string dateCreation;

        public string DateCreation
        {
            get { return dateCreation; }
            set { dateCreation = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


    }
}