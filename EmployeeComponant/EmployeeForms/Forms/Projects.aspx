<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="EmployeeForms.Forms.Projects" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="form-horizontal">
        <div class="form-group">
            <label class="control-label col-sm-2" for="email">Project Name:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtProjName" CssClass="col-sm-10" placholder="Enter Project Name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="INSERT" runat="server" BorderStyle="None" ErrorMessage="*Required" ForeColor="Red" ControlToValidate="txtProjName"></asp:RequiredFieldValidator>
                </div>
            </div>
             <div class="form-group">
            <label class="control-label col-sm-2" for="email">Project Location:</label>
                  <div class="col-sm-10" style="left: 0px; top: 0px">
                <asp:TextBox ID="txtProjLoc"  CssClass="col-sm-10" placholder="Enter Project Location" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="INSERT" runat="server" BorderStyle="None" ErrorMessage="*Required" ForeColor="Red" ControlToValidate="txtProjLoc"></asp:RequiredFieldValidator>
                  </div>
        </div>
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="btnInsertProj" CssClass="btn btn-primary" ValidationGroup="INSERT" runat="server" Text="Insert" OnClick="btnInsertProj_Click" />
                <asp:Button  ID="btnDel" CssClass="btn btn-primary" ValidationGroup="INSERT" runat="server" Text="Delete"  Visible="false" OnClick="btnDel_Click" />
                      </div>
       </div>
     <br />
    <br />


    <asp:GridView AutoGenerateSelectButton="true"   OnSelectedIndexChanged="OnSelectedIndexChanged" ID="gvProj" DataKeyNames="PNO" CssClass="table table-hover col-sm-12" runat="server" EnablePersistedSelection="True" EnableSelection="true"></asp:GridView>
       </asp:Content>
