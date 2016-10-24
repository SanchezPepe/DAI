using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Alta : System.Web.UI.Page
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
        
    }
    protected void btAgregar_Click(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            OdbcCommand sql = new OdbcCommand("SELECT MAX(claveU) FROM usuario", miConexion);
            Object o = sql.ExecuteScalar();
            int num = int.Parse(tbEdad.Text);
            if (DBNull.Value.Equals(o))
            {
                //Es el primer dato y la llave primaria debe ser 1
                String query = "INSERT INTO usuario values(1,'" + tbCorreo.Text + "','"
                    + tbCont.Text + "','" + tbNombre.Text + "','" + tbSexo.Text + "'," + num + ")";
                sql = new OdbcCommand(query, miConexion);
                int res=sql.ExecuteNonQuery();
                lbNoticias.Text = res.ToString();
            }
            else
            {
                int llaveprimaria = (int)o;
                llaveprimaria++;
                String query = "INSERT INTO usuario values("+llaveprimaria+",'" + tbCorreo.Text + "','"
                    + tbCont.Text + "','" + tbNombre.Text + "','" + tbSexo.Text + "'," + num + ")";
                sql = new OdbcCommand(query, miConexion);
                int res = sql.ExecuteNonQuery();
                if (res > 0)
                    lbNoticias.Text = "Alta Exsitosa";
                else
                    lbNoticias.Text = "No se pudo realizar el alta";
            }
            miConexion.Close();
        }
    }
    protected void btRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("menu.aspx");
    }
}