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

        public Biblioteca(string n, string i, string oA, string oC, List<Libro> libri)
        {
            
            
            List<Libro> libri = new List<Libro>();
            Nome = n;
            Indirizzo = i;
            OrarioApertura = oA;
            OrarioChiusura = oC;
            
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("nome non valido");
                }
                else
                {
                    _nome = value;
                }
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("indirizzo non valido ");
                }
                else
                {
                    _indirizzo = value;
                }
            }
        }

        public string OrarioApertura
        {
            get;
            set;
            
        }

        public string OrarioChiusura
        {
            get;
            set;
 
        }

        public List<Libro> ListaLibri
        {
            get;
            set;

 
        }



        public void AddLibro()
        {
            throw new System.NotImplementedException();
        }

        public void RicercaLibro()
        {
            throw new System.NotImplementedException();
        }

        public void RicercaLibroAutore()
        {
            throw new System.NotImplementedException();
        }

        public void NumeroLibriBiblioteca()
        {
            throw new System.NotImplementedException();
        }
    }
}