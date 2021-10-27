<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AssesmentWeb.HOME.Login" %>

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


        <div>
            <ul>

                <li><a runat="server" href="~/">HOME</a></li>




                <li style="float: right"><a runat="server" href="~/HOME/Login">LOG IN</a></li>
            </ul>
        </div>
        <div>
            <table align="center">
                <tr>

                    <td>
                        <asp:Label ID="LblRTONo" runat="server" Text="RTO NO : " CssClass="lbl"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRTONo" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" style="color:red;font-size:xx-large;" runat="server" ErrorMessage="*"  ControlToValidate="txtRTONo"></asp:RequiredFieldValidator>
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
                        <asp:Label ID="LblPassword" runat="server" Text="PASSWORD : " CssClass="lbl"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" Width="256" TextMode="Password" CssClass="txtBox"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" style="color:red;font-size:xx-large;" runat="server" ErrorMessage="*" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>

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
                    <td colspan="2" >
                        <p align="center">
                            <asp:Button ID="btnLogin" runat="server" Text="LOGIN" OnClick="BtnLogin_Click" CssClass="Btn"></asp:Button>


                        </p>
                    </td>
                
                    
                </tr>
                 <tr>
                    <td>&nbsp;</td>

                </tr>
                <tr>
                    <td>&nbsp;</td>

                </tr>
                <tr>
                    <td colspan="2" >
                        <asp:Label ID="lblLoginSucess" runat="server" Text=""></asp:Label>
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

