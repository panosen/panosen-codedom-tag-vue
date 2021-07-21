using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-form-item
    /// </summary>
    public class ElFormItemComponent : ElementComponent
    {
        /// <summary>
        /// el-form-item
        /// </summary>
        public override string Name { get; set; } = "el-form-item";
    }

    /// <summary>
    /// el-form-item
    /// </summary>
    public static class ElFormItemComponentExtension
    {
        /// <summary>
        /// label="${label}"
        /// </summary>
        public static TElFormItemComponent Label<TElFormItemComponent>(this TElFormItemComponent elFormItemComponent, string label)
            where TElFormItemComponent : ElFormItemComponent
        {
            elFormItemComponent.AddProperty("label", label);

            return elFormItemComponent;
        }
    }
}
