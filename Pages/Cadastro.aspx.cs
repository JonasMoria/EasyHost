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
        String testeSenha = txtCadSenha.Text;
        adm.Senha = txtCadRepetirSenha.Text;
        adm.NomeEmpresa = txtCadNomeEmpresa.Text;

        if (validaStrings(adm.Email, adm.NomeEmpresa) && validaSenhas(txtCadSenha.Text, txtCadRepetirSenha.Text) && validaDocumento(adm.CPF)) {

            if (AdministradorDB.VerificaUsuarioExistente(adm.CPF).Equals("Existe")) {
                lblTexto.Text = "Usuário Já Existe!";
                lblTexto.Visible = true;
            }
            if (AdministradorDB.VerificaUsuarioExistente(adm.CPF).Equals("NaoExiste")) {
                if (AdministradorDB.Insert(adm).Equals("Sucesso")) {
                    lblTexto.Text = "Cadastrado com sucesso! Volte para fazer Login";
                    lblTexto.Visible = true;
                }
            }

        } else {
            lblTexto.Text = "Erro no cadastro. Verifique seus dados";
            lblTexto.Visible = true;
        }
    }

    private Boolean validaStrings(String email, String empresa) {
        if (String.IsNullOrWhiteSpace(email) && String.IsNullOrWhiteSpace(empresa)) {
            return false;
        } else {
            return true;
        }
    }
    private Boolean validaSenhas(String senha, String testeSenha) {

        Boolean autorizado = false;

        if (!String.IsNullOrWhiteSpace(senha) && !String.IsNullOrWhiteSpace(testeSenha)) {
            if (senha.Length >= 8 && testeSenha.Length >= 8) {
                if (senha.Equals(testeSenha)) {
                    autorizado = true;
                }
            }
        }

        return autorizado;
    }
    private Boolean validaDocumento(String documento) {

        Boolean autorizado = false;

        if (!String.IsNullOrWhiteSpace(documento)) {
            if (documento.Length == 11 || documento.Length == 14) {
                autorizado = true;
            }
        }

        return autorizado;
    }
}
