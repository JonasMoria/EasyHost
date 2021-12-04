using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AdministradorDB
/// </summary>
public class AdministradorDB {


    public static String ReservarAdm(Reserva reserva) {

        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            ObjConexao = Mapped.Connection();
            string sql = @"INSERT INTO res_reservas VALUES (?checkin, ?checkout, ?cpf, ?fun, ?qua,?hos);";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?checkin", reserva.CheckIn));
            Comando.Parameters.Add(Mapped.Parameter("?checkout", reserva.CheckOut));
            Comando.Parameters.Add(Mapped.Parameter("?cpf", reserva.AdmCPF));
            Comando.Parameters.Add(Mapped.Parameter("?fun", reserva.FunCPF = null));
            Comando.Parameters.Add(Mapped.Parameter("?qua", reserva.Quarto));
            Comando.Parameters.Add(Mapped.Parameter("?hos", reserva.Hospede));
            Comando.ExecuteNonQuery();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return "Sucesso";
        } catch (Exception e) {

            return e.Message;
        }

    }
    public static DataSet SelectReservas(String cpf) {
        DataSet ds = new DataSet();
        IDbConnection ObjConexao;
        IDbCommand Comando;
        IDataAdapter Adapter;
        ObjConexao = Mapped.Connection();
        string sql = @"SELECT * FROM res_reservas  WHERE ADM_CPF = ?cpf";
        Comando = Mapped.Command(sql, ObjConexao);
        Comando.Parameters.Add(Mapped.Parameter("?cpf", cpf));
        Adapter = Mapped.Adapter(Comando);
        Adapter.Fill(ds);
        ObjConexao.Close();
        Comando.Dispose();
        ObjConexao.Dispose();
        return ds;
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

    public static Administrador LoginAdm(string email, string senha) {
        Administrador administrador = null;
        try {
            IDbConnection ObjConexao;
            IDbCommand Comando;
            IDataReader ObjDataReader;
            ObjConexao = Mapped.Connection();
            string sql = @"SELECT * FROM adm_administrador  WHERE ADM_EMAIL = ?email AND ADM_SENHA = ?senha";
            Comando = Mapped.Command(sql, ObjConexao);
            Comando.Parameters.Add(Mapped.Parameter("?email", email));
            Comando.Parameters.Add(Mapped.Parameter("?senha", senha));
            ObjDataReader = Comando.ExecuteReader();
            while (ObjDataReader.Read()) {
                administrador = new Administrador();
                administrador.CPF = ObjDataReader["ADM_CPF"].ToString();
                administrador.Email = ObjDataReader["ADM_EMAIL"].ToString();
                administrador.NomeEmpresa = ObjDataReader["ADM_NOME_EMPRESA"].ToString();
            }

            ObjDataReader.Close();
            ObjConexao.Dispose();
            Comando.Dispose();
            ObjConexao.Close();
            return administrador;

        } catch (Exception e) {
            return null;
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
            Comando.Parameters.Add(Mapped.Parameter("?senha", Comuns.HashTexto(administrador.Senha)));
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
            Comando.Parameters.Add(Mapped.Parameter("?senha", Comuns.HashTexto(funcionario.Senha)));
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
