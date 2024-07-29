using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Excel;
using OfficeOpenXml;
using UnityEngine;

public static class ExcelHelper
{
 

    public static void CreateWorkSheet(string fileName, int rowNum, int columnNum, object[] values,string workSheetName)
    {
        string filePath = Application.dataPath + "/Data/Config/" + fileName + ".xlsx";
        FileInfo newFile = new FileInfo(filePath);
        using (ExcelPackage package = new ExcelPackage(newFile))
        {
            ExcelWorksheet worksheet;
            if (package.Workbook.Worksheets[workSheetName]!=null)
            {
                worksheet= package.Workbook.Worksheets[workSheetName];
            }
            else
            {
                worksheet= package.Workbook.Worksheets.Add(workSheetName);
            }

            for (int i = 0; i < columnNum; i++)
            {
                for (int j = 0; j < rowNum; j++)
                {
                    worksheet.SetValue(j + 1, i + 1, values[i + columnNum * j]);
                }
            }
            Debug.Log("新分页储存成功！");
            package.Save();
        }
    }

    public static (List<string> tables,List<int> columNum, List<int> rowNum, List<DataRowCollection> drc) ReadExcel(string fileName)
    {
        string filePath = Application.dataPath + "/Data/Config/" + fileName + ".xlsx";
        FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
        IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
        DataSet result = excelReader.AsDataSet();
        var columList = new List<int>();
        var rowList = new List<int>();
        var drcList = new List<DataRowCollection>();
        var tables = new List<string>();
        for (int i = 0; i < result.Tables.Count; i++)
        {
            columList.Add(result.Tables[i].Columns.Count);
            rowList.Add(result.Tables[i].Rows.Count);
            drcList.Add(result.Tables[i].Rows);
            tables.Add(result.Tables[i].TableName);
        }

        return (tables,columList, rowList, drcList);
    }

    public static void ConvertToScriptData()
    {
    }
}