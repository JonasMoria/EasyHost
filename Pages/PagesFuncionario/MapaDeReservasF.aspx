<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPages/MP_Funcionario.master" AutoEventWireup="true" CodeFile="MapaDeReservasF.aspx.cs" Inherits="Pages_PagesFuncionario_MapaDeReservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../../Content/css/MapaReservas.css" rel="stylesheet" />
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

        <%--Botão Nova Reserva--%>
        <section class="col-12 mt-5">
            <button type="button" class="btn btn-success" data-toggle="modal" data-target="#myModal">
                <i class="fa fa-plus"></i>Nova Reserva 
            </button>
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
                            <div class="col-6">
                                <button type="button" class="btn text-white" style="background-color: #FFB344">Novo Hóspede</button>
                            </div>
                            <div class="col-6">
                                <button type="button" class="btn text-white" style="background-color: #FFB344">Nova Acomodação</button>
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

        <%--Mapa De Reservas--%>
        <section class="border">
            <h1 style="text-align: center">AQUI FICA O CALENDÁRIO</h1>
        </section>

        <!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    </main>
</asp:Content>

