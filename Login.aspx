<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
    html { 
  background: url("campus.jpg") no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
         input[type=text] ,input[type=password]{
  
  box-sizing: border-box;
  border: 2px solid white;
  border-bottom: 2px solid rgb(223, 160, 115);
  color:rgb(223, 160, 115);
  font-size:20px;
  outline:none;
  float:right;
  border-radius: 10px ;
}
     input[type=text]:focus,input[type=password]:focus {
  border-radius: 10px ;
  border:2px solid rgb(223, 160, 115);
  
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

    a{
        font-size:17px;
    }
  .logIn{
      font-size:32px;
      padding-bottom:40px;
      font-family: 'Trebuchet MS', sans-serif;
      font-weight:bold;
  }
  .namee{
      margin:10px 0px;
  }
  .register{
      font-size:12px;
      padding-top:4px;
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
         width:400px;
         height:auto;
         margin-top: 200px;
    }

</style>
<body>
    <form id="form1" runat="server">
        
        <div class="logIn">Log In to GUCera</div>
        <div class="namee">
            User ID:&nbsp;&nbsp;
        <asp:TextBox ID="username" runat="server"  ></asp:TextBox>
        </div>
        <div class="namee">
        Password: <asp:TextBox ID="password" TextMode="Password" runat="server" maxlength="20" ></asp:TextBox></div>
        
        <br />
        
        <asp:Button Class="btn" ID="signin" runat="server" OnClick="login" Text="log in" />

        <div class="register">don't have an account? register from here</div>
        <a href="studentRegister.aspx">Register as Student</a>
        <br />
        <a href="instructorRegister.aspx">Register as Instructor</a>

    </form>
    
</body>
</html>
