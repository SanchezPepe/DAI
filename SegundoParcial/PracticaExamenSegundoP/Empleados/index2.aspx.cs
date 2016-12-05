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
            String conectar = "Driver={SQL Server Native Client 11.0}; Server=DESKTOP-TR4IJ0I;Uid=sa;Pwd=sqladmin;Database=Empresa";
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
            String query = "SELECT pedido.idPedido, pedido.montoT, sueldoB, nombre FROM empleado INNER JOIN pedido ON empleado.nombre = pedido.vendedor";
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            GridView1.DataSource = lector;
            GridView1.DataBind();
            lbNoticias.Text = "<br />Cargado correctamente";
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
}