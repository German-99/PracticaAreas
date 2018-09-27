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
            float aux3 = aux * aux2;
            arearectangulo.Text = aux3.ToString();
        }
        
        private void BotonTriangulo_Click(object sender, RoutedEventArgs e)
        {
            int aux = int.Parse(baseTriangulo.Text);
            int aux2 = int.Parse(alturaTriangulo.Text);
            float aux3 = (aux * aux2) / 2;
            areaTriangulo.Text = aux3.ToString();
        }

        private void BotonCirculo_Click(object sender, RoutedEventArgs e)
        {
            int aux = int.Parse(Radio.Text);
            double aux3 = (aux * aux) * 3.14 ;
            areaCirculo.Text = aux3.ToString();

        }

        private void BotonTrapecio_Click(object sender, RoutedEventArgs e)
        {
            int aux = int.Parse(Basemayor.Text);
            int aux2 = int.Parse(Basemenor.Text);
            int aux3 = int.Parse(alturatrapecio.Text);
            double aux4 = ((aux + aux2) / 2) * aux3;
            areaTrapecio.Text = aux4.ToString();
        }
    }
}
