using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-radio
    /// </summary>
    public class ElRadioComponent : ElementComponent, ILabel
    {
        /// <summary>
        /// el-radio
        /// </summary>
        public override string Name { get; set; } = "el-radio";
    }
}
