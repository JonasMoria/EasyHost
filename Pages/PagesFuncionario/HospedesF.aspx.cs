using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_PagesFuncionario_HospedesF : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string url = "http://localhost:52757/";
        //impedindo o usuario de entrar caso não tenha feito login
        if (Session["login"] == null) {
            Response.Redirect(url + "Default.aspx");
        }
    }
}