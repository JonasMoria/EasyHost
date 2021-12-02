using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_PagesFuncionario_HospedesF : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string url = "http://localhost:52757/";
        if (Session["FUN"] == null)
            Response.Redirect(url + "Default.aspx");
        if (!Page.IsPostBack) {
            CarregarGridView();
        }
        if (gdvHospedes.Rows.Count > 0) {
            gdvHospedes.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
    protected void btn_CadastrarHos_Click(object sender, EventArgs e) {

        Funcionario fun = (Funcionario)Session["FUN"]; 
        Hospede hos = new Hospede();
        hos.Nome = txtNomeHospede.Text;
        hos.Telefone = txtCelHospede.Text;
        hos.AdmCPF = fun.AdmCPF.ToString();

        if (AdministradorDB.Cadastra_Hospede(hos).Equals("Sucesso")) {
            lblTexto.Text = "Hóspede cadastrado com sucesso!";
            lblTexto.Visible = true;
            CarregarGridView();
            txtCelHospede.Text = "";
            txtNomeHospede.Text = "";
        } else {
            lblTexto.Text = "Erro no cadastro. Verifique os dados.";
            lblTexto.Visible = true;
        }
    }

    void CarregarGridView() {
        Funcionario fun = (Funcionario)Session["FUN"];
        DataSet dsUsuarios = AdministradorDB.SelectHospedes(fun.AdmCPF);
        int qtd = dsUsuarios.Tables[0].Rows.Count;
        if (qtd > 0) {
            gdvHospedes.DataSource = dsUsuarios.Tables[0].DefaultView;
            gdvHospedes.DataBind();
            gdvHospedes.Visible = true;
            gdvHospedes.HeaderRow.TableSection = TableRowSection.TableHeader;
        } else {
            gdvHospedes.Visible = false;
        }

    }
    protected void gdvHospedes_RowDataBound(object sender, GridViewRowEventArgs e) {

    }

    protected void btnExcluirFunc_Click(object sender, EventArgs e) {

    }
}