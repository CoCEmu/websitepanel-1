﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BlackBerryUsers.ascx.cs"
    Inherits="WebsitePanel.Portal.BlackBerry.BlackBerryUsers" %>
<%@ Register Src="../ExchangeServer/UserControls/UserSelector.ascx" TagName="UserSelector"
    TagPrefix="wsp" %>
<%@ Register Src="../ExchangeServer/UserControls/Menu.ascx" TagName="Menu" TagPrefix="wsp" %>
<%@ Register Src="../ExchangeServer/UserControls/Breadcrumb.ascx" TagName="Breadcrumb"
    TagPrefix="wsp" %>
<%@ Register Src="../UserControls/SimpleMessageBox.ascx" TagName="SimpleMessageBox"
    TagPrefix="wsp" %>
<%@ Register Src="../UserControls/EnableAsyncTasksSupport.ascx" TagName="EnableAsyncTasksSupport"
    TagPrefix="wsp" %>
<%@ Register Src="../UserControls/QuotaViewer.ascx" TagName="QuotaViewer" TagPrefix="wsp" %>
<wsp:EnableAsyncTasksSupport id="asyncTasks" runat="server" />
<div id="ExchangeContainer">
    <div class="Module">
        <div class="Header">
            <wsp:Breadcrumb id="breadcrumb" runat="server" PageName="Text.PageName" />
        </div>
        <div class="Left">
            <wsp:Menu id="menu" runat="server" />
        </div>
        <div class="Content">
            <div class="Center">
                <div class="Title">
                    <asp:Image ID="Image1" SkinID="BlackBerryUsersLogo" runat="server" />
                    <asp:Localize ID="locTitle" runat="server" meta:resourcekey="locTitle"></asp:Localize>
                </div>
                <div class="FormBody">
                    <wsp:SimpleMessageBox id="messageBox" runat="server" />
                    <div class="FormButtonsBarClean">
                        <div class="FormButtonsBarClean">
                            <div class="FormButtonsBarCleanLeft">
                                <asp:Button runat="server" CssClass="Button1" ID="btnCreateNewBlackBerryUser"
                                    OnClick="btnCreateNewBlackBerryUser_Click"  meta:resourcekey="btnCreateNewBlackBerryUser" />
                            </div>
                            <div class="FormButtonsBarCleanRight">
                                <asp:Panel ID="SearchPanel" runat="server" DefaultButton="cmdSearch">
                                    <asp:DropDownList ID="ddlSearchColumn" runat="server" CssClass="NormalTextBox">
                                        <asp:ListItem Value="DisplayName" meta:resourcekey="ddlSearchColumnDisplayName">DisplayName</asp:ListItem>
                                        <asp:ListItem Value="PrimaryEmailAddress" meta:resourcekey="ddlSearchColumnEmail">Email</asp:ListItem>
                                    </asp:DropDownList><asp:TextBox ID="txtSearchValue" runat="server" CssClass="NormalTextBox" Width="100"></asp:TextBox><asp:ImageButton
                                        ID="cmdSearch" runat="server" meta:resourcekey="cmdSearch" SkinID="SearchButton"
                                        CausesValidation="false" />
                                </asp:Panel>
                            </div>
                        </div>
                        <div class="FormButtonsBarCleanRight">
                            <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="False" EnableViewState="true"
                                Width="100%" CssSelectorClass="NormalGridView" DataSourceID="odsAccountsPaged" meta:resourcekey="gvUsers"
                                AllowPaging="true" AllowSorting="true">
                                <Columns>
                                    <asp:TemplateField HeaderText="gvUsersDisplayName" SortExpression="DisplayName">
                                        <ItemStyle Width="50%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Image ID="img1" runat="server" ImageUrl='<%# GetAccountImage((int)Eval("AccountType")) %>'
                                                ImageAlign="AbsMiddle" />
                                            <asp:HyperLink ID="lnk1" runat="server" NavigateUrl='<%# GetUserEditUrl(Eval("AccountId").ToString()) %>'> 
									    <%# Eval("DisplayName") %>
                                            </asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="gvUsersEmail" DataField="PrimaryEmailAddress" SortExpression="PrimaryEmailAddress"
                                        ItemStyle-Width="50%" />
                                </Columns>
                            </asp:GridView>
                            <asp:ObjectDataSource ID="odsAccountsPaged" runat="server" EnablePaging="True" SelectCountMethod="GetBlackBerryUsersPagedCount"
                                SelectMethod="GetBlackBerryUsersPaged" SortParameterName="sortColumn" TypeName="WebsitePanel.Portal.BlackBerryHelper">
                                <SelectParameters>
                                    <asp:QueryStringParameter Name="itemId" QueryStringField="ItemID" DefaultValue="0" />
                                    <asp:ControlParameter Name="filterColumn" ControlID="ddlSearchColumn" PropertyName="SelectedValue" />
                                    <asp:ControlParameter Name="filterValue" ControlID="txtSearchValue" PropertyName="Text" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <br />
                            <div class="FormButtonsBarCleanLeft">
                            
				    <asp:Localize ID="locQuota" runat="server" meta:resourcekey="locQuota" Text="Total Users Created:"></asp:Localize>
				    &nbsp;&nbsp;&nbsp;				    
                            <wsp:QuotaViewer ID="usersQuota" runat="server" QuotaTypeId="2"   />				    				    
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
            </div>
            <div class="Right">
                <asp:Localize ID="FormComments" runat="server" meta:resourcekey="FormComments"></asp:Localize>
            </div>
        </div>
    </div>
</div>
