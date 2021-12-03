﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MP_Administrador.master" AutoEventWireup="true" CodeFile="MapaReservas.aspx.cs" Inherits="Pages_MapaReservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../Content/css/MapaReservas.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">

    <%--<%--corrigindo um erro do modal--%>
    <style>
        main {
            z-index: -1;
        }
    </style>

    <main class="pagina" id="pagina" style="background-color: #FFF8E5">

        <%--Localização Do Usuario--%>
        <section class="col-12 row p-2 local">
            <div class="col-4">
                <h2>Mapa De Reservas</h2>
            </div>
            <div class="col-8 pt-3">
                <h6 style="float: right; margin-right: 10%"><strong style="color: #FFB344">HOME</strong> / Mapa de Reservas</h6>
            </div>
        </section>

        <asp:Label runat="server" ID="lblUser" />
        <%--Botão Nova Reserva E Selecionar Quarto--%>
        <section class="col-12 row mt-5">
            <div class="col-5">
                <button type="button" class="btn btn-success" data-toggle="modal" data-target="#myModal">
                    <i class="fa fa-plus"></i>Nova Reserva 
                </button>
            </div>
            <div class="col-7">
                <asp:DropDownList ID="QuartosDropList" CssClass="btn dropdown-toggle text-white" BackColor="DarkSlateGray" runat="Server">
                    <asp:ListItem Enabled="true" Text="SELECIONAR QUARTO" Value="-1"></asp:ListItem>
                </asp:DropDownList>
            </div>

        </section>

        <!-- Modal -->
        <section class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #00A19D">
                        <h5 class="modal-title" id="exampleModalLabel">NOVA RESERVA</h5>
                        <button type="button" class="close btn" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times"></i>
                        </button>
                    </div>
                    <div class="modal-body" style="background-color: #00A19D">
                        <asp:Label ID="lblCheckIn" runat="server" CssClass="labels" Text="&nbsp  INDISPONÍVEL  &nbsp" />
                        <asp:TextBox ID="txtCheckIn" runat="server" CssClass="form-control" TextMode="Date" />
                        <br />
                        <asp:Label ID="lblCheckOut" runat="server" CssClass="labels" Text="&nbsp  INDISPONÍVEL  &nbsp" />
                        <asp:TextBox ID="txtCheckOut" runat="server" CssClass="form-control" TextMode="Date" />
                        <br />
                        <asp:TextBox ID="txtHospede" runat="server" CssClass="form-control" placeholder="HÓSPEDE" />
                        <br />
                        <asp:TextBox ID="txtContatoHospede" runat="server" CssClass="form-control" placeholder="CONTATO" />
                        <br />

                        <div class="col-12 row" style="margin-left: 1%">
                            <div class="col-12 text-center">
                                <button type="button" class="btn text-white" id="btnNovoHosp" data-toggle="modal" data-target="#modalCadHosp" style="background-color: #FFB344">Novo Hóspede</button>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer" style="background-color: #00A19D">
                        <button type="button" style="background-color: #E05D5D; color: white; border-color: none" class="btn " data-dismiss="modal">Cancelar</button>
                        <asp:Button runat="server" ID="btnReservar" CssClass="btn text-white" Text="Reservar" BackColor="green" BorderColor="" />
                    </div>
                </div>
            </div>
        </section>

        <%--Modal Cadastro Rapido de Hóspedes--%>
        <section class="modal fade" id="modalCadHosp" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header" style="background-color: #00A19D">
                        <h5 class="modal-title" id="">NOVO HOSPEDE</h5>
                        <button type="button" class="close btn" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times"></i>
                        </button>
                    </div>
                    <div class="modal-body" style="background-color: #00A19D">
                        <section class="col-12 row mt-2">
                            <div class="form-group">
                                <asp:Label ID="lblTexto" runat="server" CssClass="text-danger" Text="" Visible="false"></asp:Label>
                            </div>
                            <br />
                            <div class="form-group">
                                <asp:Label ID="lblNomeHospede" runat="server" CssClass="text-white mt-2" Text="Nome" />
                                <asp:TextBox ID="txtNomeHospede" runat="server" CssClass="form-control" placeholder="Nome do Hóspede" />
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblTelHospede" runat="server" CssClass="text-white mt-2" Text="Contato" />
                                <asp:TextBox ID="txtCelHospede" runat="server" CssClass="form-control" placeholder="Contato do Hóspede" />
                            </div>
                            <div class="col-12 text-center mt-4" >
                                <asp:Button runat="server" ID="btnCadHospede" CssClass="btn btn-success text-white" Text="Cadastrar"  />
                            </div>
                        </section>
                    </div>
                    <div class="modal-footer" style="background-color: #00A19D">
                        <button type="button" style="background-color: #E05D5D; color: white; border-color: none" class="btn " data-dismiss="modal">Cancelar</button>
                        <asp:Button runat="server" ID="Button1" CssClass="btn text-white" Text="Cadastrar" BackColor="green" BorderColor="" />
                    </div>
                </div>
            </div>
        </section>



        <%--Mapa De Reservas--%>
        <section class="border" style="margin-top: 3%">
            <h1 style="text-align: center">AQUI FICA O CALENDÁRIO</h1>
        </section>

    </main>


</asp:Content>

