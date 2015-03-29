<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransferWithinAccounts.aspx.cs" Inherits="ub.pl.TransferWithinAccounts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
    From<br/>
        <asp:DropDownList runat="server" ID="ddl_from" DataSourceID="SqlDataSource1" DataTextField="AccountType" DataValueField="AccountType"/>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BankConnectionString %>" SelectCommand="SELECT [AccountType] FROM [AccountInformation]"></asp:SqlDataSource>
        <br/>
        To<br/>
        <asp:DropDownList runat="server" ID="ddl_to" DataSourceID="SqlDataSource2" DataTextField="AccountType" DataValueField="AccountType"/>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BankConnectionString %>" SelectCommand="SELECT [AccountType] FROM [AccountInformation]"></asp:SqlDataSource>
        <br/>
        Amount<br/>
        <asp:TextBox runat="server" ID="txt_amount"></asp:TextBox>
        <br/>
        <br/>
        Particulars<br/>
        <asp:TextBox runat="server" ID="txt_particulars"></asp:TextBox>
        <br/>
        <br/>
        Code<br/>
        <asp:TextBox runat="server" ID="txt_code"></asp:TextBox>
        <br/>
        <br/>
        Reference<br/>
        <asp:TextBox runat="server" ID="txt_reference"></asp:TextBox>
        <br/>
        <br/>
        <asp:Button runat="server" ID="btn_submit" Text="Submit" OnClick="btn_submit_Click"/>
        <asp:Label runat="server" ID="lbl_text"></asp:Label>
    </div>
    </form>
</body>
</html>
