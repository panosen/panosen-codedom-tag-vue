using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-col
    /// https://element.eleme.cn/#/zh-CN/component/layout
    /// </summary>
    public class ElColComponent : ElementComponent
    {
        /// <summary>
        /// el-col
        /// </summary>
        public override string Name { get; set; } = "el-col";
    }

    /// <summary>
    /// el-row
    /// </summary>
    public static class ElColComponentExtension
    {
        /// <summary>
        /// :span
        /// 栅格占据的列数
        /// </summary>
        public static TElColComponent _Span<TElColComponent>(this TElColComponent elRowComponent, int span) where TElColComponent : ElRowComponent
        {
            elRowComponent.AddProperty(":span", span);

            return elRowComponent;
        }

        /// <summary>
        /// :offset
        /// 栅格左侧的间隔格数
        /// </summary>
        public static TElColComponent _Offset<TElColComponent>(this TElColComponent elRowComponent, int span) where TElColComponent : ElRowComponent
        {
            elRowComponent.AddProperty(":offset", span);

            return elRowComponent;
        }

        /// <summary>
        /// :push
        /// 栅格向右移动格数
        /// </summary>
        public static TElColComponent _Push<TElColComponent>(this TElColComponent elRowComponent, int push) where TElColComponent : ElRowComponent
        {
            elRowComponent.AddProperty(":push", push);

            return elRowComponent;
        }

        /// <summary>
        /// :pull
        /// 栅格向左移动格数
        /// </summary>
        public static TElColComponent _Pull<TElColComponent>(this TElColComponent elRowComponent, int pull) where TElColComponent : ElRowComponent
        {
            elRowComponent.AddProperty(":pull", pull);

            return elRowComponent;
        }
    }
}
