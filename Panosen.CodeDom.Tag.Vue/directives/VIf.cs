using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-model 扩展
    /// https://vuejs.org/v2/api/#v-if
    /// </summary>
    public static class VIfExtension
    {
        /// <summary>
        /// v-if
        /// </summary>
        public static TComponent VIf<TComponent>(this TComponent builder, string @if)
            where TComponent : BasicComponent
        {
            builder.AddProperty("v-if", @if);

            return builder;
        }
    }
}
