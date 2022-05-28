<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMainPage.aspx.cs" Inherits="_20220515_Web3L.AdminMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
    <frameset id="index" name="index" border="2" framespaceing="0" rows="120,*" frameborder="yes">
        <frame id="topFrame" name="topFrame" src="AdminTop.aspx" noresize="noresize" scrolling="no">
            <frameset border="2" framespacing="0" frameborder="yes" cols="20%,*">
                <frame id="leftFrame" name="leftFrame" src="AdminManagePage.aspx" noresize="noresize" scrolling="no"></frame>
                <frame id="mainFrame" name="mainFrame" src="AdminDefault.aspx" ></frame>
            </frameset>
        </frame>
    </frameset>
</html>
