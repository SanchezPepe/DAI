using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sueldo : System.Web.UI.Page
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
        if (Session["Ans"] == "No")
            Response.Write("El empleado no existe");
        else
        {
            String query = "SELECT sueldoB, pedido.montoT FROM empleado INNER JOIN pedido ON empleado.nombre = pedido.vendedor WHERE nombre LIKE '" + Session["Ans"] + "'";

            OdbcConnection miConexion = conectarDB();
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            double sueldoB = 0;
            double ventaT = 0;
            if (lector.HasRows)
            {
                lector.Read();
                sueldoB = lector.GetFloat(0);
                ventaT = lector.GetDouble(1);
                if (ventaT >= 100 && ventaT <= 1000)
                {
                    ventaT = ventaT * 0.1;
                }
                if (ventaT > 1000 && ventaT <= 2000)
                {
                    ventaT = ventaT * 0.2;
                }
                if (ventaT > 2000 && ventaT <= 4000)
                {
                    ventaT = ventaT * 0.25;
                }
                else
                {
                    ventaT = ventaT * 0.35;
                }

                Response.Write("Sueldo final con comisiones de: " + Session["Ans"] + "<br/>");
                double final = sueldoB + ventaT;
                Response.Write("$" + final);
            }
            lector.Close();
            miConexion.Close();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
}