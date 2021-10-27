<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="AssesmentWeb.HOME.Report" %>

<%@ Register Src="~/HOME/USER CONTROLS/RTOnav.ascx" TagPrefix="uc1" TagName="RTOnav" %>





<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - My ASP.NET Application</title>
    <link href="../CSS/mycss.css" rel="stylesheet" type="text/css" />

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
        
        <uc1:RTOnav runat="server" ID="RTOnav1" />
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
            <table align="center">
                <tr>
                    <td>
                        <p align="center">
                            <asp:Button ID="BtnNewVehicleRegistrationReports" runat="server" Text="NEW VEHICLE REPORTS" OnClick="BtnNewVehicleRegistrationReports1_Click" CssClass="Btn1"></asp:Button>


                        </p>
                    </td>
                    <td>
                        <p align="center">
                            <asp:Button ID="BtnHistoryOfVehicleReports" runat="server" Text="HISTORY OF VEHICLE" OnClick="BtnHistoryOfVehicleReports1_Click" CssClass="Btn1"></asp:Button>


                        </p>

                    </td>
                </tr>
                <tr>
                    <td>
                        <p align="center">
                            <asp:Button ID="BtnLLRReport" runat="server" Text="LLR REPORT" OnClick="BtnLLRReport1_Click" CssClass="Btn1"></asp:Button>


                        </p>
                    </td>
                    <td>
                        <p align="center">
                            <asp:Button ID="BtnLicenceReport" runat="server" Text="LICENCE REPORT" OnClick="BtnLicenceReport1_Click" CssClass="Btn1"></asp:Button>


                        </p>

                    </td>
                </tr>
              
            </table>
        </div>
        <div>
            <footer id="copyright">
                <p>&copy; <%: DateTime.Now.Year %> - Regional Transport Office - South India</p>

            </footer>

        </div>




    </form>



</body>
</html>


