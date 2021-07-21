using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-form
    /// https://element.eleme.cn/#/zh-CN/component/form
    /// </summary>
    public class ElFormComponent : ElementComponent
    {
        /// <summary>
        /// el-form
        /// </summary>
        public override string Name { get; set; } = "el-form";
    }

    /// <summary>
    /// size
    /// </summary>
    public enum ElFormSize
    {
        /// <summary>
        /// none
        /// </summary>
        None,

        /// <summary>
        /// medium
        /// </summary>
        Medium,

        /// <summary>
        /// small
        /// </summary>
        Small,

        /// <summary>
        /// mini
        /// </summary>
        Mini
    }

    /// <summary>
    /// el-form
    /// </summary>
    public static class ElFormComponentExtension
    {
        /// <summary>
        /// label-width="${width}"
        /// </summary>
        public static TElFormComponent LabelWidth<TElFormComponent>(this TElFormComponent elFormComponent, string width)
            where TElFormComponent : ElFormComponent
        {
            elFormComponent.AddProperty("label-width", width);

            return elFormComponent;
        }

        /// <summary>
        /// label-width="${width}"
        /// </summary>
        public static TElFormComponent Size<TElFormComponent>(this TElFormComponent elFormComponent, ElFormSize size)
            where TElFormComponent : ElFormComponent
        {
            switch (size)
            {
                case ElFormSize.Medium:
                    elFormComponent.AddProperty("size", "medium");
                    break;
                case ElFormSize.Small:
                    elFormComponent.AddProperty("size", "small");
                    break;
                case ElFormSize.Mini:
                    elFormComponent.AddProperty("size", "mini");
                    break;
                case ElFormSize.None:
                default:
                    break;
            }

            return elFormComponent;
        }

        /// <summary>
        /// label-width="${width}"
        /// </summary>
        public static TElFormComponent Size<TElFormComponent>(this TElFormComponent elFormComponent, string size)
            where TElFormComponent : ElFormComponent
        {
            elFormComponent.AddProperty("size", size);

            return elFormComponent;
        }

        /// <summary>
        /// :inline="${inline}"
        /// </summary>
        public static TElFormComponent _Inline<TElFormComponent>(this TElFormComponent elFormComponent, BooleanValue inline)
            where TElFormComponent : ElFormComponent
        {
            elFormComponent.AddProperty(":inline", inline.Value);

            return elFormComponent;
        }
    }
}
