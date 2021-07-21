using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-model 扩展
    /// https://vuejs.org/v2/api/#v-else-if
    /// </summary>
    public static class VElseIfExtension
    {
        /// <summary>
        /// v-else-if
        /// </summary>
        public static TVueComponent VElseIf<TVueComponent>(this TVueComponent builder, string elseIf)
            where TVueComponent : VueComponent
        {
            builder.AddProperty("v-else-if", elseIf);

            return builder;
        }
    }
}
