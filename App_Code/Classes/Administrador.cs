using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Administrador
/// </summary>
public class Administrador {

    private string _CPF;
    private string _Email;
    private string _Senha;
    private string _NomeEmpresa;

    public Administrador() {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string CPF {
        get {
            return _CPF;
        }

        set {
            _CPF = value;
        }
    }

    public string Email {
        get {
            return _Email;
        }

        set {
            _Email = value;
        }
    }

    public string Senha {
        get {
            return _Senha;
        }

        set {
            _Senha = value;
        }
    }

    public string NomeEmpresa {
        get {
            return _NomeEmpresa;
        }

        set {
            _NomeEmpresa = value;
        }
    }
}