﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<%--    Author: Lee Harrold
         Date: Jan 28, 2016
         Class: OOSD Oct 2015
         Description: About page   --%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-lg-12" style ="background-color: rgba(38, 38, 38, 0.8); color:white">
                <h2>About</h2>
                <h3>Travel Experts</h3>
                <p>Travel Experts has been serving customers in need of their own vacation since 2015. We tend to our customers faster than any other agency. Our mascot Otebri (Owl of the Travel Experts BRIgade) the owl acts as the bug catcher, preventing your experience on our website from being frustrating and guarantees customer satisfaction, much like our caring agents.</p>
                <img id="otebri" src="Images/otebri.jpg" />

                <br />
                <br />
                <br />
                <p>If you have any complaints about our customer service, packages or anything particular, click <asp:HyperLink style="color:lightcyan" ID="hlComplaints" runat="server" NavigateUrl="~/Complaints.aspx">here</asp:HyperLink>.</p>
            </div>
        </div>
    </div>
</asp:Content>
