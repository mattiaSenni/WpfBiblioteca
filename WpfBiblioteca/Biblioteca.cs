using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfBiblioteca
{
    public class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private string _orarioApertura;
        private string _orarioChiusura;
        private List<Libro> _listaLibri;
        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura, List<Libro> listaLibri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            ListaLibri = listaLibri;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Nome non valido");
                }
                else
                    _nome = value;
            }
        }

        public string Indirizzo
        {
            get
            {
                return _indirizzo;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Indirizzo non valido");
                }
                else
                    _indirizzo = value;
            }
        }

        public string OrarioApertura
        {
            get
            {
                return _orarioApertura;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Orario di apertura non valido");
                }
                else
                    _orarioApertura = value;
            }
        }

        public string OrarioChiusura
        {
            get
            {
                return _orarioChiusura;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Orario di chiusura non valido");
                }
                else
                    _orarioChiusura = value;
            }
        }

        public List<Libro> ListaLibri
        {
            get;
            set;     
        }

        public void AddLibro(Libro libro)
        {
            _listaLibri.Add(libro);
        }

        public Libro CercaLibroTitolo(string titolo)
        {
            foreach(Libro l in _listaLibri)
            {
                if(l.Titolo == titolo)
                {
                    return l;
                }
            }
        }

        public List<Libro> CercaLibriAutore(string nominativoAutore)
        {
            List<Libro> listaLibriAutore;

            foreach (Libro l in _listaLibri)
            {
                if (l.Autore == nominativoAutore)
                {
                    listaLibriAutore.Add(l);
                }
            }

            return listaLibriAutore;
        }

        public int Numerolibri()
        {
            return _listaLibri.Count; 
        }
    }
}