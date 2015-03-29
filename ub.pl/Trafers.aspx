<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trafers.aspx.cs" Inherits="ub.pl.Trafers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
     Customer Number<br/>
        <asp:TextBox ID="txt_customernumber" Width="150px" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_customernumber" runat="server" ControlToValidate="txt_customernumber" ErrorMessage="Enter Customer Number" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>
        <br/>
        Account Name<br/>
        <asp:TextBox ID="txt_accountname" Width="150px" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_accountname" runat="server" ControlToValidate="txt_accountname" ErrorMessage="Enter Account Name" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>
        <br/>
        <asp:Button runat="server" ID="btn_submit" Text="Submit" OnClick="btn_submit_Click"/>
    </div>
    </form>
</body>
</html>
