using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Hospede
/// </summary>
public class Hospede
{

    private string _Nome;
    private string _Telefone;
    private string _AdmCPF;

    public Hospede()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string Nome
    {
        get
        {
            return _Nome;
        }
        set
        {
            _Nome = value;
        }
    }

    public string Telefone
    {
        get
        {
            return _Telefone;
        }
        set
        {
            _Telefone = value;
        }
    }

    public string AdmCPF
    {
        get
        {
            return _AdmCPF;
        }
        set
        {
            _AdmCPF = value;
        }
    }
}
