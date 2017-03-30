using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsKurs
{
    public class Kurs
    {
        private List<Teilnehmer> listTeilnehmer;
        private String bezeichnung;
        private int count;
        private DateTime datum;
        private int id;

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

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

        public bool Add(Teilnehmer eilnehmer)
        {
            throw new System.NotImplementedException();
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}