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
using Microsoft.Office.Interop;
using e = Microsoft.Office.Interop.Excel;
using System.IO;

namespace crearExcel
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        e.Application excelApp;
        e.Worksheet hoja;
        e.Workbook libro;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbEjec_Click(object sender, RoutedEventArgs e)
        {
            String fileTest = "C:\\DLL2";
            if (File.Exists(fileTest))
                File.Delete(fileTest);
            excelApp = new e.Application();
            libro = excelApp.Workbooks.Add();
            hoja = (e.Worksheet)libro.Worksheets.get_Item(1);
            hoja.Cells[1, 1] = "hola";
            libro.SaveAs(fileTest);
            libro.Close();
            excelApp.Quit();
        }
    }
}
