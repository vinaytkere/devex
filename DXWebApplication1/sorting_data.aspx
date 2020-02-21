<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sorting_data.aspx.cs" Inherits="DXWebApplication1.sorting_data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" KeyFieldName="employeeid" Width="100%">
                <Columns>
                    <dx:GridViewDataColumn FieldName="employeeid" SortOrder="Ascending" Caption="Employee Id" />
                    <dx:GridViewDataColumn FieldName="fullname" Caption="Full Name" />
                    <dx:GridViewDataColumn FieldName="title" Caption="Designation" />
                    <dx:GridViewDataColumn FieldName="country" Caption="Country" />
                    <dx:GridViewDataColumn FieldName="city" Caption="City" />
                </Columns>
            </dx:ASPxGridView>
        </div>
    </form>
</body>
</html>
