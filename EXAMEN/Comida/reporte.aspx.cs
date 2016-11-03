using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reporte : System.Web.UI.Page
{
    protected OdbcConnection conectarDB()
    {
        OdbcConnection conexion = null;
        try
        {
            String conectar = "Driver={SQL Server Native Client 11.0}; Server=CC201-01;Uid=sa;Pwd=sqladmin;Database=datosIngenieria";
            conexion = new OdbcConnection(conectar);
            conexion.Open();
        }
        catch (Exception e)
        {
            Console.Write(e.ToString());
        }

        return conexion;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        String query = "SELECT * FROM asistente INNER JOIN carrera ON asistente.claveU = carrera.claveU WHERE carrera.nombre LIKE '" + Session["Ans"] + "'";
        OdbcConnection miConexion = conectarDB();
        OdbcCommand sql = new OdbcCommand(query, miConexion);
        OdbcDataReader lector = sql.ExecuteReader();
        if (!lector.HasRows)
            Label1.Text = "No existe, intente de nuevo";
        else
        {
            GridView1.DataSource = lector;
            GridView1.DataBind();
        }
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("inicio.aspx");
    }
}