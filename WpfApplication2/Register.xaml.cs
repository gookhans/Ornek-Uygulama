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
using System.Xml;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using OrnekUygulama.ServiceReference1;


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
            int hangisi, harf, sayac;
            Random Rharf = new Random();
            Random Rrakam = new Random();
            Random Rhangisi = new Random();
            for (int i = 0; i < 5; i++)
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

        private String crypt(String passwd)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(passwd, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;

        }


        private void Bkayit_Click(object sender, RoutedEventArgs e)
        {
            serviceConnectionPortTypeClient service = new serviceConnectionPortTypeClient();
            //Boolean st = service.dbConnect();

            if (    TfirstName.Text != "" && 
                    TlastName.Text != "" && 
                    Tmail.Text!="" &&
                    Tpass.Text!="" &&
                    Tmail.Text==Tmail2.Text &&
                    Tpass.Text==Tpass2.Text &&
                    kod==Tkod.Text
                    )
            {

               String HashPass= crypt(Tpass.Text);

                var st = service.memberRegistration(TfirstName.Text, TlastName.Text, Tmail.Text, HashPass);
                MessageBox.Show(st);
            }
            else
            {
                MessageBox.Show("Please check the information you have input and make sure your email address is not registered on the system ");
            }
        }
    }
}

         

