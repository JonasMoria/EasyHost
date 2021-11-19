<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Pages_Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">

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
                <asp:Label ID="lblTexto" runat="server" CssClass="text-danger" Text="" Visible="false"></asp:Label>
            </div>
            <br />

            <div class="form-group">
                <asp:Label ID="lblCadUsuario" runat="server" Text="Email" />
                <asp:TextBox ID="txtCadUsuario" runat="server" CssClass="form-control" placeholder="usuario@exemplo.com" TextMode="Email" />
            </div>

            <div class="form-group">
                <label id="lblCadSenha">Senha</label>
                <asp:TextBox ID="txtCadSenha" runat="server" CssClass="form-control" placeholder="Digite a sua enha" TextMode="Password" />
            </div>

            <div class="form-group">
                <label id="lblCadRepetirSenha">Repita a sua senha</label>
                <asp:TextBox ID="txtCadRepetirSenha" runat="server" CssClass="form-control" placeholder="Repita a sua senha" TextMode="Password" />
            </div>

            <div class="col-12 row">
                <div class="form-group col-md-6 col-sm-12">
                    <label id="lblCadNomeEmpresa">Nome da sua empresa</label>
                    <asp:TextBox ID="txtCadNomeEmpresa" runat="server" CssClass="form-control" placeholder="Digite nome de sua empresa" />
                </div>
                <div class="form-group col-md-6 col-sm-12">
                    <label id="lblDoc">CPF/CNPJ</label>
                    <asp:TextBox ID="txtDoc" runat="server" CssClass="form-control" placeholder="Digite seu CPF ou CNPJ" />
                </div>
            </div>



            <br />
            <asp:Button ID="btnCriar" runat="server" Text="Cadastrar" CssClass="btn" OnClick="btnCriar_Click"/>
            <div style="margin-top: 3%; text-align: center">

                <br />
                <hr style="color: black; height: 2px; width: 80%; margin-left: 10%" />
                <button id="btnVoltar"><a id="aNovaConta" href="../Default.aspx">Voltar para Login</a></button>
            </div>
            <br />
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
