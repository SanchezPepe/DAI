using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ArrayList productos;
        if (Session["AltaProducto"] != null)
            productos = (ArrayList)Session["AltaProducto"];
        else
            productos = new ArrayList();
        productos.Add(TextBox1.Text);
        TextBox1.Text = "";
        Session["AltaProducto"] = productos;
    }
}