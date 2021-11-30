<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MP_Administrador.master" AutoEventWireup="true" CodeFile="MapaReservas.aspx.cs" Inherits="Pages_MapaReservas" %>

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

    <main class="pagina" id="pagina">

        <%--Localização Do Usuario--%>
        <section class="col-12 row p-2 local">
            <div class="col-4">
                <h2>Mapa De Reservas</h2>
            </div>
            <div class="col-8 pt-3">
                <h6 style="float: right; margin-right: 10%"><strong style="color: blue">HOME</strong> / Mapa de Reservas</h6>
            </div>
        </section>

        <asp:label runat="server" ID="lblUser"/>
        <%--Botão Nova Reserva E Selecionar Quarto--%>
        <section class="col-12 row mt-5">
            <div class="col-5">
                <button type="button" class="btn btn-success" data-toggle="modal" data-target="#myModal">
                    <i class="fa fa-plus"></i>Nova Reserva 
                </button>
            </div>
            <div class="col-7">
                <asp:DropDownList ID="QuartosDropList" CssClass="btn dropdown-toggle text-white" BackColor="DarkSlateGray"  runat="Server">
                    <asp:ListItem Text="Selecionar Quarto" Value="1" />
                    <asp:ListItem Text="Item 2" Value="2" />
                    <asp:ListItem Text="Item 3" Value="3" />
                    <asp:ListItem Text="Item 4" Value="4" />
                    <asp:ListItem Text="Item 5" Value="5" />
                </asp:DropDownList>
            </div>

        </section>

        <!-- Modal -->
        <section class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">NOVA RESERVA</h5>
                        <button type="button" class="close btn" data-dismiss="modal" aria-label="Close">
                            <i class="fa fa-times"></i>
                        </button>
                    </div>
                    <div class="modal-body">
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
                            <div class="col-6">
                                <button type="button" class="btn text-white" style="background-color: darkgoldenrod">NOVO HÓSPEDE</button>
                            </div>
                            <div class="col-6">
                                <button type="button" class="btn text-white" style="background-color: darkgoldenrod">NOVA ACOMODAÇÃO</button>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" style="background-color: crimson; color: white; border-color: black" class="btn " data-dismiss="modal">CANCELAR</button>
                        <asp:Button runat="server" ID="btnReservar" CssClass="btn text-white" Text="RESERVAR" BackColor="green" BorderColor="Black" />
                    </div>
                </div>
            </div>
        </section>

        <%--Mapa De Reservas--%>
        <section class="border">
            <h1 style="text-align: center">AQUI FICA O CALENDÁRIO</h1>
        </section>
     
    </main>


</asp:Content>

