<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomWebPart.ascx.cs" Inherits="CMSApp.MyWebParts.CustomWebPart" %>
<asp:Label ID="weightLbl" runat="server">Weight</asp:Label>
<asp:TextBox ID="weightTextBox" runat="server"></asp:TextBox>
<asp:Label ID="heightLabel" runat="server">Height</asp:Label>
<asp:TextBox ID="heightIdTextBox" runat="server"></asp:TextBox>

<asp:Label ID="resultLabel" runat="server">Result is:</asp:Label>
<asp:Literal ID="result" runat="server"></asp:Literal>
<asp:Button id="submitBtn" runat="server" Text="calculate" OnClick="submitBtn_Click"/>