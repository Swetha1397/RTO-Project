<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LLRRegistrationFinal.aspx.cs" Inherits="AssesmentWeb.HOME.SERVICES.LLRRegistrationFInal" %>
<%@ Register Src="~/HOME/USER CONTROLS/RTOnav.ascx" TagPrefix="uc1" TagName="RTOnav" %>





<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %>- My ASP.NET Application</title>
    <link href="../../CSS/mycss.css" rel="stylesheet" type="text/css" />

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <script>

</script>
    <style>
        
        .auto-style1 {
            margin-bottom: 0;
        }
        
    </style>


</head>
<body>



    <form runat="server">

        <div>
            <h3><b>REGIONAL TRANSPORT OFFICE</b></h3>
        </div>
        <uc1:RTOnav runat="server" ID="RTOnav" />

        <%--<div>
            <ul>

                <li><a runat="server" href="~/HOME/home">About</a></li>
                      <li><a runat="server" href="~/HOME/Services">Services</a></li>
                      <li><a runat="server" href="~/HOME/Reports">Report</a></li>
                      <li><a runat="server" href="~/HOME/DATABASE_UPDATE/dbUpdate">Database Update</a></li>



                <li style="float: right"><a runat="server" href="~/Default.aspx">LOG OUT</a></li>
            </ul>
        </div>--%>
        <div class="container">
            <table align="center">
                <tr>

                    <td>
                        <asp:Label ID="lblCategory" runat="server" Text="CATEGORY : " CssClass="lbl"></asp:Label>
                    </td>
                    <td>
                        <%--changes: dropdownlist id was changed at 19/10/2021--%>
                        <asp:DropDownList ID="ddlVehicleCategory" runat="server" CssClass="ddl" >
                            <asp:ListItem>TWO WHEELER (WITH GEAR)</asp:ListItem>
                            <asp:ListItem>TWO WHEELER (WITHOUT GEAR)</asp:ListItem>
                            <asp:ListItem>FOUR WHEELER(WITH GEAR)</asp:ListItem>
                            <asp:ListItem>FOUR WHEELER(WITHOUT GEAR)</asp:ListItem>
                            <asp:ListItem>TWO &amp; FOUR WHEELER(WITH GEAR)</asp:ListItem>
                            <asp:ListItem>TWO &amp; FOUR WHEELER(WITHOUT GEAR)</asp:ListItem>
                            <asp:ListItem>HEAVY</asp:ListItem>
                        </asp:DropDownList>
                    </td>

                </tr>
                <tr>
                    <td>&nbsp;</td>

                </tr>
                <tr>
                    <td>&nbsp;</td>

                </tr>

                <tr>
                    <td colspan="2">
                        <p align="center">
                            <asp:Button ID="btnRegister" runat="server" Text="REGISTER" OnClick="BtnRegister_Click" CssClass="Btn"></asp:Button>


                        </p>
                    </td>


                </tr>


            </table>
        </div>

        <div>
            <footer id="copyright">
                <p>&copy; <%: DateTime.Now.Year %>- Regional Transport Office - South India</p>

            </footer>

        </div>




    </form>
</html>