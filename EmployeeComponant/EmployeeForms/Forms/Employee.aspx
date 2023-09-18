<%@ Page Language="C#"  EnableEventValidation="false" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeForms.Forms.WebForm1" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="form-horizontal">
        <div class="form-group">
            <label class="control-label col-sm-2" for="email">Employee Name:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtEmaployeeName" CssClass="col-sm-10" placholder="Enter Name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ValidationGroup="INSERT" runat="server" ControlToValidate="txtEmaployeeName" ErrorMessage="*Required" BorderStyle="None"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-sm-2" for="pwd">User Name:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtUserNmae" CssClass="col-sm-10" placholder="Enter User Name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ValidationGroup="INSERT" runat="server" ControlToValidate="txtUserNmae" ErrorMessage="*Required" BorderStyle="None"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-sm-2" for="pwd">Sallary :</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtSallary" CssClass="col-sm-10" placholder="Enter Sallary" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" ValidationGroup="INSERT" runat="server" ControlToValidate="txtSallary" ErrorMessage="*Required" BorderStyle="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BorderStyle="None" ControlToValidate="txtSallary" ErrorMessage="*Required Number" ForeColor="Red" ValidationExpression="\d*" ValidationGroup="INSERT"></asp:RegularExpressionValidator>
            </div>
        </div>

           <div class="form-group">
            <label class="control-label col-sm-2" for="pwd">Department :</label>
            <div class="col-sm-10">
                <asp:DropDownList CssClass="col-sm-10" ID="ddlDepartments" runat="server"></asp:DropDownList>
            </div>
        </div>

           <div class="form-group">
            <label class="control-label col-sm-2" for="pwd">PassWord :</label>
            <div class="col-sm-10">
               <asp:TextBox ID="txtPassWord" CssClass="col-sm-10" placholder="Enter Sallary" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4"  runat="server" ForeColor="Red" ValidationGroup="INSERT" ControlToValidate="txtPassWord" ErrorMessage="*Required" BorderStyle="None"></asp:RequiredFieldValidator>
            </div>
        </div>
                <div class="form-group">
            <label class="control-label col-sm-2" for="pwd">Confirm PassWord :</label>
            <div class="col-sm-10">
               <asp:TextBox ID="txtPassWordConfirm" CssClass="col-sm-10" placholder="Enter Sallary" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" ForeColor="Red" ValidationGroup="INSERT" runat="server" ControlToCompare="txtPassWordConfirm" ControlToValidate="txtPassWord" ErrorMessage="*Dont Match" BorderStyle="None"></asp:CompareValidator>
            </div>
        </div>

        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="btnInsertEmployee" CssClass="btn btn-primary"  ValidationGroup="INSERT" runat="server" Text="Insert" OnClick="btnInsertEmployee_Click" />
                 <asp:Button ID="btnDelete" CssClass="btn btn-primary"  ValidationGroup="INSERT" runat="server" Text="Delete"  Visible="false" OnClick="DeletClick" />
            </div>
        </div>
    </div>
    <br />
    <br />
    <asp:GridView AutoGenerateSelectButton="true"   OnSelectedIndexChanged="OnSelectedIndexChanged" ID="gvEmployees" DataKeyNames="SSN" CssClass="table table-hover col-sm-12" runat="server" EnablePersistedSelection="True" EnableSelection="true">
    </asp:GridView> 
</asp:Content>
