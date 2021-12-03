<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MP_Administrador.master" AutoEventWireup="true" CodeFile="Funcionarios.aspx.cs" Inherits="Pages_Funcionarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Content/css/Funcionarios.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <main class="pagina" id="pagina" style="background-color: #FFF8E5">

        <%--Localização Do Usuario--%>
        <section class="col-12 row p-2 local">
            <div class="col-4">
                <h2>Cadastrar Funcionarios</h2>
            </div>
            <div class="col-8 pt-3">
                <h6 style="float: right; margin-right: 10%"><strong style="color: #E05D5D">HOME</strong> / Funcionarios</h6>
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
                <asp:Button runat="server" ID="btnCadFuncionario" CssClass="btn btn-success text-white " Text="CADASTRAR" OnClick="btn_CadasdastrarFun_Click" />
            </div>
        </section>
        <%-- Tabela De Funcionários--%>
        <div class="row" style="margin-top: 3%">
            <style>
                .dt-button {
                    background-color: goldenrod !important;
                    color: white !important;
                    border: none !important;
                }
            </style>
            <div class="col-md-12 tabFuncionarios">
                <asp:GridView ID="gdvFuncionarios" runat="server" AutoGenerateColumns="false" CssClass="table table-hover table-borderless tabela" OnRowDataBound="gdvFuncionarios_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="FUN_NOME" HeaderText="NOME" />
                        <asp:BoundField DataField="FUN_EMAIL" HeaderText="E-MAIL" />
                        <asp:BoundField DataField="FUN_CPF" HeaderText="CPF" />
                        <asp:TemplateField HeaderText="EDITAR">
                            <ItemTemplate>
                                <button type="button" data-toggle="modal" class="btn btn-warning color-white" data-target="#modalEditar">
                                    <i class="fa fa-pencil-alt"></i>
                                </button>
                                <button type="button" data-toggle="modal" class="btn btn-danger color-white" data-target="#modalExcluir">
                                    <i class="fa fa-times"></i>
                                </button>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>

        <!-- Modal Excluir Funcionario -->
        <section class="modal fade" id="modalExcluir" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">EXCLUIR FUNCIONARIO</h5>
                        <button type="button" class="close btn" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times"></i>
                        </button>
                    </div>
                    <div class="modal-body">
                        <h2>DESEJA EXCLUIR ESTE FUNCIONARIO?</h2>
                    </div>
                    <div class="modal-footer">
                        <button type="button" style="background-color: forestgreen; color: white; border-color: black" class="btn " data-dismiss="modal">CANCELAR</button>
                        <asp:Button runat="server" ID="btnExcluirHosp" OnClick="btnExcluir_Click" CssClass="btn text-white bg-danger" Text="EXCLUIR" BackColor="green" BorderColor="Black" />
                    </div>
                </div>
            </div>
        </section>

        <!-- Modal Editar Funcionario -->
        <section class="modal fade" id="modalEditar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="">EDITAR FUNCIONARIO</h5>
                        <button type="button" class="close btn" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times"></i>
                        </button>
                    </div>
                    <div class="modal-body">
                        <asp:Label ID="lblEditNome" runat="server" Text="Nome" />
                        <asp:TextBox ID="txtCheckIn" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblEditEmail" runat="server" Text="Email" />
                        <asp:TextBox ID="txtEditEmail" runat="server" CssClass="form-control" TextMode="Email" />
                        <br />
                        <asp:Label ID="lblEditSenha" runat="server" Text="Senha" />
                        <asp:TextBox ID="txtEditSenha" runat="server" CssClass="form-control" TextMode="Password" />
                        <br />
                        <asp:Label ID="lblEditRepSenha" runat="server" Text="Repita a Senha" />
                        <asp:TextBox ID="txtEditRepSenha" runat="server" CssClass="form-control" TextMode="Password" />

                    </div>
                    <div class="modal-footer">
                        <button type="button" style="background-color: crimson; color: white; border-color: black" class="btn " data-dismiss="modal">CANCELAR</button>
                        <asp:Button runat="server" ID="btnEditar" CssClass="btn text-white" Text="SALVAR" BackColor="green" BorderColor="Black" />
                    </div>
                </div>
            </div>
        </section>

    </main>

</asp:Content>

