<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Allocate.aspx.cs" Inherits="Time_Management_System_Project.Allocate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:lightpink;">
                   
            <table class="autostyle1">
                <tr>
                    <td>
                        <asp:Label ID="lblEmpProjectId" runat="server" Text="Employee Project Id"></asp:Label>
                        
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmpProjectId" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Employee Project Id should not be null" ControlToValidate="txtProjectId"></asp:RequiredFieldValidator>
                    </td>
                
                <tr>
                    <td>
                        <asp:Label ID="lblEmployeeId" runat="server" Text="Employee Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmployeeId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblProjectId" runat="server" Text="Project Id "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtProjectId" runat="server"></asp:TextBox></td>
                </tr> 
                <tr>
                <td></td>
                <td>                     
             <asp:Button 
             ID="AllocateEmp" 
             runat="server" 
             Text="Allocate"
             ForeColor="SaddleBrown"
             Font-Bold="true"
             Height="50px"
             Width="150px" OnClick="AllocateEmp_Click" />
              <br />  
              <asp:Label ID="lblAllocate" runat="server" Text=" "></asp:Label>
                </tr>
           
            </table>
        </div>
    </form>
</body>
</html>
