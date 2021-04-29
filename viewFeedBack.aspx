<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewFeedBack.aspx.cs" Inherits="GUCera.viewFeedBack" %>

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
</style>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID = "PlaceHolder1" runat="server" />
        </div>
    </form>
</body>
</html>
