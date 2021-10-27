<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CheckAadhar.ascx.cs" Inherits="AssesmentWeb.HOME.DATABASE_UPDATE.CheckAadhar" %>
<div class="container">
    <table align="center">

        <tr>
            <td>
                <asp:Label ID="lblAadhar" runat="server" Text="AADHAR NO : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAadhar" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Must be 12 digit value" ControlToValidate="txtAadhar" MaximumValue="999999999999" MinimumValue="100000000000"></asp:RangeValidator>
            </td>

        </tr>
        <tr>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td colspan="2">
                <p align="center">
                    <asp:Button ID="btnCheckAadhar" runat="server" Text="CHECK" OnClick="btnCheckAadhar_Click" CssClass="Btn"></asp:Button>


                </p>
            </td>


        </tr>


    </table>
</div>