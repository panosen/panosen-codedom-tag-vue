using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue
{
    /// <summary>
    /// 整数值
    /// </summary>
    public class IntValue
    {
        public string Value { get; private set; } = string.Empty;

        public static readonly IntValue Empty = new IntValue { Value = string.Empty };

        public static implicit operator IntValue(int value)
        {
            var IntValue = new IntValue();
            IntValue.Value = value.ToString();
            return IntValue;
        }

        public static implicit operator IntValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return Empty;
            }

            var intValue = new IntValue();
            intValue.Value = value;
            return intValue;
        }
    }
}
