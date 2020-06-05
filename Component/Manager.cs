using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CodeGenerator.Component;

public class Manager
{
    private static DataSet ds;
    public static Settings settings = new Settings();

    public static Settings Settings { get { return settings; } }

    public static DataRow GetTable(CodeGenerator.TableName tableName)
    {
        return DS.Tables[tableName.ToString()].Rows[0];
    }

    public static void FillSettings()
    {
        foreach (var table in DS.Tables.Cast<DataTable>())
        {
            try
            {
                settings.GetType().GetProperty(table.TableName).SetValue(settings, DS.Tables[table.TableName].Rows[0]["value"].ToString(), null);
            }
            catch
            {
            }
        }
    }

    public static void WriteDatas()
    {
        ds.WriteXml(Application.StartupPath + "\\App_Data\\DefaultSettings.xml");
    }

    private static DataSet DS
    {
        get
        {
            if (ds == null)
            {
                ds = new DataSet();
                ds.ReadXml(Application.StartupPath + "\\App_Data\\DefaultSettings.xml");
            }
            return ds;
        }
    }
}