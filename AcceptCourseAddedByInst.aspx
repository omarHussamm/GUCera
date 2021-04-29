<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptCourseAddedByInst.aspx.cs" Inherits="GUCera.AcceptCourseAddedByInst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            AdminID:<br />
            <asp:TextBox ID="AdminId" runat="server"></asp:TextBox>
            <br />
            CourseID:</div>
        <asp:TextBox ID="CourseId" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="AcceptCourse" runat="server" Text="AcceptCourse" OnClick="AcceptCourse_Click" />
        </p>
    </form>
</body>
</html>
