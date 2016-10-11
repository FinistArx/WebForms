<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="WebApplication5.default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="TVStatus" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="OnOffButton" runat="server" Text="Включить/Выключить" /><br />
            Каналы<br />
            <asp:Button ID="PreviousChannelButton" runat="server" Text="Previus" Width="60px" Height="30px" />
            <asp:Button ID="NextChannelButton" runat="server" Text="Next" Width="60px" Height="30px" />
            <asp:Label ID="ErrorChannel" runat="server" Text=""></asp:Label>
            <br />
            Громкость<br />
            <asp:Button ID="DownVolumeButton" runat="server" Text="-" Width="50px" />
            <asp:Button ID="UpVolumeButton" runat="server" Text="+" Width="50px" />
            <asp:Label ID="ErrorVolume" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
