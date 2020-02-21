<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nested_gridview.aspx.cs" Inherits="DXWebApplication1.nested_gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxGridView ID="grid" runat="server"  KeyFieldName="organization_id">
                <Columns>
                    <dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true" VisibleIndex="0" />
                    <dx:GridViewDataTextColumn FieldName="organization_id" VisibleIndex="1">
                        <EditFormSettings VisibleIndex="0" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataColumn FieldName="description" VisibleIndex="4">
                        <EditFormSettings VisibleIndex="1" />
                    </dx:GridViewDataColumn>
                </Columns>
                <Templates>
                    <DetailRow>
<%--                        Contact Phone:
                <dx:ASPxLabel runat="server" Text='<%# Eval("Phone") %>' Font-Bold="true" />
                        , Fax:
                <dx:ASPxLabel runat="server" Text='<%# Eval("Fax") %>' Font-Bold="true" />
                        <br />
                        <br />--%>
                        <dx:ASPxGridView ID="detailGrid" runat="server" KeyFieldName="organization_id"
                            Width="100%" EnablePagingGestures="False" OnBeforePerformDataSelect="detailGrid_DataSelect">
                            <Columns>
                                <dx:GridViewDataColumn FieldName="office_master_id" Caption="Order Id" VisibleIndex="1" />
                                <dx:GridViewDataColumn FieldName="organization_id" VisibleIndex="2" />
                                <dx:GridViewDataColumn FieldName="office_name" VisibleIndex="2" />
                            </Columns>
                            <Settings ShowFooter="True" />
                            <SettingsPager EnableAdaptivity="true" />
                            <Styles Header-Wrap="True" />
                        </dx:ASPxGridView>
                    </DetailRow>
                </Templates>
                <SettingsDetail ShowDetailRow="true" />
            </dx:ASPxGridView>
        </div>
    </form>
</body>
</html>
