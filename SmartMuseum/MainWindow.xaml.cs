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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Stampa_Click(object sender, RoutedEventArgs e)
        {
            OperaArte opera = new OperaArte(lblautore.ToString(), lblQuadro.ToString(), lblnome_quadro.ToString());
            if (rdbQuadro1.IsChecked == true)
            {
               
                string autore = $"Steve McCurry";
                lblautore.Content=autore;
                string nome_quadro = $"the intelligent animal";
                lblnome_quadro.Content = nome_quadro;
                string quadro = "The picture above, and in front of it you can see how animals understand\nwhat is going on around them, and also the friendship between animals\nand humans.";
                lblQuadro.Content = quadro;
            }
            if (rdbQuadro2.IsChecked == true)
            {
                string autore = $"Ferdinando Scianna";
                lblautore.Content = autore;
                string nome_quadro = $"the sea in the clouds";
                lblnome_quadro.Content = nome_quadro;
                string quadro2 = "The second photo was taken by Ferdinando Scianna, and is intended to\nshow how small man is in comparison to the earth,and also to his own\n doubts, which he will never know the answer to, so his will to discover\nthe things of the earth will always be limited by the person's age and\ntherefore we will always find ourselves referring to Sehnsucht.";
                lblQuadro.Content = quadro2;
            }
            if (rdbQuadro3.IsChecked == true)
            {
                string autore = $"Ferdinando Scianna";
                lblautore.Content = autore;
                string nome_quadro = $"the supernatural";
                lblnome_quadro.Content = nome_quadro;
                string quadro3 = "In the third photo, also taken by Ferdinando Scianna, here he takes a rare\noptical illusion of nature, where a woman's face is formed, taking his\ncue from the various works of Leopardi and his contrast and change\nbetween historical and cosmic pessimism.";
                lblQuadro.Content = quadro3;
            }
            else if (rdbQuadro3.IsChecked == false && rdbQuadro2.IsChecked == false && rdbQuadro1.IsChecked == false)
            {
                MessageBox.Show("selezionare un quadro", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Prossima_Pagina_Click(object sender, RoutedEventArgs e)
        {
            new PageSmartMuseum2().ShowDialog();
        }


    }
}
 