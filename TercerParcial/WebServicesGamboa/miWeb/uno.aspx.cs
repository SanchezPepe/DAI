using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int intOp1 = int.Parse(Request.Form["op1"]);
        int intOp2 = int.Parse(Request.Form["op2"]);
        int res = intOp1 + intOp2;
        
        Response.Write("<br /> + La suma de "+ intOp1+" y "+intOp2+" es igual a "+res);
    }
}