using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Relatorios : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string url = "http://localhost:52757/";
        if (Session["ADM"] == null)
            Response.Redirect(url + "Default.aspx");
        if (!Page.IsPostBack) {
            CarregarGridView();
        }
        if (gdvRelatorios.Rows.Count > 0) {
            gdvRelatorios.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
    void CarregarGridView() {
        Administrador adm = (Administrador)Session["ADM"];
        DataSet dsUsuarios = AdministradorDB.SelectReservas(adm.CPF.ToString());
        int qtd = dsUsuarios.Tables[0].Rows.Count;
        if (qtd > 0) {
            gdvRelatorios.DataSource = dsUsuarios.Tables[0].DefaultView;
            gdvRelatorios.DataBind();
            gdvRelatorios.Visible = true;
            gdvRelatorios.HeaderRow.TableSection = TableRowSection.TableHeader;
        } else {
            gdvRelatorios.Visible = false;
        }
    }
    protected void gdvRelatorios_RowDataBound(object sender, GridViewRowEventArgs e) {

    }

}