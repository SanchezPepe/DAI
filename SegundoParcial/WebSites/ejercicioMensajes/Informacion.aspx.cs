using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Informacion : System.Web.UI.Page
{

    protected OdbcConnection abrirConexion()
    {
        OdbcConnection conexion = null;
        try
        {
            String conectar = "Driver={SQL Server Native Client 11.0}; Server=CC201-17,Uid=sa,Psw=sqladmin;Database=mensajeria";
            conexion = new OdbcConnection(conectar);
            conexion.Open();
        }
        catch (Exception ex)
        {
            Console.Write(ex.ToString());
        }
        return conexion;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Respuesta"] == "No")
            Response.Write("Usuario o contraseña incorrecta");
        else
        {
            String query = "SELECT * FROM usuario WHERE claveU =" + Session["Respuesta"];

            OdbcConnection conexion = abrirConexion();
            OdbcCommand cmm = new OdbcCommand(query, conexion);
            OdbcDataReader lector = cmm.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                String datos = "Clave única:";
                datos = datos + lector.GetInt32(0)
                    + "</br> Nombre: " + lector.GetString(1)
                    + "</br> Correo: " + lector.GetString(2)
                    + "</br> Contraseña: " + lector.GetString(3)
                    + "</br> Edad: " + lector.GetInt32(4);
                Response.Write("Los datos del usuario son: " + "</br>");
                Response.Write(datos);
            }
            lector.Close();
            conexion.Close();
        }
    }
}