using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Funcionarios : System.Web.UI.Page {

    static string url = "http://localhost:52757/";
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btn_CadasdastrarFun_Click(object sender, EventArgs e)
    {
        
        Funcionario fun = new Funcionario();

        fun.CPF = txtCPFFuncionario.Text;
        fun.Nome = txtCadFuncionario.Text;
        fun.Email = txtEmailFuncionario.Text;
        fun.Senha = txtRepSenhaFuncionario.Text;
        fun.AdmCPF = "1234567";

        if (AdministradorDB.Cadastra_Funcionario(fun).Equals("Sucesso"))
        {
            lblTexto.Text = "Funcionário cadastrado com sucesso!";
            lblTexto.Visible = true;
        }
        else
        {
            lblTexto.Text = "Erro no cadastro. Verifique os dados.";
            lblTexto.Visible = true;
        }

    }
}
