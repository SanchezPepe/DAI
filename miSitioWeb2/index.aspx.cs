using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        String stringDeConexion = "Driver={SQL Server Native Client 11.0};Server=CC201-02;Uid=sa;Pwd=sqladmin;Database=gamespot;";
        try
        {
            OdbcConnection conexion = new OdbcConnection(stringDeConexion);
            conexion.Open();
            return conexion;
        } catch(Exception ex)
        {
            Label1.Text = "no se pudo hacer la conexion" + ex.StackTrace.ToString();
            return null;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            OdbcCommand sql = new OdbcCommand("SELECT nombre FROM juegos",miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            DropDownList1.Items.Clear();
            while (lector.Read())
            {
                DropDownList1.Items.Add(lector.GetString(0));
            }
            lector.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            String query = "SELECT claveU FROM usuario WHERE email='"+tbUsario.Text+"'AND password='"+tbContraseña.Text+"'";
            OdbcCommand sql = new OdbcCommand(query,miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                Response.Redirect("menu.aspx");
            }
            else
            {
                Label1.Text = "El usuario o password son incorrectos";
            }
        }
    }
}