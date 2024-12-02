<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agecalculator.aspx.cs" Inherits="Agecalculator.agecalculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="select birthyear"></asp:Label>
        <asp:TextBox ID="txt_brt_dte" runat="server" TextMode="Date"></asp:TextBox><br />

        <asp:Label ID="Label2" runat="server" Text="select current date"></asp:Label>
        <asp:TextBox ID="txt_crnt_date" runat="server" TextMode="Date"></asp:TextBox><br />

        <asp:Button ID="Button1" runat="server" Text="Calculate Age" 
            onclick="Button1_Click" />
    </div>
    
    </form>
</body>
</html>
