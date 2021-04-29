<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issueCertificate.aspx.cs" Inherits="GUCera.issueCertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
                input[type=text] {
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
     input[type=text]:focus {
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
         width:400px;
         height:auto;
         margin-top: 100px;
    }
    .namee{
        margin:10px auto;
    }
    
</style>
<body>
    <form id="form1" runat="server">
        <div>
            
            <div class="namee">
            Course ID:
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
            </div>
            <div class="namee">
            Student ID:
            <asp:TextBox ID="sid" runat="server"></asp:TextBox>
           </div>
            <br />
            <asp:Button Class="btn" ID="Button1" runat="server" Text="Issue Certificate" OnClick="Button1_Click" />
            
        </div>
    </form>
</body>
</html>
