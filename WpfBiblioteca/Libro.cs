using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBiblioteca
{
    class Libro
    {
        private string _titolo;
        private string _autore;
        private int _annoPubblicazione;
        private string _editore;
        private int _numeroPag;

        public Libro(string titolo,string autore,int annoPubblicazione,string editore,int numeroPag )
        {

        }
        public string Titolo
        {
            get
            {
                return _titolo;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Serve un titolo");
                }
                _titolo = value;
            }
        }
        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Serve un Autore");
                }
                _autore = value;
            }
        }
        public string Editore
        {
            get
            {
                return _editore;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Serve un Editore");
                }
                _editore = value;
            }
        }
        public int AnnoPubblicazione
        {
            get
            {
                return _annoPubblicazione;
            }
            set
            {
                if (value<-3000)
                {
                    throw new Exception("Anno non valido");
                }
                _annoPubblicazione = value;
            }
        }
        public int NumeroPag
        {
            get
            {
                return _numeroPag;
            }
            set
            {
                if (value <=0)
                {
                    throw new Exception("Il libro deve avere delle pagine");
                }
                _numeroPag = value;
            }
        }

    }
}
