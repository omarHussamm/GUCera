<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewcertifcate.aspx.cs" Inherits="GUCera.Viewcertifcate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                 please  enter the required fields <br />
            Course id:<br />
            <asp:TextBox ID="cid" runat="server"  ></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate = "cid" ErrorMessage=" please fill in the Courseid"></asp:RequiredFieldValidator>
            
            <br />
              <asp:Button ID="signin" runat="server" OnClick="login" Text="enter " />
                 <br />

        </div>
    </form>
</body>
</html>
