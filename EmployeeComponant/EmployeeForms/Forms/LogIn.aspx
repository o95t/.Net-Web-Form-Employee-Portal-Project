<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="EmployeeForms.Forms.LogIn" %>



<!DOCTYPE html>

<html>
<head runat="server">

    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <style>




        body#LoginForm{ background-image:url("https://hdwallsource.com/img/2014/9/blur-26347-27038-hd-wallpapers.jpg"); background-repeat:no-repeat; background-position:center; background-size:cover; padding:10px;}

.form-heading { color:#fff; font-size:23px;}
.panel h2{ color:#444444; font-size:18px; margin:0 0 8px 0;}
.panel p { color:#777777; font-size:14px; margin-bottom:30px; line-height:24px;}
.login-form .form-control {
  background: #f7f7f7 none repeat scroll 0 0;
  border: 1px solid #d4d4d4;
  border-radius: 4px;
  font-size: 14px;
  height: 50px;
  line-height: 50px;
}
.main-div {
  background: #ffffff none repeat scroll 0 0;
  border-radius: 2px;
  margin: 10px auto 30px;
  max-width: 38%;
  padding: 50px 70px 70px 71px;
}

.login-form .form-group {
  margin-bottom:10px;
}
.login-form{ text-align:center;}
.forgot a {
  color: #777777;
  font-size: 14px;
  text-decoration: underline;
}
.login-form  .btn.btn-primary {
  background: #f0ad4e none repeat scroll 0 0;
  border-color: #f0ad4e;
  color: #ffffff;
  font-size: 14px;
  width: 100%;
  height: 50px;
  line-height: 50px;
  padding: 0;
}
.forgot {
  text-align: left; margin-bottom:30px;
}
.botto-text {
  color: #ffffff;
  font-size: 14px;
  margin: auto;
}
.login-form .btn.btn-primary.reset {
  background: #ff9900 none repeat scroll 0 0;
}
.back { text-align: left; margin-top:10px;}
.back a {color: #444444; font-size: 13px;text-decoration: none;}

    </style>
</head>
<%--<body>
    <form id="form1" runat="server">

        <div class="form-horizontal">
            <div class="form-group">
                <label class="control-label col-sm-2" for="email">User Name:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtUserName" CssClass="col-sm-10" placholder="Enter User Name" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2" for="pwd">PassWord:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtpass" type="password" CssClass="col-sm-10" placholder="Enter PassWord" runat="server"></asp:TextBox>
                </div>

                <asp:CustomValidator ID="LogInValidation" ValidationGroup="LogInValidationValidationGroup" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
            </div>
            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <asp:Button ID="btnLog" CssClass="btn btn-primary" runat="server" Text="LogIn" ValidationGroup="LogInValidationValidationGroup" OnClick="btnLog_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
--%>











    




<body id="LoginForm">

        <form id="form1" runat="server">
    <div class="container">
        <h1 class="form-heading"></h1>
        <div class="login-form">
            <div class="main-div">
                <div class="panel">

                    <p>Please enter your  User Name and password</p>
                </div>
                <form id="Login">

                    <div class="form-group">


                        <asp:TextBox ID="txtUserName" CssClass="form-control" placeholder="Enter User Name" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="txtpass" type="password" CssClass="form-control" placeholder="Enter PassWord" runat="server"></asp:TextBox>

                    </div>


                    <asp:CustomValidator ID="LogInValidation" ValidationGroup="LogInValidationValidationGroup" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                    <asp:Button ID="btnLog" CssClass="btn btn-primary" runat="server" Text="LogIn" ValidationGroup="LogInValidationValidationGroup" OnClick="btnLog_Click" />
                </form>
            </div>

        </div>
    </div>

</form>
</body>






</html>







