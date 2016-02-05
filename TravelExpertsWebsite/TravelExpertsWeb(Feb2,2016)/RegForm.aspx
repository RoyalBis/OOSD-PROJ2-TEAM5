<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegForm.aspx.cs" Inherits="RegForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="StyleSheet2.css" rel="stylesheet" />
    <script>
        var regex = new RegExp(/^[ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ]( )?\d[ABCEGHJKLMNPRSTVWXYZ]\d$/i);
        var regexPhone = new RegExp(/^\d\d\d\d\d\d\d\d\d\d/)
        $(document).ready(function () {
            $("#next0").click(function () {
                $("#step0").hide();
                $("#step1").show();
                $("#1").siblings('li').removeClass('active');
                $("#1").addClass('active');
                document.getElementsByTagName('html')[0].style.backgroundImage='url(image/background2.jpg)'
            });
        });

        $(document).ready(function () {
            $("#next1").click(function () {
                var txt1 = $('[id$=txtUsername]').val();
                $('[id$=lblUsername]').html(txt1);
                $('[id$=inpUsername]').val(txt1);
                var txt2 = $('[id$=txtPassword]').val();
                $('[id$=lblPassword]').html(txt2);
                $('[id$=inpPassword]').val(txt2);
                var txt2_2 = $('[id$=txtConfirmPW]').val();

                if (txt1 == null || txt1 == "" ||
                    txt2 == null || txt2 == "") {
                    alert("Fields marked with * are required");
                    return false;
                }
                else if (txt2 != txt2_2){
                    alert("Password confirmation did not match");
                    $('[id$=txtPassword]').focus();
                    $('[id$=txtPassword]').val("");
                    $('[id$=txtConfirmPW]').val("");
                    return false;
                }
                else {
                    $("#step1").hide();
                    $("#step2").show();
                    $("#2").siblings('li').removeClass('active');
                    $("#2").addClass('active');
                }
                document.getElementsByTagName('html')[0].style.backgroundImage = 'url(image/background3.jpg)'
            });
        });

        $(document).ready(function () {
            $("#prev2").click(function () {
                $("#step2").hide();
                $("#step1").show();
                $("#1").siblings('li').removeClass('active');
                $("#1").addClass('active');
                document.getElementsByTagName('html')[0].style.backgroundImage = 'url(image/background2.jpg)'
            });
        });
        $(document).ready(function () {
            $("#next2").click(function () {
                var txt3 = $('[id$=txtFirstName]').val();
                $('[id$=lblFirstName]').html(txt3);
                $('[id$=inpFirstName]').val(txt3);
                var txt4 = $('[id$=txtLastName]').val();
                $('[id$=lblLastName]').html(txt4);
                $('[id$=inpLastName]').val(txt4);

                if (txt3 == null || txt3 == "" ||
                    txt4 == null || txt4 == "") {
                    alert("Fields marked with * are required");
                    return false;
                }
                else {
                    $("#step2").hide();
                    $("#step3").show();
                    $("#3").siblings('li').removeClass('active');
                    $("#3").addClass('active');
                }
                document.getElementsByTagName('html')[0].style.backgroundImage = 'url(image/background4.jpg)'
            });
        });

        $(document).ready(function () {
            $("#prev3").click(function () {
                $("#step3").hide();
                $("#step2").show();
                $("#2").siblings('li').removeClass('active');
                $("#2").addClass('active');
                document.getElementsByTagName('html')[0].style.backgroundImage = 'url(image/background3.jpg)'
            });
        });
        $(document).ready(function () {
            $("#next3").click(function () {
                var txt5 = $('[id$=txtAddress]').val();
                $('[id$=lblAddress]').html(txt5);
                $('[id$=inpAddress]').val(txt5);
                var txt6 = $('[id$=txtCity]').val();
                $('[id$=lblCity]').html(txt6);
                $('[id$=inpCity]').val(txt6);
                var txt7 = $('[id$=txtProvince]').val();
                $('[id$=lblProvince]').html(txt7);
                $('[id$=inpProvince]').val(txt7);
                var txt8 = $('[id$=txtPostal]').val();
                $('[id$=lblPostal]').html(txt8);
                $('[id$=inpPostal]').val(txt8);
                var txt9 = $('[id$=txtCountry]').val();
                $('[id$=lblCountry]').html(txt9);
                $('[id$=inpCountry]').val(txt9);

                if (txt5 == null || txt5 == "" ||
                    txt6 == null || txt6 == "" ||
                    txt7 == null || txt7 == "" ||
                    txt8 == null || txt8 == "") {
                    alert("Fields marked with * are required");
                    return false;
                }
                else if (txt7.length>2)
                {
                    alert("Please enter 2 characters province code (ex:AB)")
                    $('[id$=txtProvince]').focus();
                    $('[id$=txtProvince]').val("");
                    return false;
                }
                else if (!regex.test(txt8))
                {
                    alert("Please enter correct postal code (ex:T2K 6L3)");
                    $('[id$=txtPostal]').focus();
                    $('[id$=txtPostal]').val("");
                    return false;
                }
                else {
                    $("#step3").hide();
                    $("#step4").show();
                    $("#4").siblings('li').removeClass('active');
                    $("#4").addClass('active');
                }

                document.getElementsByTagName('html')[0].style.backgroundImage = 'url(image/background5.jpg)'
            });
        });

        $(document).ready(function () {
            $("#prev4").click(function () {
                $("#step4").hide();
                $("#step3").show();
                $("#3").siblings('li').removeClass('active');
                $("#3").addClass('active');
                document.getElementsByTagName('html')[0].style.backgroundImage = 'url(image/background4.jpg)'
            });
        });
        $(document).ready(function () {
            $("#next4").click(function () {
                var txt10 = $('[id$=txtHomePhone]').val();
                $('[id$=lblHomePhone]').html(txt10);
                $('[id$=inpHomePhone]').val(txt10);
                var txt11 = $('[id$=txtBusPhone]').val();
                $('[id$=lblBusPhone]').html(txt11);
                $('[id$=inpBusPhone]').val(txt11);
                var txt12 = $('[id$=txtEmail]').val();
                $('[id$=lblEmail]').html(txt12);
                $('[id$=inpEmail]').val(txt12);
                //var txt13 = $('[id$=txtAgentID]').val();
                //$('[id$=lblAgentID]').html(txt13);
                //$('[id$=inpAgentID]').val(txt13);

                if (txt10 == null || txt10 == "") {
                    alert("Home phone is required");
                    $('[id$=txtHomePhone]').focus();
                    return false;
                }
                else if (!regexPhone.test(txt10)) {
                    alert("Please enter correct phone number (ex:4032748668)");
                    $('[id$=txtHomePhone]').focus();
                    $('[id$=txtHomePhone]').val("");
                    return false;
                }
                else {
                    $("#step4").hide();
                    $("#step5").show();
                    $("#5").siblings('li').removeClass('active');
                    $("#5").addClass('active');
                    document.getElementsByTagName('html')[0].style.backgroundImage = 'url(image/background6.jpg)'
                }
            });
        });

        $(document).ready(function () {
            $("#prev5").click(function () {
                $("#step5").hide();
                $("#step4").show();
                $("#4").siblings('li').removeClass('active');
                $("#4").addClass('active');
                document.getElementsByTagName('html')[0].style.backgroundImage = 'url(image/background5.jpg)'
            });
        });

        function isPresent(textbox)
        {
            var x = textbox;
            if (x==null || x=="")
            {
                alert("field cannot be empty");
                return false;
            }
        }
    </script>
    <!-- multistep form -->
    <form id="msform" runat="server">
	    <!-- progressbar -->
        <br />
	    <ul id="progressbar">
		    <li class="active">Welcome</li>
		    <li id="1">Account</li>
		    <li id="2">Name</li>
            <li id="3">Address</li>
            <li id="4">Contact</li>
            <li id="5">Summary</li>
	    </ul>
        <br />
	    <!-- fieldsets -->
        <fieldset id="step0">
		    <h2 class="fs-title">Welcome to Travel Experts</h2>
		    <h3 class="fs-subtitle">Click to start your journey</h3>
            <input type="button" id="next0" name="next" class="next action-button" value="Next" />
	    </fieldset>
	    <fieldset id="step1">
		    <h2 class="fs-title">Account Signup</h2>
		    <h3 class="fs-subtitle">Create your username and password</h3>
            <asp:TextBox ID="txtUsername" runat="server" placeholder="Username*"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" placeholder="Password*" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtConfirmPW" runat="server" placeholder="Confirm PW*" TextMode="Password"></asp:TextBox>
		    <input type="button" id="next1" class="next action-button" value="Next" />
	    </fieldset>
	    <fieldset id="step2">
		    <h2 class="fs-title">Your Name is?</h2>
		    <h3 class="fs-subtitle">Nice to meet you!</h3>
		    <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name*"></asp:TextBox>
            <asp:TextBox ID="txtLastName" runat="server" placeholder="Last Name*"></asp:TextBox>
            <input type="button" id="prev2" name="previous" class="previous action-button" value="Previous" />
		    <input type="button" id="next2" class="next action-button" value="Next" />
	    </fieldset>
        <fieldset id="step3">
		    <h2 class="fs-title">Address Information</h2>
		    <h3 class="fs-subtitle">This information improves our service</h3>
            <asp:TextBox ID="txtAddress" runat="server" placeholder="Address*"></asp:TextBox>
            <asp:TextBox ID="txtCity" runat="server" placeholder="City*"></asp:TextBox>
            <asp:TextBox ID="txtProvince" runat="server" placeholder="Province*"></asp:TextBox>
            <asp:TextBox ID="txtPostal" runat="server" placeholder="Postal Code*"></asp:TextBox>
            <asp:TextBox ID="txtCountry" runat="server" placeholder="Country"></asp:TextBox>
            <input type="button" id="prev3" name="previous" class="previous action-button" value="Previous" />
		    <input type="button" id="next3" class="next action-button" value="Next" />
	    </fieldset>
	    <fieldset id="step4">
		    <h2 class="fs-title">Contact Information</h2>
		    <h3 class="fs-subtitle">Information improves our service</h3>
		    <asp:TextBox ID="txtHomePhone" runat="server" placeholder="Home Phone*"></asp:TextBox>
            <asp:TextBox ID="txtBusPhone" runat="server" placeholder="Business Phone"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox>
            <%--<asp:TextBox ID="txtAgentID" runat="server" placeholder="Agent ID"></asp:TextBox>--%>
            <input type="button" id="prev4" name="previous" class="previous action-button" value="Previous" />
		    <input type="button" id="next4" class="next action-button" value="Next" />
	    </fieldset>
        <fieldset id="step5">
		    <h2 class="fs-title">Summary</h2>
		    <asp:Label class="fs-subtitle" ID="lblMsg2" runat="server">Done, please check before submit</asp:Label>
		    <br />
            <br />
            <table style="color:white">
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;Username:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblUsername" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpUsername" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;Password:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblPassword" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpPassword" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;First Name:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblFirstName" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpFirstName" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;Last Name:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblLastName" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpLastName" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;Address:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblAddress" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpAddress" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;City:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblCity" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpCity" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;Province:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblProvince" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpProvince" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;Postal Code:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblPostal" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpPostal" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;Country:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblCountry" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpCountry" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;HomePhone:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblHomePhone" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpHomePhone" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;BusPhone:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblBusPhone" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpBusPhone" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;Email:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblEmail" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpEmail" runat="server" />
                    </td>
                </tr>
<%--                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;Agent ID:</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblAgentID" runat="server"></asp:Label>
                        <asp:HiddenField ID="inpAgentID" runat="server" />
                    </td>
                </tr>--%>
            </table>
            <br />
            <input type="button" id="prev5" name="previous" class="previous action-button" value="Previous" />
            <asp:Button ID="submit" class="next action-button" runat="server" Text="Submit" OnClick="submit_Click" />
	    </fieldset>
<%--        <fieldset id="step6">
		    <h2 class="fs-title">Thank you for register!</h2>
		    <h3 class="fs-subtitle">Redirecting you to package ordering...</h3>
	    </fieldset>--%>
    </form>
</asp:Content>

