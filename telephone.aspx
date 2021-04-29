<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="telephone.aspx.cs" Inherits="GUCera.telephone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              please  enter the required fields <br />
            telephone number:<br />
            <asp:TextBox ID="mob" runat="server"  ></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate = "mob" ErrorMessage=" please fill in the telephone number"></asp:RequiredFieldValidator>
            
            <br />
              <asp:Button ID="signin" runat="server" OnClick="login" Text="enter " />
                 <br />
        </div>
    </form>
</body>
</html>
