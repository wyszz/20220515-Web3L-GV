<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_20220515_Web3L.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style3 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">教师ID</td>
                    <td>
                        <asp:TextBox ID="tbx_teacherid" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">密码</td>
                    <td>
                        <asp:TextBox ID="tbx_password" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style3">
                        <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="登录" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_reset" runat="server" OnClick="btn_reset_Click" style="height: 27px" Text="重置" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
