using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Descrição resumida de Comuns
/// </summary>
public class Comuns {

    //Criptografar Senhas
    public static string HashTexto(string texto) {
        HashAlgorithm algoritmo = HashAlgorithm.Create("SHA-512");
        byte[] retornoHash = algoritmo.ComputeHash(Encoding.UTF8.GetBytes(texto));
        return Convert.ToBase64String(retornoHash);
    }


}