using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String query = "SELECT nombre FROM empleado WHERE nombre LIKE '" + TextBox1.Text +"'";
        OdbcConnection con = conectarDB();
        OdbcCommand sql = new OdbcCommand(query, con);
        OdbcDataReader lector = sql.ExecuteReader();
        if (lector.HasRows)
        {
            lector.Read();
            Session["Ans"] = lector.GetString(0);
        }
        else
        {
            Session["Ans"] = "No";
        }
        con.Close();
        lector.Close();

        Response.Redirect("sueldo.aspx");
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("index2.aspx");
    }
}