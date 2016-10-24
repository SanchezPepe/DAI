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

namespace calculadoraN
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        public MainWindow(){
            InitializeComponent();
        }

        private void btCalcula_Click(object sender, RoutedEventArgs e){
            if (tbNum1.Text != "" && tbNum2.Text != ""){
                if ((bool)rbSuma.IsChecked)
                    suma();
                else if ((bool)rbResta.IsChecked)
                    resta();
                else if ((bool)rbMultiplica.IsChecked)
                    multiplicacion();
                else if ((bool)rbDivision.IsChecked)
                    division();
                else
                    MessageBox.Show("Selecciona una operación");
            }
            else
                MessageBox.Show("Ingresa un número en las cajas de texto");
        }

        private void suma(){
            double n1 = double.Parse(tbNum1.Text);
            double n2 = double.Parse(tbNum2.Text);
            double resp = n1 + n2;
            tbResp.Text = resp.ToString();
        }

        private void resta(){
            double n1 = double.Parse(tbNum1.Text);
            double n2 = double.Parse(tbNum2.Text);
            double resp = n1 - n2;
            tbResp.Text = resp.ToString();
        }

        private void multiplicacion(){
            double n1 = double.Parse(tbNum1.Text);
            double n2 = double.Parse(tbNum2.Text);
            double resp = n1 * n2;
            tbResp.Text = resp.ToString();
        }

        private void division(){
            double n1 = double.Parse(tbNum1.Text);
            double n2 = double.Parse(tbNum2.Text);
            if (n2 != 0){
                double resp = n1 / n2;
                tbResp.Text = resp.ToString();
            }
            else
                MessageBox.Show("No se puede dividir entre 0");
        }
    }
}
