<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MP_Funcionario.master" AutoEventWireup="true" CodeFile="HospedesF.aspx.cs" Inherits="Pages_PagesFuncionario_HospedesF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Content/css/Hospedes.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <main class="pagina" id="pagina" style="background-color: #FFF8E5">

        <%--Localização Do Usuario--%>
        <section class="col-12 row p-2 local">
            <div class="col-4">
                <h2>Cadastrar Hóspedes</h2>
            </div>
            <div class="col-8 pt-3">
                <h6 style="float: right; margin-right: 10%"><strong style="color: #FFB344">HOME</strong> / Hóspedes</h6>
            </div>
        </section>

        <%-- Form Para Cadastro De Hóspedes--%>
        <section class="col-12 row mt-2">
            <div class="form-group">
                <asp:Label ID="lblTexto" runat="server" CssClass="text-danger" Text="" Visible="false"></asp:Label>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="lblNomeHospede" runat="server" Text="Nome" />
                <asp:TextBox ID="txtNomeHospede" runat="server" CssClass="form-control" placeholder="Nome do Hóspede" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblTelHospede" runat="server" Text="Contato" />
                <asp:TextBox ID="txtCelHospede" runat="server" CssClass="form-control" placeholder="Contato do Hóspede" />
            </div>
            <div style="margin-left: 3%; margin-top: 1%">
                <asp:Button runat="server" ID="btnCadHospede" CssClass="btn btn-success text-white " Text="CADASTRAR" OnClick="btn_CadastrarHos_Click" />
            </div>
        </section>

        <%-- Tabela De Hóspedes--%>
        <div class="row" style="margin-top: 5%">
            <div class="col-md-12 tabHospedes">
                <asp:GridView ID="gdvHospedes" runat="server" AutoGenerateColumns="false" CssClass="table table-hover table-borderless tabela" OnRowDataBound="gdvHospedes_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="HOS_NOME" HeaderText="NOME" />
                        <asp:BoundField DataField="HOS_TELEFONE" HeaderText="CONTATO" />
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

        <!-- Modal Excluir Hóspede -->
        <section class="modal fade" id="modalExcluir" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">EXCLUIR HOSPEDE</h5>
                        <button type="button" class="close btn" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times"></i>
                        </button>
                    </div>
                    <div class="modal-body">
                        <h2>DESEJA EXCLUIR ESTE HOSPEDE?</h2>
                    </div>
                    <div class="modal-footer">
                        <button type="button" style="background-color: forestgreen; color: white; border-color: black" class="btn " data-dismiss="modal">CANCELAR</button>
                        <asp:Button runat="server" ID="btnExcluirFunc" OnClick="btnExcluirFunc_Click" CssClass="btn text-white bg-danger" Text="EXCLUIR" BackColor="green" BorderColor="Black" />
                    </div>
                </div>
            </div>
        </section>

        <!-- Modal Editar Hospede -->
        <section class="modal fade" id="modalEditar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="">EDITAR HOSPEDE</h5>
                        <button type="button" class="close btn" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times"></i>
                        </button>
                    </div>
                    <div class="modal-body">
                        <asp:Label ID="lblEditNome" runat="server" Text="Nome" />
                        <asp:TextBox ID="txtEditNome" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblEditTel" runat="server" Text="Telefone" />
                        <asp:TextBox ID="txtEditTel" runat="server" CssClass="form-control" TextMode="Number" />
                        <br />
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

