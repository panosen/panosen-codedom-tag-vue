using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public static class VChipComponentExtension
    {
        public static VChipComponent Label(this VChipComponent vChipComponent)
        {
            vChipComponent.AddAttribute("label");

            return vChipComponent;
        }
    }
}
