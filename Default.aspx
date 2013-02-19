<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 179px">
    
        principle amount<br />
        <asp:TextBox ID="loanamount" runat="server"></asp:TextBox>
        <br />
        annual interest rate
        <br />
        <asp:TextBox ID="rate" runat="server"></asp:TextBox>
        <br />
        mortgage lenth:<br />
        <asp:TextBox ID="mortgagelength" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="performCalculateButton" runat="server" 
            Text="ComputerMonthlyPmt" />
        <br />
        <asp:Label ID="Results" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
