﻿<%@ Control Language="C#" AutoEventWireup="true"  Codebehind="FiftyOne_Activate.ascx.cs"
    Inherits="CMSModules_DeviceProfiles_FormControls_FiftyOne_Activate" %>
<%@ Register Assembly="FiftyOne.Foundation" Namespace="FiftyOne.Foundation.UI.Web"
    TagPrefix="fiftyOne" %>
<style type="text/css">
    .FiftyOneContainer 
    {
        padding-top: 7px;
        width: 100%;
    }
    .FiftyOneFooter
    {
        padding: 5px 0px;
    }
    .FiftyOneFooter > span
    {
        display: block;
    }
</style>
<fiftyOne:Detection runat="server" ID="elemActivate" />
