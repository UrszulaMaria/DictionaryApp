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
            if (lista_rozwijana_przeszle.SelectedItem == past_simple)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"past_simple.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_przeszle.SelectedItem == past_continuous)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"past_continuous.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_przeszle.SelectedItem == past_perfect)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"past_perfect.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_przeszle.SelectedItem == past_perfect_continuous)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"past_perfect_continuous.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_terazniejsze.SelectedItem == present_simple)
            {
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"present_simple.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_terazniejsze.SelectedItem == present_continuous)
            {
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"present_continuous.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_terazniejsze.SelectedItem == present_perfect)
            {
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"present_perfect.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_terazniejsze.SelectedItem == present_perfect_continuous)
            {
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"present_perfect_continuous.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_przyszle.SelectedItem == future_simple)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"future_simple.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_przyszle.SelectedItem == future_continuous)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"future_continuous.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_przyszle.SelectedItem == future_perfect)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"future_perfect.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_przyszle.SelectedItem == future_perfect_continuous)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_warunkowe.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"future_perfect_continuous.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_warunkowe.SelectedItem == tr_zerowy)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"zero_conditional.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_warunkowe.SelectedItem == tr_pierwszy)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"first_conditional.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_warunkowe.SelectedItem == tr_drugi)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"second_conditional.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_warunkowe.SelectedItem == tr_trzeci)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"third_conditional.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                tresc.Text = line;
            }
            if (lista_rozwijana_warunkowe.SelectedItem == tr_mieszany)
            {
                lista_rozwijana_terazniejsze.Text = " ";
                lista_rozwijana_przeszle.Text = " ";
                lista_rozwijana_przyszle.Text = " ";
                // Open the text file using a stream reader.
                StreamReader sr = new StreamReader(@"mixed_conditional.txt");
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
