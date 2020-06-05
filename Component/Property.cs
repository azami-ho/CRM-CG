using System;
using System.Collections.Generic;
using System.Linq;

[Serializable]
public sealed class Property
{
    private string _name;
    internal string Name
    {
        get
        {
            return this._name;
        }
        set
        {
            this._name = value;
        }
    }

    private string _SqlType;
    internal string SqlType
    {
        get
        {
            return this._SqlType;
        }
        set
        {
            this._SqlType = value;
        }
    }

    private string _DotNetType;
    internal string DotNetType
    {
        get
        {
            return this._DotNetType;
        }
        set
        {
            this._DotNetType = value;
        }
    }

    private string _DefaultValue;
    internal string DefaultValue
    {
        get
        {
            return this._DefaultValue;
        }
        set
        {
            this._DefaultValue = value;
        }
    }

    private bool _IsNull;
    internal bool IsNull
    {
        get
        {
            return this._IsNull;
        }
        set
        {
            this._IsNull = value;
        }
    }

    private int? _Length;
    internal int? Length
    {
        get
        {
            return this._Length;
        }
        set
        {
            this._Length = value;
        }
    }

    public string Description { get; set; }

    private string _ParentName = string.Empty;
    public string ParentName
    {
        get { return _ParentName; }
        set { _ParentName = value; }
    }

    private string _ParentField = string.Empty;
    public string ParentField
    {
        get { return _ParentField; }
        set { _ParentField = value; }
    }

    public bool IsIdentity { get; set; }

    public bool Validate { get; set; }

    public bool IsUnique { get; set; }
}

[Serializable]
public sealed class PropertyCollection
{
    readonly Dictionary<string, Property> dic = new Dictionary<string, Property>();

    internal void Add(Property obj)
    {
        if (!this.dic.ContainsKey(obj.Name))
            this.dic.Add(obj.Name, obj);
    }

    internal Property this[string Name]
    {
        get
        {
            if (this.dic.ContainsKey(Name))
                return this.dic[Name];
            return null;
        }
    }

    internal List<Property> GetAll
    {
        get
        {
            return new List<Property>(this.dic.Values);
        }
    }

    internal int Count
    {
        get
        {
            return this.dic.Count;
        }
    }

    internal void Clear()
    {
        this.dic.Clear();
    }

    internal bool Contains(string Name)
    {
        return this.GetAll.Any(pr => pr.Name == Name);
    }

    public string TableDescription { get; set; }

    public bool HasForeignKey { get; set; }

    public string Schema { get; set; }
}
