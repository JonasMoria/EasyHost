using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Cadastro : System.Web.UI.Page {


    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnCriar_Click(object sender, EventArgs e) {

        Usuario usuario = new Usuario();

        usuario.Email = txtCadUsuario.Text;
        usuario.Senha = txtCadSenha.Text;
        usuario.ADM_CPF = txtDoc.Text;
        usuario.NomeEmpresa = txtCadNomeEmpresa.Text;

        lblErro.Text = "Sucesso No Cadastro";
        lblErro.Visible = true;

        UsuarioDB.Insert(usuario);

        if (UsuarioDB.Insert(usuario).Equals("Sucesso")) {
            lblErro.Text = "Sucesso No Cadastro";
            lblErro.Visible = true;
        } else {
            lblErro.Text = UsuarioDB.Insert(usuario);
            lblErro.Visible = true;
        }




    }

}
