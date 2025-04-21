<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtchetyClassic.aspx.cs" Inherits="AIS_Infekcii_Web.OtchetyClassic" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Список отчетов</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="d-flex justify-content-between align-items-center mb-4">
            <h2>Список отчетов</h2>
            <a href="AddOtchet.aspx" class="btn btn-success">+ Добавить отчет</a>
        </div>

        <asp:Label ID="lblMessage" runat="server" CssClass="text-danger fw-bold" />

        <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-striped"
            AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="OtchetId" HeaderText="ID" />
                <asp:BoundField DataField="NazvanieBolezni" HeaderText="Болезнь" />
                <asp:BoundField DataField="KolichestvoZabolevshih" HeaderText="Количество" />
                <asp:BoundField DataField="DataOtcheta" HeaderText="Дата" DataFormatString="{0:dd.MM.yyyy}" />
                <asp:BoundField DataField="RajonId" HeaderText="Район" />

                <asp:TemplateField HeaderText="Действия">
                    <ItemTemplate>
                        <a href='EditOtchet.aspx?id=<%# Eval("OtchetId") %>' class="btn btn-sm btn-primary me-2">Редактировать</a>
                        <a href='DeleteOtchet.aspx?id=<%# Eval("OtchetId") %>' class="btn btn-sm btn-danger">Удалить</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
