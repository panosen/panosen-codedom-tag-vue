using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// ComponentExtension
    /// </summary>
    public static class ComponentExtension
    {
        /// <summary>
        /// @click="${click}"
        /// </summary>
        public static TComponent _Click<TComponent>(this TComponent component, string click)
            where TComponent : BasicComponent
        {
            component.AddProperty("@click", click);

            return component;
        }
    }
}
