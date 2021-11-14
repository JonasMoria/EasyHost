using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Cadastro : System.Web.UI.Page {

    static string url = "http://localhost:61416/";
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnCriar_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();
        usu.Email = txtCadUsuario.Text;
        usu.Senha = txtCadRepetirSenha.Text;
        usu.CPF = txtDoc.Text;
        usu.NomeEmpresa = txtCadNomeEmpresa.Text;

       

        UsuarioDB.Insert(usu);

        Response.Redirect(url + "Default.aspx");


    }

}
