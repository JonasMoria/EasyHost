using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Cadastro : System.Web.UI.Page {


    protected void Page_Load(object sender, EventArgs e) {

    }

<<<<<<< HEAD
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
=======
    protected void btnCriar_Click(object sender, EventArgs e)
    {

        Administrador adm = new Administrador();
        adm.CPF = txtDoc.Text;
        adm.Email = txtCadUsuario.Text;
        adm.Senha = txtCadRepetirSenha.Text;
        adm.NomeEmpresa = txtCadNomeEmpresa.Text;


       

        if (AdministradorDB.Insert(adm).Equals("Sucesso") && adm.CPF != "" && adm.Email != "")
        {

            lblTexto.Text = "Cadastrado com sucesso! Volte para fazer Login";
            lblTexto.Visible = true;

        } 
        else if (AdministradorDB.Insert(adm).Equals("Duplicate entry"+" "+"'"+adm.CPF+"'"+" "+"for key 'adm_administrador.PRIMARY'"))
        {

            lblTexto.Text = "Esse usuário já existe em nosso sistema";
            lblTexto.Visible = true;
        }
        else
        {
            lblTexto.Text = "Erro no cadastro. Verifique seus dados";
            lblTexto.Visible = true;
>>>>>>> 512450c6c7aa16a9ff9f46caee1def8b5c9add76
        }




    }

}
