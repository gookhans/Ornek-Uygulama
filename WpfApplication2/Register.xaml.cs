﻿using System;
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
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passwd));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();

        }


        private void Bkayit_Click(object sender, RoutedEventArgs e)
        {
            serviceConnectionPortTypeClient service = new serviceConnectionPortTypeClient();
            

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
                if (st == "Successful")
                {
                    MessageBox.Show(st);
                    Login frmLog = new Login();
                    frmLog.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Error! Try Again");
            }
            else
            {
                MessageBox.Show("Please check the information you have input and make sure your email address is not registered on the system ");
            }
        }
    }
}

         

