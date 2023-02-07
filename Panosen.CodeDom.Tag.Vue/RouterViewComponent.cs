using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// router-view
    /// </summary>
    public class RouterViewComponent : BasicComponent
    {
        public override string Name { get; set; } = "router-view";

        public override bool SelfClosing { get; set; } = true;
    }
}
