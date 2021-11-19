<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MP_Administrador.master" AutoEventWireup="true" CodeFile="Funcionarios.aspx.cs" Inherits="Pages_Funcionarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Content/css/Funcionarios.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <main class="pagina" id="pagina">

        <%--Localização Do Usuario--%>
        <section class="col-12 row p-2 local">
            <div class="col-4">
                <h2>Cadastrar Funcionários</h2>
            </div>
            <div class="col-8 pt-3">
                <h6 style="float: right; margin-right: 10%"><strong style="color: blue">HOME</strong> / Funcionários</h6>
            </div>
        </section>

        <%-- Form Para Cadastro De Funcionários--%>
        <section class="col-12 row mt-2">
            <div class="form-group">
                <asp:Label ID="lblTexto" runat="server" CssClass="text-danger" Text="" Visible="false"></asp:Label>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="lblNomeFuncionario" runat="server" Text="Nome" />
                <asp:TextBox ID="txtCadFuncionario" runat="server" CssClass="form-control" placeholder="Nome do Funcionário" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblCPFFuncionario" runat="server" Text="CPF" />
                <asp:TextBox ID="txtCPFFuncionario" runat="server" CssClass="form-control" placeholder="CPF do Funcionário" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblEmailFuncionario" runat="server" Text="Email" />
                <asp:TextBox ID="txtEmailFuncionario" runat="server" CssClass="form-control" TextMode="Email" placeholder="Email do Funcionário" />
            </div>
            <div class="form-group col-12 row">
                <div class="col-md-6 col-sm-12">
                    <asp:Label ID="lblSenhaFuncionario" runat="server" Text="Senha" />
                    <asp:TextBox ID="txtSenhaFuncionario" runat="server" CssClass="form-control" TextMode="Password" placeholder="senha do Funcionário" />
                </div>
                <div class="col-md-6 col-sm-12">
                    <asp:Label ID="lblRepSenhaFuncionario" runat="server" Text="Repetir Senha" />
                    <asp:TextBox ID="txtRepSenhaFuncionario" runat="server" CssClass="form-control" TextMode="Password" placeholder="Repita Senha do Funcionário" />
                </div>
            </div>

            <div style="margin-left: 3%; margin-top: 1%">
               <asp:Button runat="server" ID="btnCadFuncionario" CssClass="btn btn-success text-white " Text="CADASTRAR" />
            </div>
         
        </section>

         <%-- Tabela De Funcionários--%>
        <section class="col-12 row mt-2 tabFuncionarios border">
            <h1>Aqui fica A tabela de funcionarios</h1>
        </section>


    </main>

</asp:Content>

