<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Address.ascx.cs" Inherits="CMSApp.MedioClinic.CMSFormControls.Address" %>

<table class="table table-hover">
    <thead>
        <tr>
            <th>Street</th>
            <th>City</th>
            <th>Country</th>
        </tr>
    </thead>
    <tbody>

       <tr>
            <td><asp:TextBox ID="streetTextBoxID" runat="server">SomeStreet</asp:TextBox></td>
            <td><asp:TextBox ID="cityTextBoxID" runat="server">someCity</asp:TextBox></td>
           <td><asp:DropDownList ID="drpCountry" runat="server"></asp:DropDownList></td>
        </tr>
        
    </tbody>
</table>
