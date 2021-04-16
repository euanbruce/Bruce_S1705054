<asp:FileUpload runat="server"></asp:FileUpload><asp:FileUpload runat="server"></asp:FileUpload><%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="SendCheque.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="AudioFile" runat="server" />

            <asp:Button ID="btn_Upload" runat="server" Text="Upload" OnClick="btn_Upload_Click"/>
            <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
