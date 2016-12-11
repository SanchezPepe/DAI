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

namespace AspirantesITAM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Conexion c = new Conexion();
            c.llenaProg(cbProg);

            cbGrado.Items.Add("4");
            cbGrado.Items.Add("5");
            cbGrado.Items.Add("6");
            cbGrado.SelectedIndex = 0;

            cbSexo.Items.Add("H");
            cbSexo.Items.Add("M");
            cbSexo.SelectedIndex = 0;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Aspirante a = new Aspirante(tbNombre.Text, cbSexo.Text[0], dpFecha.Text, tbCorreo.Text, int.Parse(cbGrado.Text), cbProg.Text);
            bool res = AspiranteG.altaAspirante(a);
            if (res)
                MessageBox.Show("Exito");
            else
                MessageBox.Show("Error");
        }

        private void btModificar_Click(object sender, RoutedEventArgs e)
        {
            Modificar m = new Modificar();
            this.Hide();
            m.Show();
        }

        private void btReporte_Click(object sender, RoutedEventArgs e)
        {
            Reporte r = new Reporte();
            this.Hide();
            r.Show();
        }

        private void btBaja_Click(object sender, RoutedEventArgs e)
        {
            Baja b = new Baja();
            this.Hide();
            b.Show();
        }



        
    }
}
