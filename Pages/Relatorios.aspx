<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MP_Administrador.master" AutoEventWireup="true" CodeFile="Relatorios.aspx.cs" Inherits="Pages_Relatorios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Content/css/Relatorios.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <main class="pagina" id="pagina" style="background-color: #FFF8E5">

        <%--Localização Do Usuario--%>
        <section class="col-12 row p-2 local">
            <div class="col-4">
                <h2>Relatórios</h2>
            </div>
            <div class="col-8 pt-3">
                <h6 style="float: right; margin-right: 10%"><strong style="color: #FFB344">HOME</strong> / Relatórios</h6>
            </div>
        </section>
        <%--Botão Selecionar Quarto--%>
        <section class="col-12 row mt-5" style="width: 25%; margin-left: 1%">
            <asp:DropDownList ID="QuartosDropList" CssClass="btn dropdown-toggle text-white" BackColor="DarkSlateGray" runat="Server">
                <asp:ListItem Text="Quarto" Value="1" />
                <asp:ListItem Text="Item 2" Value="2" />
                <asp:ListItem Text="Item 3" Value="3" />
                <asp:ListItem Text="Item 4" Value="4" />
                <asp:ListItem Text="Item 5" Value="5" />
            </asp:DropDownList>
        </section>
        <%-- Relatórios--%>
        <section class="col-12 row mt-2 tabRelatorios border">
            <h1>Aqui fica Os Relatórios</h1>
        </section>

    </main>

</asp:Content>

