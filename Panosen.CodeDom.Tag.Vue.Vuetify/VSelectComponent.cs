using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// v-select
    /// </summary>
    public class VSelectComponent : BasicComponent
    {
        /// <summary>
        /// v-select
        /// </summary>
        public override string Name { get; set; } = "v-select";

        public VSelectComponent Rules(string rules)
        {
            this.AddProperty(":rules", rules);
            return this;
        }

        public VSelectComponent _Options(string options)
        {
            this.AddProperty(":items", options);
            return this;
        }

        public VSelectComponent Label(string label)
        {
            this.AddProperty("label", label);
            return this;
        }

        public VSelectComponent _Multiple(string multiple)
        {
            this.AddProperty(":multiple", multiple);
            return this;
        }
    }
}
