    <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>EasyHost</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/css/Default.css" rel="stylesheet" />
</head>

<body>

    <form id="form1" runat="server" class="row col-12">

        <div class="col-12" id="nav">
            <h1>EASYHOST</h1>
        </div>

        <section class="col-12" id="formLogin">
            <h3>BEM-VINDO(A)</h3>
            <div class="col-12 border">
                <asp:RadioButton id="radAdm" Text="Administrador" Checked="false" CssClass="me-3" GroupName="RadioGroup1" runat="server" /> 
                <asp:RadioButton id="radFun" Text="Funcionário" Checked="false  " GroupName="RadioGroup1" runat="server" />
            </div>
             <div class="form-group">
                <asp:Label ID="lblTexto" runat="server" CssClass="text-danger" Text="E-mail ou senha incorretos!" Visible="false"></asp:Label>
            </div>
            <br />
            <div class="form-group">
                <asp:Label ID="lblUsuario" runat="server" Text="Email" />
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="usuario@exemplo.com" TextMode="Email" />
            </div>
            <div class="form-group">
                <label id="lblSenha">Senha</label>
                <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" placeholder="Senha" TextMode="Password" />
            </div>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="ENTRAR" CssClass="btn" OnClick="btnLogin_Click" />
            <div style="margin-top: 3%; text-align: center">
                <a id="recSenha" href="/Pages/RecuperarSenha.aspx">Ops! Esqueci a Senha</a>
                <br />
                <hr style="color: black; height: 2px; width: 80%; margin-left: 10%" />
                <button class="btn btn-success"><a id="aNovaConta" href="Pages/Cadastro.aspx">CRIAR CONTA</a></button>
            </div>
            <br />          
        </section>

        <footer class="col-12 text-center text-white" style="position: absolute; bottom:10px">
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
