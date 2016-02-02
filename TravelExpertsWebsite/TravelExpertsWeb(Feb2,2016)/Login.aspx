<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Scripts_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="msform" runat="server">
        <fieldset>
            <h2 class="fs-title">Travel Experts</h2>
            <asp:Label class="fs-subtitle" ID="lblMsg" runat="server">Enter username and password</asp:Label>
		    <br />
            <br />
            <asp:TextBox ID="txtLUsername" runat="server" placeholder="Username"></asp:TextBox>
            <asp:TextBox ID="txtLPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
            <asp:Button ID="signout" class="next action-button" runat="server" Text="Signout" Visible="false" OnClick="signout_Click"/>
            <asp:Button ID="login" class="next action-button" runat="server" Text="Login" OnClick="login_Click" />
        </fieldset>
	</form>
</asp:Content>

