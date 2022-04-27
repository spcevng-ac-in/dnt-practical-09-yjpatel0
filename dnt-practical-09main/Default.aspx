<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    
    <h3>Image Upload</h3>

    <form id="Form1" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br /><br />
    <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
   <br />
    <hr />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowHeader="false">
    <Columns>
      
        <asp:ImageField DataImageUrlField="Value" ControlStyle-Height="100" ControlStyle-Width="100" />
          <asp:BoundField DataField="Text" /> 
    </Columns>
    </asp:GridView>
    </form>   
</body>
</html>