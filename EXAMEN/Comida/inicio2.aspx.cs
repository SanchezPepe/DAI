using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class inicio2 : System.Web.UI.Page
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
        
        OdbcConnection miConexion = conectarDB();
        if (miConexion != null)
        {
            OdbcCommand sql = new OdbcCommand("SELECT nombre FROM universidad", miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            while (lector.Read())
            {
                DropDownList1.Items.Add(lector.GetString(0));
            }
            lector.Close();
            miConexion.Close();
        }
    }

    protected void btuni_Click(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarDB();
        if (miConexion != null)
        {
            String query = "SELECT asistente.claveU, asistente.nombre, asistente.apellido, asistente.sexo, asistente.correo FROM asistente INNER JOIN universidad_asistente ON asistente.claveU = universidad_asistente.claveU INNER JOIN universidad ON universidad_asistente.claveUni = universidad.claveUni WHERE universidad.nombre LIKE '" + DropDownList1.SelectedItem.Value + "'";
            OdbcCommand sql = new OdbcCommand(query, miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            GridView1.DataSource = lector;
            GridView1.DataBind();
    }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("inicio.aspx");
    }
}