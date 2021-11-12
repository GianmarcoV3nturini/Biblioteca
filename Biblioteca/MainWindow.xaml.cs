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

namespace Biblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBiblioteca biblioteca;
        public MainWindow()
        {
            InitializeComponent();
            biblioteca = new ClassBiblioteca("Biblioteca","via Cavour 100", "10.00", "19:00");
            txtNome.Text = biblioteca.Nome;
            txtIndirizzo.Text = biblioteca.Indirizzo;
            txtApertura.Text = biblioteca.OrarioApertura;
            txtChiusura.Text = biblioteca.OrarioChiusura;
        }
        public void AggiornaListBox()
        {
            foreach(Libro l in biblioteca.Libri)
            {
                lstLibri.Items.Add(l.ToString());
            }
        }

        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            Libro l = new Libro(txtAutore.Text, txtTitolo.Text, txtAnnoPubblicazione.Text,txtEditore.Text, int.Parse(txtNPagine.Text));
            biblioteca.AggiungiLibro(l);
            AggiornaListBox();
        }

        private void btnCercaLibro_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(biblioteca.CercaLibroTitolo(txtCercaDaTitolo.Text));
        }

        private void btnCercaLibri_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(biblioteca.CercaLibriAutore(txtCercaDaAutore.Text));

        }

        private void btnNumeroLibri_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(biblioteca.LibriPresenti()+"");

        }

        private void lstLibri_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
