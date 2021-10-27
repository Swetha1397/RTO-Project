<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LLR.aspx.cs" Inherits="AssesmentWeb.HOME.AboutRTO.LLR" %>

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
                <b style: font-weight="16">LLR</b><br />
                For Applying LLR, one should get learner licence (LLR commonly called). One who completed 18 years, can apply for LLR through online. 
You can select your RTO/MVI office with the help of Pincode. You can apply for LLR either directly or through recognised driving schools.
Online portal is self-guided and fill up all information required. You have to upload all the necessary documents such as address proof, 
age proof and medical certificate if applicant age is more than 40 years etc.You can make fees either by online or through nearest SBI branch by offline. 
Once payment done you can fix the appointment in online itself to take photographs at the RTO/MVI office to avoid unnecessary waiting time. 
At the end of the process, you will get barcode/QR code acknowledgement slip. Take print out of the acknowledgement slip and visit to the RTO/MVI office 
on the appointment day and time (you can reach just half an hour before the appointment time). After scrutinizing your application by the Motor Vehicles Inspector, 
photographs will be taken and you can get LLR print out from portal. This LLR is valid for six months and you can apply for DL of your choice within one month of LLR issue date.
If applicant failed in Learner Licence test, he/she can reappear for test on the next day onwards after paying necessary fees. If LLR is expired the applicant has to apply fresh.
            </p>
            <p>
                <b>DOCUMENTS REQUIRED:</b><br />
                1.Age proof<br />
                2.Address proof<br />
                3.Medical Certificate in Form No.1-A.<br />
                4.Application cum Declaration as to the Physical Fitness Form-1.



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
