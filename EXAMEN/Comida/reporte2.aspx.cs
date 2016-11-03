using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reporte2 : System.Web.UI.Page
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
        if (Session["Ans"] == "No")
            Response.Write("No existe");
        else
        {
            String query = "SELECT * FROM asistente INNER JOIN carrera ON asistente.claveU = carrera.claveU WHERE carrera.nombre LIKE 'otro' OR carrera.nombre LIKE 'externo'";
            OdbcConnection miConexion = conectarDB();
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            GridView1.DataSource = lector;
            GridView1.DataBind();
            lector.Close();
            query = "SELECT COUNT(claveP) FROM pago";
            sql = new OdbcCommand(query, miConexion);
            lector = sql.ExecuteReader();
            lector.Read();
            int num = lector.GetInt32(0);
            double total = 150 * num;
            lbtotal.Text = total.ToString();
        }

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("inicio.aspx");
    }
}