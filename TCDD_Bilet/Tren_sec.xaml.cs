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
    public partial class Tren_Sec  : Window
    {
        public Tren_Sec()
        {
            InitializeComponent();
        }
        public void Biletsec_click(object sender,RoutedEventArgs e){
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
             SqlConnection con=new SqlConnection(@"server=localhost;database=TCDD_Data;Integrated Security=true");
             con.Open();
             string sorgu = "INSERT INTO Tren_Table (Tren_Adi,Kalkis_Saati) VALUES (@Tren_Adi,@Kalkis_Saati)";
             SqlCommand cmd = con.CreateCommand();
            cmd.CommandText=sorgu;
            cmd.Parameters.Add("Tren_Adi", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["Tren_Adi"].Value = Tren_Adi.Content;

            cmd.Parameters.Add("Kalkis_Saati", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["Kalkis_Saati"].Value = Tren_Kalkis_Saati.Content;


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
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Vagon_Secim s2 = new Vagon_Secim();
            this.Close();
            s2.Show();

        }
    }
}
