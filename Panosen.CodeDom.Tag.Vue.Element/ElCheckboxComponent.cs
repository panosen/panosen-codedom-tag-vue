using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-checkbox
    /// </summary>
    public class ElCheckboxComponent : ElementComponent, ILabel
    {
        /// <summary>
        /// el-checkbox
        /// </summary>
        public override string Name { get; set; } = "el-checkbox";
    }

    /// <summary>
    /// el-form-item
    /// </summary>
    public static class ElCheckboxComponentExtension
    {

    }
}
