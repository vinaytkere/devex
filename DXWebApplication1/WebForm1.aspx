<%@ Page Title="" Language="C#" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DXWebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LeftPanelContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="RightPanelContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="PageToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="PageContent" runat="server">
    <dx:ASPxGridView ID="grid" runat="server"
        KeyFieldName="CourseID" AutoGenerateColumns="False" Width="100%">
        <Columns>
            <dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true" VisibleIndex="0" />
            <dx:GridViewDataTextColumn FieldName="CourseID" VisibleIndex="1">
                <EditFormSettings VisibleIndex="0" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColumn FieldName="Title" VisibleIndex="4">
                <EditFormSettings VisibleIndex="1" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataMemoColumn FieldName="Credits" Visible="False">
                <EditFormSettings VisibleIndex="2" Visible="True" />
            </dx:GridViewDataMemoColumn>
            <dx:GridViewDataColumn FieldName="DepartmentID" VisibleIndex="2">
                <EditFormSettings VisibleIndex="3" />
            </dx:GridViewDataColumn>
        </Columns>
        <SettingsPager Mode="ShowAllRecords"/>
        <EditFormLayoutProperties ColCount="3">
            <Items>
                <dx:GridViewColumnLayoutItem ColumnName="CourseID" />
                <dx:GridViewColumnLayoutItem ColumnName="Title" />
                <dx:GridViewColumnLayoutItem ColumnName="Credits" />
                <dx:GridViewColumnLayoutItem ColumnName="DepartmentID" />
                <dx:EditModeCommandLayoutItem Width="100%" HorizontalAlign="Right" />
            </Items>
        </EditFormLayoutProperties>
        <EditFormLayoutProperties>
            <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="600" />
        </EditFormLayoutProperties>
    </dx:ASPxGridView>
</asp:Content>
