using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ReservasDB
/// </summary>
public class ReservasDB {
    public static DataSet SelectAllWithQuartos(String cpf) {
        DataSet ds = new DataSet();
        IDbConnection ObjConexao;
        IDbCommand Comando;
        IDataAdapter Adapter;
        ObjConexao = Mapped.Connection();
        string sql = @"SELECT *,  
	                        DATE_FORMAT(DATE(r.RES_CHECKIN),'%Y-%m-%d') AS di, 
	                        DATE_FORMAT(DATE(r.RES_CHECKIN),'%Y-%m-%d') AS de,
	                        DATE_FORMAT(DATE(r.RES_CHECKOUT),'%Y-%m-%d') AS df
                        FROM res_reservas r
	                        inner join qua_quartos q 
	                    on q.QUA_ID = r.QUA_ID inner join hos_hospedes h on h.hos_id=r.hos_id WHERE r.ADM_CPF= ?cpf";
        Comando = Mapped.Command(sql, ObjConexao);
        Comando.Parameters.Add(Mapped.Parameter("?cpf", cpf));
        Adapter = Mapped.Adapter(Comando);
        Adapter.Fill(ds);
        ObjConexao.Close();
        Comando.Dispose();
        ObjConexao.Dispose();
        return ds;
    }
}

