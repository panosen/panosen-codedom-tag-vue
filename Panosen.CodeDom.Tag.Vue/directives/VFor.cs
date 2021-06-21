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
    /// https://vuejs.org/v2/api/#v-for
    /// </summary>
    public static class VForExtension
    {
        /// <summary>
        /// v-for
        /// </summary>
        public static TComponent VFor<TComponent>(this TComponent component, string @for)
            where TComponent : BasicComponent
        {
            component.AddProperty("v-for", @for);

            return component;
        }

        /// <summary>
        /// v-for="{item} in {items}" :key="{key}"
        /// </summary>
        /// <param name="component"></param>
        /// <param name="items"></param>
        /// <param name="item"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TComponent VFor<TComponent>(this TComponent component, string item, string items, string key = null)
            where TComponent : BasicComponent
        {
            component.AddProperty("v-for", $"{item} in {items}");

            if (!string.IsNullOrEmpty(key))
            {
                component.AddProperty(":key", $"{key}");
            }

            return component;
        }

        /// <summary>
        /// v-for="({item}, {index}) in {items}" :key="{index}"
        /// </summary>
        /// <param name="component"></param>
        /// <param name="items"></param>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static TComponent VForIndex<TComponent>(this TComponent component, string item, string items, string index)
            where TComponent : BasicComponent
        {
            component.AddProperty("v-for", $"({item}, {index}) in {items}");
            component.AddProperty(":key", $"{index}");

            return component;
        }
    }
}
