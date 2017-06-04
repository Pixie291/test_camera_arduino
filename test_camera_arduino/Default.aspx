<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="test_camera_arduino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1" />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Przejdz do kamery" />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="3" />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="4" />
    </form>
</body>
</html>
