using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Funcionario
/// </summary>
public class Funcionario
{

    private string _CPF;
    private string _Nome;
    private string _Email;
    private string _Senha;
    private string _AdmCPF;

    public Funcionario()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public string CPF
    {
        get
        {
            return _CPF;
        }

        set
        {
            _CPF = value;
        }
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

    public string Email
    {
        get
        {
            return _Email;
        }

        set
        {
            _Email = value;
        }
    }

    public string Senha
    {
        get
        {
            return _Senha;
        }

        set
        {
            _Senha = value;
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
