using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Usuario {
  
    private string _Email;
    private string _Senha;
    private string _CPF;
    private string _NomeEmpresa;
    

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
         public string NomeEmpresa
    {
        get
        {
            return _NomeEmpresa;
        }

        set
        {
            _NomeEmpresa = value;
        }
    }
}
