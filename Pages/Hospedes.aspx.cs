using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Hospedes : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btn_CadastrarHos_Click(object sender, EventArgs e)
    {
        Hospede hos = new Hospede();
        hos.Nome = txtNomeHospede.Text;
        hos.Telefone = txtCelHospede.Text;
        hos.AdmCPF = "1234567";

        if (AdministradorDB.Cadastra_Hospede(hos).Equals("Sucesso"))
        {
            lblTexto.Text = "Hóspede cadastrado com sucesso!";
            lblTexto.Visible = true;
        }
        else
        {
            lblTexto.Text = "Erro no cadastro. Verifique os dados.";
            lblTexto.Visible = true;
        }
    }
}
