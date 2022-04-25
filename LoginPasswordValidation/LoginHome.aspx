<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginHome.aspx.cs" Inherits="LoginPasswordValidation.LoginHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <thead>
              
                </thead>
                <tbody>
                <tr>
                    <td>
                        <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="txtUserName" runat="server" CausesValidation="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server"  Text="Password"></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CausesValidation="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                   <asp:Button runat="server" ID="btnSubmit" Visible="True" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
                    <tr>
                        <td>
                            <asp:ListBox ID="lstValidationErrors" runat="server" Visible="false"></asp:ListBox>
                        </td>
                    </tr>
            </tbody>
            </table>
        </div>
    </form>
</body>
</html>
