<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorAddAssignment.aspx.cs" Inherits="GUCera.instructorAddAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
                input[type=text],input[type=datetime-local] {
  border-radius: 10px ;
  box-sizing: border-box;
  border: 2px solid white;
  border-bottom: 2px solid rgb(223, 160, 115);
  color:rgb(223, 160, 115);
  font-size:20px;
  outline:none;
  width:188px;
  float:right;
}
     input[type=text]:focus,input[type=datetime-local]:focus {
  border-radius: 10px ;
  border:2px solid rgb(223, 160, 115);
}
    html { 
  background: url("inst.jpg") no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
    .btn{
background-color: white; 
  border: none;
  color: rgb(223, 160, 115);
  padding: 10px 20px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 10px 2px;
  cursor: pointer;
  border-radius: 12px;
  border: 2px solid rgb(223, 160, 115);
  outline: none;
    }
    .btn:hover {
  background-color: rgb(223, 160, 115);
  color: white;
  border: 2px solid white;
}
  
    form{
        padding: 50px 100px;
         color:white;
         border-radius: 100px;
         background: rgba(223, 160, 115, 0.90);
         text-align: center;
         font-family: verdana;
         font-size: 20px;
         border-radius: 16px;
         margin: auto;
         width:450px;
         height:auto;
         margin-top: 100px;
    }
    
</style>
<body>
    <form id="form1" runat="server">
        <div>
            Course ID:<asp:TextBox ID="cid" runat="server"></asp:TextBox>
            <br />
            <br />
            Assignment Type:<asp:TextBox ID="type" runat="server"></asp:TextBox>
            <br />
            <br />
            Assignmnet Number: <asp:TextBox ID="number" runat="server"></asp:TextBox>
            <br />
            <br />
            Full Grade:<asp:TextBox ID="fullgrade" runat="server"></asp:TextBox>
            <br />
            <br />
            Weight:<asp:TextBox ID="weight" runat="server"></asp:TextBox>
            <br />
            <br />
            Deadline:<input type="datetime-local" id="deadLineTime" runat="server" min="2020-01-02">
            <br />
            <br />
            Content:<asp:TextBox ID="content" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn" ID="Button1" runat="server" Text="Add Assignmnent" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
