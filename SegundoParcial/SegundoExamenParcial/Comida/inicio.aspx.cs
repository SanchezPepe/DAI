using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

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

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "otro")
        {
            Response.Redirect("reporte2.aspx");
        }
        else
        {
            if (TextBox1.Text == "")
                lbnoticias.Text = "Ingrese datos";
            else
            {
                Session["Ans"] = TextBox1.Text;
                Response.Redirect("reporte.aspx");
            }
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("inicio2.aspx");
    }
}