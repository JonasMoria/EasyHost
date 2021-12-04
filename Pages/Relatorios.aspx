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

        <%-- Relatórios--%>
        <div class="row" style="margin-top: 5%">
            <style>
                .dt-button {
                    background-color: goldenrod !important;
                    color: white !important;
                    border: none !important;
                }
            </style>
            <div class="col-md-12 tabRelatorios">
                <asp:GridView ID="gdvRelatorios" runat="server" AutoGenerateColumns="false" CssClass="table table-hover table-borderless tabela" OnRowDataBound="gdvRelatorios_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="RES_ID" HeaderText="ID" />
                        <asp:BoundField DataField="RES_CHECKIN" HeaderText="CHECK IN" />
                        <asp:BoundField DataField="RES_CHECKOUT" HeaderText="CHECK OUT" />
                        <asp:BoundField DataField="FUN_CPF" HeaderText="FUNCIONARIO" />
                        <asp:BoundField DataField="QUA_ID" HeaderText="QUARTO" />
                        <asp:BoundField DataField="HOS_ID" HeaderText="HOSPEDE" />
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
        <!-- Modal Excluir Quartos -->
        <section class="modal fade" id="modalExcluir" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">EXCLUIR QUARTO</h5>
                        <button type="button" class="close btn" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times"></i>
                        </button>
                    </div>
                    <div class="modal-body">
                        <h2>DESEJA EXCLUIR ESTA RESERVA?</h2>
                    </div>
                    <div class="modal-footer">
                        <button type="button" style="background-color: forestgreen; color: white; border-color: black" class="btn " data-dismiss="modal">CANCELAR</button>
                        <asp:Button runat="server" ID="btnExcluirFunc" CssClass="btn text-white bg-danger" Text="EXCLUIR" BackColor="green" BorderColor="Black" />
                    </div>
                </div>
            </div>
        </section>

        <!-- Modal Editar Reserva -->
        <section class="modal fade" id="modalEditar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #00A19D">
                        <h5 class="modal-title" id="">ATUALIZAR RESERVA</h5>
                        <button type="button" class="close btn" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times"></i>
                        </button>
                    </div>
                    <div class="modal-body" style="background-color: #00A19D">
                        <asp:Label ID="lblCheckIn" runat="server" CssClass="labels" Visible="false" Text="&nbsp  INDISPONÍVEL  &nbsp" />
                        <asp:TextBox ID="txtCheckIn" runat="server" CssClass="form-control" TextMode="Date" />
                        <br />
                        <asp:Label ID="lblCheckOut" runat="server" CssClass="labels" Visible="false" Text="&nbsp  INDISPONÍVEL  &nbsp" />
                        <asp:TextBox ID="txtCheckOut" runat="server" CssClass="form-control" TextMode="Date" />
                        <br />
                        <asp:TextBox ID="txtHospede" runat="server" CssClass="form-control" placeholder="ID HOSPEDE" />
                        <br />
                        <asp:TextBox ID="TxtQuarto" runat="server" CssClass="form-control" placeholder="ID QUARTO" />
                        <br />

                        <div class="col-12 row" style="margin-left: 1%">
                            <div class="col-12 text-center">
                                <button type="button" class="btn text-white" id="btnNovoHosp" data-toggle="modal" data-target="#modalCadHosp" style="background-color: #FFB344">Novo Hóspede</button>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer" style="background-color: #00A19D">
                        <button type="button" style="background-color: #E05D5D; color: white; border-color: none" class="btn " data-dismiss="modal">Cancelar</button>
                        <asp:Button runat="server" ID="btnReservar" CssClass="btn text-white" Text="ATUALIZAR" BackColor="green" />
                    </div>
                </div>
            </div>
        </section>

    </main>

</asp:Content>

