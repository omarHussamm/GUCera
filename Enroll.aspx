<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enroll.aspx.cs" Inherits="GUCera.Enroll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             Course Number:<br />
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate = "cid" ErrorMessage=" please fill in the course id "></asp:RequiredFieldValidator>
            <br />
            Instructor id:<br />
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate ="id" ErrorMessage="please fill in the instructor id "></asp:RequiredFieldValidator>
            <br /> 
             <asp:Button ID="createstudent" runat="server" OnClick="register" Text="enter " />
                 <br />

        </div>
    </form>
</body>
</html>
