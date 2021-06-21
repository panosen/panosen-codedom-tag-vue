using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// https://vuetifyjs.com/en/components/selection-controls#switches-boolean
    /// </summary>
    public class VSwitchComponent : VueComponent
    {
        /// <summary>
        /// vue tag名称
        /// </summary>
        public override string Name { get; set; } = "v-switch";

        /// <summary>
        /// 显示的文字
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public VSwitchComponent Label(string label)
        {
            this.AddProperty("label", label);

            return this;
        }
    }
}
