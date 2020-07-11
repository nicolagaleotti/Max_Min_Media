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
using Metodi;

namespace InterfacciaGrafica
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

        private void btncalcola_Click(object sender, RoutedEventArgs e)
        {
            txtmassimo.Text = Metodi_MaxMinMedia.Max(int.Parse(txtn1.Text), int.Parse(txtn2.Text)).ToString();
            txtminimo.Text = Metodi_MaxMinMedia.Min(int.Parse(txtn1.Text), int.Parse(txtn2.Text)).ToString();
            txtmedia.Text = Metodi_MaxMinMedia.Media(double.Parse(txtn1.Text), double.Parse(txtn2.Text)).ToString();
        }
    }
}
