<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Bookings.aspx.cs" Inherits="Bookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" />
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <br /><asp:Label class="fs-title" ID="lblUsername" runat="server" ForeColor="white"></asp:Label><br /><br /><br />
                    <form id="form2" runat="server">
                        <div class = "col-lg-3" style ="background-color: rgba(38, 38, 38, 0.8); color:white">
                            <br /><p>Customer Information</p>
                            <asp:DetailsView ID="dvCustomer" runat="server" AutoGenerateEditButton="True" AutoGenerateRows="False" DataKeyNames="CustomerId" DataSourceID="CustomerID" DefaultMode="Edit" Height="50px" Width="260px" BorderStyle="None" GridLines="None" CellSpacing="15" CssClass="table">
                                <Fields>
                                    <asp:BoundField DataField="CustomerId" HeaderText="Customer ID:" InsertVisible="False" ReadOnly="True" SortExpression="CustomerId"/>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustFirstName" HeaderText="First Name:" SortExpression="CustFirstName" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustLastName" HeaderText="Last Name:" SortExpression="CustLastName" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustAddress" HeaderText="Address:" SortExpression="CustAddress" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustCity" HeaderText="City:" SortExpression="CustCity" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustProv" HeaderText="Province:" SortExpression="CustProv"/>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustPostal" HeaderText="Postal Code:" SortExpression="CustPostal" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustCountry" HeaderText="Country:" SortExpression="CustCountry" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="Username" HeaderText="Username:" SortExpression="Username" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="Password" HeaderText="Password:" SortExpression="Password" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustEmail" HeaderText="Email:" SortExpression="CustEmail" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustBusPhone" HeaderText="Bus Phone:" SortExpression="CustBusPhone" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustHomePhone" HeaderText="Home Phone" SortExpression="CustHomePhone" />
                                </Fields>
                            </asp:DetailsView>
                            <asp:SqlDataSource ID="CustomerID" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:TravelExpertsConnectionString %>" DeleteCommand="DELETE FROM [Customers] WHERE [CustomerId] = @original_CustomerId AND [CustFirstName] = @original_CustFirstName AND [CustLastName] = @original_CustLastName AND [CustAddress] = @original_CustAddress AND [CustCity] = @original_CustCity AND [CustProv] = @original_CustProv AND [CustPostal] = @original_CustPostal AND (([CustCountry] = @original_CustCountry) OR ([CustCountry] IS NULL AND @original_CustCountry IS NULL)) AND (([Password] = @original_Password) OR ([Password] IS NULL AND @original_Password IS NULL)) AND (([Username] = @original_Username) OR ([Username] IS NULL AND @original_Username IS NULL)) AND [CustEmail] = @original_CustEmail AND [CustBusPhone] = @original_CustBusPhone AND (([CustHomePhone] = @original_CustHomePhone) OR ([CustHomePhone] IS NULL AND @original_CustHomePhone IS NULL))" InsertCommand="INSERT INTO [Customers] ([CustFirstName], [CustLastName], [CustAddress], [CustCity], [CustProv], [CustPostal], [CustCountry], [Password], [Username], [CustEmail], [CustBusPhone], [CustHomePhone]) VALUES (@CustFirstName, @CustLastName, @CustAddress, @CustCity, @CustProv, @CustPostal, @CustCountry, @Password, @Username, @CustEmail, @CustBusPhone, @CustHomePhone)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [CustomerId], [CustFirstName], [CustLastName], [CustAddress], [CustCity], [CustProv], [CustPostal], [CustCountry], [Password], [Username], [CustEmail], [CustBusPhone], [CustHomePhone] FROM [Customers] WHERE ([CustomerId] = @CustomerId)" UpdateCommand="UPDATE [Customers] SET [CustFirstName] = @CustFirstName, [CustLastName] = @CustLastName, [CustAddress] = @CustAddress, [CustCity] = @CustCity, [CustProv] = @CustProv, [CustPostal] = @CustPostal, [CustCountry] = @CustCountry, [Password] = @Password, [Username] = @Username, [CustEmail] = @CustEmail, [CustBusPhone] = @CustBusPhone, [CustHomePhone] = @CustHomePhone WHERE [CustomerId] = @original_CustomerId AND [CustFirstName] = @original_CustFirstName AND [CustLastName] = @original_CustLastName AND [CustAddress] = @original_CustAddress AND [CustCity] = @original_CustCity AND [CustProv] = @original_CustProv AND [CustPostal] = @original_CustPostal AND (([CustCountry] = @original_CustCountry) OR ([CustCountry] IS NULL AND @original_CustCountry IS NULL)) AND (([Password] = @original_Password) OR ([Password] IS NULL AND @original_Password IS NULL)) AND (([Username] = @original_Username) OR ([Username] IS NULL AND @original_Username IS NULL)) AND [CustEmail] = @original_CustEmail AND [CustBusPhone] = @original_CustBusPhone AND (([CustHomePhone] = @original_CustHomePhone) OR ([CustHomePhone] IS NULL AND @original_CustHomePhone IS NULL))">
                                <DeleteParameters>
                                    <asp:Parameter Name="original_CustomerId" Type="Int32" />
                                    <asp:Parameter Name="original_CustFirstName" Type="String" />
                                    <asp:Parameter Name="original_CustLastName" Type="String" />
                                    <asp:Parameter Name="original_CustAddress" Type="String" />
                                    <asp:Parameter Name="original_CustCity" Type="String" />
                                    <asp:Parameter Name="original_CustProv" Type="String" />
                                    <asp:Parameter Name="original_CustPostal" Type="String" />
                                    <asp:Parameter Name="original_CustCountry" Type="String" />
                                    <asp:Parameter Name="original_Password" Type="String" />
                                    <asp:Parameter Name="original_Username" Type="String" />
                                    <asp:Parameter Name="original_CustEmail" Type="String" />
                                    <asp:Parameter Name="original_CustBusPhone" Type="String" />
                                    <asp:Parameter Name="original_CustHomePhone" Type="String" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="CustFirstName" Type="String" />
                                    <asp:Parameter Name="CustLastName" Type="String" />
                                    <asp:Parameter Name="CustAddress" Type="String" />
                                    <asp:Parameter Name="CustCity" Type="String" />
                                    <asp:Parameter Name="CustProv" Type="String" />
                                    <asp:Parameter Name="CustPostal" Type="String" />
                                    <asp:Parameter Name="CustCountry" Type="String" />
                                    <asp:Parameter Name="Password" Type="String" />
                                    <asp:Parameter Name="Username" Type="String" />
                                    <asp:Parameter Name="CustEmail" Type="String" />
                                    <asp:Parameter Name="CustBusPhone" Type="String" />
                                    <asp:Parameter Name="CustHomePhone" Type="String" />
                                </InsertParameters>
                                <SelectParameters>
                                    <asp:SessionParameter Name="CustomerId" SessionField="CustID" Type="Int32" />
                                </SelectParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="CustFirstName" Type="String" />
                                    <asp:Parameter Name="CustLastName" Type="String" />
                                    <asp:Parameter Name="CustAddress" Type="String" />
                                    <asp:Parameter Name="CustCity" Type="String" />
                                    <asp:Parameter Name="CustProv" Type="String" />
                                    <asp:Parameter Name="CustPostal" Type="String" />
                                    <asp:Parameter Name="CustCountry" Type="String" />
                                    <asp:Parameter Name="Password" Type="String" />
                                    <asp:Parameter Name="Username" Type="String" />
                                    <asp:Parameter Name="CustEmail" Type="String" />
                                    <asp:Parameter Name="CustBusPhone" Type="String" />
                                    <asp:Parameter Name="CustHomePhone" Type="String" />
                                    <asp:Parameter Name="original_CustomerId" Type="Int32" />
                                    <asp:Parameter Name="original_CustFirstName" Type="String" />
                                    <asp:Parameter Name="original_CustLastName" Type="String" />
                                    <asp:Parameter Name="original_CustAddress" Type="String" />
                                    <asp:Parameter Name="original_CustCity" Type="String" />
                                    <asp:Parameter Name="original_CustProv" Type="String" />
                                    <asp:Parameter Name="original_CustPostal" Type="String" />
                                    <asp:Parameter Name="original_CustCountry" Type="String" />
                                    <asp:Parameter Name="original_Password" Type="String" />
                                    <asp:Parameter Name="original_Username" Type="String" />
                                    <asp:Parameter Name="original_CustEmail" Type="String" />
                                    <asp:Parameter Name="original_CustBusPhone" Type="String" />
                                    <asp:Parameter Name="original_CustHomePhone" Type="String" />
                                </UpdateParameters>
                            </asp:SqlDataSource>
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

