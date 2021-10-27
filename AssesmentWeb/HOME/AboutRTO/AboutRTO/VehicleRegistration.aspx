<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehicleRegistration.aspx.cs" Inherits="AssesmentWeb.HOME.AboutRTO.VehicleRegistration" %>

<%@ Register Src="~/HOME/USER CONTROLS/HomeUserControl.ascx" TagPrefix="uc1" TagName="HomeUserControl" %>
<%@ Register Src="~/HOME/USER CONTROLS/RTOUserControl.ascx" TagPrefix="uc1" TagName="RTOUserControl" %>






<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../../CSS/mycss.css" rel="stylesheet" type="text/css" />
     <style>
        div.dL {
    margin-left: 200px;
    text-align: center;
    font-size: 18px;
    text-justify: auto;
    color: saddlebrown;
    font-family: 'Times New Roman', Times, serif;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:HomeUserControl runat="server" ID="HomeUserControl" />
        <uc1:RTOUserControl runat="server" ID="RTOUserControl" />

            <div class="dL">
            <p>
                <b style: font-weight="16">REGISTRATION OF MOTOR VEHICLE</b><br />
                Issuance of temporary registration of motor vehicles, 
registration of motor vehicle, Change of address in registration certificate, duplicate registration certificate, endorsing hire purchase agreement, 
hire purchase agreement termination, renewal of registration, transfer of ownership of the vehicle of this state, 
re-registration of vehicle or transfer of ownership from other state, no objection certificate, advance registration number allotted by the government, 
advance registration number allotted by the regional transport officer within 1000 number from starting number of that day, alteration of vehicles, 
registration numbers reserved by the government.

            </p>
        </div>

        <div>
            <footer id="copyright">
                <p>&copy; <%: DateTime.Now.Year %> - Regional Transport Office - South India</p>

            </footer>

        </div>
    </form>
</body>
</html>
