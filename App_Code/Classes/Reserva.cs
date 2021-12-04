using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Reserva
/// </summary>
public class Reserva {

    private string _Hospede;
    private string _Quarto;
    private string _checkIn;
    private string _checkOut;
    private string _AdmCPF;
    private string _FunCPF;

    public string Hospede {
        get {
            return _Hospede;
        }

        set {
            _Hospede = value;
        }
    }


    public string CheckIn {
        get {
            return _checkIn;
        }

        set {
            _checkIn = value;
        }
    }

    public string CheckOut {
        get {
            return _checkOut;
        }

        set {
            _checkOut = value;
        }
    }

    public string AdmCPF {
        get {
            return _AdmCPF;
        }

        set {
            _AdmCPF = value;
        }
    }

    public string FunCPF {
        get {
            return _FunCPF;
        }

        set {
            _FunCPF = value;
        }
    }

    public string Quarto {
        get {
            return _Quarto;
        }

        set {
            _Quarto = value;
        }
    }
}