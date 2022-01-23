<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Time_Management_System_Project.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Admin Page</h2>
            <br /><br />
            <asp:Button ID="BtnNewProject" runat="server" Text="New Project" ForeColor="SaddleBrown" OnClick="NewProject_Click" /> <br /><br />
            <h3>TimeSheet</h3>
            <asp:GridView ID="GridViewAdmin" runat="server" Height="489px" Width="1443px" style="margin-right: 0px">
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
