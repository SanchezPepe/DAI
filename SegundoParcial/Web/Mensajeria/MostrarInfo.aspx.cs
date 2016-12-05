using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MostrarInfo : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        String stringDeConexion = "Driver={SQL Server Native Client 11.0};Server=112SALAS08;Uid=sa;Pwd=sqladmin;Database=Mensajes;";
        try
        {
            OdbcConnection conexion = new OdbcConnection(stringDeConexion);
            conexion.Open();
            return conexion;
        }
        catch (Exception ex)
        {
            lbNoticias.Text = "No se pudo hacer la conexion" + ex.StackTrace.ToString();
            return null;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Reporte_Click(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            String query = "SELECT emisor,usuario.nombre, usuario.email, count(*) as 'Numero de mensajes' FROM mensaje INNER JOIN usuario ON usuario.claveU=mensaje.emisor WHERE fechaEnvio >= '" + tbInicio.Text + "' AND fechaEnvio < '" + tbFin.Text + "' GROUP BY mensaje.emisor,usuario.nombre,usuario.email";
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            GridView1.DataSource = lector;
            GridView1.DataBind();
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