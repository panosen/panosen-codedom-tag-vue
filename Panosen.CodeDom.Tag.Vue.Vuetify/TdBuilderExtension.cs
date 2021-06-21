using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public static class TdBuilderExtension
    {
        [Obsolete("计划废弃")]
        public static TComponent _Colspan<TComponent>(this TComponent builder, IntValue colspan)
            where TComponent : BasicComponent, new()
        {
            builder.AddProperty(":colspan", colspan.Value);

            return builder;
        }
    }
}
