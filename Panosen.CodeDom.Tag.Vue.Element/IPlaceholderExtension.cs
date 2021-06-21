using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// placeholder=""
    /// </summary>
    public interface IPlaceholder
    {
    }

    /// <summary>
    /// placeholder=""
    /// </summary>
    public static class IPlaceholderExtension
    {
        /// <summary>
        /// placeholder=""
        /// </summary>
        /// <typeparam name="TVueComponent"></typeparam>
        /// <param name="component"></param>
        /// <param name="placeholder"></param>
        /// <returns></returns>
        public static TVueComponent Placeholder<TVueComponent>(this TVueComponent component, string placeholder) where TVueComponent : VueComponent, IPlaceholder
        {
            component.AddProperty("placeholder", placeholder);

            return component;
        }
    }
}
