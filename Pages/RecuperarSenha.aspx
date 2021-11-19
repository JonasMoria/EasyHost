<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecuperarSenha.aspx.cs" Inherits="Pages_RecuperarSenha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>EasyHost | Recuperar Senha</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/css/RecuperarSenha.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-12" id="nav">
            <h1>EASYHOST</h1>
        </div>
        <section class="col-12" id="formRecSenha">

            <h3>Recuperar Senha</h3>

            <div id="formCodigo" class="form-group">
                <asp:Label runat="server" ID="lblCodRecSenha" Text="Digite o Código Recebido" />
                <asp:TextBox runat="server" ID="codRecSenha" CssClass="form-control" Placeholder="- - - - -" />
                <asp:Button runat="server" ID="btnReenviarCod" Text="Reenviar Código" />
                <br />
                <asp:Button runat="server" ID="btnVerificarCod" CssClass="btn btn-danger" Text="VERIFICAR" OnClick="btnVerificarCod_Click" />
            </div>

            <div runat="server" ID="formTrocarSenha" Visible="false">
                <h3>Nova Senha</h3>
                <asp:Label runat="server" ID="lblNovaSenha" Text="Digite Sua Nova Senha" />
                <asp:TextBox runat="server" ID="txtNovaSenha" CssClass="form-control" Placeholder="..." TextMode="Password" />
                <br />
                <asp:Label runat="server" ID="lblRepNovaSenha" Text="Repita Sua Nova Senha" />
                <asp:TextBox runat="server" ID="txtRepNovaSenha" CssClass="form-control" Placeholder="..." TextMode="Password" />
                <br />
                <asp:Button runat="server" ID="btnTrocarSenha" Text="CONFIRMAR" CssClass="btn btn-success" />
            </div>

            <br />
            <button id="btnVoltar"><a style="text-decoration: none; color: white" id="aNovaConta" href="../Default.aspx">Voltar para Login</a></button>


        </section>
        <footer class="col-12 text-center text-white" style="position: absolute; bottom: 10px">
            EasyHost © <span id="ano">2021</span>
        </footer>

        <script>
            const ano = document.getElementById('ano');
            const anoAtual = new Date();
            ano.innerHTML = anoAtual.getFullYear();
        </script>
    </form>
</body>
</html>
