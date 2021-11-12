using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {

    static string url = "http://localhost:52757/";

    protected void Page_Load(object sender, EventArgs e) {

        //postback

    }



    protected void btnLogin_Click(object sender, EventArgs e) {

        var usuario = txtUsuario;
        var senha = txtSenha;

        if (!String.IsNullOrWhiteSpace(usuario.Text) || senha.Text != "")

            Response.Redirect(url);

        else

            lblTexto.Visible = true;
         


    }
}
