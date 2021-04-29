<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment.aspx.cs" Inherits="GUCera.Assignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="Register" runat="server" OnClick =" viewass">View My Assignment </asp:LinkButton>
                 <br />
                  <asp:LinkButton ID="LinkButton1" runat="server" OnClick =" submitass">Submit My Assignment   </asp:LinkButton>
                 <br />
                 <asp:LinkButton ID="Register1" runat="server" OnClick =" viewassgrade">View My Assignment Grade  </asp:LinkButton>
                 <br />
        </div>
    </form>
</body>
</html>
