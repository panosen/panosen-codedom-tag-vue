using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Pano
{
    public abstract class PanoComponent : VueComponent
    {
        public override bool BuiltIn => true;
    }
}
