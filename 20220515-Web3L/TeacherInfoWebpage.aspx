<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherInfoWebpage.aspx.cs" Inherits="_20220515_Web3L.TeacherInfo" %>

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
            text-align: center;
            height: 163px;
        }
        .auto-style3 {
            width: 158px;
            text-align: right;
        }
        .auto-style4 {
            width: 158px;
            height: 24px;
            text-align: right;
        }
        .auto-style5 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="1" RepeatDirection="Horizontal">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2" colspan="2">
                            <asp:Image ID="Image1" runat="server" Height="160px" Width="130px" ImageUrl='<%# Eval("photourl") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><strong>教师ID：</strong></td>
                        <td class="auto-style5"><strong>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("teacherid") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>教师姓名：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("teachername") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>性别：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("gender") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>年龄：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("age") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>Email：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>QQ：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("qq") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><strong>电话号码：</strong></td>
                        <td class="auto-style5"><strong>
                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("phone") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>出生年月：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label8" runat="server" Text='<%# Eval("birthday") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>职称：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label9" runat="server" Text='<%# Eval("titlename") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>用户角色：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label10" runat="server" Text='<%# Eval("rolename") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>当前状态：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("authorizedname") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>所在办公室：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label12" runat="server" Text='<%# Eval("officename") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><strong>所属学院：</strong></td>
                        <td><strong>
                            <asp:Label ID="Label13" runat="server" Text='<%# Eval("schoolname") %>'></asp:Label>
                            </strong></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
</body>
</html>
