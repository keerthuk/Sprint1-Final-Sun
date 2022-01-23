<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="Time_Management_System_Project.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="UserId" style="position:absolute; top: 258px; left: 381px; height: 26px; width: 154px;"
                 runat="server" ForeColor="#0033CC" Text="User Id"></asp:Label>

             <asp:TextBox ID="textUserId" style="position:absolute; top: 259px; left: 623px; width: 154px; height: 26px;" 
                runat="server"></asp:TextBox>
             
            <br />

            <asp:Label ID="Password" style="position:absolute; top: 339px; left: 379px; height: 26px; width: 154px;"  
                runat="server" ForeColor="#0033CC" Text="Password"></asp:Label>

              
            <asp:TextBox ID="textPassword" TextMode ="Password" style="position:absolute; top: 342px; left: 624px; width: 154px; height: 26px;"  
                runat="server"></asp:TextBox> 
            
            <br /> <br />
            <asp:Button ID="Login" style="position:absolute; top: 450px; left: 541px; width: 194px; height: 40px;"
                runat="server" Text="Login" ForeColor="Black" OnClick="Login_Click" BackColor="#66FF66" BorderStyle="None" />

            
            
            <asp:Label ID="title"  style="position:absolute; top: 10px; left:3px; width: 1479px; height: 120px; margin-bottom: 73px;" 
                runat="server" Font-Bold="True" Font-Italic="True" 
                        Font-Names="Times New Roman" Font-Size="XX-Large" ForeColor="Black" 
                        Text="Time Management System" BackColor="#FFCCFF"></asp:Label>
              
            <asp:Label ID="subTitle" 
                style="position:absolute; top: 134px; left: 406px; width: 397px; height: 52px; margin-bottom: 73px;" 
        runat="server" Text="Welcome to Login page" Font-Bold="True" Font-Italic="True" 
        Font-Names="Calibri Light" Font-Size="XX-Large" ForeColor="Blue"></asp:Label>

        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textUserId" ErrorMessage="Please Enter User Id" ForeColor="Red"></asp:RequiredFieldValidator>
    </form>
</body>
</html>
