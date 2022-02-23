<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Maturita2011.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Orso" runat="server" ImageUrl="/Images/orso.jpg" Width="200px"/>
            <asp:Label ID="NomeParco" runat="server" Text="Label"></asp:Label>
            <asp:Repeater ID="rptTable" runat="server">
                <HeaderTemplate>
                    <table class="table">
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("codice") %> </td>
                        <td><%# Eval("nome") %></td> 
                        <td><%# Eval("rischioEstinzione") %></td> 
                        <td><%# Eval("nomeOrdine") %></td> 
                        
                    </tr>
                </ItemTemplate>
                <FooterTemplate></table></FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
