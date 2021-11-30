using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

public partial class Pages_Funcionarios : System.Web.UI.Page {


    protected void Page_Load(object sender, EventArgs e) {
        string url = "http://localhost:52757/";
        //impedindo o usuario de entrar caso não tenha feito login
        if (Session["login"] == null) {
            Response.Redirect(url + "Default.aspx");
        }
        if (!Page.IsPostBack) {
            CarregarGridView();
        }
        if (gdvFuncionarios.Rows.Count > 0) {
            gdvFuncionarios.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }

    protected void btn_CadasdastrarFun_Click(object sender, EventArgs e) {

        Funcionario fun = new Funcionario();

        fun.CPF = txtCPFFuncionario.Text;
        fun.Nome = txtCadFuncionario.Text;
        fun.Email = txtEmailFuncionario.Text;
        fun.Senha = txtRepSenhaFuncionario.Text;
        string repSenha = txtSenhaFuncionario.Text;
        fun.AdmCPF = Session["getCpf"].ToString();

        if (validaCadastro(fun, repSenha)) {
            if (AdministradorDB.Cadastra_Funcionario(fun).Equals("Sucesso")) {
                lblTexto.Text = "Funcionário cadastrado com sucesso!";
                lblTexto.Visible = true;
                CarregarGridView();
                txtCPFFuncionario.Text = "";
                txtCadFuncionario.Text = "";
                txtEmailFuncionario.Text = "";
                txtRepSenhaFuncionario.Text = "";
            } else {
                lblTexto.Text = "Erro no cadastro. Verifique os dados.";
                lblTexto.Visible = true;
            }
        } else {
            lblTexto.Text = "Erro no cadastro. Verifique os dados.";
            lblTexto.Visible = true;
        }

    }

    private Boolean validaCadastro(Funcionario f, String senha) {
        if (!String.IsNullOrWhiteSpace(f.Email) && !String.IsNullOrWhiteSpace(f.Nome)) {
            if (f.CPF.Length == 11) {
                if (senha.Equals(f.Senha)) {
                    return true;
                }
            }
        }
        return false;
    }
    void CarregarGridView() {
        DataSet dsUsuarios = AdministradorDB.SelectFuncionarios(Session["getCpf"].ToString());
        int qtd = dsUsuarios.Tables[0].Rows.Count;
        if (qtd > 0) {
            gdvFuncionarios.DataSource = dsUsuarios.Tables[0].DefaultView;
            gdvFuncionarios.DataBind();
            gdvFuncionarios.Visible = true;
            gdvFuncionarios.HeaderRow.TableSection = TableRowSection.TableHeader;
        } else {
            gdvFuncionarios.Visible = false;
        }

    }

    protected void gdvFuncionarios_RowDataBound(object sender, GridViewRowEventArgs e) {



    }

    protected void btnExcluir_Click(object sender, EventArgs e) {

    }
}
