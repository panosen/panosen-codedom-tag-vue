using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-cloak 扩展
    /// https://vuejs.org/v2/api/#v-cloak
    /// </summary>
    public static class VCloakExtension
    {
        /// <summary>
        /// v-pre
        /// </summary>
        public static TVueComponent VCloak<TVueComponent>(this TVueComponent builder)
            where TVueComponent : VueComponent
        {
            builder.AddAttribute("v-cloak");

            return builder;
        }
    }
}
