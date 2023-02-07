using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// label="label"
    /// </summary>
    public interface ILabel
    {
    }

    /// <summary>
    /// label=""
    /// </summary>
    public static class ILabelExtension
    {
        /// <summary>
        /// label="label"
        /// </summary>
        public static TVueComponent Label<TVueComponent>(this TVueComponent component, string label) where TVueComponent : BasicComponent, ILabel
        {
            component.AddProperty("label", label);

            return component;
        }

        /// <summary>
        /// label="label"
        /// </summary>
        public static TVueComponent _Label<TVueComponent>(this TVueComponent component, string label) where TVueComponent : BasicComponent, ILabel
        {
            component.AddProperty(":label", label);

            return component;
        }
    }
}
