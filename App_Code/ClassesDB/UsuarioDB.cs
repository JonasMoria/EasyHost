using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de UsuarioDB
/// </summary>
public class UsuarioDB {
    /// <summary>
    /// Método para inserir um usuário
    /// </summary>
    /// <param name="usuario"> Objeto do tipo usuário</param>
    /// <returns>0 se for sucesso / -2 se for erro</returns>
    public static String Insert(Usuario usuario) {
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"INSERT INTO usu_usuario VALUES
                        (0, ?email, ?senha, ?adm_cpf, ?nomeEmpresa)";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?email", usuario.Email));
            Comando.Parameters.Add(Mapped.Parameter("?senha", usuario.Senha));
            Comando.Parameters.Add(Mapped.Parameter("?adm_cpf", usuario.ADM_CPF));
            //Comando.Parameters.Add(Mapped.Parameter("?fun_cpf", usuario.FUN_CPF));
            Comando.Parameters.Add(Mapped.Parameter("?nomeEmpresa", usuario.NomeEmpresa));
            Comando.ExecuteNonQuery();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return "Sucesso";
        } catch (Exception erro) {
            Console.Write(erro);
            return erro.Message;
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
            string sql = "DELETE FROM USU_USUARIOS WHERE USU_CODIGO = ?cpf";
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

    public static int Update(Usuario usuario) {
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"UPDATE USU_USUARIO SET USU_EMAIL = ?email, USU_SENHA=?senha WHERE USU_CPF = ?cpf";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?email", usuario.Email));
            Comando.Parameters.Add(Mapped.Parameter("?senha", usuario.Senha));
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
