<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewGrade.aspx.cs" Inherits="GUCera.viewGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
       html { 
  background: url("inst.jpg") no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
    #customers {
  font-family: Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#customers td, #customers th {
  border: 1px solid #ddd;
  padding: 8px;
}

#customers tr:nth-child(odd){background-color: rgb(223, 160, 115);
color: white;
}
#customers tr:nth-child(even){color: rgb(223, 160, 115);
background-color: white;
}

#customers tr:hover {background-color: #ddd;
color:white;}

#customers th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: rgb(223, 160, 115);
  color: white;
}
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
  
    .inn{
        padding: 50px 100px;
         color:white;
         border-radius: 100px;
         background: rgba(223, 160, 115, 0.90);
         text-align: center;
         font-family: verdana;
         font-size: 20px;
         border-radius: 16px;
         margin: auto;
         width:500px;
         height:auto;
         margin-top: 100px;
    }
    .namee{
        margin: 10px auto;
    }
</style>
<body>
    <form id="form1" runat="server">
        <div class="inn">
            <div class="namee">
            Student ID:
            <asp:TextBox ID="studID" runat="server"></asp:TextBox>
            </div><div class="namee">
            Course ID:
            <asp:TextBox ID="courID" runat="server"></asp:TextBox>
            </div><div class="namee">
            Assignment Type:
            <asp:TextBox ID="aType" max="10" runat="server"></asp:TextBox>
           </div><div class="namee">
            Assignmnent Number:
            <asp:TextBox ID="aNum" runat="server"></asp:TextBox>
            </div><div class="namee">
            Grade:
            <asp:TextBox ID="g" runat="server"></asp:TextBox>
            </div>
            <br />
            <asp:Button class="btn" ID="Button1" runat="server" Text="Submit Grade" OnClick="Button1_Click" />
        </div>
        <br />
        <div>
            <asp:PlaceHolder ID = "PlaceHolder1" runat="server" />
        </div>
    </form>
</body>
</html>
