<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateEmployeeDetails.aspx.cs" Inherits="Time_Management_System_Project.UpdateEmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmpid" runat="server" Text="Employee Id " ForeColor="Blue" Width="200px" Height="30px"></asp:Label>
            <asp:TextBox ID="txtEmpid" runat="server" ></asp:TextBox><br />

            <asp:Label ID="lblNewMailId" runat="server" Text="New Mail Id" ForeColor="Blue" Width="200px" Height="30px"></asp:Label>
            <asp:TextBox ID="txtMailId" runat="server"></asp:TextBox><br /> <br />

            <asp:Button ID="update" runat="server" Text="Update" ForeColor="RED" Width="142px" Height="30px" OnClick="update_Click" />
            <asp:Label ID="lblUpdate" runat="server" Text=" "></asp:Label>
             <br /><br />

            <asp:GridView ID="GridViewUpdate" runat="server" Height="672px" Width="1457px">
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
