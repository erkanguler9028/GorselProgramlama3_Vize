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

namespace GorselVize
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<StatikBilgi> liste = new List<StatikBilgi>()
            {
                new StatikBilgi() {Ad="Erkan", Soyad="GÜLER", OgrenciNo=181130055, Bolum="Bilgisayar Programcılığı"}
            };

            bilgi.ItemsSource = liste;
        }

        private void btnUygulama_Click(object sender, RoutedEventArgs e)
        {
            Uygulama uyg = new Uygulama();
            uyg.Show();
            this.Hide();
        }

        public class StatikBilgi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int OgrenciNo { get; set; }
            public string Bolum { get; set; }

        }
    }
}
