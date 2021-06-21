using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// https://vuetifyjs.com/en/components/buttons#buttons
    /// </summary>
    public class VBtnComponent : VuetifyComponent, IOnClick
    {
        /// <summary>
        /// v-btn
        /// </summary>
        public override string Name { get; set; } = "v-btn";
    }
}
