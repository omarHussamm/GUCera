<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="GUCera.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                  please fill the fields to add your feedback <br />
            Course Id:<br />
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate = "cid" ErrorMessage=" please fill in the Courseid"></asp:RequiredFieldValidator>
            <br />
            Comment : <br />
            <asp:TextBox ID="comment" runat ="server"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate ="comment" ErrorMessage="please add your comment "></asp:RequiredFieldValidator>
            <br /> 
         

        <asp:Button ID="createstudent" runat="server" OnClick="submit" Text="submit " />
                 <br />
             
                 
        </div>
    </form>
</body>
</html>
