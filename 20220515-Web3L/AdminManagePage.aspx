<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminManagePage.aspx.cs" Inherits="_20220515_Web3L.AdminManagePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
            <Nodes>
                <asp:TreeNode Text="教师信息管理" Value="教师信息管理">
                    <asp:TreeNode NavigateUrl="~/DisplayTeacher.aspx" Target="mainFrame" Text="显示教师信息" Value="显示教师信息"></asp:TreeNode>
                    <asp:TreeNode Target="mainFrame" Text="新增教师信息" Value="新增教师信息"></asp:TreeNode>
                    <asp:TreeNode Target="mainFrame" Text="更新教师信息" Value="更新教师信息"></asp:TreeNode>
                    <asp:TreeNode Target="mainFrame" Text="删除教师信息" Value="删除教师信息"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="学生信息管理" Value="学生信息管理"></asp:TreeNode>
                <asp:TreeNode Text="学院信息管理" Value="学院信息管理"></asp:TreeNode>
                <asp:TreeNode Text="教研室信息管理" Value="教研室信息管理"></asp:TreeNode>
                <asp:TreeNode Text="退出系统" Value="退出系统"></asp:TreeNode>
            </Nodes>
        </asp:TreeView>
        <div>
            </div>
    </form>
</body>
</html>
