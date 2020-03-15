using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemensHelperCore
{
    public class GuidGenerator
    {
        static public string generete_guid()
        {
            var g = Guid.NewGuid().ToString();
            return g;
        }
    }
}