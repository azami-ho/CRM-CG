using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenerator.Component
{
    public sealed class Settings
    {
        public string solutionRootFolder { get; set; }
        public string defaultNamespace { get; set; }
        public string connectionString { get; set; }
        public string dsNameSpace { get; set; }
        public string dalNameSpace { get; set; }
        public string facadeNameSpace { get; set; }
        public string bolNameSpace { get; set; }
        public string saveProjectPath { get; set; }
        public string lastSaveFile { get; set; }
        public string masterPageUrl { get; set; }
        public string contentPlaceHolderID { get; set; }
        public string collectionPath { get; set; }
    }
}
