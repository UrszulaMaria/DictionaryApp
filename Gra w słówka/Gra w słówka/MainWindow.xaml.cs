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
using System.IO;

namespace Gra_w_słówka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<List<string>> WordList = new List<List<string>>();
        Random Random = new Random();
        int sentenceNumber = 0;

        public void DwoloadWordsFromTxtFile()
        {
            
            string Sentence = "";
            using (StreamReader sr = new StreamReader("dane.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    List<string> words = new List<string>();
                    Sentence = sr.ReadLine();
                    words = Sentence.Split(' ').ToList();
                    WordList.Add(words);
                }
            }
            WordList = WordList.OrderBy(a => Guid.NewGuid()).ToList();
        }
        public void DisplayRandomCombinations()
        {
            if (sentenceNumber == WordList.Count) sentenceNumber = 0;
            var RandomList=WordList[sentenceNumber].OrderBy(a => Guid.NewGuid()).ToList();
            string toDisplay = "";
            foreach (var randomWord in RandomList)
                toDisplay += randomWord + " ";
           ZmiszaneSlowka.Content = toDisplay.Remove(toDisplay.Length - 1);
            ++sentenceNumber;
            WordsToWrite.Text = "";
        }
        public MainWindow()
        {
           
            InitializeComponent();
            
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            DwoloadWordsFromTxtFile();
            DisplayRandomCombinations();
            Points.Text = "Punkty: " + Environment.NewLine + "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayRandomCombinations();
        }


        private void WordsToWrite_GotFocus(object sender, RoutedEventArgs e)
        {
            WordsToWrite.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string sentence = String.Join(" ", WordList[sentenceNumber-1].ToArray());
            string points = Points.Text;
           
            points = points.Replace("Punkty: \r\n", "");
            if (sentence.ToUpper() == WordsToWrite.Text.ToUpper())
            {
                
                Points.Text = "Punkty: " + Environment.NewLine + (Convert.ToInt32(points) + 1).ToString();
            }

            WordList.RemoveAt(sentenceNumber - 1);
            if (WordList.Count == 0)
            {
                MessageBox.Show("Ukończyłęś pkt " + points, "Result");
                Window window = new MainWindow();
                window.Show();
                this.Close();
            }
            else
            {
                --sentenceNumber;
                DisplayRandomCombinations();
            }
                
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WordsToWrite.Text = "";
        }
    }
}
