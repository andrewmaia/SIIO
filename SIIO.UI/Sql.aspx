<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sql.aspx.cs" Inherits="SIIO.UI.Sql" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtComando" runat="server" Height="229px" TextMode="MultiLine" Width="515px"></asp:TextBox>
        <br/>
        <asp:Button ID="btnExecutar" runat="server" Text="Executar"  onclick="btnExecutar_Click" />
        <asp:Button ID="btnExecutarGrid" runat="server" Text="Executar Grid" 
            onclick="btnExecutarGrid_Click" />
        <br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="gv" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
