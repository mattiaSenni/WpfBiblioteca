using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBiblioteca
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private string _orarioApertura;
        private string _orarioChiusura;
        private List<Libro> _listaLibri;
        public Biblioteca(string nome,string indirizzo,string orarioApertura,string orarioChiusura,List<Libro> listaLibri)
        {
            _nome = nome;
            _indirizzo = indirizzo;
            _orarioApertura = orarioApertura;
            _orarioChiusura = orarioChiusura;
            _listaLibri = listaLibri;   
        }
    }
}
