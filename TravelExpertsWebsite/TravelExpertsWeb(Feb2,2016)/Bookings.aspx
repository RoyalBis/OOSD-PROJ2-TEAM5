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
                            <asp:DetailsView ID="dvCustomer" runat="server" AutoGenerateEditButton="True" AutoGenerateRows="False" DataSourceID="CustomerInfo" DefaultMode="Edit" Height="50px" Width="260px" BorderStyle="None" GridLines="None" CellSpacing="15" CssClass="table">
                                <Fields>
                                    <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId" ReadOnly="true"/>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustFirstName" HeaderText="First Name:" SortExpression="CustFirstName" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustLastName" HeaderText="Last Name:" SortExpression="CustLastName" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustAddress" HeaderText="Address:" SortExpression="CustAddress" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustCity" HeaderText="City:" SortExpression="CustCity" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustProv" HeaderText="Province:" SortExpression="CustProv" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustPostal" HeaderText="Postal Code:" SortExpression="CustPostal" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustCountry" HeaderText="Country:" SortExpression="CustCountry" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustHomePhone" HeaderText="Home Phone:" SortExpression="CustHomePhone" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustBusPhone" HeaderText="Bus Phone:" SortExpression="CustBusPhone" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustEmail" HeaderText="Email:" SortExpression="CustEmail" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="Username" HeaderText="Username:" SortExpression="Username" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="Password" HeaderText="Password:" SortExpression="Password" />
                                </Fields>
                            </asp:DetailsView>
                            <asp:ObjectDataSource ID="CustomerInfo" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SelectThisCustomer" TypeName="CustomerDB" ConflictDetection="CompareAllValues" ConvertNullToDBNull="True" UpdateMethod="UpdateCustomer">
                                <SelectParameters>
                                    <asp:SessionParameter Name="custID" SessionField="CustID" Type="Int32" />
                                </SelectParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="original_Cust" Type="Object" />
                                    <asp:Parameter Name="Cust" Type="Object" />
                                </UpdateParameters>
                            </asp:ObjectDataSource>
                        </div>
                        <div class = "col-lg-8" style ="background-color: rgba(38, 38, 38, 0.8); color:white">
                            <br /><p>Booking History</p>
                            <asp:GridView ID="gvBooking" runat="server" CellPadding="6" CssClass="table" GridLines="None">
                            </asp:GridView>
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Total: "></asp:Label>
                            <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                        </div>
                    </form>
                </div>
            </div>
        </div>
</asp:Content>

