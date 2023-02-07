using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-once 扩展
    /// https://vuejs.org/v2/api/#v-once
    /// </summary>
    public static class VOnceExtension
    {
        /// <summary>
        /// v-once
        /// </summary>
        public static TVueComponent VOnce<TVueComponent>(this TVueComponent builder)
            where TVueComponent : BasicComponent
        {
            builder.AddAttribute("v-once");

            return builder;
        }
    }
}
