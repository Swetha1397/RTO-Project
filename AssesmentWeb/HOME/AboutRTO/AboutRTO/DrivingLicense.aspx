<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DrivingLicense.aspx.cs" Inherits="AssesmentWeb.HOME.AboutRTO.DrivingLicense" %>

<%@ Register Src="~/HOME/USER CONTROLS/HomeUserControl.ascx" TagPrefix="uc1" TagName="HomeUserControl" %>
<%@ Register Src="~/HOME/USER CONTROLS/RTOUserControl.ascx" TagPrefix="uc1" TagName="RTOUserControl" %>









<!DOCTYPE html>

<html>
<head>
    <title></title>
    <link href="../../../CSS/mycss.css" rel="stylesheet" type="text/css" />
     <style>
        div.dL {
    margin-left: 200px;
    text-align: center;
    font-size: 18px;
    text-justify: auto;
    color:saddlebrown;
    font-family: 'Times New Roman', Times, serif;
}
    </style>
</head>
<body>
    <form id="form1">
        <uc1:HomeUserControl runat="server" ID="HomeUserControl" />
        <uc1:RTOUserControl runat="server" ID="RTOUserControl" />
            <div class="dL">
                <p>
                    <b style: font-weight="16">DRIVING LICENSE</b>
                    <br />
                    For Driving License, Two Wheeler and LMV, the applicant has to appear for test of competence to drive by individually or through recognised Driving Schools before the Motor Vehicle Inspector. The data already 
entered and document uploaded for LLR can be used for getting DL in Portal, but a fee has to be paid by online itself.Driving licence will be issued for 20 years from the date of issue or up to 40 years of 
age whichever is earlier for A non-transport vehicles and in case of transport vehicle it will be valid for three years from the date of issue.The Motor vehicles Inspector will conduct the test of competence 
to drive vehicle as per the procedures laid down under the rule 15 of Central Motor Vehicle Rules,1989. After satisfaction about the driving skills, the testing authority will pass the order for issue of driving
licence.Once applicant clears driving test, Driving License will be issued by the Asst. Licensing Authority after capturing of bio-metrics including Photograph.If applicant failed in driving test, they can appear
again for re-test after 7 days. If the applicant does not pass even after three driving tests, he shall not be qualified to reappear for such test before 60 days.
                    <br />
                </p>
                <p>
                    <b style: font-weight="14">DOCUMENTS REQUIRED:</b>
                    <br />
                    1. Application in Form-2 generated through online<br />
                    2.Valid Learner Licence.<br />
                    3.Documents of vehicle in which applicant proposes to appear for test of competence to drive.<br />
                    4.Form 5 and Form 15

                </p>
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
