using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected OdbcConnection abrirConexion()
    {
        OdbcConnection conexion = null;
        try
        {
            String conectar = "Driver={SQL Server Native Client 11.0};Server=CC201-17;Uid=sa;Pwd=sqladmin;Database=Mensajes;";
            conexion = new OdbcConnection(conectar);
            conexion.Open();
        }
        catch (Exception ex)
        {
            Console.Write(ex.ToString());
        }
        return conexion;
        
        
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BTLogin_Click(object sender, EventArgs e)
    {
        String claveU = TextBox1.Text;
        String contra = TextBox2.Text;
        String query = "SELECT claveU FROM usuario WHERE claveU =" + claveU + " AND passwd = '" + contra + "'";

        OdbcConnection conexion = abrirConexion();
        OdbcCommand cmm = new OdbcCommand(query, conexion);
        OdbcDataReader lector = cmm.ExecuteReader();
        if (lector.HasRows)
        {
            lector.Read();
            Session["Respuesta"] = lector.GetInt32(0);
        }
        else
            Session["Respuesta"] = "No";
        lector.Close();
        conexion.Close();
        
        Response.Redirect("Informacion.aspx");

    }
}