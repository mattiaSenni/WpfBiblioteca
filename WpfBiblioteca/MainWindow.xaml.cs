using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBiblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Inizializza();
        }
        private void Inizializza()
        {
            List<Libro> libri = new List<Libro>();
            libri.Add(new Libro("titolo", "autore", 2000, "editore", 210));
            libri.Add(new Libro("ciao", "pierpaolo", 1970, "mondadori", 300));
            biblioteca = new Biblioteca("biblioteca", "via pierpaolo", "10:00", "22:00", libri);
            lblNumeroLibri.Content = biblioteca.Numerolibri();
            lstLibri.ItemsSource = biblioteca.ListaLibri;
        }
        private Biblioteca biblioteca;


        private void btnInformazioniBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(biblioteca.ToString());
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            grdHome.Visibility = Visibility.Hidden;
            grdAggiungiLibro.Visibility = Visibility.Visible;
        }

        private void btnCercaLibro_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show(biblioteca.CercaLibroTitolo(txtCercaLibro.Text).ToString());
        }

        private void btnCercaAutore_Click(object sender, RoutedEventArgs e)
        {
            lstLibri.ItemsSource = biblioteca.CercaLibriAutore(txtCercaAutore.Text);
            if(txtCercaAutore.Text == "")
            {
                lstLibri.ItemsSource = biblioteca.ListaLibri;
            }
        }

        private void btnInformazioniLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro l = (Libro)lstLibri.SelectedItem;
                MessageBox.Show(l.ToString());
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadingTime_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro l = (Libro)lstLibri.SelectedItem;
                MessageBox.Show(l.ReadTime());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstLibri.SelectedIndex != -1)
            {
                btnInformazioniLibro.IsEnabled = true;
                btnReadingTime.IsEnabled = true;
            }
            else
            {
                btnInformazioniLibro.IsEnabled = false;
                btnReadingTime.IsEnabled = false;
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            grdHome.Visibility = Visibility.Visible;
            grdAggiungiLibro.Visibility = Visibility.Hidden;
        }

        private void btnCreaLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro l = new Libro(txtTitolo.Text, txtAutore.Text, int.Parse(txtAnnoPubblicazione.Text), txtEditore.Text, int.Parse(txtNumeroPagine.Text));
                biblioteca.ListaLibri.Add(l);
                lstLibri.ItemsSource = null;
                lstLibri.ItemsSource = biblioteca.ListaLibri;
                grdHome.Visibility = Visibility.Visible;
                grdAggiungiLibro.Visibility = Visibility.Hidden;
                lblNumeroLibri.Content = biblioteca.Numerolibri();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
