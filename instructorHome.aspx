<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorHome.aspx.cs" Inherits="GUCera.instructorHome" %>

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
     input[type=text] {
  width: auto;
  padding: 12px 20px;
  margin: 8px 0;
  box-sizing: border-box;
  border: 2px solid white;
  border-bottom: 2px solid rgb(223, 160, 115);
  color:rgb(223, 160, 115);
  font-size:20px;
  outline:none;
}
     input[type=text]:focus {
  border-radius: 10px ;
  border:2px solid rgb(223, 160, 115);
}
    .grid-container {
  display: grid;
  grid-template-columns: auto auto auto;
  background: rgba(223, 160, 115, 0.5);
  padding: 10px;
   grid-column-gap: 50px;
   grid-row-gap: 50px;
   grid-template-columns: auto auto;
   grid-template-rows: auto auto;
  height: 700px;
  align-content: center;
  border-radius: 46px;
}

.grid-item {
  background-color: #ffffff;
  border: 1px solid rgb(223, 160, 115);
  padding: 20px;
  font-size: 30px;
  text-align: center;
  border-radius: 16px;
  color:rgb(223, 160, 115);
}
h1{
    color: rgb(223, 160, 115);
    font-family: 'Trebuchet MS', sans-serif;
    text-align:center;
    font-size:50px
}
.btn{
  color: white; 
  border: none;
  background-color: rgb(223, 160, 115);
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
  color: rgb(223, 160, 115);
  background-color: white;
  border: 2px solid rgb(223, 160, 115);
}
</style>
<body>
    <h1>Hello Instructor</h1>
     <form id="form1" runat="server">
        <div class="grid-container">
        <div class="grid-item"> Add mobile number

            <br />
            <asp:TextBox ID="mobileNo" runat="server"></asp:TextBox>
            <br />
            <asp:Button class="btn" ID="mob" runat="server" Text="Add" OnClick="mob_Click" Width="73px" />

            <br />
            
</div>
        <div class="grid-item"> 
            <asp:Button class="btn" ID="Button1" runat="server" Text="Add Course" OnClick="Button1_Click" />

        </div>
        <div class="grid-item">  
            <asp:Button class="btn" ID="Button2" runat="server" Text="Add Assignment" OnClick="Button2_Click" />

        </div>  
        <div class="grid-item">  Course:<asp:TextBox ID="cid" runat="server"></asp:TextBox>
             <br />
             <asp:Button class="btn" ID="viewGarde" runat="server" Text="View/Grade Assignmnets" OnClick="viewGarde_Click" />

        </div>
        <div class="grid-item">
            Course:<asp:TextBox ID="cid1" runat="server"></asp:TextBox>
             <br />
             <asp:Button class="btn" ID="viewFeedBack" runat="server" Text="View Feedback" OnClick="viewFeedBack_Click" />

        </div>
        <div class="grid-item">
           
             <asp:Button class="btn" ID="certificate" runat="server" Text="Issue Certificate" OnClick="certificate_Click" />

        </div>  
             </div>
      
    </form>
      
</body>
</html>
