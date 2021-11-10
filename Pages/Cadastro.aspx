<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Pages_Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>EasyHost | Cadastro</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/css/Cadastro.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <div class="col-12" id="nav">
            <h1>EASYHOST</h1>
        </div>
        <section class="col-12" id="formLogin">
            <h3>Cadastre-se</h3>
            <div class="form-group">
                <asp:Label ID="lblUsuario" runat="server" Text="Email" />
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="usuario@exemplo.com" TextMode="Email" />
            </div>
            <div class="form-group">
                <label id="lblSenha">Senha</label>
                <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" placeholder="Senha" TextMode="Password" />
            </div>
            <div class="form-group">
                <label id="lblRepetirSenha">Repita a sua senha</label>
                <asp:TextBox ID="txtRepetirSenha" runat="server" CssClass="form-control" placeholder="Senha" TextMode="Password" />
            </div>
            <br />
            <asp:Button ID="btnCriar" runat="server" Text="Cadastrar" CssClass="btn" />
            <div style="margin-top: 3%; text-align: center">

                <br />
                <hr style="color: black; height: 2px; width: 80%; margin-left: 10%" />
                <button id="btnVoltar"><a id="aNovaConta" href="../Default.aspx">Voltar para Login</a></button>
            </div>
            <br />
        </section>

    </form>
</body>
</html>
