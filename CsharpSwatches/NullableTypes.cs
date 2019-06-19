using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//makes an unsigned assembly visible to another unsigned assemly
[assembly: InternalsVisibleToAttribute("CsharpSwatchesTest")]

namespace CsharpSwatches
{
    internal class NullableTypes
    {
        internal double? ndouble = null;
        internal bool? nbool = null;
        internal Nullable<int> nint = null;
        //internal string? nstring = null;

        
        internal void testc()
        {
            nbool = false;
            
        }



    }
}
