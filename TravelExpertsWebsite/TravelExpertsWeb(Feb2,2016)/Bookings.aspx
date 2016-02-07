<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Bookings.aspx.cs" Inherits="Bookings" %>

<%--    Author: Kevin Liao
         Date: Jan 28, 2016
         Class: OOSD Oct 2015
         Description: Booking page with updatable cust info and booking details  --%>

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
                            <asp:DetailsView ID="dvCustomer" runat="server" AutoGenerateEditButton="True" AutoGenerateRows="False" DataKeyNames="CustomerId" DataSourceID="CustInfo" DefaultMode="Edit" Height="50px" Width="260px" BorderStyle="None" GridLines="None" CellSpacing="15" CssClass="table">
                                <Fields>
                                    <asp:BoundField DataField="CustomerId" HeaderText="Customer ID:" InsertVisible="False" ReadOnly="True" SortExpression="CustomerId" />
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustFirstName" HeaderText="First Name:" SortExpression="CustFirstName" >
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustLastName" HeaderText="Last Name:" SortExpression="CustLastName" >
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustAddress" HeaderText="Address:" SortExpression="CustAddress" >
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustCity" HeaderText="City:" SortExpression="CustCity" >
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustProv" HeaderText="Province:" SortExpression="CustProv" >
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Postal Code:" SortExpression="CustPostal">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CustPostal") %>'></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Error:Invalid postal code format" ValidationExpression="^(\d{5}-\d{4}|\d{5}|\d{9})$|^([a-zA-Z]\d[a-zA-Z] \d[a-zA-Z]\d)$" Display="Dynamic" ControlToValidate="TextBox1" ForeColor="White"></asp:RegularExpressionValidator>
                                        </EditItemTemplate>
                                        <InsertItemTemplate>
                                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CustPostal") %>'></asp:TextBox>
                                        </InsertItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("CustPostal") %>'></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle ForeColor="Black" />
                                    </asp:TemplateField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustCountry" HeaderText="Country:" SortExpression="CustCountry" >
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="Password" HeaderText="Password:" SortExpression="Password" >
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="Username" HeaderText="Username:" SortExpression="Username" >
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustEmail" HeaderText="Email:" SortExpression="CustEmail" ConvertEmptyStringToNull="false">
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustBusPhone" HeaderText="Bus Phone:" SortExpression="CustBusPhone" ConvertEmptyStringToNull="false">
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField ItemStyle-ForeColor="black" DataField="CustHomePhone" HeaderText="Home Phone:" SortExpression="CustHomePhone" >
<ItemStyle ForeColor="Black"></ItemStyle>
                                    </asp:BoundField>
                                </Fields>
                            </asp:DetailsView>
                            <asp:SqlDataSource ID="CustInfo" runat="server" ConnectionString="<%$ ConnectionStrings:TravelExpertsConnectionString %>" DeleteCommand="DELETE FROM [Customers] WHERE [CustomerId] = @CustomerId" InsertCommand="INSERT INTO [Customers] ([CustFirstName], [CustLastName], [CustAddress], [CustCity], [CustProv], [CustPostal], [CustCountry], [Password], [Username], [AgentId], [CustEmail], [CustBusPhone], [CustHomePhone]) VALUES (@CustFirstName, @CustLastName, @CustAddress, @CustCity, @CustProv, @CustPostal, @CustCountry, @Password, @Username, @AgentId, @CustEmail, @CustBusPhone, @CustHomePhone)" SelectCommand="SELECT [CustFirstName], [CustomerId], [CustLastName], [CustAddress], [CustCity], [CustProv], [CustPostal], [CustCountry], [Password], [Username], [AgentId], [CustEmail], [CustBusPhone], [CustHomePhone] FROM [Customers] WHERE ([CustomerId] = @CustomerId)" UpdateCommand="UPDATE [Customers] SET [CustFirstName] = @CustFirstName, [CustLastName] = @CustLastName, [CustAddress] = @CustAddress, [CustCity] = @CustCity, [CustProv] = @CustProv, [CustPostal] = @CustPostal, [CustCountry] = @CustCountry, [Password] = @Password, [Username] = @Username, [AgentId] = @AgentId, [CustEmail] = @CustEmail, [CustBusPhone] = @CustBusPhone, [CustHomePhone] = @CustHomePhone WHERE [CustomerId] = @CustomerId">
                                <DeleteParameters>
                                    <asp:Parameter Name="CustomerId" Type="Int32" />
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
                                    <asp:Parameter Name="AgentId" Type="Int32" />
                                    <asp:Parameter Name="CustEmail" Type="String" ConvertEmptyStringToNull="false"/>
                                    <asp:Parameter Name="CustBusPhone" Type="String" ConvertEmptyStringToNull="false"/>
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
                                    <asp:Parameter Name="AgentId" Type="Int32" />
                                    <asp:Parameter Name="CustEmail" Type="String" ConvertEmptyStringToNull="false"/>
                                    <asp:Parameter Name="CustBusPhone" Type="String" ConvertEmptyStringToNull="false"/>
                                    <asp:Parameter Name="CustHomePhone" Type="String" />
                                    <asp:Parameter Name="CustomerId" Type="Int32" />
                                </UpdateParameters>
                            </asp:SqlDataSource>
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

