using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Baja : System.Web.UI.Page
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
            OdbcCommand sql = new OdbcCommand("SELECT email FROM usuario", miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            while (lector.Read())
            {
                DropDownList1.Items.Add(lector.GetString(0));
            }
            lector.Close();
        }
    }
    protected void btRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("menu.aspx");
    }
    protected void btBaja_Click(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            String query="SELECT claveU FROM usuario WHERE email='"+DropDownList1.SelectedItem.Value+"'";
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            Object o = sql.ExecuteScalar();
            int id=(int)o;
            query = "DELETE FROM usuario WHERE claveU=" + id;
            sql = new OdbcCommand(query, miConexion);
            int res = sql.ExecuteNonQuery();
            if (res > 0)
               lbNoticias.Text = "Baja Exsitosa";
            else
               lbNoticias.Text = "No se pudo dar de baja";
            miConexion.Close();
        }
    }
}