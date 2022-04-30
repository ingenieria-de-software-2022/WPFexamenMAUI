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

namespace WPFexamenMAUI
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

        private void whatIs_Click(object sender, RoutedEventArgs e)
        {
            documents.Navigate("https://drive.google.com/file/d/1xqlDvPq9B7wy-PcxLs8aZd5cEPojUZQI/view?usp=sharing");
        }

        private void learning_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Para seguir aprendiendo consulte la pestaña \"Navegador\" y acepte los scripts para ver documentación sobre MAUI");
            mauiDocs.Navigate("https://docs.microsoft.com/es-es/dotnet/maui/");
        }

        private void structure_Click(object sender, RoutedEventArgs e)
        {
            documents.Navigate("https://drive.google.com/file/d/1AedLavroyF2OnNWcpm7802GiJwnSMze7/view?usp=sharing");
        }

        private void example_Click(object sender, RoutedEventArgs e)
        {
            documents.Navigate("https://drive.google.com/file/d/1OFHZyz0U2m7eTsTYfF8azInQLQr57AX0/view?usp=sharing");
        }

        private void lifecicle_Click(object sender, RoutedEventArgs e)
        {
            documents.Navigate("https://drive.google.com/file/d/1W9eZPZ8W5oFwUx8mDawH5ZB4yMRTKmgr/view?usp=sharing");
        }

        private void demo_Click(object sender, RoutedEventArgs e)
        {
            demo1.Navigate("https://www.youtube.com/v/g7974vxPu9A");
        }

        private void signature_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }
    }
}
