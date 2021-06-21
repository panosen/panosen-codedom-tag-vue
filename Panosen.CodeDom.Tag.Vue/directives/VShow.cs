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
    /// https://vuejs.org/v2/api/#v-show
    /// </summary>
    public static class VShowExtension
    {
        /// <summary>
        /// v-text
        /// </summary>
        public static TVueComponent VShow<TVueComponent>(this TVueComponent builder, string show)
            where TVueComponent : VueComponent
        {
            builder.AddProperty("v-show", show);

            return builder;
        }
    }
}
