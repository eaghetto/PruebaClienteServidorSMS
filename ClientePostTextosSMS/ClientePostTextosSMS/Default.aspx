<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClientePostTextosSMS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblTemporarl" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGenerarPost" runat="server" Text="Generar Post Texto" OnClick="btnGenerarPost_Click" />
    </div>
    </form>
</body>
</html>
