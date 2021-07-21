using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-model 扩展
    /// https://vuejs.org/v2/api/#v-html
    /// </summary>
    public static class VHtmlExtension
    {
        /// <summary>
        /// v-text
        /// </summary>
        public static TVueComponent VHtml<TVueComponent>(this TVueComponent builder, string html)
            where TVueComponent : VueComponent
        {
            builder.AddProperty("v-html", html);

            return builder;
        }
    }
}
