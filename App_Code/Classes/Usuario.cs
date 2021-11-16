using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Usuario {
  
    private string _Email;
    private string _Senha;
    private string _ADM_CPF;
    private string _FUN_CPF;
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
    public string ADM_CPF
    {
        get
        {
            return _ADM_CPF;
        }

        set
        {
            _ADM_CPF = value;
        }

    }

    public string FUN_CPF
    {
        get
        {
            return _FUN_CPF;
        }

        set
        {
            _FUN_CPF = value;
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
