<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="GUCera.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:LinkButton ID="Register" runat="server" OnClick =" creditcard"> Add Credit Card Details </asp:LinkButton>
                 <br />
                  <asp:LinkButton ID="LinkButton1" runat="server" OnClick =" promocode">View My Promocodes    </asp:LinkButton>
                 <br />
        </div>
    </form>
</body>
</html>
