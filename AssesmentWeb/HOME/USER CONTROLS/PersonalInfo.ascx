<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PersonalInfo.ascx.cs" Inherits="AssesmentWeb.HOME.DATABASE_UPDATE.PersonalInfo" %>
<div class="container">
    <table align="center">
        <tr>

            <td>
                <asp:Label ID="lblFname" runat="server" Text="FIRST NAME : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Style="color: red; font-size: xx-large;" runat="server" ErrorMessage="*" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lbllname" runat="server" Text="LAST NAME : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server" Width="256" CssClass="txtBox"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Style="color: red; font-size: xx-large;" runat="server" ErrorMessage="*" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lbldob" runat="server" Text="DOB : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDob" runat="server" Width="256" CssClass="txtBox" TextMode="Date"></asp:TextBox>
            </td>
            

        </tr>

        <tr>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAadhar" runat="server" Text="AADHAR NO : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblAadharNo" runat="server" CssClass="lbl"></asp:Label>

            </td>
            


        </tr>
        <tr>
            <td>&nbsp;</td>

        </tr>
        <tr>

            <td>
                <asp:Label ID="LblState" runat="server" Text="SELECT STATE : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblStateDisp" runat="server" Text="" CssClass="lbl"></asp:Label>

            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>

        </tr>

        <tr>

            <td>
                <asp:Label ID="lblDistrict" runat="server" Text="SELECT DISTRICT : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblDistrictDisp" runat="server" Text="" CssClass="lbl"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>

        </tr>

        <tr>

            <td>
                <asp:Label ID="LblCityName" runat="server" Text="SELECT CITY : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblCityDisp" runat="server" Text="" CssClass="lbl"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>

        </tr>
        <tr>

            <td>
                <asp:Label ID="lblArea" runat="server" Text="SELECT AREA : " CssClass="lbl"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlArea" runat="server" OnSelectedIndexChanged="ddlArea_SelectedIndexChanged">
                    <asp:ListItem Selected hidden>SELECT AREA</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>

        </tr>
        <tr>

            <td>
                <asp:Label ID="lblAddress" runat="server" Text="ADDRESS : " CssClass="lbl"></asp:Label>
            </td>
            <%-- changes: changed the id and runat server added--%>
            <td>
                <textarea id="TextAreaAddress" cols="20" runat="server" rows="4"></textarea>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Style="color: red; font-size: xx-large;" runat="server" ErrorMessage="*" ControlToValidate="TextAreaAddress"></asp:RequiredFieldValidator>
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
<p align="center">
    <asp:Label ID="lblRegSuccess" runat="server"></asp:Label>
</p>

