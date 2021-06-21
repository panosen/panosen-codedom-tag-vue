using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-model 扩展
    /// https://vuejs.org/v2/api/#v-text
    /// </summary>
    public static class VTextExtension
    {
        /// <summary>
        /// v-text
        /// </summary>
        public static TVueComponent VText<TVueComponent>(this TVueComponent builder, string textContent)
            where TVueComponent : VueComponent
        {
            builder.AddProperty("v-text", textContent);

            return builder;
        }
    }
}
