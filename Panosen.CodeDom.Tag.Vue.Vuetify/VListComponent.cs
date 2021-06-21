using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public class VListComponent : VuetifyComponent
    {
        public override string Name { get; set; } = "v-list";

        public VListComponent()
        {
            this.AddAttribute("dense");
        }
    }
}
