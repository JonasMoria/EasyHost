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

    protected void btnCriar_Click(object sender, EventArgs e)
    {

        Funcionario fun = new Funcionario();
        fun.Nome = "0";
        fun.CPF = "1";

        Administrador adm = new Administrador();
        adm.CPF = txtDoc.Text;
        adm.Nome = "teste";

        

        Usuario usu = new Usuario();
        usu.Email = txtCadUsuario.Text;
        usu.Senha = txtCadRepetirSenha.Text;
        usu.ADM_CPF = txtDoc.Text;
        usu.FUN_CPF = "0";
        usu.NomeEmpresa = txtCadNomeEmpresa.Text;  

       if (usu.ADM_CPF != "")
        {
            FuncionarioDB.Insert(fun);
            AdministradorDB.Insert(adm);
            UsuarioDB.Insert(usu);

            Response.Redirect(url + "Default.aspx");
        }
          
            
        
        
        
      


    }

}
