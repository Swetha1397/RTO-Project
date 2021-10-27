<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LicenseReport.aspx.cs" Inherits="AssesmentWeb.REPORTS.LicenseReport" %>

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
            <table align="Center">
                <tr>
                    <td><b>LICENSE REPORT</b></td>
                </tr>
            </table>
        </div>
        <div>
            <table align="center">
                <tr>
                    <td>
                    <asp:Label ID="lblVehicleCategory" runat="server" Text="SELECT VEHICLE CATEGORY" CssClass="lbl" ></asp:Label>
                    </td>
                    <td>
                        &nbsp;&nbsp;
                        <asp:DropDownList ID="ddlCategory" runat="server" Height="20px" Width="166px" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
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
                  <td>
                  <asp:Label ID="lblVehicleStatus" runat="server" Text="SELECT VEHICLE STATUS" CssClass="lbl" ></asp:Label>
                  </td>
                         <td>
                        &nbsp;&nbsp;
                       <asp:DropDownList ID="ddlStatus" runat="server" Height="20px" Width="166px" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                           <asp:ListItem>Active</asp:ListItem>
                           <asp:ListItem>Expired</asp:ListItem>
                             </asp:DropDownList> 
                    &nbsp;</td>
                </tr>
                </table>
                <br />        
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
                    <asp:Button ID="btnFetch" runat="server" Text="FETCH" OnClick="btnFetch_Click" Width="118px" CssClass="Btn" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnReset" runat="server" Text="RESET" OnClick="btnReset_Click" Width="118px" CssClass="Btn" />
            <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnDownload" runat="server" Text="DownloadAsPDF" OnClick="btnDownload_Click" CssClass="Btn" Width="267px" />

            <br />
            <br />

            <table align="center">
                <tr>
                    <td>
                        <b><asp:Label ID="lblCategory" runat="server" Text="Vehicle Category:" Visible="False"></asp:Label></b>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;
                         <b><asp:Label ID="lblDisplayCategory" runat="server" Visible="False"></asp:Label></b>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <b> <asp:Label ID="lblStatus" runat="server" Text="Vehicle Status:" Visible="False"></asp:Label></b>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;
                         <b> <asp:Label ID="lblDisplayStatus" runat="server" Visible="False"></asp:Label></b>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <div align="center">
                <br />
                <asp:GridView ID="GridView1" runat="server" Height="235px" Width="500px" Visible="False">
            </asp:GridView>
                
                </div>

            <br />
        </div>
        <div align="center">
        <asp:Label ID="lblDisplay" runat="server" Visible="False"></asp:Label>
        </div>
        <div align="Right">
           <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             <asp:Button ID="btnBack" runat="server" Text="BACK" Width="118px" CssClass="Btn" OnClick="btnBack_Click" /></h3> 
        </div>
    </form>
</body>
</html>
