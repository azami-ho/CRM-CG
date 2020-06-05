namespace CodeGenerator
{
    public enum TableName
    {
        defaultNamespace,
        connectionString,
        dsNameSpace,
        dalNameSpace,
        facadeNameSpace,
        bolNameSpace,
        saveProjectPath,
        lastSaveFile,
        masterPageUrl,
        contentPlaceHolderID,
        collectionPath
    }

    public enum ActionType
    {
        Select,
        Insert,
        Update,
        Delete
    }

    public enum ControlType
    {
        TextBox,
        Numeric,
        Label,
        DropDownList,
        CheckBox,
        DatePicker,
        TimeBox,
        PersonSelector,
        ImageFile,
        Radio,
    }
}