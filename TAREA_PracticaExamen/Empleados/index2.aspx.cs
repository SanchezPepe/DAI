using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index2 : System.Web.UI.Page
{
    protected OdbcConnection conectarDB()
    {
        OdbcConnection conexion = null;
        try
        {
            String conectar = "Driver={SQL Server Native Client 11.0}; Server=112SALAS08;Uid=sa;Pwd=sqladmin;Database=Empresa";
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
        OdbcConnection miConexion = conectarDB();
        if (miConexion != null)
        {
            String query = "SELECT p.claveP, p.totalV, sueldoB, nombre FROM empleado, pedido p";
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            GridView1.DataSource = lector;
            GridView1.DataBind();
            lbNoticias.Text = "Cargado correctamente";
        }
        else
        {
            lbNoticias.Text = "No hay datos";
        }
    }
    protected void btRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Informacion.aspx");
    }
}