using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Quarto
/// </summary>
public class Quarto {

    private string _Nome;
    private string _Situacao;
    private string _AdmCPF;

    public Quarto() {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string Nome {
        get {
            return _Nome;
        }

        set {
            _Nome = value;
        }
    }

    public string Situacao {
        get {
            return _Situacao;
        }

        set {
            _Situacao = value;
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




}
