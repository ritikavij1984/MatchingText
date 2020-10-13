<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatchingText.aspx.cs" Inherits="MatchingText.MatchingText" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" spellcheck="True" translate="no" title="Match the input texts">
        <div spellcheck="True" title="Match Input Texts">
           <b/>Enter Text Below: 
            <br/>
            <asp:TextBox ID="TextBox1" runat="server" Font-Bold="False" Width="150" ToolTip="Enter Text" Text="Sample text"></asp:TextBox>
            <br/><br/>
            <b/>Enter SubText Below: 
            <br/>
            <asp:TextBox ID="TextBox2" runat="server" Width="150" ToolTip="Enter SubText" Text="Sample text"> </asp:TextBox>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Match Inputs" ToolTip="Click on the button to match the inputs" OnClick="btnMatchText_Click" BorderStyle="Solid" Font-Bold="True" />
            <br/><br/>Output:
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
