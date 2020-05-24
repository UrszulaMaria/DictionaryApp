using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
using Newtonsoft.Json.Linq;

namespace DictionaryApp.Translator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DictionaryClass dictionary;
        public MainWindow()
        {
            InitializeComponent();

            dictionary = new DictionaryClass();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(FromPl.IsChecked??false)
                TargetText.Text = dictionary.pl2en(SourceText.Text);
            else
                TargetText.Text = dictionary.en2pl(SourceText.Text);
        }
    }


    public class DictionaryClass
    {
        JObject jObject = null;

        public DictionaryClass()
        {
            string fileName = "data.json";
            string jsonString = File.ReadAllText(fileName);
            jObject = JObject.Parse(jsonString);               
        }

        public string en2pl(string en)
        {
            string enl = en.Trim().ToLower();
            try
            {
                foreach(var set in jObject["WordSets"])
                {
                    var words = set["words"];
                    foreach(var word in words)
                    {
                        if (word["en"].ToString().ToLower() == enl)
                            return word["pl"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Nie znaleziono tłumaczenia";
        }

        public string pl2en(string pl)
        {
            string pll = pl.Trim().ToLower();
            try
            {
                foreach (var set in jObject["WordSets"])
                {
                    var words = set["words"];
                    foreach (var word in words)
                    {

                        string []plt = word["pl"].ToString().ToLower().Split(',');
                        var pltc = plt.Where(s => s.Trim() == pll);
                        if (pltc.Count()>0)
                            return word["en"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Nie znaleziono tłumaczenia";
        }
    }
}
