<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOtchet.aspx.cs" Inherits="AIS_Infekcii_Web.AddOtchet" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Добавить отчёт</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h2 class="mb-4">Добавление отчёта</h2>

            <div class="mb-3">
                <label for="txtBolezn" class="form-label">Название болезни</label>
                <asp:TextBox ID="txtBolezn" runat="server" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtData" class="form-label">Дата отчёта</label>
                <asp:TextBox ID="txtData" runat="server" CssClass="form-control" TextMode="Date" />
            </div>

            <div class="mb-3">
                <label for="txtKolvo" class="form-label">Количество заболевших</label>
                <asp:TextBox ID="txtKolvo" runat="server" CssClass="form-control" TextMode="Number" />
            </div>

            <div class="mb-3">
                <label for="txtRajonId" class="form-label">ID района</label>
                <asp:TextBox ID="txtRajonId" runat="server" CssClass="form-control" TextMode="Number" />
            </div>

            <asp:Button ID="btnAdd" runat="server" Text="Добавить" CssClass="btn btn-primary" OnClick="btnAdd_Click" />
        </div>
    </form>
</body>
</html>