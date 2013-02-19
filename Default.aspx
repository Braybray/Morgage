<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Principle Amount:<br />
        <asp:TextBox ID="LoanAmount" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        Annual Interest Rate:<br />
        <asp:TextBox ID="Rate" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        Morgage Length:
        <br />
        <asp:TextBox ID="MorgageLength" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="PerformCalcButton" runat="server" Text="Compute Monthly Cost" 
            Width="150px" />
        <br />
        <br />
        <asp:Label ID="Results" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
