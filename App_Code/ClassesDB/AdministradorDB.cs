using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AdministradorDB
/// </summary>
public class AdministradorDB
{

    public AdministradorDB()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public static String Insert(Administrador administrador)
    {
        try
        {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"INSERT INTO adm_administrador VALUES
                        (?cpf, ?email, ?senha, ?nomeEmpresa)";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?cpf", administrador.CPF));
            Comando.Parameters.Add(Mapped.Parameter("?email", administrador.Email));
            Comando.Parameters.Add(Mapped.Parameter("?senha", administrador.Senha));
            Comando.Parameters.Add(Mapped.Parameter("?nomeEmpresa", administrador.NomeEmpresa));
            Comando.ExecuteNonQuery();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return "Sucesso";
        }
        catch (Exception e)
        {
            
            return e.Message;
        }
    }

    /// <summary>
    /// Método de exclusão
    /// </summary>
    /// <param name="cpf">cpf do usuário (PK)</param>
    /// <returns>0 se for sucesso / -2 se for erro</returns>
    public static int Delete(int cpf)
    {
        try
        {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = "DELETE FROM adm_administrador WHERE ADM_CPF = ?cpf";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?cpf", cpf));
            Comando.ExecuteNonQuery();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return 0;
        }
        catch (Exception e)
        {
            return -2;
        }
    }

    public static int Update(Administrador administrador)
    {
        try
        {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"UPDATE adm_administrador SET ADM_EMAIL = ?email WHERE ADM_CPF = ?cpf";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?cpf", administrador.CPF));
            Comando.Parameters.Add(Mapped.Parameter("?email", administrador.Email));
            Comando.ExecuteNonQuery();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return 0;
        }
        catch (Exception e)
        {
            return -2;
        }
    }
}
