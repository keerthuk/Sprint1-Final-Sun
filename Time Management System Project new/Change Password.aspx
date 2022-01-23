<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change Password.aspx.cs" Inherits="Time_Management_System_Project.Change_Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><table class="autostyle1">
            <tr>
                <td>
                    <asp:Label ID="lblEmpid" runat="server" Text="Employee Id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox>
                </td>
            </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblNewPass" runat="server" Text="New Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNewPassword" runat="server"></asp:TextBox><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblConfirmPass" runat="server" Text="Confirm Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox><br /><br />
                </tr> 
                <tr>
                <td></td>
                <td>            
             <asp:Button 
             ID="submit" 
             runat="server" 
             Text="Submit"
             ForeColor="SaddleBrown"
             Font-Bold="true"
             Height="50px"
             Width="150px" OnClick="submit_Click" />
              <br />  
              <asp:Label ID="lblChangePassword" runat="server" Text=" "></asp:Label>
                </tr>         
            </table>

        </div>
    </form>
</body>
</html>
