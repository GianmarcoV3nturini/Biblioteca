using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private DateTime _annoPubblicazione;
        private string _editore;
        private int _nPagine;

        public Libro(string autore,string titolo,DateTime anno,string editore,int pagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = anno;
            Editore = editore;
            NPagine = pagine;
        }

        public int NPagine
        {
            get { return _nPagine; }
            set
            {
                if(value<= 0)
                    throw new Exception("dato non valido");
                _nPagine = value;
            }
        }

        public DateTime AnnoPubblicazione
        {
            get { return _annoPubblicazione; }
            set
            {             
                _annoPubblicazione = value;
            }
        }
        public string Editore
        {
            get { return _editore; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("dato non valido");
                _editore = value;
            }
        }
        public string Titolo
        {
            get { return _titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("dato non valido");
                _titolo = value;
            }
        }
        public string Autore
        {
            get { return _autore; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("dato non valido");
                _autore = value;
            }
        }

        public override string ToString()
        {
            return Autore + Titolo + AnnoPubblicazione + Editore + NPagine;
        }

        public int ReadingTime()
        {
            int ore = 0;
            if (NPagine < 100)
                ore = 1;
            else
                ore = NPagine / 100;
            return ore;
        }
    }
}
