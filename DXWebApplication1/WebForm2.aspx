<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DXWebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxGridView ID="MainGrid" runat="server" KeyFieldName="oid" Width="100%" AutoGenerateColumns="true">
                <SettingsDetail ShowDetailRow="True" />
                <Templates>
                    <DetailRow>
                        <dx:ASPxGridView ID="detailGrid" runat="server"  KeyFieldName="office_master_id" AutoGenerateColumns="true" OnDataBinding="detailGrid_DataBinding">
                        </dx:ASPxGridView>
                    </DetailRow>
                </Templates>
            </dx:ASPxGridView>
        </div>
    </form>
</body>
</html>
