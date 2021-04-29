<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminIssuePromocode.aspx.cs" Inherits="GUCera.AdminIssuePromocode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Issue Promocode to a Student<br />
            <br />
            StudentID:<br />
            <asp:TextBox ID="StudentId" runat="server"></asp:TextBox>
            <br />
            Code:<br />
            <asp:TextBox ID="Code" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Issue" runat="server" Text="Issue Promocode" OnClick="Issue_Click" />
        </div>
    </form>
</body>
</html>
