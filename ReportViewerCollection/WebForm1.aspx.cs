using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
using Microsoft.Reporting.WebForms;

namespace ReportViewerCollection
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

protected void Button1_Click(object sender, EventArgs e)
{
    ReportViewer ReportViewer1 = new ReportViewer();
    ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath(@"\Report1.rdlc");

    var people = MyDataSource.GetAllPeople();

    ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource()
    {
        Name = "DataSet1",
        Value = people
    });


    byte[] byteViewer = ReportViewer1.LocalReport.Render("PDF");
    FileStream newFile;



    string filename = Guid.NewGuid().ToString() + ".pdf";
    string path = HttpContext.Current.Server.MapPath(@"\") + filename;
    newFile = new FileStream(path, FileMode.Create);
    newFile.Write(byteViewer, 0, byteViewer.Length);
    newFile.Flush();
    newFile.Close();
}


    }
}