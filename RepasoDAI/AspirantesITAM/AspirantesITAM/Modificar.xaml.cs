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

namespace AspirantesITAM
{
    /// <summary>
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {
        public Modificar()
        {
            InitializeComponent();
            Conexion c = new Conexion();
            c.llenaProg(cbProgram);
        }

        private void BTMOd_Click(object sender, RoutedEventArgs e)
        {
            bool res = AspiranteG.modifica(tbcorreo.Text, cbProgram.Text);
            if (res)
                MessageBox.Show("Se  modificó");
            else
                MessageBox.Show("No se modifico");
        }
    }
}
