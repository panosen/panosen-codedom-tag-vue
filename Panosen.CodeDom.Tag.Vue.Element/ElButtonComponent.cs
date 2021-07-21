using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-button
    /// https://element.eleme.cn/#/zh-CN/component/button
    /// </summary>
    public class ElButtonComponent : ElementComponent
    {
        /// <summary>
        /// el-button
        /// </summary>
        public override string Name { get; set; } = "el-button";
    }

    /// <summary>
    /// https://element.eleme.cn/#/zh-CN/component/button
    /// </summary>
    public static class ElButtonComponentExtension
    {
        /// <summary>
        /// type="primary"
        /// </summary>
        public static TElButtonComponent Type<TElButtonComponent>(this TElButtonComponent elButtonComponent, string type) where TElButtonComponent : ElButtonComponent
        {
            elButtonComponent.AddProperty("type", type);

            return elButtonComponent;
        }

        /// <summary>
        /// plain
        /// </summary>
        public static TElButtonComponent Plain<TElButtonComponent>(this TElButtonComponent elButtonComponent) where TElButtonComponent : ElButtonComponent
        {
            elButtonComponent.AddAttribute("plain");

            return elButtonComponent;
        }

        /// <summary>
        /// round
        /// </summary>
        public static TElButtonComponent Round<TElButtonComponent>(this TElButtonComponent elButtonComponent) where TElButtonComponent : ElButtonComponent
        {
            elButtonComponent.AddAttribute("round");

            return elButtonComponent;
        }

        /// <summary>
        /// circle
        /// </summary>
        public static TElButtonComponent Circle<TElButtonComponent>(this TElButtonComponent elButtonComponent) where TElButtonComponent : ElButtonComponent
        {
            elButtonComponent.AddAttribute("circle");

            return elButtonComponent;
        }

        /// <summary>
        /// type="primary"
        /// </summary>
        public static TElButtonComponent Icon<TElButtonComponent>(this TElButtonComponent elButtonComponent, string size) where TElButtonComponent : ElButtonComponent
        {
            elButtonComponent.AddProperty("icon", size);

            return elButtonComponent;
        }

        /// <summary>
        /// size="small"
        /// </summary>
        public static TElButtonComponent Size<TElButtonComponent>(this TElButtonComponent elButtonComponent, string size) where TElButtonComponent : ElButtonComponent
        {
            elButtonComponent.AddProperty("size", size);

            return elButtonComponent;
        }
    }
}
