<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditOtchet.aspx.cs" Inherits="AIS_Infekcii_Web.EditOtchet" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Редактировать отчет</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <h2>Редактировать отчёт</h2>
        <asp:Label runat="server" ID="lblMessage" CssClass="text-danger" />
        
        <div class="mb-3">
            <label>Название болезни:</label>
            <asp:TextBox ID="txtBolezn" runat="server" CssClass="form-control" />
        </div>
        <div class="mb-3">
            <label>Количество заболевших:</label>
            <asp:TextBox ID="txtKolvo" runat="server" CssClass="form-control" TextMode="Number" />
        </div>
        <div class="mb-3">
            <label>Дата отчета:</label>
            <asp:TextBox ID="txtData" runat="server" CssClass="form-control" TextMode="Date" />
        </div>
        <div class="mb-3">
            <label>ID района:</label>
            <asp:TextBox ID="txtRajonId" runat="server" CssClass="form-control" TextMode="Number" />
        </div>

        <asp:Button runat="server" ID="btnUpdate" Text="Сохранить изменения" CssClass="btn btn-primary w-100" OnClick="btnUpdate_Click" />
    </form>
</body>
</html>