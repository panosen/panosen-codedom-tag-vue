using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-breadcrumb-item
    /// </summary>
    public class ElBreadcrumbItemComponent : ElementComponent, IRouterLink
    {
        /// <summary>
        /// el-breadcrumb-item
        /// </summary>
        public override string Name { get; set; } = "el-breadcrumb-item";
    }
}
