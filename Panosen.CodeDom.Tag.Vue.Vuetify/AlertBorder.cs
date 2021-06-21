using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public class AlertBorder
    {
        public string Value { get; private set; } = string.Empty;

        public static readonly AlertBorder Top = new AlertBorder { Value = "top" };
        public static readonly AlertBorder Right = new AlertBorder { Value = "right" };
        public static readonly AlertBorder Bottom = new AlertBorder { Value = "bottom" };
        public static readonly AlertBorder Left = new AlertBorder { Value = "left" };

        public static readonly AlertBorder Empty = new AlertBorder { Value = string.Empty };

        public static implicit operator AlertBorder(string value)
        {
            var typeValue = new AlertBorder();
            typeValue.Value = value;
            return typeValue;
        }
    }
}
