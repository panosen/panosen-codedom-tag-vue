using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// 
    /// </summary>
    public static class BundleExtension
    {
        /// <summary>
        /// required
        /// </summary>
        public static TVueComponent Required<TVueComponent>(this TVueComponent builder)
            where TVueComponent : BasicComponent
        {
            builder.AddAttribute("required");

            return builder;
        }

        /// <summary>
        /// disabled
        /// </summary>
        public static TVueComponent Disabled<TVueComponent>(this TVueComponent builder)
            where TVueComponent : BasicComponent
        {
            builder.AddAttribute("disabled");

            return builder;
        }
    }
}
