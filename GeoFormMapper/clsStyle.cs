using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFormMapper
{
    class clsStyle
    {
        public string StyleName;
        public int Red;
        public int Green;
        public int Blue;

        public clsStyle(string StyleName, int Red, int Green, int Blue)
        {
            this.StyleName = StyleName;
            this.Red = Red;
            this.Green = Green;
            this.Blue = Blue;
        }
    }
}
