using Panosen.CodeDom.Tag.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Tag.Vue.Vuetify
{
    /// <summary>
    /// v-text-field
    /// </summary>
    public class VTextFieldComponent : VueComponent, ILabel
    {
        /// <summary>
        /// v-text-field
        /// </summary>
        public override string Name { get; set; } = "v-text-field";

        public VTextFieldComponent _Rules(string rules)
        {
            this.AddProperty(":rules", rules);
            return this;
        }

        //public VTextFieldComponent Label(string label)
        //{
        //    this.AddProperty("label", label);
        //    return this;
        //}

        /// <summary>
        /// :counter
        /// </summary>
        /// <param name="counter"></param>
        /// <returns></returns>
        public VTextFieldComponent _Counter(IntValue counter)
        {
            this.AddProperty(":counter", counter.Value);
            return this;
        }

        public VTextFieldComponent Clearable()
        {
            this.AddAttribute("clearable");
            return this;
        }

        public VTextFieldComponent _Disable(BooleanValue condition)
        {
            this.AddProperty(":disabled", condition.Value);
            return this;
        }
    }
}
