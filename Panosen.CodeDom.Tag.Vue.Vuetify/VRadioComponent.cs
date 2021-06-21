using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public class VRadioComponent : VuetifyComponent
    {
        public override string Name { get; set; } = "v-radio";

        public VRadioComponent _Value(string value)
        {
            this.AddProperty(":value", value);
            return this;
        }

        public VRadioComponent _Label(string label)
        {
            this.AddProperty(":label", label);
            return this;
        }
    }
}
