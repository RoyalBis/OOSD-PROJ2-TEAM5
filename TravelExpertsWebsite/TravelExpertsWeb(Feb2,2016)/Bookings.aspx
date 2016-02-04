<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Bookings.aspx.cs" Inherits="Bookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" />
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <br /><u style="color:white"><asp:Label class="welcome" ID="lblUsername" runat="server" ForeColor="white"></asp:Label></u><br /><br /><br />
                    <form id="form2" runat="server">
                        <div class = "col-lg-3" style ="background-color: rgba(38, 38, 38, 0.8); color:white">
                            <br /><p>Customer Information</p>
                        </div>
                        <div class = "col-lg-8" style ="background-color: rgba(38, 38, 38, 0.8); color:white">
                            <br /><p>Booking History</p>
                            <asp:GridView ID="gvBooking" runat="server" CellPadding="6" CssClass="table" GridLines="None">
                            </asp:GridView>
                            <br />
                        </div>
                    </form>
                </div>
            </div>
        </div>
</asp:Content>

