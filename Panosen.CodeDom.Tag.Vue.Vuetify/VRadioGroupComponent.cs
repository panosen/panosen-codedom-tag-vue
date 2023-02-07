using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    public class VRadioGroupComponent : BasicComponent
    {
        public override string Name { get; set; } = "v-radio-group";

        /// <summary>
        /// 方向
        /// </summary>
        /// <returns></returns>
        public VRadioGroupComponent Direction(RadioGroupDirection direction)
        {
            if (!string.IsNullOrEmpty(direction.Value))
            {
                this.AddAttribute(direction.Value);
            }
            return this;
        }
    }
}
