using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-slot 扩展
    /// https://vuejs.org/v2/api/#v-slot
    /// </summary>
    public static class VSlotExtension
    {
        /// <summary>
        /// v-slot:${name}
        /// </summary>
        public static TVueComponent VSlot<TVueComponent>(this TVueComponent builder, string name)
            where TVueComponent : BasicComponent
        {
            builder.AddAttribute($"v-slot:{name}");

            return builder;
        }

        /// <summary>
        /// v-slot:${name}="${value}"
        /// </summary>
        public static TVueComponent VSlot<TVueComponent>(this TVueComponent builder, string name, string value)
            where TVueComponent : BasicComponent
        {
            builder.AddProperty($"v-slot:{name}", value);

            return builder;
        }
    }
}
