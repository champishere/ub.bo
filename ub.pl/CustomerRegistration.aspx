<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegistration.aspx.cs" Inherits="ub.pl.CustomerRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1>Customer REGISTRATION</h1>
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
        Account Alias<br/>
        <asp:TextBox ID="txt_accountalias" Width="150px" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfv_accountalias" runat="server" ControlToValidate="txt_accountalias" ErrorMessage="Enter Account Alias" Font-Bold="True" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
        <br/>
        <br/> 
        Account Number<br/>
        <asp:DropDownList runat="server" ID="ddl_bankname" Height="20px" Width="115px" DataSourceID="SqlDataSource1" DataTextField="BankName" DataValueField="BankNumber"/>
        <asp:DropDownList runat="server" ID="ddl_branchname" Height="20px" Width="115px" DataSourceID="SqlDataSource2" DataTextField="BranchName" DataValueField="BranchNumber"/>
        <asp:TextBox ID="txt_accountnumber" Width="150px" runat="server" TextMode="SingleLine"></asp:TextBox>
        <asp:DropDownList runat="server" ID="ddl_suffix" Height="20px" Width="115px" DataSourceID="SqlDataSource3" DataTextField="AccountType" DataValueField="Suffix"/>
                        <asp:RequiredFieldValidator ID="rfv_accountnumber" runat="server" ControlToValidate="txt_accountnumber" ErrorMessage="Enter Account Number" Font-Bold="True" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
                       
        <br/>
        <br/>
        AccountBalance<br/>
        <asp:TextBox ID="txt_accountbalance" Width="150px" runat="server" TextMode="SingleLine"></asp:TextBox>

        <br/>
        <br/>
        Account Status<br/>
        <asp:RadioButtonList runat="server" RepeatDirection="Horizontal" ID="rdbtnl_accountstatus" RepeatLayout="Table">
            <asp:ListItem Text="Active" Value="Active"></asp:ListItem>
            <asp:ListItem Text="Closed" Value="Closed"></asp:ListItem>
            <asp:ListItem Text="Frozen" Value="Frozen"></asp:ListItem>
        </asp:RadioButtonList>
        <br/>
        <br/>     
        <asp:Button ID="btn_Save" runat="server" Width="100px" Text="Save" OnClick="btn_Save_Click" />
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BankConnectionString %>" SelectCommand="SELECT [BankName], [BankNumber] FROM [BankInformation]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BankConnectionString %>" SelectCommand="SELECT [BranchName], [BranchNumber] FROM [BranchInformation]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BankConnectionString %>" SelectCommand="SELECT [AccountType], [Suffix] FROM [AccountInformation]"></asp:SqlDataSource>
    <asp:HyperLink ID="hyp_transfer" Text="Transfer" NavigateUrl="~/Trafers.aspx" runat="server"></asp:HyperLink>   

    </div>
    </form>
</body>
</html>
