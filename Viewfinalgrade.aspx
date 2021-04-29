<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewfinalgrade.aspx.cs" Inherits="GUCera.Viewfinalgrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                          please fill the fields to view your assignemnt grades <br />
            Course Id:<br />
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate = "cid" ErrorMessage=" please fill in the Courseid"></asp:RequiredFieldValidator>
            <br />
            Number:<br />
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate ="number" ErrorMessage="please fill in the Assingment number"></asp:RequiredFieldValidator>
            <br /> 
            Type:<br />
            <asp:TextBox ID="type" runat="server"></asp:TextBox> 
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="type" ErrorMessage="please fill in the Assignemt type "></asp:RequiredFieldValidator>
            <br />
          

        <asp:Button ID="createstudent" runat="server" OnClick="register" Text="enter " />
                 <br />

        </div>
    </form>
</body>
</html>
