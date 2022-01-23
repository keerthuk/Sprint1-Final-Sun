<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manager Master.aspx.cs" Inherits="Time_Management_System_Project.Manager_Master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .btnstyle {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            cursor: pointer;
            }
    </style>
</head>
    
<body >
    
    <form id="form1" runat="server">
        <div>
            <asp:Button style="margin:20px"
             ID="ViewingTimeSheet" 
             runat="server" 
             Text="View TimeSheet"
             CssClass="btnstyle"
             Height="50px"
             Width="165px"
             Font-Bold="true"
             OnClick="ViewingTimeSheet_Click"
             />
            <asp:Button style="margin:20px"
             ID="AllocateProject" 
             runat="server" 
             Text="Allocate Project"
             CssClass="btnstyle"
             Font-Bold="true"
             Height="50px"
             Width="162px" OnClick="AllocateProject_Click"
             />
            <asp:Button style="margin:20px"
             ID="ChangePassword"
             runat="server" 
             Text="Change Password"
             CssClass="btnstyle"
             Font-Bold="true"
             Height="50px"
             Width="196px" OnClick="ChangePassword_Click"
             /> <br /> <br />
            <asp:Button style="margin:20px"
             ID="ReleaseEmp"
             runat="server" 
             Text="Release"
             CssClass="btnstyle"
             Font-Bold="true"
             Height="50px"
             Width="150px" OnClick="ReleaseEmp_Click"
             />
            <asp:Button style="margin:20px"
             ID="update"
             runat="server" 
             Text="Update"
             CssClass="btnstyle" 
             Height="50px"
             Width="161px"
             Font-Bold="true" OnClick="update_Click"
             /> <br /> <br />
            
            <asp:GridView ID="GridViewManagerTimeSheet" runat="server" Height="607px" Width="1459px">
                <RowStyle BackColor="Beige" Font-Italic="True" />
                <EmptyDataRowStyle BackColor="Yellow" />
                <PagerStyle BackColor="#FFC0C0" Font-Italic="True" Font-Underline="True" />
                <SelectedRowStyle BackColor="#00C000" Font-Bold="True"  />
                <EditRowStyle BackColor="#0000C0" />
                <AlternatingRowStyle BackColor="Gray" BorderColor="Black" BorderStyle="Dashed" BorderWidth="1px" Font-Bold="True" />
                <FooterStyle BackColor="#00C0C0" />
                <HeaderStyle BackColor="IndianRed" Font-Bold="True" Font-Italic="True" Font-Underline="True" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
