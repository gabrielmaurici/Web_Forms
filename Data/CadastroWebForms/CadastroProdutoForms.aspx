<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroProdutoForms.aspx.cs" Inherits="CadastroWebForms.CadastroProdutoForms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 484px">
            <asp:Label ID="lbNome" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="tbNome" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:Label ID="lbValor" runat="server" Text="Valor"></asp:Label>
            <asp:TextBox ID="tbValor" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:Label ID="lbCategoria" runat="server" Text="Categoria"></asp:Label>
            <asp:TextBox ID="tbNomeCategoria" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:Label ID="lbDescCategoria" runat="server" Text="Descrição Categoria"></asp:Label>
            <asp:TextBox ID="tbDescCategoria" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="btSalvar" runat="server" Text="Salvar" OnClick="btSalvar_Click" Width="135px" />
            <asp:Button ID="btLimpar" runat="server" Text="Limpar" Width="135px" OnClick="btLimpar_Click" />

        

            <asp:GridView ID="gvCadastros" runat="server" Height="16px" style="margin-left: 0px" Width="257px">
            </asp:GridView>

        

        </div>
    </form>
</body>
</html>
