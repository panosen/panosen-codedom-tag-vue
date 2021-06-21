using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// https://vuetifyjs.com/en/components/simple-tables
    /// </summary>
    public class VSimpleTableComponent : VuetifyComponent
    {
        public override string Name { get; set; } = "v-simple-table";

        public VSimpleTableComponent Template(TemplateComponent templateBuilder)
        {
            this.AddChild(templateBuilder);

            return this;
        }
    }
}
