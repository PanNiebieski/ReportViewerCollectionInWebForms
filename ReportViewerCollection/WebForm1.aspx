<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ReportViewerCollection.WebForm1" %>

<%@ Register TagPrefix="rsweb" Namespace="Microsoft.Reporting.WebForms" Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

<%--        <rsweb:ReportViewer ID="rptViewer" runat="server" Width="100%" Height="600px"
            Font-Names="Verdana" Font-Size="8pt" InteractiveDeviceInfos="(Collection)"
            WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
            <LocalReport ReportPath="Report.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DSAllEmployee" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>--%>

        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
      <%--      <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllPeople" TypeName="ClassLibrary1.MyDataSource"></asp:ObjectDataSource>--%>
        </div>
    </form>
</body>
</html>
