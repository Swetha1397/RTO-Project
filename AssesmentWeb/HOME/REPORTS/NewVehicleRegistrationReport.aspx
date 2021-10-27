<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewVehicleRegistrationReport.aspx.cs" Inherits="AssesmentWeb.REPORTS.NewVehicleRegistrationReport" %>

<%@ Register Src="~/HOME/USER CONTROLS/RTOnav.ascx" TagPrefix="uc1" TagName="RTOnav" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
   <%-- <title><%: Page.Title %>- My ASP.NET Application</title>--%>
    <link href="../../CSS/mycss.css" rel="stylesheet" type="text/css" />

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <script>

</script>
    

    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="Center">
 
                <tr>
                    <td><b>REGIONAL TRANSPORT OFFICE</b></td>
                
                </tr>
            
                </table>
        </div>
        <div>
            <uc1:RTOnav runat="server" ID="RTOnav" />
        </div>
        <div>
            <%--<table align="Center">
                <tr>
                    <td><b>NEW VEHICLE REGISTATION REPORT</b></td>
                </tr>
            </table>--%>
        </div>
        <div>
            <table align="center">
                <tr>
                    <td>
                        <asp:Label ID="lblFromTxt" runat="server" Text="FROM" CssClass="lbl" ></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtFrom" runat="server" TextMode="Date"></asp:TextBox>

                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;
                    </td>
                    <td>
                        <asp:Label ID="lblToTxt" runat="server" Text="TO" CssClass="lbl"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtTo" runat="server" TextMode="Date" ></asp:TextBox>
                    </td>

                </tr>
                </table>
                <br />
        
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
                    <asp:Button ID="btnFetch" runat="server" Text="FETCH" OnClick="btnFetch_Click" CssClass="Btn" Width="118px" />

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                        <asp:Button ID="btnReset" runat="server" Text="RESET" OnClick="btnReset_Click" CssClass="Btn" Width="118px" />
            <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnDownload" runat="server" Text="DownloadAsPDF" OnClick="btnDownload_Click" CssClass="Btn" Width="267px" />

            <br />
            <br />

            <table align="center">
                <tr>
                    <td>
                        <asp:Label ID="lblFromDate" runat="server" Text="FROM:" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="lblFrom" runat="server" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          <asp:Label ID="lblToDate" runat="server" Text="TO:" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;
                          <asp:Label ID="lblTo" runat="server" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <div align="center">
            <asp:GridView ID="GridView1" runat="server" Height="235px" Width="500px" Visible="False">
            </asp:GridView>
                </div>

            <br />
        </div>
        <div align="center">
        <asp:Label ID="lblDisplay" runat="server" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
