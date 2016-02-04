<%@ Page Title="About" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Travel Experts</h3>
    <p>Travel Experts has been serving customers in need of their own vacation since 2015. We tend to our customers faster than any other agency. Our mascot Otebri (Owl of the Travel Experts BRIgade) the owl acts as the bug catcher, preventing your experience on our website from being frustrating and guarantees customer satisfaction, much like our caring agents.</p>
    <img id="otebri" src="Images/otebri.jpg" />

    <br />
    <br />
    <br />
    <p>If you have any complaints about our customer service, packages or anything particular, click <asp:HyperLink ID="hlComplaints" runat="server" NavigateUrl="~/Complaints.aspx">here</asp:HyperLink>.</p>
</asp:Content>
