<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New Project.aspx.cs" Inherits="Time_Management_System_Project.New_Project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1417px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:hotpink;">
            <h2>Add New Project </h2>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblProjectid" runat="server" Text="Project Id"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtProjectId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblProjectname" runat="server" Text="Project Name"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPtartdate" runat="server" Text="Start Date"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEnddate" runat="server" Text="End date"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtenddate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblIsactive" runat="server" Text="Is Active"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtIsActive" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td class="auto-style1">
                        <asp:Button ID="btnCreate" runat="server" Text="CREATE" OnClick="btnCreate_Click" /><br /><br />
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br /><br /><br /> 
                     </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridViewProject" runat="server" Height="489px" Width="1467px" style="margin-right: 0px">
                        <RowStyle BackColor="Beige" Font-Italic="True" />
                        <EmptyDataRowStyle BackColor="Yellow" />
                        <PagerStyle BackColor="#FFC0C0" Font-Italic="True" Font-Underline="True" />
                        <SelectedRowStyle BackColor="#00C000" Font-Bold="True"  />
                        <EditRowStyle BackColor="#0000C0" />
                        <AlternatingRowStyle BackColor="Gray" BorderColor="Black" BorderStyle="Dashed" BorderWidth="1px" Font-Bold="True" />
                        <FooterStyle BackColor="#00C0C0" />
                        <HeaderStyle BackColor="IndianRed" Font-Bold="True" Font-Italic="True" Font-Underline="True" />
                        </asp:GridView>
    </form>
</body>
</html>
