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

namespace OrnekUygulama
{
 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Register : Window
    {
        
        public Register()
        {
            InitializeComponent();
            guvenlikkodu();
        }
        String kod;
        public void guvenlikkodu()
        {
            
            kod = "";
            int hangisi,harf,sayac;
            Random Rharf = new Random();
            Random Rrakam = new Random();
            Random Rhangisi = new Random();
            for(int i=0; i<5; i++)
            {
                sayac = 0;
                hangisi = Rhangisi.Next(1, 3);
                if (hangisi == 1)
                    kod += Rrakam.Next(0, 10).ToString();
               else if (hangisi == 2)
                {
                    
                    harf = Rharf.Next(1, 27);
                    for (char h = 'a'; h <= 'z'; h++)
                    {
                        sayac++;
                        if (harf == sayac)
                         kod += h;
                            
                        
                    }
                }

            }
            GuvenlikKod.Content = kod;
        }

        private void Bkayit_Click(object sender, RoutedEventArgs e)
        {
            if (Tkod.Text == kod)
                MessageBox.Show("Kayıt Başarılı!");
            else
                MessageBox.Show("BAŞARISIZ!");
        }
    }
}
