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
using System.Data.SqlClient;
using System.Data;

namespace TCDD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Vagon_Secim : Window
    {
        static int Vagon_Koltuk;
        static bool vgnolus = false;
        static bool vgnolus2 = false;
        static bool vgnolus3 = false;
        static bool vgnolus4 = false;
        int Vagon1_Koltuk_Sirasi = 1;
        int Vagon2_Koltuk_Sirasi=1;
        Button Vagon1_Koltuk = new Button() { Width = 50, Height = 50 };

        Button Vagon2_Koltuk = new Button() { Width = 50, Height = 50 };


        //CheckBox checkBox = new CheckBox() { Width = 60, Height = 40 };


        public Vagon_Secim()
        {
            InitializeComponent();
            for (Vagon_Koltuk = 0; Vagon_Koltuk < 42; Vagon_Koltuk++)
                {
                    Button Vagon1_Koltuk = new Button() { Width = 50, Height = 50 };
                    Vagon1_Koltuk.Content = Vagon1_Koltuk_Sirasi.ToString();
                    Vagon1_Koltuk.Name = "Button" + Vagon1_Koltuk_Sirasi.ToString();
                    Koltuk.Children.Add(Vagon1_Koltuk);
                    Vagon1_Koltuk_Sirasi++;
                    Vagon1_Koltuk.Click += (Vagon1_Koltuk_Click);
                    //Vagon2_Koltuk_Click +=(Vagon2_Koltuk_Click);
                }
        }

        public void Ilk_Vagon_click(object sender, RoutedEventArgs e)
        {

        }
        public void Birinci_Vagon_click(object sender, RoutedEventArgs e)
        {
             //if (!vgnolus)
            //     for (Vagon_Koltuk = 0; Vagon_Koltuk < 42; Vagon_Koltuk++)
            //     {
            //         Button Vagon1_Koltuk = new Button() { Width = 50, Height = 50 };
            //         Vagon1_Koltuk.Content = Vagon1_Koltuk_Sirasi.ToString();
            //         Vagon1_Koltuk.Name = "Button" + Vagon1_Koltuk_Sirasi.ToString();
            //         Koltuk.Children.Add(Vagon1_Koltuk);
            //         Vagon1_Koltuk_Sirasi++;
            //     }
            //Label Vagon_Adi =new Label ();
            //  Vagon_Adi.Content =" 1.Vagon";
            //  V_Adi.Children.Add(Vagon_Adi);
                Vagon_Adi.Content="1.Vagon";
             //vgnolus = true;
            //  if (!vgnolus)

            // vgnolus = true;

             //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //  SqlConnection baglanti = new SqlConnection();
            //                     baglanti.ConnectionString = @"server=localhost;database=TCDD_Data;Integrated Security=true";
            //                     SqlCommand komut = new SqlCommand();
            //                     komut.CommandText = "SELECT *FROM Vagon1_Koltuk_Table";
            //                     komut.Connection = baglanti;
            //                     komut.CommandType = CommandType.Text;

            //                     SqlDataReader dr;
            //                     baglanti.Open();
            //                     try
            //                     {
            //                     dr = komut.ExecuteReader();
            //                     while (dr.Read())
            //                     {
            //                         Vagon1_Koltuk.Content.Add(dr["Koltuk_Sirasi"]);

            //                         //Vagon1_Koltuk = (dr["masa_durum"].ToString());
            //                     }
                                

            //                     }
            //                     catch(SqlException ex){

            //                         MessageBox.Show(ex.ToString());  
            //                         return;
            //                     }
            //                             baglanti.Close();           


        }
         public void Vagon1_Koltuk_Click(object sender, EventArgs e) {
         MessageBox.Show(Vagon1_Koltuk_Sirasi.ToString()+".Koltuk"+" Seçildi");
         Vagon1_Koltuk.BorderBrush = Brushes.Red;
        }

        public void Ikinci_Vagon_click(object sender, RoutedEventArgs e)
        {
             //if (!vgnolus2)
             Vagon_Adi.Content="2.Vagon";
            //     for (Vagon_Koltuk = 0; Vagon_Koltuk < 42; Vagon_Koltuk++)
            //     {
            //         Button Vagon2_Koltuk = new Button() { Width = 50, Height = 50 };
            //         Vagon2_Koltuk.Content = Vagon2_Koltuk_Sirasi.ToString();
            //         Vagon2_Koltuk.Name = "Button" + Vagon2_Koltuk_Sirasi.ToString();
            //         Koltuk.Children.Add(Vagon2_Koltuk);
            //         Vagon2_Koltuk_Sirasi++;
            //         Vagon2_Koltuk.Click += (Vagon2_Koltuk_Click);
            //     }
              //vgnolus2 = true;
            //  if (!vgnolus2)
            //
            //  for (Vagon_Koltuk = 0; Vagon_Koltuk < 42; Vagon_Koltuk++)
            //     {
            //         Button Vagon2_Koltuk = new Button() { Width = 50, Height = 50 };
            //         Vagon2_Koltuk.Content = Vagon2_Koltuk_Sirasi.ToString();
            //         Vagon2_Koltuk.Name = "Button" + Vagon2_Koltuk_Sirasi.ToString();
            //         Koltuk.Children.Add(Vagon2_Koltuk);
            //         Vagon2_Koltuk_Sirasi++;
            //         Vagon2_Koltuk.Click += (Vagon2_Koltuk_Click);
            //     }
            //     vgnolus2 = true;
        }
         public void Vagon2_Koltuk_Click(object sender, EventArgs e) {

        //   MessageBox.Show("2.Vagon "+Vagon2_Koltuk_Sirasi.ToString()+".Koltuk"+" Seçildi");
        //   Vagon2_Koltuk.Background = Brushes.Red;

        }
        public void Ucuncu_Vagon_click(object sender, RoutedEventArgs e)
        {
            Vagon_Adi.Content="3.Vagon";
            // if (!vgnolus3)
            //     for (Vagon_Koltuk = 0; Vagon_Koltuk < 42; Vagon_Koltuk++)
            //     {
            //         CheckBox checkBox2 = new CheckBox() { Width = 60, Height = 40 };
            //         Koltuk.Children.Add(checkBox2);
            //     }
            // vgnolus3 = true;
        }
        public void Dorduncu_Vagon_click(object sender, RoutedEventArgs e)
        {
            Vagon_Adi.Content="4.Vagon";
            // if (!vgnolus4)
            //     for (Vagon_Koltuk = 0; Vagon_Koltuk < 42; Vagon_Koltuk++)
            //     {
            //         CheckBox checkBox3 = new CheckBox() { Width = 60, Height = 40 };
            //         Koltuk.Children.Add(checkBox3);

            //     }
            // vgnolus4 = true;
        }
        public void Devam_Click(object sender, RoutedEventArgs e)
        {
            // if (checkBox.IsChecked == false){
            //         MessageBox.Show("Lütfen Koltuk Seçimi Yapınız");
            //         return ;
            // }

            Yolcu_Bilgileri s3 = new Yolcu_Bilgileri();
            this.Close();
            s3.Show();

        }


    }
}
