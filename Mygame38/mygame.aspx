<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mygame.aspx.cs" Inherits="Mygame38.mygame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="tb_Name" runat="server"></asp:TextBox>
        <asp:TextBox ID="tb_Url" runat="server"></asp:TextBox>
        <asp:Button ID="bn_Name" runat="server" OnClick="Button1_Click" Text="搜尋" Height="27px" />
        <asp:Button ID="Add_Name" runat="server" Text="加入" OnClick="Add_Name_Click" />
        <asp:Button ID="bn_del" runat="server" Height="27px" OnClick="bn_del_Click" Text="刪除" />
    </form>
    <p>
        &nbsp;</p>
    </body>
</html>
