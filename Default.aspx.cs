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

        string url = "http://localhost:52757/";
        Administrador adm  = new Administrador();
        adm.Email = txtUsuario.Text;
        adm.Senha = txtSenha.Text;

        var txt = lblTexto;

        if (AdministradorDB.LoginAdm(adm).Equals("Sucesso") && !String.IsNullOrEmpty(adm.Email) && !String.IsNullOrEmpty(adm.Senha)) {
            Response.Redirect(url+"Pages/MapaReservas.aspx");
        } else {
            txt.Visible = true;
        }

    }
}
