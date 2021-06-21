using System;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// https://element.eleme.cn/#/zh-CN/component/installation
    /// </summary>
    public abstract class ElementComponent : VueComponent
    {
        /// <summary>
        /// BuiltIn
        /// </summary>
        public override bool BuiltIn { get; set; } = true;
    }
}
