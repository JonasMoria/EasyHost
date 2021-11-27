using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {

    static string url = "http://localhost:52757/";

    protected void Page_Load(object sender, EventArgs e) {

        //Criando uma sessão
        Session["login"] = null;
        if (Request.Cookies["email"] != null && Request.Cookies["senha"] != null) {
            txtUsuario.Text = Request.Cookies["email"].Value;
            txtSenha.Text = Request.Cookies["senha"].Value;
        }

    }



    protected void btnLogin_Click(object sender, EventArgs e) {

        string url = "http://localhost:52757/";


        var txt = lblTexto;

        if (checkRadio(radAdm, radFun, txt)) {
            if (radAdm.Checked) {
                Administrador adm = new Administrador();
                adm.Email = txtUsuario.Text;
                adm.Senha = txtSenha.Text;
                if (AdministradorDB.LoginAdm(adm).Equals("Sucesso") && !String.IsNullOrEmpty(adm.Email) && !String.IsNullOrEmpty(adm.Senha)) {
                    Session.Add("login", "validado");
                    Response.Redirect(url + "Pages/MapaReservas.aspx");
                } else {
                    txt.Visible = true;
                }
            }
            if (radFun.Checked) {
                Funcionario func = new Funcionario();
                func.Email = txtUsuario.Text;
                func.Senha = txtSenha.Text;
                if (FuncionarioDB.LoginFunc(func).Equals("Sucesso") && !String.IsNullOrEmpty(func.Email) && !String.IsNullOrEmpty(func.Senha)) {
                    Session.Add("login", "validado");
                    Response.Redirect(url + "Pages/PagesFuncionario/MapaDeReservasF.aspx");
                } else {
                    txt.Visible = true;
                }
            }
        }

    }

    private Boolean checkRadio(CheckBox radio, CheckBox radio2, Label txt) {
        if (!radio.Checked && !radio2.Checked) {
            txt.Text = "Selecione uma das opcções acima";
            txt.Visible = true;
            return false;
        } else {
            return true;
        }
    }
}
