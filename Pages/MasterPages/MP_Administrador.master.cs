using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_MasterPages_MP_Administrador : System.Web.UI.MasterPage {
    protected void Page_Load(object sender, EventArgs e) {
        string url = "http://localhost:52757/";
        if (Session["ADM"] == null)
            Response.Redirect(url + "Default.aspx");

         Administrador d = (Administrador)Session["ADM"];
        //lblAdm.Text = d.Email;
    }



    protected void btnSair_Click(object sender, EventArgs e) {
        string url = "http://localhost:52757/";
        Session.Remove("ADM");
        Response.Redirect(url + "Default.aspx");
    }
}
