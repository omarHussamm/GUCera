<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCreatePromocode.aspx.cs" Inherits="GUCera.AdminCreatePromocode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Code:<br />
            <asp:TextBox ID="Code" runat="server"></asp:TextBox>
            <br />
            issueDate:<br />
            <input type="datetime-local" id="Issuedate" runat="server"/>
            &nbsp;<br />
            expiryDate:<br />
           <input type="datetime-local" id="Expirydate" runat="server"/>
            <br />
            Discout:<br />
            <asp:TextBox ID="Discount" runat="server"></asp:TextBox>
            <br />
            AdminId:<br />
            <asp:TextBox ID="AdminId" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="CreatePromo" runat="server" Text="Create PromoCode" OnClick="CreatePromo_Click" />
        </div>
    </form>
</body>
</html>
