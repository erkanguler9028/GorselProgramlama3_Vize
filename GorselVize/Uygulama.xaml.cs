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
using System.Windows.Shapes;

namespace GorselVize
{
    /// <summary>
    /// Uygulama.xaml etkileşim mantığı
    /// </summary>
    public partial class Uygulama : Window
    {
        List<Veriler> veri = new List<Veriler>();
        public Uygulama()
        {
            InitializeComponent();
            this.Title = "Öğrenci Tablosu";
        }

        int sayac = 0;
        string cinsiyet="";
        private void btnEkle_Click(object sender, RoutedEventArgs e)
        {   
            if (btn1.IsChecked==true)
            {
                cinsiyet = "Erkek";
            }
            else if(btn2.IsChecked==true)
            {
                cinsiyet = "Kadın";
            }

            if (txtAd.Text == "")
            {
                MessageBox.Show("Lütfen ad bilgisi giriniz...", "Eksik Bilgi!", MessageBoxButton.OK, MessageBoxImage.Warning);
                labelUyari.Content = "Lütfen ad bilgisi giriniz!";
                
            }
            else if (txtSoyad.Text == "")
            {
                MessageBox.Show("Lütfen soyad bilgisi giriniz...", "Eksik Bilgi!", MessageBoxButton.OK, MessageBoxImage.Warning);
                labelUyari.Content = "Lütfen soyad bilgisi giriniz!";
            }
            else if (cinsiyet == "")
            {
                MessageBox.Show("Lütfen cinsiyet bilgisi belirtiniz...", "Eksik Bilgi!", MessageBoxButton.OK, MessageBoxImage.Warning);
                labelUyari.Content = "Lütfen cinsiyet bilgisi belirtiniz!";
            }
            else if (dogumTarihi == "")
            {
                MessageBox.Show("Lütfen doğum tarihi giriniz...", "Eksik Bilgi!", MessageBoxButton.OK, MessageBoxImage.Warning);
                labelUyari.Content = "Lütfen doğum tarihi giriniz!";
            }
            else if (txtOgrenciNo.Text == "")
            {
                MessageBox.Show("Lütfen öğrenci numarası giriniz", "Eksik Bilgi!", MessageBoxButton.OK, MessageBoxImage.Warning);
                labelUyari.Content = "Lütfen öğrenci numarası giriniz!";
            }
            else if (cmbBolum.Text == "")
            {
                MessageBox.Show("Lütfen kayıtlı bölüm bilgisi belirtiniz...", "Eksik Bilgi!", MessageBoxButton.OK, MessageBoxImage.Warning);
                labelUyari.Content = "Lütfen kayıtlı bölüm bilgisi belirtiniz!";
            }
            else
            {
                sayac++;
                Veriler veri1 = new Veriler();
                veri1.Sira = sayac;
                veri1.Ad = txtAd.Text;
                veri1.Soyad = txtSoyad.Text;
                veri1.Cinsiyet = cinsiyet;
                veri1.OgrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
                veri1.Bolum =cmbBolum.Text;
                veri1.Tarih = dogumTarihi;
                veri.Add(veri1);
                tablo.Items.Add(veri1);
                cmbBilgi.Items.Add(sayac+". Satır Bilgisi");
                labelUyari.Content = "";
            }
        }

        public class Veriler
        {
            public int Sira { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Cinsiyet { get; set; }
            public string Tarih { get; set; }
            public int OgrenciNo { get; set; }
            public string Bolum { get; set; }            

        }

        private void cmbBilgi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int satir = cmbBilgi.SelectedIndex;
            MessageBox.Show("Ad: "+ veri[satir].Ad + "\n" +
                            "Soyad: " + veri[satir].Soyad + "\n" +
                            "Cinsiyet: " + veri[satir].Cinsiyet + "\n" +
                            "Doğum Tarihi: " + veri[satir].Tarih + "\n" +
                            "Öğrenci No: " + veri[satir].OgrenciNo + "\n" +
                            "Bölüm Adı: " + veri[satir].Bolum + "\n",
                            "Seçilen Satır: "+ (satir+1), MessageBoxButton.OK, MessageBoxImage.Information);
        }

        string dogumTarihi="";
        private void DogumTarihi_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {            
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;            
            dogumTarihi= date.Value.ToShortDateString();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menu = new MainWindow();
            menu.Show();
            this.Hide();
        }

    }
}
