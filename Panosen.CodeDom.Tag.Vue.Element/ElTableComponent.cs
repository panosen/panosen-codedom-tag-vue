using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-table
    /// https://element.eleme.cn/#/zh-CN/component/table
    /// </summary>
    public class ElTableComponent : ElementComponent
    {
        /// <summary>
        /// el-table
        /// </summary>
        public override string Name { get; set; } = "el-table";
    }

    /// <summary>
    /// ElTableComponentExtension
    /// </summary>
    public static class ElTableComponentExtension
    {
        /// <summary>
        /// :data
        /// </summary>
        public static TElTableComponent _Data<TElTableComponent>(this TElTableComponent elTableComponent, string data)
            where TElTableComponent : ElTableComponent
        {
            elTableComponent.AddProperty(":data", data);

            return elTableComponent;
        }

        /// <summary>
        /// width
        /// </summary>
        public static TElTableComponent Width<TElTableComponent>(this TElTableComponent elTableComponent, int width)
            where TElTableComponent : ElTableComponent
        {
            elTableComponent.AddProperty("width", width);

            return elTableComponent;
        }

        /// <summary>
        /// width
        /// </summary>
        public static TElTableComponent Width<TElTableComponent>(this TElTableComponent elTableComponent, string width)
            where TElTableComponent : ElTableComponent
        {
            elTableComponent.AddProperty("width", width);

            return elTableComponent;
        }

        /// <summary>
        /// height
        /// </summary>
        public static TElTableComponent Height<TElTableComponent>(this TElTableComponent elTableComponent, int height)
            where TElTableComponent : ElTableComponent
        {
            elTableComponent.AddProperty("height", height);

            return elTableComponent;
        }

        /// <summary>
        /// height
        /// </summary>
        public static TElTableComponent Height<TElTableComponent>(this TElTableComponent elTableComponent, string height)
            where TElTableComponent : ElTableComponent
        {
            elTableComponent.AddProperty("height", height);

            return elTableComponent;
        }

        /// <summary>
        /// border
        /// </summary>
        public static TElTableComponent Border<TElTableComponent>(this TElTableComponent elTableComponent)
            where TElTableComponent : ElTableComponent
        {
            elTableComponent.AddAttribute("border");

            return elTableComponent;
        }
    }
}
