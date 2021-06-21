using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public sealed class RadioGroupDirection
    {
        private const string ROW = "row";

        private const string COLUMN = "column";

        public string Value { get; private set; } = string.Empty;

        public static readonly RadioGroupDirection Empty = new RadioGroupDirection { Value = string.Empty };

        public static readonly RadioGroupDirection Row = new RadioGroupDirection { Value = ROW };
        public static readonly RadioGroupDirection Column = new RadioGroupDirection { Value = COLUMN };

        public static implicit operator RadioGroupDirection(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return Empty;
            }

            switch (value.ToLower())
            {
                case ROW:
                    return Row;
                case COLUMN:
                    return Column;
                default:
                    return Empty;
            }
        }
    }
}
