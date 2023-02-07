using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-bind修饰符
    /// </summary>
    public enum VBindModifiers
    {
        /// <summary>
        /// none
        /// </summary>
        None = 0,

        /// <summary>
        /// Bind as a DOM property instead of an attribute (what’s the difference?). If the tag is a component then .prop will set the property on the component’s $el.
        /// </summary>
        Prop = 1,

        /// <summary>
        /// (2.1.0+) transform the kebab-case attribute name into camelCase.
        /// </summary>
        Camel = 2,

        /// <summary>
        /// (2.3.0+) a syntax sugar that expands into a v-on handler for updating the bound value.
        /// </summary>
        Sync = 3
    }

    /// <summary>
    /// v-bind 扩展
    /// https://vuejs.org/v2/api/#v-bind
    /// </summary>
    public static class VBindExtension
    {
        /// <summary>
        /// v-bind
        /// </summary>
        public static TVueComponent VBind<TVueComponent>(this TVueComponent builder, string value)
            where TVueComponent : BasicComponent
        {
            builder.AddProperty($"v-bind", value);

            return builder;
        }

        /// <summary>
        /// v-bind
        /// </summary>
        public static TVueComponent VBind<TVueComponent>(this TVueComponent builder, string key, string value, VBindModifiers vBindModifiers = default)
        where TVueComponent : BasicComponent
        {
            switch (vBindModifiers)
            {
                case VBindModifiers.Prop:
                    builder.AddProperty($"v-bind:{key}.prop", value);
                    break;
                case VBindModifiers.Camel:
                    builder.AddProperty($"v-bind:{key}.camel", value);
                    break;
                case VBindModifiers.Sync:
                    builder.AddProperty($"v-bind:{key}.sync", value);
                    break;
                case VBindModifiers.None:
                default:
                    builder.AddProperty($"v-bind:{key}", value);
                    break;
            }

            return builder;
        }
    }
}
