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

        if (validaCampos(txtCadUsuario.Text, txtCadSenha.Text, txtCadRepetirSenha.Text, txtDoc.Text, txtCadNomeEmpresa.Text)) {
            if (validaSenhas(txtCadSenha.Text, txtCadRepetirSenha.Text)) {
                //Gravar no Banco
                Administrador adm = new Administrador();
                adm.CPF = txtDoc.Text;
                adm.Email = txtCadUsuario.Text;
                adm.Senha = txtCadRepetirSenha.Text;
                adm.NomeEmpresa = txtCadNomeEmpresa.Text;

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
                lblTexto.Visible = true;
                lblTexto.Text = "Senhas Diferentes, verifique novamente";
            }

        } else {
            lblTexto.Visible = true;
            lblTexto.Text = "Dados Inválidos, verifique os campos";
        }

    }
    private bool validaSenhas(String senha, String testeSenha) {
        if (!String.IsNullOrWhiteSpace(senha) && !String.IsNullOrWhiteSpace(testeSenha)) {
            if (senha.Equals(testeSenha)) {
                return true;
            }
        }
        return false;
    }

    private bool validaCampos(string email, string senha, string repSenha, string cpf, string empresa) {

        if (!String.IsNullOrWhiteSpace(email) && !String.IsNullOrWhiteSpace(senha) && !String.IsNullOrWhiteSpace(repSenha) && !String.IsNullOrWhiteSpace(cpf) && !String.IsNullOrWhiteSpace(empresa)) {
            if (senha.Length >= 8 && repSenha.Length >= 8) {
                if (cpf.Length == 11 || cpf.Length == 14) {
                    return true;
                }
            }
        }

        return false;
    }
}
