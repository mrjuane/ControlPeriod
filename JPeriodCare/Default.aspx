<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PeriodCare.Default" %>

<%@ Register Src="~/WUCPeriod.ascx" TagPrefix="uc1" TagName="WUCPeriod" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:WUCPeriod runat="server" id="WUCPeriod" />
        </div>
    </form>
    <link href="CSS/StyleSheetPeriod.css" type="text/css" rel="stylesheet" />
</body>
</html>
