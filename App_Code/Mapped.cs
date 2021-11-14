using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Descrição resumida de Mapped
/// </summary>
public class Mapped
{

    public static IDbConnection Connection()
    {

        MySqlConnection objConexao = new MySqlConnection(ConfigurationManager.AppSettings["StringDeConexaoMySQL"]);
        objConexao.Open();
        return objConexao;
    }


    public static IDbCommand Command(string sql, IDbConnection objConexao)
    {
        IDbCommand command = objConexao.CreateCommand();
        command.CommandText = sql;
        return command;
    }


    public static IDataAdapter Adapter(IDbCommand command)
    {
        IDbDataAdapter adap = new MySqlDataAdapter();
        adap.SelectCommand = command;
        return adap;
    }


    public static IDataParameter Parameter(string nomeParametro, object valor)
    {
        return new MySqlParameter(nomeParametro, valor);
    }


}



