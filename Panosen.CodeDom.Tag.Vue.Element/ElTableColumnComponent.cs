using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Element
{
    /// <summary>
    /// el-table-column
    /// </summary>
    public class ElTableColumnComponent : ElementComponent
    {
        /// <summary>
        /// el-table-column
        /// </summary>
        public override string Name { get; set; } = "el-table-column";
    }

    /// <summary>
    /// ElTableColumnComponentExtension
    /// </summary>
    public static class ElTableColumnComponentExtension
    {
        /// <summary>
        /// prop
        /// </summary>
        public static TElTableColumnComponent SetProp<TElTableColumnComponent>(this TElTableColumnComponent elTableColumnComponent, string prop)
            where TElTableColumnComponent : ElTableColumnComponent
        {
            elTableColumnComponent.AddProperty("prop", prop);

            return elTableColumnComponent;
        }

        /// <summary>
        /// label
        /// </summary>
        public static TElTableColumnComponent SetLabel<TElTableColumnComponent>(this TElTableColumnComponent elTableColumnComponent, string label)
            where TElTableColumnComponent : ElTableColumnComponent
        {
            elTableColumnComponent.AddProperty("label", label);

            return elTableColumnComponent;
        }

        /// <summary>
        /// width
        /// </summary>
        public static TElTableColumnComponent SetWidth<TElTableColumnComponent>(this TElTableColumnComponent elTableColumnComponent, int witdh)
            where TElTableColumnComponent : ElTableColumnComponent
        {
            elTableColumnComponent.AddProperty("width", witdh);

            return elTableColumnComponent;
        }

        /// <summary>
        /// width
        /// </summary>
        public static TElTableColumnComponent SetFixed<TElTableColumnComponent>(this TElTableColumnComponent elTableColumnComponent, string @fixed)
            where TElTableColumnComponent : ElTableColumnComponent
        {
            elTableColumnComponent.AddProperty("fixed", @fixed);

            return elTableColumnComponent;
        }
    }
}
