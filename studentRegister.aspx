<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentRegister.aspx.cs" Inherits="GUCera.studentRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
               input[type=text] ,input[type=email],select{
  border-radius: 10px ;
  box-sizing: border-box;
  border: 2px solid white;
  border-bottom: 2px solid rgb(223, 160, 115);
  color:rgb(223, 160, 115);
  font-size:20px;
  outline:none;
  width:188px;
}
     input[type=text]:focus,input[type=email]:focus,select:focus {
  border-radius: 10px ;
  border:2px solid rgb(223, 160, 115);
}
    html { 
  background: url("campus.jpg") no-repeat center center fixed; 
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
    .in{
        padding-bottom:5px;
    }
  .reg{
      font-size:32px;
      padding-bottom:40px;
      font-family: 'Trebuchet MS', sans-serif;
      font-weight:bold;
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
         width:350px;
         height:auto;
         margin-top: 200px;
    }
   
</style>
<body>
    <form id="form1" runat="server">
       <div>
            <div class="reg">Register as Student</div>
            
            <div class="in">
                First name:
            <asp:TextBox ID="firstName" runat="server" maxlength="10"></asp:TextBox></div>
            <div class="in">
               Last name:
            <asp:TextBox ID="lastName" runat="server" maxlength="10"></asp:TextBox></div>
            <div class="in">
               password:&nbsp;&nbsp;<asp:TextBox ID="password" runat="server" maxlength="10"></asp:TextBox></div>
            <div class="in">
               email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="email" TextMode="Email" runat="server" maxlength="50"></asp:TextBox></div>
            <div class="in">
               gender:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <select id="gender" runat="server">
                    <option value="0">Male</option>
                     <option value="1">Female</option>
                </select></div>
            <div class="in">
               address:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="address" runat="server" maxlength="50"></asp:TextBox></div>
            <br />
            <asp:Button CssClass="btn" ID="btn1" runat="server" Text="Register" OnClick="reg_Click" />
            <br />
        </div>
    </form>
</body>
</html>
