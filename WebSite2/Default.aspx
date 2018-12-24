<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Width="65px">1</asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Width="77px">2</asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Width="68px">3</asp:TextBox>
    
    </div>
        <asp:TextBox ID="TextBox4" runat="server" Width="66px">4</asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" Width="76px">5</asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" Width="71px">6</asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox7" runat="server" Width="66px">7</asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server" Width="76px">8</asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" Width="72px">9</asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="41px" OnClick="Button1_Click" Text="1" Width="45px" />
        <asp:Button ID="Button2" runat="server" Height="41px" OnClick="Button2_Click" Text="2" Width="41px" />
        <asp:Button ID="Button3" runat="server" Height="39px" OnClick="Button3_Click" Text="3" Width="45px" />
        <br />
        <asp:Button ID="Button4" runat="server" Height="40px" OnClick="Button4_Click" Text="4" Width="44px" />
        <asp:Button ID="Button5" runat="server" Height="37px" OnClick="Button5_Click" Text="5" Width="42px" />
        <asp:Button ID="Button6" runat="server" Height="42px" OnClick="Button6_Click" Text="6" Width="46px" />
        <br />
        <asp:Button ID="Button7" runat="server" Height="42px" OnClick="Button7_Click" Text="7" Width="44px" />
        <asp:Button ID="Button8" runat="server" Height="37px" OnClick="Button8_Click" style="margin-top: 0px" Text="8" Width="44px" />
        <asp:Button ID="Button9" runat="server" Height="40px" OnClick="Button9_Click" Text="9" Width="44px" />
    </form>
</body>
</html>
