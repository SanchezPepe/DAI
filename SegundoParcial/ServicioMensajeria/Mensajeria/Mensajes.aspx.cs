using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mensajes : System.Web.UI.Page
{
    protected OdbcConnection conectarBD()
    {
        String stringDeConexion = "Driver={SQL Server Native Client 11.0};Server=CC201-02;Uid=sa;Pwd=sqladmin;Database=Mensajeria;";
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
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            String query = "SELECT claveU FROM usuario";
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            while (lector.Read())
            {
                DropDownList1.Items.Add(lector.GetString(0));
            }
            lector.Close();
        }
        else
        {
            lbNoticias.Text = "No hay datos";
        }
    }
    protected void btEnviar_Click(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            String query = "SELECT COUNT(*) FROM mensaje";
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            Object o = sql.ExecuteScalar();
            int cont = (int)o + 1;
            lbNoticias.Text = DateTime.Now.ToString();

            query = "INSERT INTO mensaje VALUES(" + cont + ",'" + tbAsunto.Text + "','" + tbMensaje.Text + "','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortDateString() + "',"+Session["Respuesta"]+"," + DropDownList1.SelectedItem.ToString() + ")";
            sql = new OdbcCommand(query, miConexion);
            int res = sql.ExecuteNonQuery();
            if (res > 0)
                lbNoticias.Text = "Mensaje enviado";
            else
                lbNoticias.Text = "Error";
        }
        else
        {
            lbNoticias.Text = "ERROR 404: Not Found";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Informacion.aspx");
    }
}