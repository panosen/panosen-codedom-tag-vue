using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-pre 扩展
    /// https://vuejs.org/v2/api/#v-pre
    /// </summary>
    public static class VPreExtension
    {
        /// <summary>
        /// v-pre
        /// </summary>
        public static TVueComponent VPre<TVueComponent>(this TVueComponent builder)
            where TVueComponent : VueComponent
        {
            builder.AddAttribute("v-pre");

            return builder;
        }
    }
}
