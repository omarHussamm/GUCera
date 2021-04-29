<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="creditcard.aspx.cs" Inherits="GUCera.creditcard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

                     please fill the fields to add your creditcard <br />
            Number:<br />
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate = "number" ErrorMessage=" please fill in the Creditcard number "></asp:RequiredFieldValidator>
            <br />
            Card Holder Name:<br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate ="name" ErrorMessage="please fill in the Card holder Name "></asp:RequiredFieldValidator>
            <br /> 
            Expirydate:<br />
            <asp:TextBox ID="date" runat="server"></asp:TextBox> 
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="date" ErrorMessage="please fill in the Credit card Expirydate "></asp:RequiredFieldValidator>
            <br />
            Cvv :<br />
            <asp:TextBox ID="cvv" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"  ControlToValidate = "cvv" ErrorMessage=" please fill in the Creditcard cvv "></asp:RequiredFieldValidator>
            <br />
                 <asp:Button ID="createstudent" runat="server" OnClick="register" Text="enter " />
                 <br />

        </div>
    </form>
</body>
</html>
