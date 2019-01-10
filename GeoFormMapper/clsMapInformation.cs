using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeExtractor;

namespace GeoFormMapper
{
    public enum enmMapSource
    {
        ShapeFile,
        ShapeExtractorFile
    }

    class clsMapInformation
    {
        public enmMapSource MapSource;
        public string SourcePathName;
        public string MapName;
        public ShapeExtractor.ShapeExtractor ShapeExtractorInfo;
        public Dictionary<string, clsStyle> Styles;

    }
}
