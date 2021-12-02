using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {

    static string url = "http://localhost:52757/";

    protected void Page_Load(object sender, EventArgs e) {

    }



    protected void btnLogin_Click(object sender, EventArgs e) {

        string url = "http://localhost:52757/";


        var txt = lblTexto;

        if (radAdm.Checked) {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text)) {
                Administrador adm = AdministradorDB.LoginAdm(txtUsuario.Text, Comuns.HashTexto(txtSenha.Text));
                if (adm != null) {
                    Session["ADM"] = adm;
                    Response.Redirect(url + "Pages/MapaReservas.aspx");
                } else {
                    txt.Visible = true;
                    txt.Text = "Usuário Inválido, Verifique seus dados";
                }

            } else {
                txt.Visible = true;
                txt.Text = "Campos Vazios, Verifique seus dados";
            }
        }

        if (radFun.Checked) {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text)) {
                Funcionario fun = FuncionarioDB.LoginFun(txtUsuario.Text, Comuns.HashTexto(txtSenha.Text));
                if (fun != null) {
                    Session["FUN"] = fun;
                    Response.Redirect(url + "Pages/PagesFuncionario/MapaDeReservasF.aspx");
                } else {
                    txt.Visible = true;
                    txt.Text = "Usuário Inválido, Verifique seus dados";
                }

            } else {
                txt.Visible = true;
                txt.Text = "Campos Vazios, Verifique seus dados";
            }
        }


    }
}



