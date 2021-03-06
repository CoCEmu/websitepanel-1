<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DomainsEditDomain.ascx.cs" Inherits="WebsitePanel.Portal.DomainsEditDomain" %>
<%@ Register Src="UserControls/EnableAsyncTasksSupport.ascx" TagName="EnableAsyncTasksSupport" TagPrefix="wsp" %>
<%@ Register Src="UserControls/CollapsiblePanel.ascx" TagPrefix="wsp" TagName="CollapsiblePanel" %>

<wsp:EnableAsyncTasksSupport id="asyncTasks" runat="server" />

<div class="FormBody">

    <div class="Huge" style="padding: 10px;border: solid 1px #e5e5e5;background-color: #f5f5f5;">
        <asp:Literal ID="DomainName" runat="server"></asp:Literal>
    </div>
    

    <fieldset id="WebSitePanel" runat="server" visible="false">
        <legend><asp:Localize ID="WebSiteSection" runat="server" meta:resourcekey="WebSiteSection" Text="Web site"></asp:Localize></legend>
        
        <ul class="VerticalButtons">
            <li><asp:HyperLink ID="BrowseWebSite" runat="server" meta:resourcekey="BrowseWebSite" Text="Browse web site" NavigateUrl="#" Target="_blank"></asp:HyperLink><br /></li>
        </ul>
        <div id="WebSiteParkedPanel" runat="server" class="FormRow">
            <asp:Localize ID="locDomainParkedWebSite" runat="server"
                meta:resourcekey="locDomainParkedWebSite" Text="This domain is parked to the web site."></asp:Localize>
        </div>
        <div id="WebSitePointedPanel" runat="server" class="FormRow">
            <asp:Localize ID="locDomainPointWebSite" runat="server"
                meta:resourcekey="locDomainPointWebSite" Text="This domain points to the following web site:"></asp:Localize><br />
            <asp:Label ID="WebSiteName" runat="server" CssClass="NormalBold">test.com</asp:Label>
        </div>
    </fieldset>

    
    <fieldset id="MailDomainPanel" runat="server" visible="false">
        <legend><asp:Localize ID="MailDomainSection" runat="server" meta:resourcekey="MailDomainSection" Text="Mail"></asp:Localize></legend>
        
        <div id="MailEnabledPanel" runat="server" class="FormRow">
            <asp:Localize ID="locMailDomain" runat="server"
                meta:resourcekey="locMailDomain" Text="This domain is mail-enabled."></asp:Localize><br />
        </div>
        <div id="PointMailDomainPanel" runat="server" class="FormRow">
            <asp:Localize ID="locPointMailDomain" runat="server"
                meta:resourcekey="locPointMailDomain" Text="This domain pointer is an alias for the following mail domain:"></asp:Localize><br />
            <asp:Label ID="MailDomainName" runat="server" CssClass="NormalBold">test.com</asp:Label>
        </div>
    </fieldset>
    
    <fieldset id="DnsPanel" runat="server" visible="false">
        <legend><asp:Localize ID="DnsSection" runat="server" meta:resourcekey="DnsSection" Text="DNS"></asp:Localize></legend>
        
        <div id="DnsEnabledPanel" runat="server" class="FormRow">
            <ul class="VerticalButtons">
                <li><asp:LinkButton ID="EditDnsRecords" runat="server" 
                        meta:resourcekey="EditDnsRecords" Text="Edit DNS records" 
                        OnClientClick="ShowProgressDialog('Opening DNS Zone Editor...');" 
                        onclick="EditDnsRecords_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="DisableDns" runat="server" meta:resourcekey="DisableDns" 
                        Text="Disable DNS" OnClientClick="ShowProgressDialog('Deleting DNS zone...');" 
                        onclick="DisableDns_Click"></asp:LinkButton></li>
            </ul>
            <asp:Localize ID="locDnsEnabled" runat="server"
                meta:resourcekey="locDnsEnabled" Text="DNS is enabled for this domain."></asp:Localize>
        </div>
        <div id="DnsDisabledPanel" runat="server" class="FormRow">
            <ul class="VerticalButtons">
                <li><asp:LinkButton ID="EnableDns" runat="server" meta:resourcekey="EnableDns" 
                        Text="Enable DNS" OnClientClick="ShowProgressDialog('Creating DNS zone...');" 
                        onclick="EnableDns_Click"></asp:LinkButton></li>
            </ul>
            <asp:Localize ID="locDnsDisabled" runat="server"
                meta:resourcekey="locDnsDisabled" Text="DNS is disabled for this domain."></asp:Localize>
        </div>
    </fieldset>
    
    
    <fieldset id="InstantAliasPanel" runat="server" visible="false">
        <legend><asp:Localize ID="InstantAliasSection" runat="server" meta:resourcekey="InstantAliasSection" Text="Instant alias"></asp:Localize></legend>
        
        <div id="InstantAliasDisabled" runat="server">
            <ul class="VerticalButtons">
                <li><asp:LinkButton ID="CreateInstantAlias" runat="server" 
                    meta:resourcekey="CreateInstantAlias" Text="Create Instant Alias" 
                    onclick="CreateInstantAlias_Click"></asp:LinkButton></li>
            </ul>
            <div class="FormRow">
                <asp:Localize ID="locInstantAliasDisabled" runat="server" meta:resourcekey="locInstantAliasDisabled" Text="Instant alias ..."></asp:Localize>
            </div>
        </div>
        
        <div id="InstantAliasEnabled" runat="server">
            <ul class="VerticalButtons">
                <li><asp:LinkButton ID="DeleteInstantAlias" runat="server" 
                    meta:resourcekey="DeleteInstantAlias" Text="Delete Instant Alias" 
                    onclick="DeleteInstantAlias_Click"></asp:LinkButton></li>
            </ul>
            <div class="FormRow">
                <asp:Localize ID="locInstantAliasEnabled" runat="server" meta:resourcekey="locInstantAliasEnabled" Text="Instant alias ..."></asp:Localize>
            </div>
            <div class="FormRow">
                <asp:Localize ID="locInstantAliasName" runat="server" meta:resourcekey="locInstantAliasName" Text="Instant alias for this domain:"></asp:Localize><br />
                <asp:Label ID="InstantAliasName" runat="server" CssClass="NormalBold"></asp:Label>
            </div>
            <div id="WebSiteAliasPanel" runat="server" visible="false" class="FormRow">
                <asp:Localize ID="locWebSiteAlias" runat="server" meta:resourcekey="locWebSiteAlias" Text="Web site temporary URL:"></asp:Localize><br />
                <asp:HyperLink ID="WebSiteAlias" runat="server" CssClass="NormalBold" NavigateUrl="#" Target="_blank">test.com.provider.com</asp:HyperLink>
            </div>
            <div id="MailDomainAliasPanel" runat="server" visible="false" class="FormRow">
                <asp:Localize ID="locMailDomainAlias" runat="server" meta:resourcekey="locMailDomainAlias" Text="Temporary e-mail alias:"></asp:Localize><br />
                <asp:Label ID="MailDomainAlias" runat="server" CssClass="NormalBold">@test.com.provider.com</asp:Label>
            </div>
        </div>
    </fieldset>
    
    <fieldset id="ResellersPanel" runat="server" visible="false">
        <legend><asp:Localize ID="ResellersSection" runat="server" meta:resourcekey="ResellersSection" Text="Resellers"></asp:Localize></legend>
        
        <asp:CheckBox ID="AllowSubDomains" runat="server" meta:resourcekey="AllowSubDomains" Text="Allow sub-domains" CssClass="Checkbox Bold" />
        <div style="padding-left: 20px;">
            <asp:Localize ID="DescribeAllowSubDomains" runat="server" meta:resourcekey="DescribeAllowSubDomains">Description...</asp:Localize>
        </div>
    </fieldset>
</div>
<div class="FormFooter">
    <asp:Button ID="btnSave" runat="server" meta:resourcekey="btnSave" CssClass="Button1" Text="Save" OnClick="btnSave_Click" OnClientClick = "ShowProgressDialog('Updating Domain...');"/>
    <asp:Button ID="btnCancel" runat="server" meta:resourcekey="btnCancel" CssClass="Button1" CausesValidation="false" 
        Text="Cancel" OnClick="btnCancel_Click" />
    <asp:Button ID="btnDelete" runat="server" meta:resourcekey="btnDelete" CssClass="Button1" CausesValidation="false" 
        Text="Delete" OnClick="btnDelete_Click" />
</div>