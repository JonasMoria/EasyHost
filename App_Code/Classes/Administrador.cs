using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Administrador
/// </summary>
public class Administrador
{

    private string _CPF;
    private string _Nome;

    public Administrador()
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



}
