using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-input
    /// </summary>
    public class ElInputComponent : ElementComponent, IPlaceholder
    {
        /// <summary>
        /// el-input
        /// </summary>
        public override string Name { get; set; } = "el-input";
    }

    /// <summary>
    /// ElInputComponentExtension
    /// </summary>
    public static class ElInputComponentExtension
    {
    }

}
