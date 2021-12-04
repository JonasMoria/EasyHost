using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Pages_MapaReservas : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {

        string url = "http://localhost:52757/";
        if (Session["ADM"] == null)
            Response.Redirect(url + "Default.aspx");
        if (!Page.IsPostBack) {
            CarregarReservas();
        }

    }
    private void CarregarReservas() {
        Administrador adm = (Administrador)Session["ADM"];
        DataSet ds = ReservasDB.SelectAllWithQuartos(adm.CPF.ToString());
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd > 0) {
            string valores = "";
            string modais = "";
            string script = @"<script>
                                document.addEventListener('DOMContentLoaded', function () {
                                    var calendarEl = document.getElementById('calendar');
                                    var calendar = new FullCalendar.Calendar(calendarEl, {
                                        plugins: ['interaction', 'dayGrid', 'timeGrid'],
                                        defaultView: 'dayGridMonth',
                                       
                                        locale: 'pt-br',
                                        header: {
                                            left: 'prev,next today',
                                            center: 'title',
                                            right: 'dayGridMonth,timeGridWeek,timeGridDay'
                                        },
                                        events: [";


            foreach (DataRow dr in ds.Tables[0].Rows) {
                string q = "QUARTO " + dr["QUA_ID"].ToString();
                valores += @"{
                                title: '" + q + @"',
                                start: '" + dr["di"].ToString() + @"'
                             },";

                modais += @"<div id='" + dr["de"] + @"' class='modal fade'>
                                <div class='modal-dialog modal-lg'>
                                    <div class='modal-content'>
                                        <div class='modal-header'>
                                            <button type='button' class='close' data-dismiss='modal'><span aria-hidden='true'>×</span> 
                                                <span class='sr-only'>close</span></button>
                                            <h2 id='modalTitle' class='modal-title'>RESERVA PARA" + dr["RES_CHECKIN"] + @"</h2>
                                        </div>
                                        <div id='modalBody' class='modal-body'><br/><br/> <div class='row text-bold text-large' >
                                            <div class='col-md-12 text-center'>" + dr["QUA_NOME"] + @"<br/>" + dr["RES_CHECKOUT"] + @"<br/>" + dr["HOS_NOME"] + @"</div>
                                        </div></div>
                                        <div class='modal-footer'>
                                            <button type='button' class='btn btn-default' data-dismiss='modal'>Fechar</button>
                                        </div>
                                    </div>
                                </div>
                            </div>";
            }
            script += valores.Substring(0, valores.Length - 1);

            script += @"],
                        eventClick: function (info) {                          
                            info.el.style.borderColor = 'red';
                            var id = '#' + moment(info.event.start.toString()).format('YYYYMMDD');

                            //$('#modalTitle').html('<h3>'+ moment(info.event.start.toString()).format('DD/MM/YYYY') + ' - ' + info.event.title + '</h3>');
                            $(id).modal('show');
                        }
                    });
                    calendar.render();
                });
            </script>";
            lblScript.Text = script;
            lblModais.Text = modais;
        }
    }



    protected void btnReservar_Click(object sender, EventArgs e) {

        Administrador adm = (Administrador)Session["ADM"];
        Reserva reserva = new Reserva();

        reserva.AdmCPF = adm.CPF.ToString();
        reserva.CheckIn = txtCheckIn.Text;
        reserva.CheckOut = txtCheckOut.Text;
        reserva.Quarto = TxtQuarto.Text;
        reserva.Hospede = txtHospede.Text;

        if (validaReserva(txtCheckIn.Text, txtCheckOut.Text, txtHospede.Text)) {

            AdministradorDB.ReservarAdm(reserva);

        } else {
            lblCheckIn.Text = "Dados Invalidos";
        }


    }

    private bool validaReserva(string checkin, string checkout, string hospede) {
        if (!String.IsNullOrWhiteSpace(checkin) && !String.IsNullOrWhiteSpace(checkout)) {
            if (!String.IsNullOrWhiteSpace(hospede)) {
                return true;
            }
        }
        return false;
    }
}