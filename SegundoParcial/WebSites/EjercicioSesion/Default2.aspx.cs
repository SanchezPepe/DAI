using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList productos = new ArrayList();
        if (Session["AltaProducto"] != null)
        {
            productos = (ArrayList)Session["AltaProducto"];
            Response.Write("Los productos son: " + "<br/>");
            Response.Write("<br/>");
            foreach (String item in productos)
                Response.Write(item + "<br/>");
        }
        else
            Response.Write("No se cargó ningún dato");

    }
}