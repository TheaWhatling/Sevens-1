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

namespace Sevens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Seven s;

        public MainWindow()
        {
            InitializeComponent();
            s = new Seven();
            DataContext = s;

        }

        private void testWPF_Click(object sender, RoutedEventArgs e)
        {
            s.layCard(Convert.ToInt32(textB.Text));
            
        }

        private void pos0_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos5_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos6_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos7_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos8_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos9_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos10_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos11_Click(object sender, RoutedEventArgs e)
        {

        }
        private void pos12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            s.start();
        }
    }
}