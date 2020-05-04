using System;
using System.Collections.Generic;
using System.IO;
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

namespace Gramatyka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lista_rozwijana_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lista_rozwijana_terazniejsze.SelectedItem == present_simple)
            {
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"present_simple.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_terazniejsze.SelectedItem == present_continuous)
            {
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"present_continuous.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_terazniejsze.SelectedItem == present_perfect)
            {
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"present_perfect.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_terazniejsze.SelectedItem == present_perfect_continuous)
            {
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"present_perfect_continuous.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
        }

        private void Tresc_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
