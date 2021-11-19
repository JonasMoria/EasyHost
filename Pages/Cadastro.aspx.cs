using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Cadastro : System.Web.UI.Page {

    static string url = "http://localhost:52757/";
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnCriar_Click(object sender, EventArgs e) {

        Administrador adm = new Administrador();
        adm.CPF = txtDoc.Text;
        adm.Email = txtCadUsuario.Text;
        adm.Senha = txtCadRepetirSenha.Text;
        adm.NomeEmpresa = txtCadNomeEmpresa.Text;




        if (AdministradorDB.Insert(adm).Equals("Sucesso") && adm.CPF != "" && adm.Email != "") {

            lblTexto.Text = "Cadastrado com sucesso! Volte para fazer Login";
            lblTexto.Visible = true;

        } else if (AdministradorDB.Insert(adm).Equals("Duplicate entry" + " " + "'" + adm.CPF + "'" + " " + "for key 'adm_administrador.PRIMARY'")) {
            lblTexto.Text = "Esse usuário já existe em nosso sistema";
            lblTexto.Visible = true;
        } else {
            lblTexto.Text = "Erro no cadastro. Verifique seus dados";
            lblTexto.Visible = true;
        }
    }
}