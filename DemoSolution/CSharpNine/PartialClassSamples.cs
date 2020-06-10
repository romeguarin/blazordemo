using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNine
{
    partial class Toy
    {
        public virtual partial string Get();
    }

    partial class Toy
    {
        public virtual partial string Get() => "Test";
    }

    class PartialClassSamples
    {
    }
}
