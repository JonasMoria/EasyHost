using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_PagesFuncionario_QuartosF : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string url = "http://localhost:52757/";
        //impedindo o usuario de entrar caso não tenha feito login
        if (Session["login"] == null) {
            Response.Redirect(url + "Default.aspx");
        }
        if (!Page.IsPostBack) {
            CarregarGridView();
        }
        if (gdvQuartos.Rows.Count > 0) {
            gdvQuartos.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
    protected void btn_CadastrarQua_Click(object sender, EventArgs e) {
        Quarto qua = new Quarto();

        qua.Nome = txtNomeQuarto.Text;
        qua.Situacao = "Disponivel";
        qua.AdmCPF = Session["getCpf"].ToString();

        if (AdministradorDB.Cadastra_Quarto(qua).Equals("Sucesso")) {
            lblTexto.Text = "Quarto cadastrado com sucesso!";
            lblTexto.Visible = true;
            CarregarGridView();
            txtNomeQuarto.Text = "";
        } else {
            lblTexto.Text = "Erro no cadastro. Verifique os dados.";
            lblTexto.Visible = true;
        }

    }
    void CarregarGridView() {
        DataSet dsUsuarios = AdministradorDB.SelectQuartos(Session["getCpf"].ToString());
        int qtd = dsUsuarios.Tables[0].Rows.Count;
        if (qtd > 0) {
            gdvQuartos.DataSource = dsUsuarios.Tables[0].DefaultView;
            gdvQuartos.DataBind();
            gdvQuartos.Visible = true;
            gdvQuartos.HeaderRow.TableSection = TableRowSection.TableHeader;
        } else {
            gdvQuartos.Visible = false;
        }
    }
    protected void gdvQuartos_RowDataBound(object sender, GridViewRowEventArgs e) {

    }

    protected void btnExcluirFunc_Click(object sender, EventArgs e) {

    }
}