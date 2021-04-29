<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Studenthomepage.aspx.cs" Inherits="GUCera.Studenthomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                   Welcome 
             <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick ="ass">Assignments  </asp:LinkButton>
                 <br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick ="allcourses">View All Availlable   Courses  </asp:LinkButton>
             <br />
             <asp:LinkButton ID="LinkButton3" runat="server" OnClick ="mycourses">View My Courses  </asp:LinkButton>
                 <br />

             <asp:LinkButton ID="Register1" runat="server" OnClick ="certificate">View My Certificates  </asp:LinkButton>
                 <br />

              <asp:LinkButton ID="LinkButton4" runat="server" OnClick ="payment">Payment Methods  </asp:LinkButton>
                 <br />

              <asp:LinkButton ID="LinkButton5" runat="server" OnClick ="info"> view my info   </asp:LinkButton>
                 <br />
            <asp:LinkButton ID="LinkButton6" runat="server" OnClick ="tel"> Add My Telephone Number   </asp:LinkButton>
                 <br />
        </div>
        
    </form>
</body>
</html>
