<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="State.aspx.cs" Inherits="AssesmentWeb.HOME.DATABASE_UPDATE.State" %>


<%@ Register Src="~/HOME/USER CONTROLS/RTOnav.ascx" TagPrefix="uc1" TagName="RTOnav" %>
<%@ Register Src="~/HOME/USER CONTROLS/RTOSideNavbar.ascx" TagPrefix="uc1" TagName="RTOSideNavbar" %>



<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - My ASP.NET Application</title>
    <link href="../../CSS/mycss.css" rel="stylesheet" type="text/css" />

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <script>

</script>
    <style>
        
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
        <div>

            <div style="display: flex; width: 100%;">
                <uc1:RTOSideNavbar runat="server" ID="RTOSideNavbar" />

                <%--<div class="sidebar">
                    <a runat="server" href="~/HOME/DATABASE_UPDATE/State">ADD STATE</a>
                    <a runat="server" href="~/HOME/DATABASE_UPDATE/District">ADD DISTRICT</a>
                    <a runat="server" href="~/HOME/DATABASE_UPDATE/City">ADD CITY</a>
                    <a runat="server" href="~/HOME/DATABASE_UPDATE/RTO">ADD RTO</a>
                    <a runat="server" href="~/HOME/DATABASE_UPDATE/Area">ADD AREA</a>
                </div>--%>

                <div style="width: 80%;">
                    <table align="center">
                       
                        <tr>

                            <td>
                                <asp:Label ID="LblStateName" runat="server" Text="ENTER STATE NAME : " CssClass="lbl"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtStateName" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
                            </td>
                           
                            <td>
                               
                               <asp:RequiredFieldValidator ID="rfvStateName" style="color:red;font-size:xx-large;" runat="server" ErrorMessage="*" ControlToValidate="txtStateName"></asp:RequiredFieldValidator>
   
                            </td>
                            
                        </tr>
                        <tr>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>

                            <td>
                                <asp:Label ID="LblStateId" runat="server" Text="ENTER STATE ID : " CssClass="lbl"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtStateId" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
                            </td>
                            <td>
                               
                               <asp:RequiredFieldValidator ID="rfvStateId" style="color:red;font-size:xx-large;" runat="server" ErrorMessage="*" ControlToValidate="txtStateName"></asp:RequiredFieldValidator>
   
                            </td>
                            
                        </tr>
                        <tr>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>
                            <td colspan="3">
                                <p style="color:red;">
                                    * These fields are mandatory
                                </p>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>
                            <td colspan="2">
                                <p align="center">
                                    <asp:Button ID="btnState" runat="server" Text="ADD STATE" OnClick="BtnState_Click" CssClass="Btn"></asp:Button>


                                </p>
                            </td>

                        </tr>
                        <tr>
                            <td colspan="2">
                                <p align="center">
                                    <asp:Label ID="lblStateSuccess" runat="server" Text=""></asp:Label>

                                </p>

                            </td>
                        </tr>
                    </table>
                </div>

            </div>

        </div>
        <div>
            <footer id="copyright">
                <p>&copy; <%: DateTime.Now.Year %> - Regional Transport Office - South India</p>

            </footer>

        </div>




    </form>



</body>
</html>
