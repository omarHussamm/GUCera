<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sumbitmyass.aspx.cs" Inherits="GUCera.Sumbitmyass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

              please fill the fields to sumbit your assignment  <br />
            Course Id:<br />
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate = "cid" ErrorMessage=" please fill in the Courseid"></asp:RequiredFieldValidator>
            <br />
            Number:<br />
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate ="number" ErrorMessage="please fill in the Assignment number"></asp:RequiredFieldValidator>
            <br /> 
            Type:<br />
            <asp:TextBox ID="type" runat="server"></asp:TextBox> 
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="type" ErrorMessage="please fill in the Assignment type "></asp:RequiredFieldValidator>
            <br />
          

        <asp:Button ID="createstudent" runat="server" OnClick="register" Text="Submit " />
                 <br />
           
             

        </div>
    </form>
</body>
</html>
