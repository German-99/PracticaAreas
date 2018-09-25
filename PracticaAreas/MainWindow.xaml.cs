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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void BotonRectangulo_Click(object sender, RoutedEventArgs e)
        {
            int aux = int.Parse(baseRectangulo.Text);
            int aux2 = int.Parse(alturaRectangulo.Text);
            int aux3 = aux * aux2;
            arearectangulo.Text = aux3.ToString();
        }
        
        private void BotonTriangulo_Click(object sender, RoutedEventArgs e)
        {
            int aux = int.Parse(b)
        }

        private void BotonCirculo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BotonTrapecio_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
