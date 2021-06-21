using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-cascade
    /// </summary>
    public class ElCascaderComponent : ElementComponent, IPlaceholder
    {
        /// <summary>
        /// el-cascade
        /// </summary>
        public override string Name { get; set; } = "el-cascader";
    }

    /// <summary>
    /// ElCascaderComponentExtension
    /// </summary>
    public static class ElCascaderComponentExtension
    {
        /// <summary>
        /// :props="${props}"
        /// </summary>
        public static TElCascaderComponent _Props<TElCascaderComponent>(this TElCascaderComponent elCascaderComponent, string props)
            where TElCascaderComponent : ElCascaderComponent
        {
            elCascaderComponent.AddProperty(":props", props);

            return elCascaderComponent;
        }

        /// <summary>
        /// :options="${options}"
        /// </summary>
        public static TElCascaderComponent _Options<TElCascaderComponent>(this TElCascaderComponent elCascaderComponent, string options)
            where TElCascaderComponent : ElCascaderComponent
        {
            elCascaderComponent.AddProperty(":options", options);

            return elCascaderComponent;
        }
    }
}
