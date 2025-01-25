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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                                /////////////////////////////////////////////////////////////////////////////////////
                                SqlConnection baglanti = new SqlConnection();
                                baglanti.ConnectionString = @"server=localhost;database=TCDD_Data;Integrated Security=true";
                                SqlCommand komut = new SqlCommand();
                                komut.CommandText = "SELECT *FROM İstasyon_Table";
                                komut.Connection = baglanti;
                                komut.CommandType = CommandType.Text;

                                SqlDataReader dr;
                                baglanti.Open();
                                try
                                {
                                dr = komut.ExecuteReader();
                                while (dr.Read())
                                {
                                    comboBox1.Items.Add(dr["Istasyon_Adi"]);
                                    comboBox2.Items.Add(dr["Istasyon_Adi"]);
                                }
                                

                                }
                                catch(SqlException ex){

                                    MessageBox.Show(ex.ToString());  
                                    return;
                                }
                                        baglanti.Close();
                                ////////////////////////////////////////////////////////////////////////////////////////                      
         }
         
        private void  comboBox1_SIChanged(object sender, SelectionChangedEventArgs  e){
                           
        }
        private void  comboBox2_SIChanged(object sender, SelectionChangedEventArgs  e){
            
        }
       
          public void Button1_click(object sender,RoutedEventArgs e){
              if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Lütfen Biniş İstasyonu Seçiniz");
                        return;
                    }
                    if(comboBox2.SelectedItem == null)
                    {
                         MessageBox.Show("Lütfen İniş  İstasyonu Seçiniz");
                        return;
                    }
                    if(comboBox1.SelectedItem == comboBox2.SelectedItem){
                        MessageBox.Show("Biniş ve İniş istasyonu aynı Olamaz !!");
                        return;
                    }   
                        if(Tarih.SelectedDate == null){
                            MessageBox.Show("Gidiş Tarihi Şeciniz");
                            return ;
                        }

            /////////////////////////////////////////////////////////////////////////////////
             SqlConnection con=new SqlConnection(@"server=localhost;database=TCDD_Data;Integrated Security=true");
             con.Open();
             string sorgu = "INSERT INTO Rota_Table (Binis_Istasyon,Inis_Istasyon,Gidis_Tarihi) VALUES (@Binis_Istasyon,@Inis_Istasyon,@Gidis_Tarihi)";
             SqlCommand cmd = con.CreateCommand();
            cmd.CommandText=sorgu;
            if(comboBox1.SelectedItem  != null )
            cmd.Parameters.Add("Binis_Istasyon", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["Binis_Istasyon"].Value = comboBox1.Text;

            if(comboBox2.SelectedItem != null)
            cmd.Parameters.Add("Inis_Istasyon", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["Inis_Istasyon"].Value = comboBox2.Text;

            if(Tarih.SelectedDate != null)
            cmd.Parameters.Add("Gidis_Tarihi", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["Gidis_Tarihi"].Value = Tarih.Text;

            try
            {
            cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {   
             MessageBox.Show(ex.ToString());  
             return;
            }
            con.Close();
            //////////////////////////////////////////////////////////////////////////////////

              if(comboBox1 != null){
              Tren_Sec s1 = new Tren_Sec();
              this.Close();
              s1.Show();
              }
        }
        
    }

 }

