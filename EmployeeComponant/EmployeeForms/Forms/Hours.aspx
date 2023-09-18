<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Hours.aspx.cs" Inherits="EmployeeForms.Forms.Hours" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="form-horizontal">
        <div class="form-group">
            <label class="control-label col-sm-2" for="email">Hours:</label>
             <div class="col-sm-10">
                <asp:TextBox ID="txtHours" CssClass="col-sm-10"  placholder="Enter Project Name" runat="server"></asp:TextBox>
            <label class="control-label col-sm-2" for="email">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="INSERT" runat="server" BorderStyle="None" ErrorMessage="*Required" ForeColor="Red" ControlToValidate="txtHours"></asp:RequiredFieldValidator>
                 </label>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationGroup="INSERT" runat="server" BorderStyle="None" ErrorMessage="*Required Number" ForeColor="Red" ControlToValidate="txtHours" ValidationExpression="\d*"></asp:RegularExpressionValidator>
                </div>
            </div>
          <div class="form-group">
            <label class="control-label col-sm-2" for="pwd">Project:</label>
            <div class="col-sm-10">
                <asp:DropDownList CssClass="col-sm-10" ID="ddlProj" runat="server"></asp:DropDownList>
            </div>
        </div>
          <div class="form-group">
            <label class="control-label col-sm-2" for="pwd">Employee:</label>
            <div class="col-sm-10">
                <asp:DropDownList CssClass="col-sm-10" ID="ddlEmployee" runat="server"></asp:DropDownList>
            </div>
        </div>
          <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="btnInsertHours" CssClass="btn btn-primary" ValidationGroup="INSERT" runat="server" Text="Insert" OnClick="btnInsertHours_Click" />
                <asp:Button  ID="btnDel" CssClass="btn btn-primary" ValidationGroup="INSERT" runat="server" Text="Delete"  Visible="false" OnClick="btnDel_Click" />
                      </div>
       </div>
     <br />
    <br />


    <asp:GridView AutoGenerateSelectButton="true"   OnSelectedIndexChanged="gvHours_SelectedIndexChanged" ID="gvHours" DataKeyNames="PNO" CssClass="table table-hover col-sm-12" runat="server" EnablePersistedSelection="True" EnableSelection="true"></asp:GridView>
   



</asp:Content>
