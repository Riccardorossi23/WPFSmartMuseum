using ClassSmartMuseum;
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

namespace SmartMuseum
{
    /// <summary>
    /// Interaction logic for PageSmartMuseum3.xaml
    /// </summary>
    public partial class PageSmartMuseum3 : Window
    {
        public PageSmartMuseum3()
        {
            InitializeComponent();
        }
        private void Stampa_Click(object sender, RoutedEventArgs e)
        {
            OperaArte opera = new OperaArte(lblautore.ToString(), lblQuadro.ToString(), lblnome_quadro.ToString());
            if (rdbQuadro1.IsChecked == true)
            {

                string autore = $"Steve Jobs";
                lblautore.Content = autore;
                string nome_quadro = $"the evolution";
                lblnome_quadro.Content = nome_quadro;
                string quadro = "The evolution of computing shown in a single photo where you can\nadmire the evolution of mobile phones, going from mobile phones that\nare big and heavy and also bulky to mobile phones that are\nsmall and light and not very bulky, this is evolution!!!";
                lblQuadro.Content = quadro;
            }
            if (rdbQuadro2.IsChecked == true)
            {

                string autore = $"The New York Time";
                lblautore.Content = autore;
                string nome_quadro = $"the first telephones";
                lblnome_quadro.Content = nome_quadro;
                string quadro2 = "The first telephones were large and expensive and only performed basic\nfunctions, in fact you could only make phone calls, in this picture you can\nsee one of the first mobile phones, which only replaced public telephones\nfor a few.";
                lblQuadro.Content = quadro2;
            }
            if (rdbQuadro3.IsChecked == true)
            {

                string autore = $"Apple";
                lblautore.Content = autore;
                string nome_quadro = $"the phone 12!!!";
                lblnome_quadro.Content = nome_quadro;
                string quadro3 = "In this photo you can see the evolution and improvements that have been\nmade to mobile phones, in fact we go from a large and cumbersome and\nnot accessible to all to a very ductile phone with an average cost,\nthis photo encapsulates the various improvements and developments in\nthe computer sector and also engineering, such as: the phone antenna\nwhich is now enclosed inside and takes an aspiral shape compared to the\nfirst that came out of the phone. ";
                lblQuadro.Content = quadro3;
            }
            else if (rdbQuadro3.IsChecked == false && rdbQuadro2.IsChecked == false && rdbQuadro1.IsChecked == false)
            {
                MessageBox.Show("selezionare un quadro", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
