<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedioClinic.aspx.cs" Inherits="CMSApp.MedioClinic.Modules.MedioClinic.MedioClinic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="idTextBoxMarkup" runat="server"></asp:TextBox>
        <asp:Button  ID="buttonId" runat="server" OnClick="buttonId_Click"/>
    </div>
        <div>
            <asp:Button ID="idAddDoctor" runat="server"  OnClick="idAddDoctor_Click"/>
        </div>>
    </form>
</body>
</html>
