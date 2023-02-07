using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// router-link
    /// </summary>
    public interface IRouterLink
    {
    }

    /// <summary>
    /// label=""
    /// </summary>
    public static class IRouterLinkExtension
    {
        /// <summary>
        /// label="label"
        /// </summary>
        public static TVueComponent _To<TVueComponent>(this TVueComponent component, string to) where TVueComponent : BasicComponent, IRouterLink
        {
            component.AddProperty(":to", to);

            return component;
        }
    }
}
