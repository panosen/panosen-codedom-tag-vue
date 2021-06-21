using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// v-model类姓
    /// </summary>
    public class VModelModifiers
    {
        /// <summary>
        /// v-model modifiers
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// v-model.lazy=""
        /// </summary>
        public static VModelModifiers Lazy { get; } = new VModelModifiers { Value = "lazy" };

        /// <summary>
        /// v-model.number=""
        /// </summary>
        public static VModelModifiers Number { get; } = new VModelModifiers { Value = "number" };

        /// <summary>
        /// v-model.trim=""
        /// </summary>
        public static VModelModifiers Trim { get; } = new VModelModifiers { Value = "trim" };

        /// <summary>
        /// 隐式转换
        /// </summary>
        public static implicit operator VModelModifiers(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            VModelModifiers vModelModifiers = new VModelModifiers();
            vModelModifiers.Value = value;

            return vModelModifiers;
        }
    }

    /// <summary>
    /// v-model 扩展
    /// https://vuejs.org/v2/api/#v-model
    /// </summary>
    public static class VModelExtension
    {
        /// <summary>
        /// v-model
        /// </summary>
        public static TComponent VModel<TComponent>(this TComponent component, string value, VModelModifiers vModelModifiers = null)
            where TComponent : BasicComponent
        {
            return VModel(component, null, value, vModelModifiers);
        }

        /// <summary>
        /// v-model
        /// </summary>
        public static TComponent VModel<TComponent>(this TComponent component, string propName, string propValue, VModelModifiers vModelModifiers = null)
            where TComponent : BasicComponent
        {
            string modelKey = "v-model";

            if (!string.IsNullOrEmpty(propName))
            {
                modelKey += $":{propName}";
            }

            if (vModelModifiers != null && !string.IsNullOrEmpty(vModelModifiers.Value))
            {
                modelKey += $".{vModelModifiers.Value}";
            }

            component.AddProperty(modelKey, propValue);

            return component;
        }
    }
}
