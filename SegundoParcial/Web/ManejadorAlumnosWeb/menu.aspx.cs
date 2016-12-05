using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class menu : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        String stringDeConexion = "Driver={SQL Server Native Client 11.0};Server=CC201-02;Uid=sa;Pwd=sqladmin;Database=gamespot;";
        try
        {
            OdbcConnection conexion = new OdbcConnection(stringDeConexion);
            conexion.Open();
            return conexion;
        }
        catch (Exception ex)
        {
            lbNoticias.Text = "no se pudo hacer la conexion" + ex.StackTrace.ToString();
            return null;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            OdbcCommand sql = new OdbcCommand("SELECT * FROM usuario", miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            GridView1.DataSource = lector;
            GridView1.DataBind();
        }
        else
        {
            lbNoticias.Text = "No se pudo hacer el llenado del Grid";
        }
    }
    protected void btAlta_Click(object sender, EventArgs e)
    {
        Response.Redirect("Alta.aspx");
    }
    protected void btBaja_Click(object sender, EventArgs e)
    {
        Response.Redirect("Baja.aspx");
    }
    protected void btModificaciones_Click(object sender, EventArgs e)
    {
        Response.Redirect("Modificaciones.aspx");
    }
}