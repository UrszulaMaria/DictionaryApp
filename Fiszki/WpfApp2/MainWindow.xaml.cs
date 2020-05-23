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
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;



namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] dniTygodnia;
        public string[] dniTygodnia1;
        public string[] jezyki { get; set; }
        public int licznik_poprawne = 0;
        public int licznik_bledne = 0;

        public MainWindow()
        {
            InitializeComponent();
            

        }

        
        

      

        private void losuj(object sender, RoutedEventArgs e)//losuj
        {
            XmlDocument Dokument = new XmlDocument();
            Dokument.Load("Baza.xml");
            XmlNodeList lista1 = Dokument.SelectNodes("slownik/polski/slowo");
           
            Random zmienna = new Random();
            int losowa = zmienna.Next(0, lista1.Count);

            losowane.Text = lista1[losowa].InnerXml;
            numer_slowa.Text = losowa.ToString();
            sprawdzane.Text = "";
        }

        private void sprawdz(object sender, RoutedEventArgs e)
        {
            XmlDocument Dokument = new XmlDocument();
            Dokument.Load("Baza.xml");
            XmlNodeList lista2 = Dokument.SelectNodes("slownik/angielski/word");

            if (sprawdzane.Text == lista2[int.Parse(numer_slowa.Text)].InnerXml)
            {
                poprawne.Content = ++licznik_poprawne;
                sprawdzane.Text = "";
               

            }
            else
            {
                bledne.Content = ++licznik_bledne;

            }
        }

       
        

        private void Reset_fiszki(object sender, RoutedEventArgs e)
        {
            licznik_poprawne = 0;
            licznik_bledne = 0;
            poprawne.Content = "";
            bledne.Content = "";
            sprawdzane.Text = "";
            losowane.Text = "";


        }
        


        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); 
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }


        
    }
}
