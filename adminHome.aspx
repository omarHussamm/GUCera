<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminHome.aspx.cs" Inherits="GUCera.adminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Admin Home<br />
            <br />
            <asp:Button ID="ListCourses" runat="server" Text="List All Courses" OnClick="ListCourses_Click" />
            <br />
            <br />
            <asp:Button ID="NoAcceptedCourses" runat="server" Text="Not Accepted Courses" OnClick="NoAcceptedCourses_Click" />
            <br />
            <br />
            <asp:Button ID="AcceptCourse" runat="server" Text="Accept Courses" OnClick="AcceptCourse_Click" />
            <br />
            <br />
            <asp:Button ID="CreatePromo" runat="server" Text="Create PromoCode" OnClick="CreatePromo_Click" />
            <br />
            <br />
            <asp:Button ID="IssuePromo" runat="server" Text="Issue PromoCode" OnClick="IssuePromo_Click" />
        </div>
    </form>
</body>
</html>
