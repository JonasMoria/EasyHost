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

    public static int Insert(Administrador adm)
    {
        try
        {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"INSERT INTO adm_administrador VALUES
                        (0, ?cpf, ?nome)";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?cpf", adm.CPF));
            Comando.Parameters.Add(Mapped.Parameter("?nome", adm.Nome));
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

    public static int Update(Administrador adm)
    {
        try
        {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"UPDATE adm_administrador SET ADM_CPF = ?nome WHERE ADM_CPF = ?cpf";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?cpf", adm.CPF));
            Comando.Parameters.Add(Mapped.Parameter("?nome", adm.Nome));
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
