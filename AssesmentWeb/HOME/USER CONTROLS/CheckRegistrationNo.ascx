<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CheckRegistrationNo.ascx.cs" Inherits="AssesmentWeb.HOME.USER_CONTROLS.CheckRegistrationNo" %>
<div class="container">
    <table align="center">

        <tr>
            <td>
                <asp:Label ID="lblRegistrationNo" runat="server" Text="REGISTRATION NO : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRegistrationNo" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td colspan="2">
                <p align="center">
                    <asp:Button ID="btnCheckRegistrationNo" runat="server" Text="CHECK" OnClick="btnCheckRegistrationNo_Click" CssClass="Btn"></asp:Button>


                </p>
            </td>


        </tr>


    </table>
</div>