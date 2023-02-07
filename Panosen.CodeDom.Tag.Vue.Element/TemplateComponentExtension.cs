using Panosen.CodeDom.Tag.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// TemplateComponentExtension
    /// </summary>
    public static class TemplateComponentExtension
    {
        /// <summary>
        /// slot="vslotName"
        /// </summary>
        public static TTemplateComponent Slot<TTemplateComponent>(this TTemplateComponent templateComponent, string slotName)
            where TTemplateComponent : TemplateComponent
        {
            templateComponent.AddProperty($"slot", slotName);

            return templateComponent;
        }

        /// <summary>
        /// slot-scope="vslotScopeName"
        /// </summary>
        public static TTemplateComponent SlotScope<TTemplateComponent>(this TTemplateComponent templateComponent, string slotScopeName)
            where TTemplateComponent : TemplateComponent
        {
            templateComponent.AddProperty($"slot-scope", slotScopeName);

            return templateComponent;
        }
    }
}
