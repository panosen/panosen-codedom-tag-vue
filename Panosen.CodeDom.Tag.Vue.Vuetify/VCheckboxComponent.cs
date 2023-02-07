using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public class VCheckboxComponent : BasicComponent
    {
        public override string Name { get; set; } = "v-checkbox";

        public VCheckboxComponent _Rules(string rules)
        {
            this.AddProperty(":rules", rules);
            return this;
        }

        public VCheckboxComponent Label(string label)
        {
            this.AddProperty("label", label);
            return this;
        }

        public VCheckboxComponent _Value(string value)
        {
            this.AddProperty(":value", value);
            return this;
        }

        public VCheckboxComponent _Label(string label)
        {
            this.AddProperty(":label", label);
            return this;
        }
    }
}
