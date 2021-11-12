using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ClassBiblioteca
    {
        private string _nome;
        private string _indirizzo;
        private string _orarioApertura;
        private string _orarioChiusura;
        private List<Libro> _libri;

        public ClassBiblioteca(string nome, string indirizzo,string apertura,string chiusura)
        {
            _libri = new List<Libro>();
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = apertura;
            OrarioChiusura = chiusura;
        }
        public string OrarioChiusura
        {
            get { return _orarioChiusura; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valore non valido");
                _orarioChiusura = value;
            }
        }
        public string OrarioApertura
        {
            get { return _orarioApertura; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valore non valido");
                _orarioApertura = value;
            }
        }
        public string Indirizzo
        {
            get { return _indirizzo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valore non valido");
                _indirizzo = value;
            }
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valore non valido");
                _nome = value;
               
            }
        }
        public void AggiungiLibro(Libro l)
        {
            _libri.Add(l);
        }
        public string CercaLibroTitolo(string titolo)
        {
            string output = null;
            foreach(Libro l in _libri)
            {
                if (titolo == l.Titolo)
                    return l.Editore;
            }
            return "Non presente";
        }
        public string CercaLibriAutore(string autore)
        {
            string output = null;
            foreach (Libro l in _libri)
            {
                if (l.Autore == autore)
                    output += l.Titolo;
            }
            return output;
        }
        public int LibriPresenti()
        {
            return _libri.Count;
        }
    }
}
