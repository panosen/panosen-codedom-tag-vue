using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// https://vuetifyjs.com/en/components/data-tables
    /// </summary>
    public class VDataTableComponent : VuetifyComponent
    {
        public override string Name { get; set; } = "v-data-table";

        public VDataTableComponent _Headers(string headers)
        {
            this.AddProperty(":headers", headers);

            return this;
        }

        public VDataTableComponent _Items(string items)
        {
            this.AddProperty(":items", items);

            return this;
        }

        public VDataTableComponent _ItemsPerPage(IntValue count)
        {
            this.AddProperty(":items-per-page", count.Value);

            return this;
        }

        public VDataTableComponent ShowSelect()
        {
            this.AddAttribute("show-select");

            return this;
        }
    }
}
