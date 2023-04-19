using ClosedXML.Excel;
using CMS.DataEngine;
using CMS.Ecommerce.Web.UI;
using CMS.EventLog;
using CMS.Helpers;
using CMS.ImportExport;
using System;
using System.Data;
using System.IO;
using System.Web;

public partial class TestPage : CMSEcommercePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            var selectSubject = new DataQuery("customtable.E_formMasterQuery.selectSubject").Execute();
            ddlSubject.DataSource = selectSubject;
            ddlSubject.DataBind();

            var selectTitleName = new DataQuery("customtable.E_formMasterQuery.selectTitleName").Execute();
            ddlTitleName.DataSource = selectTitleName;
            ddlTitleName.DataBind();
        }

        DataSet dataSet = FrormData();
        BindData(dataSet);
    }

    protected DataSet FrormData()
    {
        string strWhere = "1=1";

        if (ValidationHelper.GetInteger(ddlSubject.SelectedIndex, 0) != 0)
        {
            strWhere += $" and ddlSubject = N'{ValidationHelper.GetString(SqlHelper.GetSafeQueryString(ddlSubject.SelectedItem.Text), string.Empty)}'";
        }

        if (ValidationHelper.GetInteger(ddlTitleName.SelectedIndex, 0) != 0)
        {
            strWhere += $" and TitleName = N'{ValidationHelper.GetString(SqlHelper.GetSafeQueryString(ddlTitleName.SelectedItem.Text), string.Empty)}'";
        }

        if (ValidationHelper.GetString(txtStratDate.DateTimeTextBox.Text, string.Empty) != string.Empty)
        {
            strWhere += $" and FormInserted >= N'{ValidationHelper.GetString(txtStratDate.DateTimeTextBox.Text, string.Empty)}'";
        }

        if (ValidationHelper.GetString(txtEndDate.DateTimeTextBox.Text, string.Empty) != string.Empty)
        {
            strWhere += $" and FormInserted <= N'{ValidationHelper.GetString(txtEndDate.DateTimeTextBox.Text, string.Empty)}'";
        }

        DataSet ds = new DataQuery("customtable.E_formMasterQuery.ReportForm").Where(strWhere).Execute();
        return ds;
    }

    private void BindData(DataSet ds)
    {
        try
        {
            FormGrid.OnExternalDataBound += FormGrid_OnExternalDataBound;
            FormGrid.DataSource = ds;
            FormGrid.DataBind();
            FormGrid.ReloadData();
        }
        catch (Exception ex)
        {
            EventLogProvider.LogEvent(EventType.ERROR, "TestPage", "BindData()", eventDescription: $"ex.Message=>{ex.Message}");
        }
    }

    protected object FormGrid_OnExternalDataBound(object sender, string sourceName, object parameter)
    {
        string url = $"{HttpContext.Current.Request.Url.Scheme}://{HttpContext.Current.Request.Url.Host}";
        if (!string.IsNullOrEmpty(ValidationHelper.GetString(HttpContext.Current.Request.Url.Port, string.Empty)))
        {
            url += $":{HttpContext.Current.Request.Url.Port}";
        }

        url += "/DancingGoatCore/BizFormFiles/";


        switch (sourceName)
        {
            case "#Image1":
                var image1 = ValidationHelper.GetString(parameter, "");
                if (!string.IsNullOrEmpty(image1))
                {
                    return string.Format($@"<img width=""150"" height=""50"" src=""{url}{image1.Split('/')[0]}"" >");
                }
                return string.Empty;
            case "#Image2":
                var image2 = ValidationHelper.GetString(parameter, "");
                if (!string.IsNullOrEmpty(image2))
                {
                    return string.Format($@"<img width=""150"" height=""50"" src=""{url}{image2.Split('/')[0]}"" >");
                }
                return string.Empty;
            case "#Image3":
                var image3 = ValidationHelper.GetString(parameter, "");
                if (!string.IsNullOrEmpty(image3))
                {
                    return string.Format($@"<img width=""150"" height=""50"" src=""{url}{image3.Split('/')[0]}"" >");
                }
                return string.Empty;
            case "#Image4":
                var image4 = ValidationHelper.GetString(parameter, "");
                if (!string.IsNullOrEmpty(image4))
                {
                    return string.Format($@"<img width=""150"" height=""50"" src=""{url}{image4.Split('/')[0]}"" >");
                }
                return string.Empty;
            case "#Image5":
                var image5 = ValidationHelper.GetString(parameter, "");
                if (!string.IsNullOrEmpty(image5))
                {
                    return string.Format($@"<button type=""button"" class=""js-getModalSRC"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal""><img width=""150"" height=""50"" src=""{url}{image5.Split('/')[0]}"" > </button>");
                }
                return string.Empty;

        }
        return parameter;
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        DataSet dataSet = FrormData();
        BindData(dataSet);
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect(Page.Request.Url.ToString(), true);
    }

    #region Zone Export

    protected void btnExport_Click(object sender, EventArgs e)
    {
        DataSet dataSet = FrormData();
        ExportToExcel(dataSet.Tables[0]);
    }

    private void ExportToExcel(DataTable dt)
    {
        try
        {
            XLWorkbook wb = new XLWorkbook();
            {
                IXLWorksheet ws = wb.Worksheets.Add("Sheet1");

                #region Add column width
                for (int row = 2; row <= 10; row++)
                {
                    ws.Column(row).Width = 15;
                }
                for (int row = 11; row <= 15; row++)
                {
                    ws.Column(row).Width = 30;
                }
                #endregion

                #region Adding Header column.
                for (int column = 0; column < dt.Columns.Count; column++)
                {
                    ws.Cell(1, column + 1).Value = dt.Columns[column].ColumnName;
                }
                #endregion

                #region Adding Rows in cell.
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    //ลบ 5 เพราะไม่เอา 5 column หลังวาดเป็น text
                    for (int column = 0; column < dt.Columns.Count - 5; column++)
                    {
                        ws.Cell(row + 2, column + 1).Value = dt.Rows[row][column];
                    }

                    for (int column = 10; column < dt.Columns.Count; column++)
                    {
                        if (!string.IsNullOrEmpty(dt.Rows[row][column].ToString()))
                        {
                            var image = ws.AddPicture("C:\\Kentico_Leaning\\Kentico13_Git_TestFunction_DancingGoat_050423\\CMS\\DancingGoatCore\\BizFormFiles\\" + dt.Rows[row][column].ToString().Split('/')[0]).MoveTo(ws.Cell(row + 2, column + 1));
                            image.Width = 200;
                            image.Height = 150;
                        }
                    }
                    ws.Row(row + 2).Height = 130;
                }
                #endregion

                #region Create File
                Response.Clear();
                Response.Buffer = true;
                Response.Charset = "";
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                string strFileName = "Export" + DateTime.Now.ToShortDateString() + ".xlsx";
                Response.AddHeader("content-disposition", "attachment;filename=" + strFileName);

                MemoryStream MyMemoryStream = new MemoryStream();
                {
                    wb.SaveAs(MyMemoryStream);
                    MyMemoryStream.WriteTo(Response.OutputStream);
                    Response.Flush();
                    Response.End();
                }
                #endregion
            }
        }
        catch (Exception ex)
        {
            EventLogProvider.LogEvent(EventType.ERROR, "TestPage", "ExportToExcel()", eventDescription: $"ex.Message=>{ex.Message}");
        }
    }

    #endregion


}