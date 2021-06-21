using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// 布尔值或变量的名称
    /// </summary>
    public class BooleanValue
    {
        public string Value { get; private set; } = string.Empty;

        public static readonly BooleanValue Empty = new BooleanValue { Value = string.Empty };

        public static readonly BooleanValue True = new BooleanValue { Value = "true" };
        public static readonly BooleanValue False = new BooleanValue { Value = "false" };

        public static implicit operator BooleanValue(bool value)
        {
            var booleanValue = new BooleanValue();
            booleanValue.Value = value ? "true" : "false";
            return booleanValue;
        }

        public static implicit operator BooleanValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return Empty;
            }

            return new BooleanValue { Value = value };
        }
    }
}
