<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewVehicleRegistrationFinal.aspx.cs" Inherits="AssesmentWeb.HOME.SERVICES.NewVehicleRegistrationFinal" %>

<%@ Register Src="~/HOME/USER CONTROLS/RTOnav.ascx" TagPrefix="uc1" TagName="RTOnav" %>





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
        
        .auto-style1 {
            height: 20px;
        }
        
        .auto-style2 {
            height: 57px;
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
                <%--<tr>

                    <td>
                        <asp:Label ID="lblAadharNo" runat="server" Text="AADHAR NO : " CssClass="lbl"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAadharNo" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>&nbsp;</td>

                </tr>--%>
                <tr>
                    <td>
                        <asp:Label ID="lblChasisNo" runat="server" Text="CHASIS NO : " CssClass="lbl"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtChasisNo" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
                    </td>
                    <td>
                               
                          <asp:RequiredFieldValidator ID="rfvChasisNo" style="color:red;font-size:xx-large;" runat="server" ErrorMessage="*" ControlToValidate="txtChasisNo"></asp:RequiredFieldValidator>
   
                    </td>

                </tr>
                <tr>
                    <td>&nbsp;</td>

                </tr>
                <tr>

                    <td class="auto-style2">
                        <asp:Label ID="lblEngineNo" runat="server" Text="ENGINE NO : " CssClass="lbl"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEngineNo" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
                    </td>
                     <td>
                               
                          <asp:RequiredFieldValidator ID="rfvEngineNo" style="color:red;font-size:xx-large;" runat="server" ErrorMessage="*" ControlToValidate="txtEngineNo"></asp:RequiredFieldValidator>
   
                    </td>

                </tr>
                <tr>
                    <td>&nbsp;</td>

                </tr>
                <tr>

                    <%--<td class="auto-style1">
                    </td>--%>
                    

                </tr>
               
                <tr>

                    <td>
                        <asp:Label ID="lblVehicleName" runat="server" Text="VEHICLE NAME : " CssClass="lbl"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtVehicleName" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
                    </td>
                    <td>
                               
                          <asp:RequiredFieldValidator ID="rfvVehicleName" style="color:red;font-size:xx-large;" runat="server" ErrorMessage="*" ControlToValidate="txtVehicleName"></asp:RequiredFieldValidator>
   
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
                            <asp:Button ID="btnRegister" runat="server" Text="REGISTER" OnClick="BtnRegister_Click" CssClass="Btn"></asp:Button>


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
</html>
