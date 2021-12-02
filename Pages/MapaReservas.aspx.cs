using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_MapaReservas : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {

        string url = "http://localhost:52757/";
        if (Session["ADM"] == null)
            Response.Redirect(url + "Default.aspx");
        if (!Page.IsPostBack) {
            
        }

    }

}