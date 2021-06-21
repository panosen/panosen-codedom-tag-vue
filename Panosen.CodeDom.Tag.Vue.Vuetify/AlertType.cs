using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public class AlertType
    {
        public string Value { get; private set; } = string.Empty;

        public static readonly AlertType Success = new AlertType { Value = "success" };
        public static readonly AlertType Info = new AlertType { Value = "info" };
        public static readonly AlertType Warning = new AlertType { Value = "warning" };
        public static readonly AlertType Danger = new AlertType { Value = "error" };

        public static readonly AlertType Empty = new AlertType { Value = string.Empty };

        public static implicit operator AlertType(string value)
        {
            var typeValue = new AlertType();
            typeValue.Value = value;
            return typeValue;
        }
    }
}
