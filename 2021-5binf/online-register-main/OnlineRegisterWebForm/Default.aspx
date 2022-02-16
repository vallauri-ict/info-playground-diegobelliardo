<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OnlineRegisterWebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h2>Online Register</h2>
    <form id="MainForm" runat="server">
        <div>
            <asp:Label ID="LblDatiTabella" runat="server" Text="Visualizza Dati Tabella: "></asp:Label>
            <asp:DropDownList ID="DropDownListTabelle" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListTabelle_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:Label ID="LblVotiStudente" runat="server" Text="Visualizza Voti Studente: "></asp:Label>
            <asp:DropDownList ID="DropDownListStudenti" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListStudenti_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:Label ID="LblVotiClasse" runat="server" Text="Visualizza Voti Classe: "></asp:Label>
            <asp:DropDownList ID="DropDownListClassi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListClassi_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:Label ID="LblVotiMateria" runat="server" Text="Visualizza Voti Materia: "></asp:Label>
            <asp:DropDownList ID="DropDownListMaterie" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListMaterie_SelectedIndexChanged"></asp:DropDownList>
            <br /> <br />
            <asp:GridView ID="GridViewTable" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
