using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
/// <summary>
/// Descrição resumida de FuncionarioDB
/// </summary>
public class FuncionarioDB
{
    public FuncionarioDB()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public static int Insert(Funcionario fun)
    {
        try
        {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"INSERT INTO fun_funcionario VALUES
                        (0, ?cpf, ?nome)";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?cpf", fun.CPF));
            Comando.Parameters.Add(Mapped.Parameter("?nome", fun.Nome));
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
            string sql = "DELETE FROM fun_funcionario WHERE FUN_CPF = ?cpf";
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

    public static int Update(Funcionario fun)
    {
        try
        {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"UPDATE fun_funcionario SET FUN_NOME = ?nome WHERE FUN_CPF = ?cpf";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?cpf", fun.CPF));
            Comando.Parameters.Add(Mapped.Parameter("?nome", fun.Nome));
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
