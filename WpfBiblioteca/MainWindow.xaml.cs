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

        }


        private void btnInformazioniBiblioteca_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCercaLibro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCercaAutore_Click(object sender, RoutedEventArgs e)
        {
            string search = txtCercaAutore.Text.ToUpper();

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
                MessageBox.Show(l.ReadingTime());
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

        }

        private void btnCreaLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
