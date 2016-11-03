using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SegundoParcial
{
    /// <summary>
    /// Lógica de interacción para Agrega.xaml
    /// </summary>
    public partial class Agrega : Window
    {


        public Agrega()
        {
            InitializeComponent();
            Conexion c = new Conexion();
            c.llenaCbIng(cbcarrera);
            c.llenaCbUni(cbuni);
        }

        private void BTAgrega_Click(object sender, RoutedEventArgs e)
        {
            int var = -1;
            bool band = true;
            SqlDataReader dr;
            SqlConnection con;

      
            if (tbnombre.Text == "")
                MessageBox.Show("Ingrese datos");
            else
            {
                Asistente a = new Asistente(int.Parse(tbclaveU.Text), tbnombre.Text, tbapellido.Text, tbsexo.Text[0], tbcorreo.Text);
                try{

                    SqlConnection cone = Conexion.agregaConexion();
                    String query = "INSERT INTO alumno VALUES ('" + a.claveU + "','" + a.nombre + "','" + a.apellido + "','" + a.sexo + "','" + a.correo +")";
                    SqlCommand cmd = new SqlCommand(query, cone);
                    cone.Close();
                    MessageBox.Show("Alta de asistente exitosa");
                    tbclaveU.Clear();
                    tbnombre.Clear();
                    tbapellido.Clear();
                    tbsexo.Clear();
                    tbcorreo.Clear();
                    if(cbcarrera.Text == "otra" || cbcarrera.Text != "externo"){
                        this.Hide();
                        ConfirmacionExt ext = new ConfirmacionExt();
                        ext.Show();
                    }else{
                        this.Hide();
                        Confirmacion ing = new Confirmacion();
                        ing.Show();
                    }

                }catch(Exception ex){
                    MessageBox.Show("No se pudo dar de alta al alumno" + ex);
                }
            }
        }


    }
}
