using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// https://vuetifyjs.com/en/components/data-iterators
    /// </summary>
    public class VDataIteratorComponent : VuetifyComponent
    {
        public override string Name { get; set; } = "v-data-iterator";

        public VDataIteratorComponent _Items(string items)
        {
            this.AddProperty(":items", items);

            return this;
        }

        public VDataIteratorComponent _ItemsPerPageSync(string itemsPerPageSync)
        {
            this.AddProperty(":items-per-page.sync", itemsPerPageSync);

            return this;
        }

        public VDataIteratorComponent _FooterProps(string footerProps)
        {
            this.AddProperty(":footer-props", $"{{{{ {footerProps} }}}}");

            return this;
        }

        public VDataIteratorComponent Template(TemplateComponent templateBuilder)
        {
            this.AddChild(templateBuilder);

            return this;
        }
    }
}
