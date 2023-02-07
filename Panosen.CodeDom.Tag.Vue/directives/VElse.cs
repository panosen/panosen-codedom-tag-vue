using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-model 扩展
    /// https://vuejs.org/v2/api/#v-else
    /// </summary>
    public static class VElseExtension
    {
        /// <summary>
        /// v-else
        /// </summary>
        public static TVueComponent VElse<TVueComponent>(this TVueComponent builder)
            where TVueComponent : BasicComponent
        {
            builder.AddAttribute("v-else");

            return builder;
        }
    }
}
