using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-row
    /// https://element.eleme.cn/#/zh-CN/component/layout
    /// </summary>
    public class ElRowComponent : ElementComponent
    {
        /// <summary>
        /// el-row
        /// </summary>
        public override string Name { get; set; } = "el-row";
    }

    /// <summary>
    /// el-row
    /// https://element.eleme.cn/#/zh-CN/component/layout
    /// </summary>
    public static class ElRowComponentExtension
    {
        /// <summary>
        /// :gutter
        /// </summary>
        public static TElRowComponent _Gutter<TElRowComponent>(TElRowComponent elRowComponent, int gutter) where TElRowComponent : ElRowComponent
        {
            elRowComponent.AddProperty(":gutter", gutter);

            return elRowComponent;
        }
    }
}
