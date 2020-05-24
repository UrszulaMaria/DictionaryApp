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

namespace dodawanie_slowek
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string[] wordList = new string[123];

        public MainWindow()
        {
            InitializeComponent();
            addProgressBar.Visibility = Visibility.Hidden;
            errorWord.Visibility = Visibility.Hidden;

            // First of all, scan db and save added words to memory
            checkIfexist();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            addProgressBar.Visibility = Visibility.Visible;

            // Grab words from edit boxes
            String polishWord = polishWordBox.Text;
            String englishWord = englishWordBox.Text;

            // Execute save word void
            saveNewWord(polishWord, englishWord);

            // UI extras
            for (int i = 0; i < 100; i++)
            {
                addProgressBar.Value++;
            }

            

            /*
                TODO: 
                - connect to db - 2/10 cause im not good at C, so txt file instead, sorry :V
                - check if the word exists - done
                - check for vulgarisms - same as above
                - check if troll (?) - same as above
             */
        }




        /*
         * Read from file to check, if word already exist
         */
        private void checkIfexist()
        {
            Array.Clear(wordList, 0, wordList.Length);
            String line;
            try
            {
                // Variable for loops
                int x = 0;

                // Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\addedWords.txt");

                // Read the first line of text
                line = sr.ReadLine();
                wordList[x] = line;
                x++;

                // Continue to read until you reach end of file
                while (line != null)
                {
                    // Write the lie to console window
                    Console.WriteLine(line);
                    // Read the next line
                    line = sr.ReadLine();
                    // Save line to array
                    wordList[x] = line;
                    x++;
                }

                // Close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }





        private void saveNewWord(string polishWord, string englishWord)
        {
            errorWord.Visibility = Visibility.Hidden;
            bool wordExist = false;
            string path = @"C:\\addedWords.txt";
            string mixed = polishWord + "=" + englishWord;

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                { }
            }

            // Check if word exist in db
            if (wordList.Contains(mixed))
                wordExist = true;
            else
                wordExist = false;

            // Debug info
            Console.WriteLine("Boolean value: " + wordExist);

            // This text is always added, making the file longer over time
            // if it is not deleted.
            // Execute only, if word does not exist
            if (!wordExist)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(polishWord + "=" + englishWord);
                }
            } 
            else
            {
                errorWord.Visibility = Visibility.Visible;
            }

            // Recheck db for words and update local variable
            checkIfexist();
        }
    }
}
