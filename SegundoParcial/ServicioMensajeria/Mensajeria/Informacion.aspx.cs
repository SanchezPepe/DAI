using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Informacion : System.Web.UI.Page
{
    protected OdbcConnection conectarDB()
    {
        OdbcConnection conexion = null;
        try
        {
            String conectar = "Driver={SQL Server Native Client 11.0}; Server=CC201-02;Uid=sa;Pwd=sqladmin;Database=Mensajeria";
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
        if (Session["Respuesta"] == "no")
            Response.Write("Usuario y/o contraseña incorrectas");
        else
        {
            String query = "SELECT * FROM usuario WHERE claveU=" + Session["Respuesta"];

            OdbcConnection miConexion = conectarDB();
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                String datos = "Clave unica: ";
                datos = datos + lector.GetInt32(0)
                    +"</br>Nombre: " + lector.GetString(1)
                    +"</br>Correo: " + lector.GetString(2)
                    +"</br>Contraseña: " + lector.GetString(3)
                    +"</br>Edad: " + lector.GetInt32(4);
                Response.Write("Los datos del usuario son:" + "</br>");
                Response.Write(datos);
            }
            lector.Close();
            miConexion.Close();
        }
    }
    protected void btMensaje_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mensajes.aspx");
    }
    protected void btBusqueda_Click(object sender, EventArgs e)
    {
        Response.Redirect("MostrarInfo.aspx");
    }
}