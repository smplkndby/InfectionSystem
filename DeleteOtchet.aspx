<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteOtchet.aspx.cs" Inherits="AIS_Infekcii_Web.DeleteOtchet" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Удалить отчет</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <h2 class="text-danger">Удалить отчет</h2>
        <asp:Label runat="server" ID="lblMessage" CssClass="text-danger fw-bold" />

        <div class="alert alert-warning mt-4" role="alert">
            <p>Вы уверены, что хотите удалить отчёт:</p>
            <p><strong>Болезнь:</strong> <asp:Label runat="server" ID="lblBolezn" /></p>
            <p><strong>Дата:</strong> <asp:Label runat="server" ID="lblData" /></p>
        </div>

        <asp:Button runat="server" ID="btnDelete" Text="Удалить" CssClass="btn btn-danger me-2" OnClick="btnDelete_Click" />
        <a href="OtchetyClassic.aspx" class="btn btn-secondary">Отмена</a>
    </form>
</body>
</html>