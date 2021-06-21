using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public class VSpacerComponent : VuetifyComponent
    {
        public override string Name { get; set; } = "v-spacer";

        public override bool SelfClosing { get; set; }
    }
}
