using System.Collections.Generic;

namespace CodeGenerator.Component
{
    public sealed class FormModel
    {
        internal string Name { get; set; }

        internal string Description { get; set; }

        internal ControlType Control { get; set; }

        private int _Width = 100;
        public int Width
        {
            get
            {
                return this._Width;
            }
            set
            {
                this._Width = value;
            }
        }

        public bool Validate { get; set; }

    }

    public sealed class FormModelCollection
    {
        Dictionary<string, FormModel> dic = new Dictionary<string, FormModel>();

        internal void Add(FormModel obj)
        {
            if (!this.dic.ContainsKey(obj.Name))
                this.dic.Add(obj.Name, obj);
        }

        internal FormModel this[string Name]
        {
            get
            {
                if (this.dic.ContainsKey(Name))
                    return this.dic[Name];
                return null;
            }
        }

        internal List<FormModel> GetAll
        {
            get
            {
                return new List<FormModel>(this.dic.Values);
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
            foreach (FormModel pr in this.GetAll)
            {
                if (pr.Name == Name)
                    return true;
            }
            return false;
        }
    }
}
