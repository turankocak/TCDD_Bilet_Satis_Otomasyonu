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
    public partial class Yolcu_Bilgileri : Window
    {
        SqlConnection con;
        SqlCommand cmd;  
               
        public Yolcu_Bilgileri()
        {
            InitializeComponent();
                                //////////////////////////////////////////////////////////////////////////////////////////
                                
                                SqlConnection baglanti = new SqlConnection();
                                baglanti.ConnectionString = @"server=localhost;database=TCDD_Data;Integrated Security=true";
                                SqlCommand komut = new SqlCommand();
                                komut.CommandText = "SELECT *FROM Tarife_Table";
                                komut.Connection = baglanti;
                                komut.CommandType = CommandType.Text;

                                SqlDataReader dr;
                                baglanti.Open();
                                dr = komut.ExecuteReader();
                                try
                                {
                                while (dr.Read())
                                {
                                    Tarife_Listesi.Items.Add(dr["Tarife_Adi"]);
                                }
                                  
                                }
                                catch(SqlException ex)
                                {

                                    MessageBox.Show(ex.ToString());  
                                    return;
                                }
                                        baglanti.Close();
                                ////////////////////////////////////////////////////////////////////////////////////////
        }
        public void Yolcu_Adi_TextChanged(object sender, TextChangedEventArgs e) {

        }
        public void Yolcu_Soyadi_TextChanged(object sender, TextChangedEventArgs e) {

        }
        public void Yolcu_Tc_TextChanged(object sender, TextChangedEventArgs e) {

        }
        public void Yolcu_Telefon_TextChanged(object sender, TextChangedEventArgs e) {

        }
        public void  Tarife_Listesi_SIChanged(object sender, SelectionChangedEventArgs  e){
        }
        private void Bilet_Onayla_click(object sender,RoutedEventArgs e){
                if(Yolcu_Adi.Text == "" ){
                MessageBox.Show("Lütfen Adınızı Giriniz");
                return;
            } 
           
            if(Yolcu_Soyadi.Text == "" ){
                MessageBox.Show("Lütfen Soyadınızı Giriniz");
                return;
            } 

            if(Yolcu_Tc.Text == "" ){
                MessageBox.Show("Lütfen TC No Giriniz");
                return;
            } 

             if(Yolcu_Telefon.Text == "" ){
                MessageBox.Show("Lütfen Telefon Numarasi Giriniz");
                return;
            } 
            

            // if(Tarife_Listesi.SelectedItem == null){
            //     MessageBox.Show("Lütfen Tarife Seçiniz");
            //     return;
            // }
            /////////////////////////////////////////////////////////////////////////////////////////////////////
           
            SqlConnection con=new SqlConnection(@"server=localhost;database=TCDD_Data;Integrated Security=true");
            con.Open();
             string sorgu = "INSERT INTO Yolcu_Table (Adi,Soyadi,TC,Tel_No,Tarife) VALUES (@Adi,@Soyadi,@TC,@Tel_No,@Tarife)";
            // cmd=new SqlCommand(sorgu,con);"
             SqlCommand cmd = con.CreateCommand();
            cmd.CommandText=sorgu;
            cmd.Parameters.Add("Adi", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("Soyadi", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("TC", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("Tel_No", System.Data.SqlDbType.NVarChar);


            // cmd.Parameters.Add("TC", System.Data.SqlDbType.Int);
            // cmd.Parameters.Add("Tel_No", System.Data.SqlDbType.Int);
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            
            cmd.Parameters["Adi"].Value = Yolcu_Adi.Text;
            cmd.Parameters["Soyadi"].Value = Yolcu_Soyadi.Text;
            cmd.Parameters["TC"].Value = Yolcu_Tc.Text;
            cmd.Parameters["Tel_No"].Value = Yolcu_Telefon.Text;
            // cmd.Parameters["TC"].Value = int.Parse(Yolcu_Tc.Text);
            // cmd.Parameters["Tel_No"].Value = int.Parse(Yolcu_Telefon.Text);


            if(Tarife_Listesi.SelectedItem != null)
            cmd.Parameters.Add("Tarife", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["Tarife"].Value = Tarife_Listesi.Text;

            try
            {
            cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {    
             MessageBox.Show(ex.ToString());  
             return ;
            }
            con.Close();     
            //MessageBox.Show("Bilet Onaylandı");  
            ///////////////////////////////////////////////////////////////////////////////////////////////
            
            MessageBox.Show("Bilet Onaylandı");
            MainWindow s4 = new MainWindow();
            this.Close();
            s4.Show();
        }
    }
}
