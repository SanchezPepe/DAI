using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected OdbcConnection conectarDB()
    {
        OdbcConnection conexion = null;
        try {
            String conectar = "Driver={SQL Server Native Client 11.0}; Server=CC201-02;Uid=sa;Pwd=sqladmin;Database=Mensajeria";
            conexion = new OdbcConnection(conectar);
            conexion.Open();
        }
        catch (Exception e) {
            Console.Write(e.ToString());
        }

        return conexion;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btEntrar_Click(object sender, EventArgs e)
    {
        String claveU = tbClaveU.Text;
        String contra = tbContraseña.Text;
        String query = "SELECT claveU FROM usuario WHERE claveU="+claveU+" AND passwd='"+contra+"'";

        OdbcConnection miConexion = conectarDB();
        OdbcCommand sql = new OdbcCommand(query, miConexion);
        OdbcDataReader lector = sql.ExecuteReader();
        if (lector.HasRows)
        {
            lector.Read();
            Session["Respuesta"] = lector.GetInt32(0);
        }
        else {
            Session["Respuesta"] = "no";
        }
        miConexion.Close();
        lector.Close();

        Response.Redirect("Informacion.aspx");
    }
}