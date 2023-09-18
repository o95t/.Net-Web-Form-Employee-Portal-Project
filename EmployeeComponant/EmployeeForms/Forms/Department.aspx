<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Department.aspx.cs" Inherits="EmployeeForms.Forms.InsertDepartment" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="form-horizontal">
        <div class="form-group">
            <label class="control-label col-sm-2" for="email">Department Name:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtDepName"  CssClass="col-sm-10" placholder="Enter Name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator1" runat="server" BorderColor="Red" ValidationGroup="INSERT" BorderStyle="None" ControlToValidate="txtDepName" ErrorMessage="*Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <label class="control-label col-sm-2" for="pwd">Department Manger:</label>
            <div class="col-sm-10">
                <asp:DropDownList CssClass="col-sm-10" ID="ddlmanger" runat="server"></asp:DropDownList>
            </div>
        </div>


        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="btnInsertDepartment" ValidationGroup="INSERT" CssClass="btn btn-primary" runat="server" Text="Insert" OnClick="btnInsertDepartment_Click" />
                <asp:Button ID="btnDelete" ValidationGroup="INSERT" CssClass="btn btn-primary" runat="server" Text="Delete"  Visible="false" OnClick="DeletDept" />
            </div>
       </div>

 </div>
    <asp:GridView AutoGenerateSelectButton="true"   OnSelectedIndexChanged="OnSelectedIndexChanged" ID="gvDepartment" DataKeyNames="DNO" CssClass="table table-hover col-sm-12" runat="server" EnablePersistedSelection="True" EnableSelection="true"></asp:GridView>
 
    </asp:Content>