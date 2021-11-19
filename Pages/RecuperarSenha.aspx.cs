using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_RecuperarSenha : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnVerificarCod_Click(object sender, EventArgs e) {

        var codigo = codRecSenha.Text;
        var caixaNovaSenha = formTrocarSenha;

        if (!String.IsNullOrEmpty(codigo) && !String.IsNullOrWhiteSpace(codigo)) {
            caixaNovaSenha.Visible = true;
        } else {
            lblCodRecSenha.Text = "Dados Incorretos! Preencha Novamente";
        }

    }
}