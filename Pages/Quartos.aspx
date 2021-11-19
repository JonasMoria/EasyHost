<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MP_Administrador.master" AutoEventWireup="true" CodeFile="Quartos.aspx.cs" Inherits="Pages_Quartos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Content/css/Quartos.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <main class="pagina" id="pagina">

        <%--Localização Do Usuario--%>
        <section class="col-12 row p-2 local">
            <div class="col-4">
                <h2>Cadastrar Quarto</h2>
            </div>
            <div class="col-8 pt-3">
                <h6 style="float: right; margin-right: 10%"><strong style="color: blue">HOME</strong> / Quartos</h6>
            </div>
        </section>

        <%-- Form Para Cadastro De Quartos--%>
        <section class="col-12 row mt-2">
             <div class="form-group">
                <asp:Label ID="lblTexto" runat="server" CssClass="text-danger" Text="" Visible="false"></asp:Label>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="lblNomeQuarto" runat="server" Text="Nome" />
                <asp:TextBox ID="txtNomeQuarto" runat="server" CssClass="form-control" placeholder="Nome/Número do Quarto" />
            </div>
            <div style="margin-left: 3%; margin-top: 1%">
                <asp:Button runat="server" ID="btnCadQuarto" CssClass="btn btn-success text-white" Text="CADASTRAR" Onclick="btn_CadastrarQua_Click"/>
            </div>
        </section>

        <%-- Tabela De Quartos--%>
        <section class="col-12 row mt-2 tabQuartos border">
            <h1>Aqui fica A tabela de Quartos</h1>
        </section>

    </main>

</asp:Content>

