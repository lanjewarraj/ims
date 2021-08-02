<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="IMS.AddItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="Index.aspx">Return back</a>
            <asp:Panel ID="Panel1" runat="server" BackColor="#999966" Font-Bold="False" Font-Size="14pt" Height="410px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Add Items into stock<br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Get" Width="65px" />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="125px">
                    <asp:ListItem>-Select item category-</asp:ListItem>
                    <asp:ListItem Value="0">Furniture</asp:ListItem>
                    <asp:ListItem>Consumable</asp:ListItem>
                    <asp:ListItem>Stationary</asp:ListItem>
                    <asp:ListItem>Electronics</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Rate (price)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Balance quantity&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Italic="True" ForeColor="#FFFFCC"></asp:Label>
            </asp:Panel>
        </div>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="516px">
        </asp:GridView>
    </form>
</body>
</html>
