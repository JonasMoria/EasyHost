using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
/// <summary>
/// Descrição resumida de FuncionarioDB
/// </summary>
public class FuncionarioDB {
    public FuncionarioDB() {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
    public static Funcionario LoginFun(string email, string senha) {
        Funcionario funcionario = null;
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            IDataReader ObjDataReader;
            ObjConexao = Mapped.Connection();
            string sql = @"SELECT * FROM fun_funcionarios  WHERE FUN_EMAIL = ?email AND FUN_SENHA = ?senha";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?email", email));
            Comando.Parameters.Add(Mapped.Parameter("?senha", senha));
            ObjDataReader = Comando.ExecuteReader();
            while (ObjDataReader.Read()) {
                funcionario = new Funcionario();
                funcionario.CPF = ObjDataReader["FUN_CPF"].ToString();
                funcionario.Email = ObjDataReader["FUN_EMAIL"].ToString();
                funcionario.Nome = ObjDataReader["FUN_NOME"].ToString();
                funcionario.AdmCPF = ObjDataReader["ADM_CPF"].ToString();
            }

            ObjDataReader.Close();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return funcionario;

        } catch (Exception e) {
            return null;
        }
    }


    public static int Insert(Funcionario fun) {
        try {
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
        } catch (Exception e) {
            return -2;
        }
    }

    /// <summary>
    /// Método de exclusão
    /// </summary>
    /// <param name="cpf">cpf do usuário (PK)</param>
    /// <returns>0 se for sucesso / -2 se for erro</returns>
    public static int Delete(int cpf) {
        try {
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
        } catch (Exception e) {
            return -2;
        }
    }

    public static int Update(Funcionario fun) {
        try {
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
        } catch (Exception e) {
            return -2;
        }
    }

}



