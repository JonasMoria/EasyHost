<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MP_Administrador.master" AutoEventWireup="true" CodeFile="Hospedes.aspx.cs" Inherits="Pages_Hospedes" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Content/css/Hospedes.css" rel="stylesheet"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <main class="pagina" id="pagina">

        <%--Localização Do Usuario--%>
        <section class="col-12 row p-2 local">
            <div class="col-4">
                <h2>Cadastrar Hóspedes</h2>
            </div>
            <div class="col-8 pt-3">
                <h6 style="float: right; margin-right: 10%"><strong style="color: blue">HOME</strong> / Hóspede</h6>
            </div>
        </section>

        <%-- Form Para Cadastro De Hóspedes--%>
        <section class="col-12 row mt-2">
            <div class="form-group">
                <asp:Label ID="lblNomeHospede" runat="server" Text="Nome" />
                <asp:TextBox ID="txtNomeHospede" runat="server" CssClass="form-control" placeholder="Nome do Hóspede" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblTelHospede" runat="server" Text="Contato" />
                <asp:TextBox ID="txtCelHospede" runat="server" CssClass="form-control" placeholder="Contato do Hóspede" />
            </div>
            <div style="margin-left: 3%; margin-top: 1%">
                <asp:Button runat="server" ID="btnCadHospede" CssClass="btn btn-success text-white " Text="CADASTRAR" />
            </div>
        </section>

        <%-- Tabela De Hóspedes--%>
        <section class="col-12 row mt-2 tabHospedes border">
            <h1>Aqui fica A tabela de Hóspedes</h1>
        </section>

    </main>

</asp:Content>

