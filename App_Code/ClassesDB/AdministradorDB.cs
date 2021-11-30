using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AdministradorDB
/// </summary>
public class AdministradorDB {

    public AdministradorDB() {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public static int DeleteFuncionario(String cpfFun, String cpfAdm) {
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"SET SQL_SAFE_UPDATES = 0;DELETE FROM fun_funcionarios WHERE FUN_CPF = ?cpfFun AND ADM_CPF = ?cpfAdm";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?cpfFun", cpfFun));
            Comando.Parameters.Add(Mapped.Parameter("?cpfAdm", cpfAdm));
            Comando.ExecuteNonQuery();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return 0;
        } catch (Exception e) {
            return -2;
        }
    }
    public static DataSet SelectQuartos(String cpf) {
        DataSet ds = new DataSet();
        IDbConnection ObjConexao;
        IDbCommand Comando;
        IDataAdapter Adapter;
        ObjConexao = Mapped.Connection();
        string sql = @"SELECT * FROM qua_quartos  WHERE ADM_CPF = ?cpf";
        Comando = Mapped.Command(sql, ObjConexao);
        Comando.Parameters.Add(Mapped.Parameter("?cpf", cpf));
        Adapter = Mapped.Adapter(Comando);
        Adapter.Fill(ds);
        ObjConexao.Close();
        Comando.Dispose();
        ObjConexao.Dispose();
        return ds;
    }
    public static DataSet SelectHospedes(String cpf) {
        DataSet ds = new DataSet();
        IDbConnection ObjConexao;
        IDbCommand Comando;
        IDataAdapter Adapter;
        ObjConexao = Mapped.Connection();
        string sql = @"SELECT * FROM hos_hospedes  WHERE ADM_CPF = ?cpf";
        Comando = Mapped.Command(sql, ObjConexao);
        Comando.Parameters.Add(Mapped.Parameter("?cpf", cpf));
        Adapter = Mapped.Adapter(Comando);
        Adapter.Fill(ds);
        ObjConexao.Close();
        Comando.Dispose();
        ObjConexao.Dispose();
        return ds;
    }
    public static DataSet SelectFuncionarios(String cpf) {
        DataSet ds = new DataSet();
        IDbConnection ObjConexao;
        IDbCommand Comando;
        IDataAdapter Adapter;
        ObjConexao = Mapped.Connection();
        string sql = @"SELECT * FROM fun_funcionarios  WHERE ADM_CPF = ?cpf";
        Comando = Mapped.Command(sql, ObjConexao);
        Comando.Parameters.Add(Mapped.Parameter("?cpf", cpf));
        Adapter = Mapped.Adapter(Comando);
        Adapter.Fill(ds);
        ObjConexao.Close();
        Comando.Dispose();
        ObjConexao.Dispose();
        return ds;
    }
    public static String getCpf(Administrador administrador) {
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"SELECT ADM_CPF FROM adm_administrador WHERE ADM_SENHA = ?senha && ADM_EMAIL = ?email";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?email", administrador.Email));
            Comando.Parameters.Add(Mapped.Parameter("?senha", administrador.Senha));
            var reader = Comando.ExecuteScalar();



            Comando.Dispose();
            ObjConexao.Close();
            ObjConexao.Dispose();



            return Convert.ToString(reader);

        } catch (Exception e) {
            return e.Message;
        }
    }

    public static String VerificaUsuarioExistente(String documento) {
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"SELECT ADM_CPF FROM adm_administrador WHERE ADM_CPF = ?documento";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?documento", documento));
            var resultado = Comando.ExecuteScalar();

            if (resultado == null) {
                return "NaoExiste";
            } else {
                return "Existe";
            }

            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();


        } catch (Exception e) {
            return e.Message;
        }
    }

    public static String LoginAdm(Administrador administrador) {
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            //string sql = @"SELECT a.ADM_EMAIL, a.ADM_SENHA, f.FUN_EMAIL, f.FUN_SENHA 
            //                FROM adm_administrador a
            //                 INNER JOIN fun_funcionarios f 
            //                    ON a.ADM_CPF = f.ADM_CPF
            //                WHERE a.ADM_EMAIL = ?email AND a.ADM_SENHA = ?senha
            //                OR f.FUN_EMAIL = ?email AND f.FUN_SENHA = ?senha";
            string sql = @"SELECT ADM_EMAIL, ADM_SENHA FROM adm_administrador WHERE ADM_SENHA = ?senha && ADM_EMAIL = ?email";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?email", administrador.Email));
            Comando.Parameters.Add(Mapped.Parameter("?senha", administrador.Senha));
            var resultado = Comando.ExecuteScalar();
            Comando.Dispose();
            ObjConexao.Close();
            ObjConexao.Dispose();

            if (resultado != null) {
                return "Sucesso";
            } else {
                return "Erro";
            }



        } catch (Exception e) {
            return e.Message;
        }
    }

    public static String Insert(Administrador administrador) {
        try {
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
        } catch (Exception e) {

            return e.Message;
        }
    }

    public static String Cadastra_Funcionario(Funcionario funcionario) {
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"INSERT INTO fun_funcionarios VALUES (?cpf, ?nome, ?email, ?senha, ?admCpf)";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?cpf", funcionario.CPF));
            Comando.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            Comando.Parameters.Add(Mapped.Parameter("?email", funcionario.Email));
            Comando.Parameters.Add(Mapped.Parameter("?senha", funcionario.Senha));
            Comando.Parameters.Add(Mapped.Parameter("?admCpf", funcionario.AdmCPF));
            Comando.ExecuteNonQuery();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return "Sucesso";
        } catch (Exception e) {

            return e.Message;
        }
    }

    public static String Cadastra_Quarto(Quarto quarto) {
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"INSERT INTO qua_quartos VALUES (0, ?nome, ?situacao, ?admCpf)";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?nome", quarto.Nome));
            Comando.Parameters.Add(Mapped.Parameter("?situacao", quarto.Situacao));
            Comando.Parameters.Add(Mapped.Parameter("?admCpf", quarto.AdmCPF));
            Comando.ExecuteNonQuery();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return "Sucesso";
        } catch (Exception e) {

            return e.Message;
        }
    }

    public static String Cadastra_Hospede(Hospede hospede) {
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"INSERT INTO hos_hospedes VALUES (0, ?nome, ?telefone, ?admCpf)";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?nome", hospede.Nome));
            Comando.Parameters.Add(Mapped.Parameter("?telefone", hospede.Telefone));
            Comando.Parameters.Add(Mapped.Parameter("?admCpf", hospede.AdmCPF));
            Comando.ExecuteNonQuery();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return "Sucesso";
        } catch (Exception e) {

            return e.Message;
        }
    }

    /// <summary>
    /// Método de exclusão
    /// </summary>
    /// <param name="cpf">cpf do usuário (PK)</param>
    /// <returns>0 se for sucesso / -2 se for erro</returns>

}
