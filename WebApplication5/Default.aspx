<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Smartenok</title>
        <style>
        .figure-div {
            border: 4px solid black;
            float: left;
            margin: 5px;
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="TV" Height="30px" Width="75px"  OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="MC" Height="30px" Width="75px"  OnClick="Button1_Click"/>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Boiler" Height="30px" Width="75px" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Cond" Height="30px" Width="75px" OnClick="Button1_Click"/>
            <br />
            <asp:Button ID="Button5" runat="server" Text="Fridge" Height="30px" Width="75px" OnClick="Button1_Click"/><br />
             <asp:Panel ID="newPanel" runat="server"></asp:Panel>
        </div>

    </form>
</body>
</html>
