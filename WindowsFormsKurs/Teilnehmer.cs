using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsKurs
{
    public class Teilnehmer
    {
        private int id;
        private string nachname;
        private string vorname;
        private string email;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                nachname = value;
            }
        }

        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}