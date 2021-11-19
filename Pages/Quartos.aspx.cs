using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Quartos : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btn_CadastrarQua_Click(object sender, EventArgs e)
    {
        Quarto qua = new Quarto();

        qua.Nome = txtNomeQuarto.Text;
        qua.Situacao = "Disponivel";
        qua.AdmCPF = "1234567";

        if (AdministradorDB.Cadastra_Quarto(qua).Equals("Sucesso"))
        {
            lblTexto.Text = "Quarto cadastrado com sucesso!";
            lblTexto.Visible = true;
        }
        else
        {
            lblTexto.Text = "Erro no cadastro. Verifique os dados.";
            lblTexto.Visible = true;
        }

    }
}
