<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspNetWebApplicationDotNet30.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Two Numbers</h2>
            <asp:Label ID="lblNumber1" runat="server" Text="Number 1:"></asp:Label>
            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblNumber2" runat="server" Text="Number 2:"></asp:Label>
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
